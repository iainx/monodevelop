#pragma warning disable 436

namespace MonoDevelop.Gettext.Translator
{
	internal partial class LanguageChooserDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment2;

		private global::Gtk.HBox tableKnown;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Label label3;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.TreeView languageTreeView;

		private global::Gtk.VBox vbox5;

		private global::Gtk.CheckButton checkbuttonUseCoutry;

		private global::Gtk.ScrolledWindow scrolledwindow2;

		private global::Gtk.TreeView countryTreeView;

		private global::Gtk.RadioButton radiobuttonKnown;

		private global::Gtk.Frame frame2;

		private global::Gtk.Alignment GtkAlignment3;

		private global::Gtk.HBox hboxUser;

		private global::Gtk.Label label2;

		private global::Gtk.Entry entryLocale;

		private global::Gtk.RadioButton radiobuttonCustom;

		private global::Gtk.Button button1;

		private global::Gtk.Button buttonOK;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Gettext.Translator.LanguageChooserDialog
			this.Events = ((global::Gdk.EventMask)(256));
			this.Name = "MonoDevelop.Gettext.Translator.LanguageChooserDialog";
			this.Title = global::Mono.Unix.Catalog.GetString("Create New Localization");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource("locale-16.png");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Resizable = false;
			this.AllowGrow = false;
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipTaskbarHint = true;
			// Internal child MonoDevelop.Gettext.Translator.LanguageChooserDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Events = ((global::Gdk.EventMask)(256));
			w1.Name = "dialog_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 16;
			this.vbox2.BorderWidth = ((uint)(8));
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 8;
			// Container child vbox3.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.tableKnown = new global::Gtk.HBox();
			this.tableKnown.Name = "tableKnown";
			this.tableKnown.Spacing = 6;
			// Container child tableKnown.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			this.vbox4.BorderWidth = ((uint)(6));
			// Container child vbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.WidthRequest = 170;
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("_Language:");
			this.label3.UseUnderline = true;
			this.vbox4.Add(this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.HeightRequest = 200;
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.languageTreeView = new global::Gtk.TreeView();
			this.languageTreeView.CanFocus = true;
			this.languageTreeView.Name = "languageTreeView";
			this.languageTreeView.HeadersVisible = false;
			this.scrolledwindow1.Add(this.languageTreeView);
			this.vbox4.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.scrolledwindow1]));
			w4.Position = 1;
			this.tableKnown.Add(this.vbox4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.tableKnown[this.vbox4]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child tableKnown.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			this.vbox5.BorderWidth = ((uint)(6));
			// Container child vbox5.Gtk.Box+BoxChild
			this.checkbuttonUseCoutry = new global::Gtk.CheckButton();
			this.checkbuttonUseCoutry.WidthRequest = 220;
			this.checkbuttonUseCoutry.CanFocus = true;
			this.checkbuttonUseCoutry.Name = "checkbuttonUseCoutry";
			this.checkbuttonUseCoutry.Label = global::Mono.Unix.Catalog.GetString("U_se Country Code");
			this.checkbuttonUseCoutry.DrawIndicator = true;
			this.checkbuttonUseCoutry.UseUnderline = true;
			this.vbox5.Add(this.checkbuttonUseCoutry);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.checkbuttonUseCoutry]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			this.countryTreeView = new global::Gtk.TreeView();
			this.countryTreeView.CanFocus = true;
			this.countryTreeView.Name = "countryTreeView";
			this.countryTreeView.HeadersVisible = false;
			this.scrolledwindow2.Add(this.countryTreeView);
			this.vbox5.Add(this.scrolledwindow2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.scrolledwindow2]));
			w8.Position = 1;
			this.tableKnown.Add(this.vbox5);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.tableKnown[this.vbox5]));
			w9.Position = 1;
			this.GtkAlignment2.Add(this.tableKnown);
			this.frame1.Add(this.GtkAlignment2);
			this.radiobuttonKnown = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("_Known Language"));
			this.radiobuttonKnown.Name = "radiobuttonKnown";
			this.radiobuttonKnown.Active = true;
			this.radiobuttonKnown.DrawIndicator = true;
			this.radiobuttonKnown.UseUnderline = true;
			this.radiobuttonKnown.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.frame1.LabelWidget = this.radiobuttonKnown;
			this.vbox3.Add(this.frame1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.frame1]));
			w12.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.hboxUser = new global::Gtk.HBox();
			this.hboxUser.Name = "hboxUser";
			this.hboxUser.Spacing = 6;
			// Container child hboxUser.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("L_ocale:");
			this.label2.UseUnderline = true;
			this.hboxUser.Add(this.label2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hboxUser[this.label2]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hboxUser.Gtk.Box+BoxChild
			this.entryLocale = new global::Gtk.Entry();
			this.entryLocale.CanFocus = true;
			this.entryLocale.Name = "entryLocale";
			this.entryLocale.IsEditable = true;
			this.entryLocale.InvisibleChar = '●';
			this.hboxUser.Add(this.entryLocale);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hboxUser[this.entryLocale]));
			w14.Position = 1;
			this.GtkAlignment3.Add(this.hboxUser);
			this.frame2.Add(this.GtkAlignment3);
			this.radiobuttonCustom = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("_User Defined Locale"));
			this.radiobuttonCustom.Name = "radiobuttonCustom";
			this.radiobuttonCustom.DrawIndicator = true;
			this.radiobuttonCustom.UseUnderline = true;
			this.radiobuttonCustom.Group = this.radiobuttonKnown.Group;
			this.frame2.LabelWidget = this.radiobuttonCustom;
			this.vbox3.Add(this.frame2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.frame2]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox2.Add(this.vbox3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
			w18.Position = 0;
			w1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Internal child MonoDevelop.Gettext.Translator.LanguageChooserDialog.ActionArea
			global::Gtk.HButtonBox w20 = this.ActionArea;
			w20.Name = "MonoDevelop.Gettext.LanguageChooserDialog_ActionArea";
			w20.Spacing = 6;
			w20.BorderWidth = ((uint)(5));
			w20.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child MonoDevelop.Gettext.LanguageChooserDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanDefault = true;
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseStock = true;
			this.button1.UseUnderline = true;
			this.button1.Label = "gtk-cancel";
			this.AddActionWidget(this.button1, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w21 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w20[this.button1]));
			w21.Expand = false;
			w21.Fill = false;
			// Container child MonoDevelop.Gettext.LanguageChooserDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOK = new global::Gtk.Button();
			this.buttonOK.CanDefault = true;
			this.buttonOK.CanFocus = true;
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.UseStock = true;
			this.buttonOK.UseUnderline = true;
			this.buttonOK.Label = "gtk-add";
			this.AddActionWidget(this.buttonOK, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w22 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w20[this.buttonOK]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 466;
			this.DefaultHeight = 415;
			this.label3.MnemonicWidget = this.languageTreeView;
			this.label2.MnemonicWidget = this.entryLocale;
			this.Hide();
			this.checkbuttonUseCoutry.Clicked += new global::System.EventHandler(this.ChangeSensitivity);
			this.entryLocale.Changed += new global::System.EventHandler(this.OnEntryLocaleChanged);
		}
	}
}
#pragma warning restore 436
