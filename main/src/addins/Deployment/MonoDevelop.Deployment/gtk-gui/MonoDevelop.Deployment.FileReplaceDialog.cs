#pragma warning disable 436

namespace MonoDevelop.Deployment
{
	public partial class FileReplaceDialog
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label7;

		private global::MonoDevelop.Components.ImageView image1;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label8;

		private global::Gtk.VBox vbox4;

		private global::Gtk.HBox hbox3;

		private global::Gtk.RadioButton radioReplace;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Label replaceLabel;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label25;

		private global::Gtk.Label sourceName;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label label26;

		private global::Gtk.Label sourceModified;

		private global::Gtk.HBox hbox4;

		private global::Gtk.RadioButton radioKeep;

		private global::Gtk.VBox vbox6;

		private global::Gtk.Label keepLabel;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label label27;

		private global::Gtk.Label targetName;

		private global::Gtk.HBox hbox9;

		private global::Gtk.Label label28;

		private global::Gtk.Label targetModified;

		private global::Gtk.HBox hbox5;

		private global::Gtk.RadioButton radioNewest;

		private global::Gtk.VBox vbox7;

		private global::Gtk.Label newestLabel;

		private global::Gtk.Label label20;

		private global::Gtk.CheckButton applyAll;

		private global::Gtk.Label label11;

		private global::Gtk.Button cancelButton;

		private global::Gtk.Button okButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Deployment.FileReplaceDialog
			this.Name = "MonoDevelop.Deployment.FileReplaceDialog";
			this.Title = global::Mono.Unix.Catalog.GetString("Replace existing file?");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(6));
			this.Resizable = false;
			this.AllowGrow = false;
			// Internal child MonoDevelop.Deployment.FileReplaceDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.Spacing = 4;
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.hbox1.Add(this.label7);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label7]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.image1 = new global::MonoDevelop.Components.ImageView();
			this.image1.Name = "image1";
			this.image1.IconId = "gtk-dialog-warning";
			this.image1.IconSize = ((global::Gtk.IconSize)(6));
			this.hbox1.Add(this.image1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.image1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			w3.Padding = ((uint)(8));
			// Container child hbox1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("<b><big>Deploy file already exists. Do you want to replace it?</big></b>");
			this.label5.UseMarkup = true;
			this.label5.Wrap = true;
			this.label5.Justify = ((global::Gtk.Justification)(3));
			this.hbox1.Add(this.label5);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label5]));
			w4.Position = 2;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.hbox1.Add(this.label6);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label6]));
			w5.Position = 3;
			w1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(w1[this.hbox1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("There is already a file in the target directory that has the same name as the sou" +
					"rce file. You can keep the existing target file, or overwrite it with the source" +
					" file.");
			this.label2.Wrap = true;
			this.label2.Justify = ((global::Gtk.Justification)(3));
			w1.Add(this.label2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(w1[this.label2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			this.hbox2.BorderWidth = ((uint)(6));
			// Container child hbox2.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.WidthRequest = 18;
			this.label8.Name = "label8";
			this.hbox2.Add(this.label8);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label8]));
			w8.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.radioReplace = new global::Gtk.RadioButton("");
			this.radioReplace.CanFocus = true;
			this.radioReplace.Name = "radioReplace";
			this.radioReplace.DrawIndicator = true;
			this.radioReplace.UseUnderline = true;
			this.radioReplace.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.radioReplace.Remove(this.radioReplace.Child);
			// Container child radioReplace.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			this.vbox5.BorderWidth = ((uint)(2));
			// Container child vbox5.Gtk.Box+BoxChild
			this.replaceLabel = new global::Gtk.Label();
			this.replaceLabel.Name = "replaceLabel";
			this.replaceLabel.Xalign = 0F;
			this.replaceLabel.UseMarkup = true;
			this.vbox5.Add(this.replaceLabel);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.replaceLabel]));
			w9.Position = 0;
			w9.Expand = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label25 = new global::Gtk.Label();
			this.label25.Name = "label25";
			this.label25.Xalign = 0F;
			this.label25.LabelProp = global::Mono.Unix.Catalog.GetString("Name:");
			this.label25.Justify = ((global::Gtk.Justification)(1));
			this.hbox6.Add(this.label25);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label25]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.sourceName = new global::Gtk.Label();
			this.sourceName.Name = "sourceName";
			this.sourceName.Xalign = 0F;
			this.sourceName.Selectable = true;
			this.sourceName.Ellipsize = ((global::Pango.EllipsizeMode)(2));
			this.sourceName.MaxWidthChars = 35;
			this.hbox6.Add(this.sourceName);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.sourceName]));
			w11.Position = 1;
			this.vbox5.Add(this.hbox6);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox6]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label26 = new global::Gtk.Label();
			this.label26.Name = "label26";
			this.label26.Xalign = 0F;
			this.label26.LabelProp = global::Mono.Unix.Catalog.GetString("Modified:");
			this.label26.Justify = ((global::Gtk.Justification)(1));
			this.hbox7.Add(this.label26);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label26]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.sourceModified = new global::Gtk.Label();
			this.sourceModified.Name = "sourceModified";
			this.sourceModified.Xalign = 0F;
			this.hbox7.Add(this.sourceModified);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.sourceModified]));
			w14.Position = 1;
			this.vbox5.Add(this.hbox7);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox7]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			this.radioReplace.Add(this.vbox5);
			this.hbox3.Add(this.radioReplace);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.radioReplace]));
			w17.Position = 0;
			this.vbox4.Add(this.hbox3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox3]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.radioKeep = new global::Gtk.RadioButton("");
			this.radioKeep.CanFocus = true;
			this.radioKeep.Name = "radioKeep";
			this.radioKeep.DrawIndicator = true;
			this.radioKeep.UseUnderline = true;
			this.radioKeep.Group = this.radioReplace.Group;
			this.radioKeep.Remove(this.radioKeep.Child);
			// Container child radioKeep.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			this.vbox6.BorderWidth = ((uint)(2));
			// Container child vbox6.Gtk.Box+BoxChild
			this.keepLabel = new global::Gtk.Label();
			this.keepLabel.Name = "keepLabel";
			this.keepLabel.Xalign = 0F;
			this.keepLabel.UseMarkup = true;
			this.vbox6.Add(this.keepLabel);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.keepLabel]));
			w19.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label27 = new global::Gtk.Label();
			this.label27.Name = "label27";
			this.label27.Xalign = 0F;
			this.label27.LabelProp = global::Mono.Unix.Catalog.GetString("Name:");
			this.label27.Justify = ((global::Gtk.Justification)(1));
			this.hbox8.Add(this.label27);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label27]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.targetName = new global::Gtk.Label();
			this.targetName.Name = "targetName";
			this.targetName.Xalign = 0F;
			this.targetName.Selectable = true;
			this.targetName.Ellipsize = ((global::Pango.EllipsizeMode)(2));
			this.targetName.MaxWidthChars = 35;
			this.hbox8.Add(this.targetName);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.targetName]));
			w21.Position = 1;
			this.vbox6.Add(this.hbox8);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox8]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label28 = new global::Gtk.Label();
			this.label28.Name = "label28";
			this.label28.Xalign = 0F;
			this.label28.LabelProp = global::Mono.Unix.Catalog.GetString("Modified:");
			this.label28.Justify = ((global::Gtk.Justification)(1));
			this.hbox9.Add(this.label28);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.label28]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.targetModified = new global::Gtk.Label();
			this.targetModified.Name = "targetModified";
			this.targetModified.Xalign = 0F;
			this.hbox9.Add(this.targetModified);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.targetModified]));
			w24.Position = 1;
			this.vbox6.Add(this.hbox9);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox9]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			this.radioKeep.Add(this.vbox6);
			this.hbox4.Add(this.radioKeep);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.radioKeep]));
			w27.Position = 0;
			this.vbox4.Add(this.hbox4);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox4]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.radioNewest = new global::Gtk.RadioButton("");
			this.radioNewest.CanFocus = true;
			this.radioNewest.Name = "radioNewest";
			this.radioNewest.DrawIndicator = true;
			this.radioNewest.UseUnderline = true;
			this.radioNewest.Group = this.radioReplace.Group;
			this.radioNewest.Remove(this.radioNewest.Child);
			// Container child radioNewest.Gtk.Container+ContainerChild
			this.vbox7 = new global::Gtk.VBox();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			this.vbox7.BorderWidth = ((uint)(2));
			// Container child vbox7.Gtk.Box+BoxChild
			this.newestLabel = new global::Gtk.Label();
			this.newestLabel.Name = "newestLabel";
			this.newestLabel.Xalign = 0F;
			this.newestLabel.UseMarkup = true;
			this.vbox7.Add(this.newestLabel);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.newestLabel]));
			w29.Position = 0;
			// Container child vbox7.Gtk.Box+BoxChild
			this.label20 = new global::Gtk.Label();
			this.label20.Name = "label20";
			this.label20.Xpad = 2;
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString("The source file will replace the existing target file if it has been modified mor" +
					"e recently.");
			this.label20.Wrap = true;
			this.vbox7.Add(this.label20);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label20]));
			w30.Position = 1;
			this.radioNewest.Add(this.vbox7);
			this.hbox5.Add(this.radioNewest);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.radioNewest]));
			w32.Position = 0;
			this.vbox4.Add(this.hbox5);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox5]));
			w33.Position = 2;
			w33.Expand = false;
			w33.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.applyAll = new global::Gtk.CheckButton();
			this.applyAll.CanFocus = true;
			this.applyAll.Name = "applyAll";
			this.applyAll.Label = global::Mono.Unix.Catalog.GetString("Apply this decision to _all files in this operation");
			this.applyAll.DrawIndicator = true;
			this.applyAll.UseUnderline = true;
			this.vbox4.Add(this.applyAll);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.applyAll]));
			w34.Position = 3;
			w34.Expand = false;
			w34.Fill = false;
			this.hbox2.Add(this.vbox4);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox4]));
			w35.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.WidthRequest = 18;
			this.label11.Name = "label11";
			this.hbox2.Add(this.label11);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label11]));
			w36.PackType = ((global::Gtk.PackType)(1));
			w36.Position = 2;
			w1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(w1[this.hbox2]));
			w37.Position = 2;
			// Internal child MonoDevelop.Deployment.FileReplaceDialog.ActionArea
			global::Gtk.HButtonBox w38 = this.ActionArea;
			w38.Name = "dialog1_ActionArea";
			w38.Spacing = 6;
			w38.BorderWidth = ((uint)(5));
			w38.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.cancelButton = new global::Gtk.Button();
			this.cancelButton.CanFocus = true;
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.UseUnderline = true;
			this.cancelButton.Label = global::Mono.Unix.Catalog.GetString("_Cancel deployment");
			this.AddActionWidget(this.cancelButton, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w39 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w38[this.cancelButton]));
			w39.Expand = false;
			w39.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.okButton = new global::Gtk.Button();
			this.okButton.CanDefault = true;
			this.okButton.CanFocus = true;
			this.okButton.Name = "okButton";
			this.okButton.UseStock = true;
			this.okButton.UseUnderline = true;
			this.okButton.Label = "gtk-ok";
			this.AddActionWidget(this.okButton, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w40 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w38[this.okButton]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 425;
			this.DefaultHeight = 420;
			this.Hide();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.DeleteActivated);
			this.cancelButton.Clicked += new global::System.EventHandler(this.CancelClicked);
			this.okButton.Clicked += new global::System.EventHandler(this.OkClicked);
		}
	}
}
#pragma warning restore 436
