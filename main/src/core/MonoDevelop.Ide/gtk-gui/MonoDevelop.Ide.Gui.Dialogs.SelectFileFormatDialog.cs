#pragma warning disable 436

namespace MonoDevelop.Ide.Gui.Dialogs
{
	internal partial class SelectFileFormatDialog
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox3;

		private global::MonoDevelop.Components.ImageView iconWarning;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label1;

		private global::Gtk.Label labelMessage;

		private global::Gtk.Label labelWarnings;

		private global::Gtk.Label label6;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.Table table1;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.Label labelCurrentFormat;

		private global::Gtk.ComboBox comboNewFormat;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Ide.Gui.Dialogs.SelectFileFormatDialog
			this.Name = "MonoDevelop.Ide.Gui.Dialogs.SelectFileFormatDialog";
			this.Title = global::Mono.Unix.Catalog.GetString("Select File Format");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoDevelop.Ide.Gui.Dialogs.SelectFileFormatDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(6));
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.iconWarning = new global::MonoDevelop.Components.ImageView();
			this.iconWarning.Name = "iconWarning";
			this.iconWarning.IconId = "gtk-dialog-warning";
			this.iconWarning.IconSize = ((global::Gtk.IconSize)(6));
			this.vbox3.Add(this.iconWarning);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.iconWarning]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			this.hbox1.Add(this.vbox3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox3]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("<b>File Format Incompatibility Detected</b>");
			this.label1.UseMarkup = true;
			this.vbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelMessage = new global::Gtk.Label();
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Xalign = 0F;
			this.labelMessage.LabelProp = global::Mono.Unix.Catalog.GetString("The current file format for project {0} is not compatible with some settings of t" +
					"he project.");
			this.vbox2.Add(this.labelMessage);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.labelMessage]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelWarnings = new global::Gtk.Label();
			this.labelWarnings.WidthRequest = 525;
			this.labelWarnings.Name = "labelWarnings";
			this.labelWarnings.Xalign = 0F;
			this.labelWarnings.Wrap = true;
			this.vbox2.Add(this.labelWarnings);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.labelWarnings]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Please select a new file format for the solution:");
			this.vbox2.Add(this.label6);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label6]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment2.LeftPadding = ((uint)(18));
			// Container child alignment2.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.alignment3 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.alignment3.TopPadding = ((uint)(3));
			this.alignment3.BottomPadding = ((uint)(3));
			// Container child alignment3.Gtk.Container+ContainerChild
			this.labelCurrentFormat = new global::Gtk.Label();
			this.labelCurrentFormat.Name = "labelCurrentFormat";
			this.labelCurrentFormat.Xalign = 0F;
			this.labelCurrentFormat.LabelProp = "MonoDevelop";
			this.alignment3.Add(this.labelCurrentFormat);
			this.table1.Add(this.alignment3);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.alignment3]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboNewFormat = global::Gtk.ComboBox.NewText();
			this.comboNewFormat.Name = "comboNewFormat";
			this.table1.Add(this.comboNewFormat);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.comboNewFormat]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Current Format:");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("New Format:");
			this.table1.Add(this.label4);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.alignment2.Add(this.table1);
			this.vbox2.Add(this.alignment2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment2]));
			w14.Position = 4;
			w14.Expand = false;
			w14.Fill = false;
			this.hbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			w1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(w1[this.hbox1]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Internal child MonoDevelop.Ide.Gui.Dialogs.SelectFileFormatDialog.ActionArea
			global::Gtk.HButtonBox w17 = this.ActionArea;
			w17.Name = "dialog1_ActionArea";
			w17.Spacing = 10;
			w17.BorderWidth = ((uint)(5));
			w17.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w17[this.buttonCancel]));
			w18.Expand = false;
			w18.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w19 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w17[this.buttonOk]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 638;
			this.DefaultHeight = 246;
			this.Hide();
		}
	}
}
#pragma warning restore 436
