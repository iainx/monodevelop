#pragma warning disable 436

namespace MonoDevelop.Debugger
{
	public partial class AttachToProcessDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::Gtk.Entry entryFilter;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView tree;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label2;

		private global::Gtk.ComboBox comboDebs;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Debugger.AttachToProcessDialog
			this.Name = "MonoDevelop.Debugger.AttachToProcessDialog";
			this.Title = global::Mono.Unix.Catalog.GetString("Attach to Process");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(3));
			// Internal child MonoDevelop.Debugger.AttachToProcessDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 12;
			this.vbox2.BorderWidth = ((uint)(9));
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Attach to:");
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryFilter = new global::Gtk.Entry();
			this.entryFilter.CanFocus = true;
			this.entryFilter.Name = "entryFilter";
			this.entryFilter.IsEditable = true;
			this.entryFilter.InvisibleChar = '●';
			this.hbox1.Add(this.entryFilter);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entryFilter]));
			w3.Position = 1;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.tree = new global::Gtk.TreeView();
			this.tree.CanFocus = true;
			this.tree.Name = "tree";
			this.GtkScrolledWindow.Add(this.tree);
			this.vbox2.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
			w6.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Debugger:");
			this.hbox2.Add(this.label2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboDebs = global::Gtk.ComboBox.NewText();
			this.comboDebs.Name = "comboDebs";
			this.hbox2.Add(this.comboDebs);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.comboDebs]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			w1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w10.Position = 0;
			// Internal child MonoDevelop.Debugger.AttachToProcessDialog.ActionArea
			global::Gtk.HButtonBox w11 = this.ActionArea;
			w11.Name = "dialog1_ActionArea";
			w11.Spacing = 6;
			w11.BorderWidth = ((uint)(5));
			w11.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11[this.buttonCancel]));
			w12.Expand = false;
			w12.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = global::Mono.Unix.Catalog.GetString("Attach");
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11[this.buttonOk]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 656;
			this.DefaultHeight = 413;
			this.Hide();
			this.entryFilter.Changed += new global::System.EventHandler(this.OnEntryFilterChanged);
		}
	}
}
#pragma warning restore 436
