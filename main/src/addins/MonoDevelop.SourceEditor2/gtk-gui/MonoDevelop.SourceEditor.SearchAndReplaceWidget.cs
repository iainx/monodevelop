#pragma warning disable 436

namespace MonoDevelop.SourceEditor
{
	internal partial class SearchAndReplaceWidget
	{
		private global::Gtk.Table table;

		private global::Gtk.Button buttonSearchMode;

		private global::Gtk.Arrow searchButtonModeArrow;

		private global::Gtk.HBox hbox1;

		private global::MonoDevelop.Components.SearchEntry searchEntry;

		private global::Gtk.Button buttonSearchBackward;

		private global::MonoDevelop.Components.ImageView image2;

		private global::Gtk.Button buttonSearchForward;

		private global::MonoDevelop.Components.ImageView image3;

		private global::Gtk.Button closeButton;

		private global::MonoDevelop.Components.ImageView image4;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Entry entryReplace;

		private global::Gtk.Button buttonReplace;

		private global::MonoDevelop.Components.ImageView image5;

		private global::Gtk.Button buttonReplaceAll;

		private global::Gtk.HBox hbox3;

		private global::MonoDevelop.Components.ImageView image6;

		private global::Gtk.Label label1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.SourceEditor.SearchAndReplaceWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "MonoDevelop.SourceEditor.SearchAndReplaceWidget";
			// Container child MonoDevelop.SourceEditor.SearchAndReplaceWidget.Gtk.Container+ContainerChild
			this.table = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table.Name = "table";
			this.table.BorderWidth = ((uint)(4));
			// Container child table.Gtk.Table+TableChild
			this.buttonSearchMode = new global::Gtk.Button();
			this.buttonSearchMode.CanFocus = true;
			this.buttonSearchMode.Name = "buttonSearchMode";
			// Container child buttonSearchMode.Gtk.Container+ContainerChild
			this.searchButtonModeArrow = new global::Gtk.Arrow(((global::Gtk.ArrowType)(0)), ((global::Gtk.ShadowType)(0)));
			this.searchButtonModeArrow.Name = "searchButtonModeArrow";
			this.buttonSearchMode.Add(this.searchButtonModeArrow);
			this.table.Add(this.buttonSearchMode);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table[this.buttonSearchMode]));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			// Container child hbox1.Gtk.Box+BoxChild
			this.searchEntry = new global::MonoDevelop.Components.SearchEntry();
			this.searchEntry.Name = "searchEntry";
			this.searchEntry.ForceFilterButtonVisible = false;
			this.searchEntry.HasFrame = true;
			this.searchEntry.RoundedShape = false;
			this.searchEntry.IsCheckMenu = false;
			this.searchEntry.ActiveFilterID = 0;
			this.searchEntry.Ready = false;
			this.searchEntry.HasFocus = false;
			this.hbox1.Add(this.searchEntry);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.searchEntry]));
			w3.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSearchBackward = new global::Gtk.Button();
			this.buttonSearchBackward.CanFocus = true;
			this.buttonSearchBackward.Name = "buttonSearchBackward";
			this.buttonSearchBackward.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child buttonSearchBackward.Gtk.Container+ContainerChild
			this.image2 = new global::MonoDevelop.Components.ImageView();
			this.image2.Name = "image2";
			this.image2.IconId = "gtk-go-up";
			this.image2.IconSize = ((global::Gtk.IconSize)(1));
			this.buttonSearchBackward.Add(this.image2);
			this.hbox1.Add(this.buttonSearchBackward);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSearchBackward]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSearchForward = new global::Gtk.Button();
			this.buttonSearchForward.CanFocus = true;
			this.buttonSearchForward.Name = "buttonSearchForward";
			this.buttonSearchForward.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child buttonSearchForward.Gtk.Container+ContainerChild
			this.image3 = new global::MonoDevelop.Components.ImageView();
			this.image3.Name = "image3";
			this.image3.IconId = "gtk-go-down";
			this.image3.IconSize = ((global::Gtk.IconSize)(1));
			this.buttonSearchForward.Add(this.image3);
			this.hbox1.Add(this.buttonSearchForward);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSearchForward]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.closeButton = new global::Gtk.Button();
			this.closeButton.CanFocus = true;
			this.closeButton.Name = "closeButton";
			this.closeButton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child closeButton.Gtk.Container+ContainerChild
			this.image4 = new global::MonoDevelop.Components.ImageView();
			this.image4.Name = "image4";
			this.image4.IconId = "gtk-close";
			this.image4.IconSize = ((global::Gtk.IconSize)(1));
			this.closeButton.Add(this.image4);
			this.hbox1.Add(this.closeButton);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.closeButton]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			this.table.Add(this.hbox1);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table[this.hbox1]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			// Container child hbox2.Gtk.Box+BoxChild
			this.entryReplace = new global::Gtk.Entry();
			this.entryReplace.CanFocus = true;
			this.entryReplace.Name = "entryReplace";
			this.entryReplace.IsEditable = true;
			this.entryReplace.InvisibleChar = '●';
			this.hbox2.Add(this.entryReplace);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryReplace]));
			w11.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonReplace = new global::Gtk.Button();
			this.buttonReplace.CanFocus = true;
			this.buttonReplace.Name = "buttonReplace";
			this.buttonReplace.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child buttonReplace.Gtk.Container+ContainerChild
			this.image5 = new global::MonoDevelop.Components.ImageView();
			this.image5.Name = "image5";
			this.image5.IconId = "gtk-find-and-replace";
			this.image5.IconSize = ((global::Gtk.IconSize)(1));
			this.buttonReplace.Add(this.image5);
			this.hbox2.Add(this.buttonReplace);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonReplace]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonReplaceAll = new global::Gtk.Button();
			this.buttonReplaceAll.CanFocus = true;
			this.buttonReplaceAll.Name = "buttonReplaceAll";
			this.buttonReplaceAll.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child buttonReplaceAll.Gtk.Container+ContainerChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.image6 = new global::MonoDevelop.Components.ImageView();
			this.image6.Name = "image6";
			this.image6.IconId = "gtk-find-and-replace";
			this.image6.IconSize = ((global::Gtk.IconSize)(1));
			this.hbox3.Add(this.image6);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.image6]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("All");
			this.hbox3.Add(this.label1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label1]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.buttonReplaceAll.Add(this.hbox3);
			this.hbox2.Add(this.buttonReplaceAll);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonReplaceAll]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			this.table.Add(this.hbox2);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table[this.hbox2]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
		}
	}
}
#pragma warning restore 436
