#pragma warning disable 436

namespace MonoDevelop.Ide.Projects
{
	internal partial class NewConfigurationDialog
	{
		private global::Gtk.VBox vbox77;

		private global::Gtk.Table table1;

		private global::Gtk.ComboBoxEntry comboName;

		private global::Gtk.ComboBoxEntry comboPlatform;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.CheckButton createChildrenCheck;

		private global::Gtk.Button cancelbutton1;

		private global::Gtk.Button okbutton1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Ide.Projects.NewConfigurationDialog
			this.Name = "MonoDevelop.Ide.Projects.NewConfigurationDialog";
			this.Title = global::Mono.Unix.Catalog.GetString("New Configuration");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			// Internal child MonoDevelop.Ide.Projects.NewConfigurationDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog-vbox6";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog-vbox6.Gtk.Box+BoxChild
			this.vbox77 = new global::Gtk.VBox();
			this.vbox77.Name = "vbox77";
			this.vbox77.Spacing = 6;
			this.vbox77.BorderWidth = ((uint)(7));
			// Container child vbox77.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboName = global::Gtk.ComboBoxEntry.NewText();
			this.comboName.Name = "comboName";
			this.table1.Add(this.comboName);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.comboName]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboPlatform = global::Gtk.ComboBoxEntry.NewText();
			this.comboPlatform.Name = "comboPlatform";
			this.table1.Add(this.comboPlatform);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.comboPlatform]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Name:");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Platform:");
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox77.Add(this.table1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox77[this.table1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox77.Gtk.Box+BoxChild
			this.createChildrenCheck = new global::Gtk.CheckButton();
			this.createChildrenCheck.Name = "createChildrenCheck";
			this.createChildrenCheck.Label = global::Mono.Unix.Catalog.GetString("Create configurations for all solution items");
			this.createChildrenCheck.Active = true;
			this.createChildrenCheck.DrawIndicator = true;
			this.createChildrenCheck.UseUnderline = true;
			this.vbox77.Add(this.createChildrenCheck);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox77[this.createChildrenCheck]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			w1.Add(this.vbox77);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(w1[this.vbox77]));
			w8.Position = 0;
			// Internal child MonoDevelop.Ide.Projects.NewConfigurationDialog.ActionArea
			global::Gtk.HButtonBox w9 = this.ActionArea;
			w9.Name = "dialog-action_area6";
			w9.Spacing = 6;
			w9.BorderWidth = ((uint)(5));
			w9.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog-action_area6.Gtk.ButtonBox+ButtonBoxChild
			this.cancelbutton1 = new global::Gtk.Button();
			this.cancelbutton1.Name = "cancelbutton1";
			this.cancelbutton1.UseStock = true;
			this.cancelbutton1.UseUnderline = true;
			this.cancelbutton1.Label = "gtk-cancel";
			this.AddActionWidget(this.cancelbutton1, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w9[this.cancelbutton1]));
			w10.Expand = false;
			w10.Fill = false;
			// Container child dialog-action_area6.Gtk.ButtonBox+ButtonBoxChild
			this.okbutton1 = new global::Gtk.Button();
			this.okbutton1.Name = "okbutton1";
			this.okbutton1.UseStock = true;
			this.okbutton1.UseUnderline = true;
			this.okbutton1.Label = "gtk-ok";
			w9.Add(this.okbutton1);
			global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w9[this.okbutton1]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 407;
			this.DefaultHeight = 187;
			this.Hide();
			this.okbutton1.Clicked += new global::System.EventHandler(this.OnOkbutton1Clicked);
		}
	}
}
#pragma warning restore 436
