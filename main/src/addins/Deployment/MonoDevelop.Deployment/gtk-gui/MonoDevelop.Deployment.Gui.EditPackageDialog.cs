#pragma warning disable 436

namespace MonoDevelop.Deployment.Gui
{
	internal partial class EditPackageDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Notebook notebook;

		private global::Gtk.VBox targetBox;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label4;

		private global::Gtk.Entry entryName;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Label label2;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Label label6;

		private global::MonoDevelop.Deployment.Gui.EntrySelectionTree entrySelector;

		private global::Gtk.Label label1;

		private global::Gtk.HBox pageFiles;

		private global::MonoDevelop.Deployment.DeployFileListWidget fileListView;

		private global::Gtk.Label label5;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button okbutton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Deployment.Gui.EditPackageDialog
			this.Name = "MonoDevelop.Deployment.Gui.EditPackageDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoDevelop.Deployment.Gui.EditPackageDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(12));
			// Container child vbox2.Gtk.Box+BoxChild
			this.notebook = new global::Gtk.Notebook();
			this.notebook.CanFocus = true;
			this.notebook.Name = "notebook";
			this.notebook.CurrentPage = 0;
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.targetBox = new global::Gtk.VBox();
			this.targetBox.Name = "targetBox";
			this.targetBox.Spacing = 6;
			this.targetBox.BorderWidth = ((uint)(12));
			// Container child targetBox.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Name:");
			this.hbox4.Add(this.label4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label4]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entryName = new global::Gtk.Entry();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.WidthChars = 40;
			this.entryName.InvisibleChar = '●';
			this.hbox4.Add(this.entryName);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entryName]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.targetBox.Add(this.hbox4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.targetBox[this.hbox4]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child targetBox.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.targetBox.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.targetBox[this.hseparator1]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.notebook.Add(this.targetBox);
			// Notebook tab
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Package Settings");
			this.notebook.SetTabLabel(this.targetBox, this.label2);
			this.label2.ShowAll();
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			this.vbox4.BorderWidth = ((uint)(12));
			// Container child vbox4.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Select the projects and solutions you want to include in the package:");
			this.vbox4.Add(this.label6);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label6]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.entrySelector = null;
			this.vbox4.Add(this.entrySelector);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.entrySelector]));
			w8.Position = 1;
			this.notebook.Add(this.vbox4);
			global::Gtk.Notebook.NotebookChild w9 = ((global::Gtk.Notebook.NotebookChild)(this.notebook[this.vbox4]));
			w9.Position = 1;
			// Notebook tab
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Projects/Solutions");
			this.notebook.SetTabLabel(this.vbox4, this.label1);
			this.label1.ShowAll();
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.pageFiles = new global::Gtk.HBox();
			this.pageFiles.Name = "pageFiles";
			this.pageFiles.Spacing = 6;
			this.pageFiles.BorderWidth = ((uint)(12));
			// Container child pageFiles.Gtk.Box+BoxChild
			this.fileListView = null;
			this.pageFiles.Add(this.fileListView);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.pageFiles[this.fileListView]));
			w10.Position = 0;
			this.notebook.Add(this.pageFiles);
			global::Gtk.Notebook.NotebookChild w11 = ((global::Gtk.Notebook.NotebookChild)(this.notebook[this.pageFiles]));
			w11.Position = 2;
			// Notebook tab
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Files");
			this.notebook.SetTabLabel(this.pageFiles, this.label5);
			this.label5.ShowAll();
			this.vbox2.Add(this.notebook);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.notebook]));
			w12.Position = 0;
			w1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w13.Position = 0;
			// Internal child MonoDevelop.Deployment.Gui.EditPackageDialog.ActionArea
			global::Gtk.HButtonBox w14 = this.ActionArea;
			w14.Name = "dialog1_ActionArea";
			w14.Spacing = 6;
			w14.BorderWidth = ((uint)(5));
			w14.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14[this.buttonCancel]));
			w15.Expand = false;
			w15.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.okbutton = new global::Gtk.Button();
			this.okbutton.CanDefault = true;
			this.okbutton.CanFocus = true;
			this.okbutton.Name = "okbutton";
			this.okbutton.UseStock = true;
			this.okbutton.UseUnderline = true;
			this.okbutton.Label = "gtk-ok";
			w14.Add(this.okbutton);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14[this.okbutton]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 599;
			this.DefaultHeight = 450;
			this.Hide();
			this.notebook.SwitchPage += new global::Gtk.SwitchPageHandler(this.OnNotebookSwitchPage);
			this.entryName.Changed += new global::System.EventHandler(this.OnEntryNameChanged);
			this.okbutton.Clicked += new global::System.EventHandler(this.OnOkbuttonClicked);
		}
	}
}
#pragma warning restore 436
