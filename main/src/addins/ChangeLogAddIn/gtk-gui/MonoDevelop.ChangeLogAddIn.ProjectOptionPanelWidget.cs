#pragma warning disable 436

namespace MonoDevelop.ChangeLogAddIn
{
	internal partial class ProjectOptionPanelWidget
	{
		private global::Gtk.Notebook notebook1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.RadioButton noneRadioButton;

		private global::Gtk.Label label3;

		private global::Gtk.RadioButton nearestRadioButton;

		private global::Gtk.Label label5;

		private global::Gtk.RadioButton oneChangeLogInProjectRootDirectoryRadioButton;

		private global::Gtk.Label label6;

		private global::Gtk.RadioButton oneChangeLogInEachDirectoryRadioButton;

		private global::Gtk.Label label7;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.CheckButton checkVersionControl;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.CheckButton checkRequireOnCommit;

		private global::Gtk.Label label1;

		private global::Gtk.VBox vbox1;

		private global::MonoDevelop.VersionControl.CommitMessageStylePanelWidget messageWidget;

		private global::Gtk.Label label2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.ChangeLogAddIn.ProjectOptionPanelWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "MonoDevelop.ChangeLogAddIn.ProjectOptionPanelWidget";
			// Container child MonoDevelop.ChangeLogAddIn.ProjectOptionPanelWidget.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.noneRadioButton = new global::Gtk.RadioButton("radiobutton1");
			this.noneRadioButton.CanFocus = true;
			this.noneRadioButton.Name = "noneRadioButton";
			this.noneRadioButton.Active = true;
			this.noneRadioButton.DrawIndicator = true;
			this.noneRadioButton.UseUnderline = true;
			this.noneRadioButton.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.noneRadioButton.Remove(this.noneRadioButton.Child);
			// Container child noneRadioButton.Gtk.Container+ContainerChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Disable ChangeLog support</b>\nNo ChangeLog entries will be generated for this " +
					"project.");
			this.label3.UseMarkup = true;
			this.noneRadioButton.Add(this.label3);
			this.vbox2.Add(this.noneRadioButton);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.noneRadioButton]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.nearestRadioButton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Custom policy"));
			this.nearestRadioButton.CanFocus = true;
			this.nearestRadioButton.Name = "nearestRadioButton";
			this.nearestRadioButton.DrawIndicator = true;
			this.nearestRadioButton.UseUnderline = true;
			this.nearestRadioButton.Group = this.noneRadioButton.Group;
			this.nearestRadioButton.Remove(this.nearestRadioButton.Child);
			// Container child nearestRadioButton.Gtk.Container+ContainerChild
			this.label5 = new global::Gtk.Label();
			this.label5.WidthRequest = 500;
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Update nearest ChangeLog</b>\nThe nearest ChangeLog file in the directory hiera" +
					"rchy will be updated (below the commit directory). If none is found, a warning m" +
					"essage will be shown. ChangeLog files will never be automatically created.");
			this.label5.UseMarkup = true;
			this.label5.Wrap = true;
			this.nearestRadioButton.Add(this.label5);
			this.vbox2.Add(this.nearestRadioButton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.nearestRadioButton]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.oneChangeLogInProjectRootDirectoryRadioButton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("One ChangeLog in the project root directory"));
			this.oneChangeLogInProjectRootDirectoryRadioButton.CanFocus = true;
			this.oneChangeLogInProjectRootDirectoryRadioButton.Name = "oneChangeLogInProjectRootDirectoryRadioButton";
			this.oneChangeLogInProjectRootDirectoryRadioButton.DrawIndicator = true;
			this.oneChangeLogInProjectRootDirectoryRadioButton.UseUnderline = true;
			this.oneChangeLogInProjectRootDirectoryRadioButton.Group = this.noneRadioButton.Group;
			this.oneChangeLogInProjectRootDirectoryRadioButton.Remove(this.oneChangeLogInProjectRootDirectoryRadioButton.Child);
			// Container child oneChangeLogInProjectRootDirectoryRadioButton.Gtk.Container+ContainerChild
			this.label6 = new global::Gtk.Label();
			this.label6.WidthRequest = 500;
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Single project ChangeLog</b>\nAll changes done in the project files will be log" +
					"ged in a single ChangeLog file, located at the project root directory. The Chang" +
					"eLog file will be created if it doesn\'t exist.");
			this.label6.UseMarkup = true;
			this.label6.Wrap = true;
			this.oneChangeLogInProjectRootDirectoryRadioButton.Add(this.label6);
			this.vbox2.Add(this.oneChangeLogInProjectRootDirectoryRadioButton);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.oneChangeLogInProjectRootDirectoryRadioButton]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.oneChangeLogInEachDirectoryRadioButton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("One ChangeLog in each directory"));
			this.oneChangeLogInEachDirectoryRadioButton.CanFocus = true;
			this.oneChangeLogInEachDirectoryRadioButton.Name = "oneChangeLogInEachDirectoryRadioButton";
			this.oneChangeLogInEachDirectoryRadioButton.DrawIndicator = true;
			this.oneChangeLogInEachDirectoryRadioButton.UseUnderline = true;
			this.oneChangeLogInEachDirectoryRadioButton.Group = this.noneRadioButton.Group;
			this.oneChangeLogInEachDirectoryRadioButton.Remove(this.oneChangeLogInEachDirectoryRadioButton.Child);
			// Container child oneChangeLogInEachDirectoryRadioButton.Gtk.Container+ContainerChild
			this.label7 = new global::Gtk.Label();
			this.label7.WidthRequest = 500;
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("<b>One ChangeLog in each directory</b>\nFile changes will be logged in a ChangeLog" +
					" located at the file\'s directory. The ChangeLog file will be created if it doesn" +
					"\'t exist.");
			this.label7.UseMarkup = true;
			this.label7.Wrap = true;
			this.oneChangeLogInEachDirectoryRadioButton.Add(this.label7);
			this.vbox2.Add(this.oneChangeLogInEachDirectoryRadioButton);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.oneChangeLogInEachDirectoryRadioButton]));
			w8.Position = 3;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.alignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment2.TopPadding = ((uint)(18));
			// Container child alignment2.Gtk.Container+ContainerChild
			this.checkVersionControl = new global::Gtk.CheckButton();
			this.checkVersionControl.CanFocus = true;
			this.checkVersionControl.Name = "checkVersionControl";
			this.checkVersionControl.Label = global::Mono.Unix.Catalog.GetString("Integrate with _version control");
			this.checkVersionControl.DrawIndicator = true;
			this.checkVersionControl.UseUnderline = true;
			this.alignment2.Add(this.checkVersionControl);
			this.alignment1.Add(this.alignment2);
			this.vbox2.Add(this.alignment1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment1]));
			w11.Position = 4;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.alignment3.LeftPadding = ((uint)(24));
			// Container child alignment3.Gtk.Container+ContainerChild
			this.checkRequireOnCommit = new global::Gtk.CheckButton();
			this.checkRequireOnCommit.CanFocus = true;
			this.checkRequireOnCommit.Name = "checkRequireOnCommit";
			this.checkRequireOnCommit.Label = global::Mono.Unix.Catalog.GetString("_Require ChangeLog entries for all files when committing");
			this.checkRequireOnCommit.DrawIndicator = true;
			this.checkRequireOnCommit.UseUnderline = true;
			this.alignment3.Add(this.checkRequireOnCommit);
			this.vbox2.Add(this.alignment3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment3]));
			w13.PackType = ((global::Gtk.PackType)(1));
			w13.Position = 6;
			w13.Expand = false;
			w13.Fill = false;
			this.notebook1.Add(this.vbox2);
			// Notebook tab
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("ChangeLog Generation");
			this.notebook1.SetTabLabel(this.vbox2, this.label1);
			this.label1.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(9));
			// Container child vbox1.Gtk.Box+BoxChild
			this.messageWidget = null;
			this.vbox1.Add(this.messageWidget);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.messageWidget]));
			w15.Position = 0;
			this.notebook1.Add(this.vbox1);
			global::Gtk.Notebook.NotebookChild w16 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox1]));
			w16.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Message Style");
			this.notebook1.SetTabLabel(this.vbox1, this.label2);
			this.label2.ShowAll();
			this.Add(this.notebook1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
			this.noneRadioButton.Toggled += new global::System.EventHandler(this.ValueChanged);
			this.nearestRadioButton.Toggled += new global::System.EventHandler(this.ValueChanged);
			this.oneChangeLogInProjectRootDirectoryRadioButton.Toggled += new global::System.EventHandler(this.ValueChanged);
			this.oneChangeLogInEachDirectoryRadioButton.Toggled += new global::System.EventHandler(this.ValueChanged);
			this.checkVersionControl.Toggled += new global::System.EventHandler(this.ValueChanged);
			this.checkRequireOnCommit.Toggled += new global::System.EventHandler(this.ValueChanged);
		}
	}
}
#pragma warning restore 436
