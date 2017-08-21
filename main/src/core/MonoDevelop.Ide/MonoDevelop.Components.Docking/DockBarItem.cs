//
// DockBarItem.cs
//
// Author:
//   Lluis Sanchez Gual
//

//
// Copyright (C) 2007 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


using System;
using Gtk;
using MonoDevelop.Ide.Gui;
using MonoDevelop.Components;
using MonoDevelop.Components.AtkCocoaHelper;
using Xwt.Motion;
using Animations = Xwt.Motion.AnimationExtensions;
using MonoDevelop.Core;
using MonoDevelop.Ide.Fonts;

namespace MonoDevelop.Components.Docking
{	
	class CrossfadeIcon: Gtk.Image, IAnimatable
	{
		// This class should be subclassed from Gtk.Misc, but there is no reasonable way to do that due to there being no bindings to gtk_widget_set_has_window

		Xwt.Drawing.Image primary, secondary;

		double secondaryOpacity;

		public CrossfadeIcon (Xwt.Drawing.Image primary, Xwt.Drawing.Image secondary)
		{
			if (primary == null)
				throw new ArgumentNullException ("primary");
			if (secondary == null)
				throw new ArgumentNullException ("secondary");

			this.primary = primary;
			this.secondary = secondary;
		}

		void IAnimatable.BatchBegin () { }
		void IAnimatable.BatchCommit () { QueueDraw (); }

		public void ShowPrimary ()
		{
			AnimateCrossfade (false);
		}

		public void ShowSecondary ()
		{
			AnimateCrossfade (true);
		}

		void AnimateCrossfade (bool toSecondary)
		{
			this.Animate ("CrossfadeIconSwap",
			              x => secondaryOpacity = x,
			              secondaryOpacity,
			              toSecondary ? 1.0f : 0.0f);
		}

		protected override void OnDestroyed ()
		{
			this.AbortAnimation ("CrossfadeIconSwap");
			base.OnDestroyed ();
		}

		protected override void OnSizeRequested (ref Requisition requisition)
		{
			base.OnSizeRequested (ref requisition);

			requisition.Width = (int) primary.Width;
			requisition.Height = (int) primary.Height;
		}

		protected override bool OnExposeEvent (Gdk.EventExpose evnt)
		{
			using (Cairo.Context context = Gdk.CairoHelper.Create (evnt.Window)) {
				if (secondaryOpacity < 1.0f)
					RenderIcon (context, primary, 1.0f - (float)Math.Pow (secondaryOpacity, 3.0f));

				if (secondaryOpacity > 0.0f)
					RenderIcon (context, secondary, secondaryOpacity);
			}

			return false;
		}

		void RenderIcon (Cairo.Context context, Xwt.Drawing.Image surface, double opacity)
		{
			context.DrawImage (this, surface.WithAlpha (opacity),
			                          Allocation.X + (Allocation.Width - surface.Width) / 2,
			                          Allocation.Y + (Allocation.Height - surface.Height) / 2);
		}
	}

	class DockBarItem
	{
		internal DockBar Bar { get; set; }
		public DockItem Item { get; set; }
		internal int Size { get; set; }

		internal IDockBarItemControl Control { get; private set; }
		uint autoShowTimeout = uint.MaxValue;
		uint autoHideTimeout = uint.MaxValue;

		public DockBarItem (DockBar bar, DockItem item, int size)
		{
			Bar = bar;
			Item = item;
			Size = size;

			Control = new DockBarItemControl ();
			Control.Initialize (this);
		}

		public void Close ()
		{
			UnscheduleAutoShow ();
			UnscheduleAutoHide ();
			AutoHide (false);
			Bar.RemoveItem (this);
			Control.Close ();
		}

		internal void UnscheduleAutoShow ()
		{
			if (autoShowTimeout != uint.MaxValue) {
				GLib.Source.Remove (autoShowTimeout);
				autoShowTimeout = uint.MaxValue;
			}
		}

		internal void UnscheduleAutoHide ()
		{
			if (autoHideTimeout != uint.MaxValue) {
				GLib.Source.Remove (autoHideTimeout);
				autoHideTimeout = uint.MaxValue;
			}
		}

		public void Present (bool giveFocus)
		{
			AutoShow ();
			if (giveFocus) {
				GLib.Timeout.Add (200, delegate {
					// Using a small delay because AutoShow uses an animation and setting focus may
					// not work until the item is visible
					Control.Present ();

					Item.SetFocus ();
					ScheduleAutoHide (false);
					return false;
				});
			}
		}

		public void Minimize ()
		{
			AutoHide (false);
		}

		internal void AutoShow ()
		{
			UnscheduleAutoHide ();
			Control.AutoShow ();
		}

		internal void AutoHide (bool animate)
		{
			UnscheduleAutoShow ();
			Control.AutoHide (animate);
		}

		internal void ScheduleAutoShow ()
		{
			UnscheduleAutoHide ();
			if (autoShowTimeout == uint.MaxValue) {
				autoShowTimeout = GLib.Timeout.Add (Bar.Frame.AutoShowDelay, delegate {
					autoShowTimeout = uint.MaxValue;
					AutoShow ();
					return false;
				});
			}
		}

		internal void ScheduleAutoHide (bool cancelAutoShow)
		{
			ScheduleAutoHide (cancelAutoShow, false);
		}

		internal void ScheduleAutoHide (bool cancelAutoShow, bool force)
		{
			if (cancelAutoShow)
				UnscheduleAutoShow ();
			if (force)
				Item.ClearFocus ();

			if (autoHideTimeout == uint.MaxValue) {
				autoHideTimeout = GLib.Timeout.Add (force ? 0 : Bar.Frame.AutoHideDelay, delegate {
					// Don't hide if the context menu for the item is being shown.
					if (Item.ShowingContextMenu)
						return true;
					// Don't hide the item if it has the focus. Try again later.
					if (Item.HasFocusedChild && !force && Control.AutoShowWindowHasFocus)
						return true;
					// Don't hide the item if the mouse pointer is still inside the window. Try again later.
					if (Item.ContainsPointer && !force)
						return true;
					autoHideTimeout = uint.MaxValue;
					AutoHide (true);
					return false;
				});
			}
		}

		public void UpdateTab ()
		{
			Control.UpdateTab ();
		}

		public void Show ()
		{
			Control.Show ();
		}

		public void Hide ()
		{
			Control.Hide ();
		}
	}

	internal interface IDockBarItemControl : IAnimatable
	{
		void Initialize (DockBarItem parentItem);
		void Close ();
		void Present ();
		void AutoShow ();
		void AutoHide (bool animate);
		void UpdateTab ();

		bool AutoShowWindowHasFocus { get; }
		DockBarItem ParentItem { get; }

		void Show ();
		event EventHandler Shown;
		void Hide ();
		event EventHandler Hidden;
	}

	class DockBarItemControl: EventBox, IDockBarItemControl
	{
		DockBarItem parentItem;
		Box box;
		Label label;
		Alignment mainBox;
		AutoHideBox autoShowFrame;
		AutoHideBox hiddenFrame;


		Gdk.Size lastFrameSize;
		MouseTracker tracker;
		CrossfadeIcon crossfade;
		double hoverProgress;

		public DockBarItemControl ()
		{
			var actionHandler = new ActionDelegate (this);
			actionHandler.PerformPress += OnPerformPress;

			Events = Events | Gdk.EventMask.EnterNotifyMask | Gdk.EventMask.LeaveNotifyMask;
			CanFocus = true;
			VisibleWindow = false;
		}

		public void Initialize (DockBarItem parentItem)
		{
			this.parentItem = parentItem;

			UpdateTab ();

			var widgetControl = parentItem.Bar.Frame.Control as Widget;
			if (widgetControl != null) {
				lastFrameSize = widgetControl.Allocation.Size;
				widgetControl.SizeAllocated += HandleBarFrameSizeAllocated;
			} else {
				LoggingService.LogWarning ("Toolkit mismatch");
			}

			tracker = new MouseTracker (this);
			tracker.TrackMotion = false;
			tracker.HoveredChanged += (sender, e) => {

				if (crossfade == null)
					return;
	
				AnimateHover (tracker.Hovered);
				if (tracker.Hovered)
					crossfade.ShowSecondary ();
				else
					crossfade.ShowPrimary ();
			};

			Styles.Changed += UpdateStyle;

			Accessible.Name = "DockbarItem";
			Accessible.Role = Atk.Role.PushButton;
		}

		public DockBarItem ParentItem {
			get {
				return parentItem;
			}
		}

		public void Close ()
		{
			Destroy ();
		}

		public void Present ()
		{
			var control = autoShowFrame.Control as DockFrameTopLevelControl;
			if (autoShowFrame != null && control.ContainerWindow != null && control.ContainerWindow != (Gtk.Window)Toplevel)
				control.ContainerWindow.Present ();
		}

		public void AutoShow ()
		{
			var bar = parentItem.Bar;
			var it = parentItem.Item;

			if (autoShowFrame == null && !bar.Frame.Control.OverlayWidgetVisible) {
				if (hiddenFrame != null)
					bar.Frame.Control.AutoHide (it, hiddenFrame, false);
				autoShowFrame = bar.Frame.Control.AutoShow (it, bar, parentItem.Size);
				if (!string.IsNullOrEmpty (it.Label)) {
					autoShowFrame.Title = it.Label;
				}

				var control = autoShowFrame.Control as DockFrameTopLevelControl;
				control.EnterNotifyEvent += OnFrameEnter;
				control.LeaveNotifyEvent += OnFrameLeave;
				control.KeyPressEvent += OnFrameKeyPress;
				QueueDraw ();
			}
		}

		public void AutoHide (bool animate)
		{
			var bar = parentItem.Bar;
			var it = parentItem.Item;

			if (autoShowFrame != null) {
				var control = autoShowFrame.Control as DockFrameTopLevelControl;

				parentItem.Size = autoShowFrame.PadSize;
				hiddenFrame = autoShowFrame;
				control.Hidden += delegate {
					hiddenFrame = null;
				};
				bar.Frame.Control.AutoHide (it, autoShowFrame, animate);
				control.EnterNotifyEvent -= OnFrameEnter;
				control.LeaveNotifyEvent -= OnFrameLeave;
				control.KeyPressEvent -= OnFrameKeyPress;
				autoShowFrame = null;
				QueueDraw ();
			}
		}

		public bool AutoShowWindowHasFocus {
			get {
				return autoShowFrame != null && autoShowFrame.HasToplevelFocus;
			}
		}

		void IAnimatable.BatchBegin () { }
		void IAnimatable.BatchCommit () { QueueDraw (); }

		void AnimateHover (bool hovered)
		{
			this.Animate ("Hover",
			              x => hoverProgress = x,
			              hoverProgress,
			              hovered ? 1.0f : 0.0f,
			              length: 100);
		}
		
		void HandleBarFrameSizeAllocated (object o, SizeAllocatedArgs args)
		{
			if (!lastFrameSize.Equals (args.Allocation.Size)) {
				lastFrameSize = args.Allocation.Size;
				if (autoShowFrame != null)
					parentItem.Bar.Frame.Control.UpdateSize (parentItem.Bar, autoShowFrame);

				parentItem.UnscheduleAutoHide ();
				AutoHide (false);
			}
		}
		
		protected override void OnDestroyed ()
		{
			this.AbortAnimation ("Hover");
			base.OnDestroyed ();
			var widgetControl = parentItem.Bar.Frame.Control as Widget;
			if (widgetControl != null) {
				widgetControl.SizeAllocated -= HandleBarFrameSizeAllocated;
			} else {
				LoggingService.LogWarning ("Toolkit mismatch");
			}
			Ide.Gui.Styles.Changed -= UpdateStyle;
		}
		
		public void UpdateTab ()
		{
			var bar = parentItem.Bar;
			var it = parentItem.Item;

			if (Child != null) {
				Widget w = Child;
				Remove (w);
				w.Destroy ();
			}
			
			mainBox = new Alignment (0,0,1,1);
			mainBox.Accessible.SetShouldIgnore (true);
			if (bar.Orientation == Gtk.Orientation.Horizontal) {
				box = new HBox ();
				if (bar.AlignToEnd)
					mainBox.SetPadding (5, 5, 11, 9);
				else
					mainBox.SetPadding (5, 5, 9, 11);
			}
			else {
				box = new VBox ();
				if (bar.AlignToEnd)
					mainBox.SetPadding (11, 9, 5, 5);
				else
					mainBox.SetPadding (9, 11, 5, 5);
			}
			box.Accessible.SetShouldIgnore (true);

			if (it.Icon != null) {
				var desat = it.Icon.WithAlpha (0.5);
				crossfade = new CrossfadeIcon (desat, it.Icon);
				crossfade.Accessible.SetShouldIgnore (true);
				box.PackStart (crossfade, false, false, 0);
				desat.Dispose ();
			}
				
			if (!string.IsNullOrEmpty (it.Label)) {
				label = new Label (it.Label);
				label.Accessible.SetShouldIgnore (true);
				label.UseMarkup = true;
				label.ModifyFont (FontService.SansFont.CopyModified (Styles.FontScale11));

				if (bar.Orientation == Orientation.Vertical)
					label.Angle = 270;

				// fine-tune label alignment issues
				if (Platform.IsMac) {
					if (bar.Orientation == Orientation.Horizontal)
						label.SetAlignment (0, 0.5f);
					else
						label.SetAlignment (0.6f, 0);
				} else {
					if (bar.Orientation == Orientation.Vertical)
						label.SetAlignment (1, 0);
				}
				// TODO: VV: Test Linux

				box.PackStart (label, true, true, 0);

				Accessible.SetLabel (it.Label);
				Accessible.SetTitle (it.Label);
				Accessible.Description = GettextCatalog.GetString ("Show the {0} pad", it.Label);
			} else
				label = null;

			box.Spacing = 2;
			mainBox.Add (box);
			mainBox.ShowAll ();
			Add (mainBox);
			UpdateStyle (this, null); 
			QueueDraw ();
		}

		void UpdateStyle (object sender, EventArgs e)
		{
			if (label != null)
				label.ModifyFg (StateType.Normal, Styles.DockBarLabelColor.ToGdkColor ());
		}

		protected override void OnHidden ()
		{
			base.OnHidden ();
			parentItem.UnscheduleAutoShow ();
			parentItem.UnscheduleAutoHide ();
			parentItem.AutoHide (false);
		}
		
		protected override bool OnEnterNotifyEvent (Gdk.EventCrossing evnt)
		{
			var bar = parentItem.Bar;
			if (bar.HoverActivationEnabled && autoShowFrame == null) {
				parentItem.ScheduleAutoShow ();
				QueueDraw ();
			}
			return base.OnEnterNotifyEvent (evnt);
		}

		void OnPerformPress (object sender, EventArgs args)
		{
			if (autoShowFrame == null) {
				parentItem.AutoShow ();
			} else {
				parentItem.AutoHide (false);
			}
		}
		
		protected override bool OnLeaveNotifyEvent (Gdk.EventCrossing evnt)
		{
			parentItem.ScheduleAutoHide (true);
			if (autoShowFrame == null) {
				QueueDraw ();
			}
			return base.OnLeaveNotifyEvent (evnt);
		}
		
		void OnFrameEnter (object s, Gtk.EnterNotifyEventArgs args)
		{
			AutoShow ();
		}

		void OnFrameKeyPress (object s, Gtk.KeyPressEventArgs args)
		{
			if (args.Event.Key == Gdk.Key.Escape)
				parentItem.ScheduleAutoHide (true, true);
		}
		
		void OnFrameLeave (object s, Gtk.LeaveNotifyEventArgs args)
		{
			if (args.Event.Detail != Gdk.NotifyType.Inferior)
				parentItem.ScheduleAutoHide (true);
		}

		bool itemActivated;

		protected override bool OnButtonPressEvent (Gdk.EventButton evnt)
		{
			var bar = parentItem.Bar;
			var it = parentItem.Item;

			if (bar.Frame.Control.OverlayWidgetVisible)
				return false;
			if (evnt.TriggersContextMenu ()) {
				it.ShowDockPopupMenu (this, evnt);
			} else if (evnt.Button == 1) {
				if (evnt.Type == Gdk.EventType.TwoButtonPress) {
					// Instead of changing the state of the pad here, do it when the button is released.
					// Changing the state will make this bar item to vanish before the ReleaseEvent is received, and in this
					// case the ReleaseEvent may be fired on another widget that is taking the space of this bar item.
					// This was happening for example with the feedback button.
					itemActivated = true;
				} else {
					AutoShow ();
					it.Present (true);
				}
			}
			return true;
		}

		protected override bool OnButtonReleaseEvent (Gdk.EventButton evnt)
		{
			if (itemActivated) {
				itemActivated = false;
				parentItem.Item.Status = DockItemStatus.Dockable;
			}
			return true;
		}

		protected override bool OnExposeEvent (Gdk.EventExpose evnt)
		{
			var bar = parentItem.Bar;
			using (var context = Gdk.CairoHelper.Create (evnt.Window)) {
				var alloc = Allocation;

				// TODO: VV: Remove preflight gradient features and replace with a flat color

				Cairo.LinearGradient lg;

				if (bar.Orientation == Orientation.Horizontal) {
					lg = new Cairo.LinearGradient (alloc.X, 0, alloc.X + alloc.Width, 0);
				} else {
					lg = new Cairo.LinearGradient (0, alloc.Y, 0, alloc.Y + alloc.Height);
				}

				using (lg) {
					Cairo.Color primaryColor = Styles.DockBarPrelightColor.ToCairoColor ();
					primaryColor.A = hoverProgress;

					Cairo.Color transparent = primaryColor;
					transparent.A = 0;

					lg.AddColorStop (0.0, transparent);
					lg.AddColorStop (0.35, primaryColor);
					lg.AddColorStop (0.65, primaryColor);
					lg.AddColorStop (1.0, transparent);

					context.Rectangle (alloc.ToCairoRect ());
					context.SetSource (lg);
				}
				context.Fill ();
			}

			if (HasFocus) {
				Gtk.Style.PaintFocus (Style, GdkWindow, State, Allocation, this, "button", Allocation.X + 2, Allocation.Y + 2, Allocation.Width - 4, Allocation.Height - 4);
			}
			return base.OnExposeEvent (evnt);
		}

		protected override bool OnFocusInEvent (Gdk.EventFocus evnt)
		{
			QueueDraw ();
			return base.OnFocusInEvent (evnt);
		}

		protected override bool OnFocusOutEvent (Gdk.EventFocus evnt)
		{
			QueueDraw ();
			return base.OnFocusOutEvent (evnt);
		}

		protected override void OnActivate ()
		{
			parentItem.AutoShow ();
		}
	}
}
