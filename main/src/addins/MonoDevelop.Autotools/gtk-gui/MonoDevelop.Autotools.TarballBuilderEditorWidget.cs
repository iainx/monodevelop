#pragma warning disable 436

namespace MonoDevelop.Autotools
{
	public partial class TarballBuilderEditorWidget
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label2;

		private global::MonoDevelop.Components.FolderEntry folderEntry;

		private global::Gtk.RadioButton radioUseExisting;

		private global::Gtk.RadioButton radioGenerate;

		private global::Gtk.VBox boxGenerate;

		private global::Gtk.HBox boxConfig;

		private global::Gtk.Label label4;

		private global::Gtk.Label label3;

		private global::Gtk.ComboBox comboConfigs;

		private global::Gtk.HBox boxConfig1;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label8;

		private global::Gtk.RadioButton rbAutotools;

		private global::Gtk.Label label9;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label1;

		private global::Gtk.RadioButton rbSimple;

		private global::Gtk.Label label7;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button autofooProperties;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Autotools.TarballBuilderEditorWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "MonoDevelop.Autotools.TarballBuilderEditorWidget";
			// Container child MonoDevelop.Autotools.TarballBuilderEditorWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Deploy directory:");
			this.hbox1.Add(this.label2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label2]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.folderEntry = new global::MonoDevelop.Components.FolderEntry();
			this.folderEntry.Name = "folderEntry";
			this.hbox1.Add(this.folderEntry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.folderEntry]));
			w2.Position = 1;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.radioUseExisting = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Use existing Makefiles"));
			this.radioUseExisting.CanFocus = true;
			this.radioUseExisting.Name = "radioUseExisting";
			this.radioUseExisting.Active = true;
			this.radioUseExisting.DrawIndicator = true;
			this.radioUseExisting.UseUnderline = true;
			this.radioUseExisting.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.vbox2.Add(this.radioUseExisting);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.radioUseExisting]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.radioGenerate = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Generate new Makefiles"));
			this.radioGenerate.CanFocus = true;
			this.radioGenerate.Name = "radioGenerate";
			this.radioGenerate.DrawIndicator = true;
			this.radioGenerate.UseUnderline = true;
			this.radioGenerate.Group = this.radioUseExisting.Group;
			this.vbox2.Add(this.radioGenerate);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.radioGenerate]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.boxGenerate = new global::Gtk.VBox();
			this.boxGenerate.Name = "boxGenerate";
			this.boxGenerate.Spacing = 6;
			// Container child boxGenerate.Gtk.Box+BoxChild
			this.boxConfig = new global::Gtk.HBox();
			this.boxConfig.Name = "boxConfig";
			this.boxConfig.Spacing = 6;
			// Container child boxConfig.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.WidthRequest = 24;
			this.label4.Name = "label4";
			this.boxConfig.Add(this.label4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.boxConfig[this.label4]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child boxConfig.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Default configuration:");
			this.boxConfig.Add(this.label3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.boxConfig[this.label3]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child boxConfig.Gtk.Box+BoxChild
			this.comboConfigs = global::Gtk.ComboBox.NewText();
			this.comboConfigs.Name = "comboConfigs";
			this.boxConfig.Add(this.comboConfigs);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.boxConfig[this.comboConfigs]));
			w8.Position = 2;
			this.boxGenerate.Add(this.boxConfig);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.boxGenerate[this.boxConfig]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child boxGenerate.Gtk.Box+BoxChild
			this.boxConfig1 = new global::Gtk.HBox();
			this.boxConfig1.Name = "boxConfig1";
			this.boxConfig1.Spacing = 6;
			// Container child boxConfig1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.WidthRequest = 24;
			this.label5.Name = "label5";
			this.boxConfig1.Add(this.label5);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.boxConfig1[this.label5]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child boxConfig1.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Select the kind of Makefile to generate:");
			this.boxConfig1.Add(this.label6);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.boxConfig1[this.label6]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.boxGenerate.Add(this.boxConfig1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.boxGenerate[this.boxConfig1]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child boxGenerate.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.WidthRequest = 24;
			this.label8.Name = "label8";
			this.hbox3.Add(this.label8);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label8]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.rbAutotools = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Autotools based"));
			this.rbAutotools.CanFocus = true;
			this.rbAutotools.Name = "rbAutotools";
			this.rbAutotools.Active = true;
			this.rbAutotools.DrawIndicator = true;
			this.rbAutotools.UseUnderline = true;
			this.rbAutotools.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.rbAutotools.Remove(this.rbAutotools.Child);
			// Container child rbAutotools.Gtk.Container+ContainerChild
			this.label9 = new global::Gtk.Label();
			this.label9.WidthRequest = 550;
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Autotools based Makefile</b>\nGenerates a Makefile structure based on Autotools" +
					", with the standard targets and configuration scripts.");
			this.label9.UseMarkup = true;
			this.label9.Wrap = true;
			this.rbAutotools.Add(this.label9);
			this.hbox3.Add(this.rbAutotools);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.rbAutotools]));
			w15.Position = 1;
			this.boxGenerate.Add(this.hbox3);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.boxGenerate[this.hbox3]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			// Container child boxGenerate.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.WidthRequest = 24;
			this.label1.Name = "label1";
			this.hbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label1]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.rbSimple = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Simple"));
			this.rbSimple.CanFocus = true;
			this.rbSimple.Name = "rbSimple";
			this.rbSimple.DrawIndicator = true;
			this.rbSimple.UseUnderline = true;
			this.rbSimple.Group = this.rbAutotools.Group;
			this.rbSimple.Remove(this.rbSimple.Child);
			// Container child rbSimple.Gtk.Container+ContainerChild
			this.label7 = new global::Gtk.Label();
			this.label7.WidthRequest = 550;
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Simple Makefile</b>\nGenerates set of Makefiles with the most common targets, a" +
					"nd a configuration script that does a basic check of package dependencies.");
			this.label7.UseMarkup = true;
			this.label7.Wrap = true;
			this.rbSimple.Add(this.label7);
			this.hbox2.Add(this.rbSimple);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.rbSimple]));
			w19.Position = 1;
			this.boxGenerate.Add(this.hbox2);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.boxGenerate[this.hbox2]));
			w20.Position = 3;
			w20.Expand = false;
			w20.Fill = false;
			// Container child boxGenerate.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(24));
			this.alignment1.TopPadding = ((uint)(8));
			this.alignment1.BottomPadding = ((uint)(8));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.autofooProperties = new global::Gtk.Button();
			this.autofooProperties.CanFocus = true;
			this.autofooProperties.Name = "autofooProperties";
			this.autofooProperties.UseUnderline = true;
			this.autofooProperties.Label = global::Mono.Unix.Catalog.GetString("Edit configure switches");
			this.hbox4.Add(this.autofooProperties);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.autofooProperties]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			this.alignment1.Add(this.hbox4);
			this.boxGenerate.Add(this.alignment1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.boxGenerate[this.alignment1]));
			w23.Position = 4;
			w23.Expand = false;
			w23.Fill = false;
			this.vbox2.Add(this.boxGenerate);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.boxGenerate]));
			w24.Position = 3;
			w24.Expand = false;
			w24.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
			this.radioUseExisting.Clicked += new global::System.EventHandler(this.OnRadioUseExistingClicked);
			this.radioGenerate.Clicked += new global::System.EventHandler(this.OnRadioGenerateClicked);
			this.comboConfigs.Changed += new global::System.EventHandler(this.OnComboConfigsChanged);
			this.rbAutotools.Toggled += new global::System.EventHandler(this.OnRbAutotoolsToggled);
			this.rbSimple.Toggled += new global::System.EventHandler(this.OnRbSimpleToggled);
			this.autofooProperties.Clicked += new global::System.EventHandler(this.OnAutofooPropertiesClicked);
		}
	}
}
#pragma warning restore 436
