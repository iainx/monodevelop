#pragma warning disable 436

namespace MonoDevelop.Autotools
{
	public partial class GenerateMakefilesDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label2;

		private global::Gtk.VBox vbox3;

		private global::Gtk.RadioButton rbSimple;

		private global::Gtk.Label label4;

		private global::Gtk.RadioButton rbAutotools;

		private global::Gtk.Label label5;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Label label3;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::Gtk.ComboBox comboConfigs;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Autotools.GenerateMakefilesDialog
			this.Name = "MonoDevelop.Autotools.GenerateMakefilesDialog";
			this.Title = global::Mono.Unix.Catalog.GetString("Generate Makefiles");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowGrow = false;
			// Internal child MonoDevelop.Autotools.GenerateMakefilesDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 12;
			this.vbox2.BorderWidth = ((uint)(12));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Select the kind of Makefile you want to generate:");
			this.vbox2.Add(this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.rbSimple = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Simple"));
			this.rbSimple.CanFocus = true;
			this.rbSimple.Name = "rbSimple";
			this.rbSimple.DrawIndicator = true;
			this.rbSimple.UseUnderline = true;
			this.rbSimple.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.rbSimple.Remove(this.rbSimple.Child);
			// Container child rbSimple.Gtk.Container+ContainerChild
			this.label4 = new global::Gtk.Label();
			this.label4.WidthRequest = 550;
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Simple Makefile</b>\nGenerates set of Makefiles with the most common targets, a" +
					"nd a configuration script that does a basic check of package dependencies.");
			this.label4.UseMarkup = true;
			this.label4.Wrap = true;
			this.rbSimple.Add(this.label4);
			this.vbox3.Add(this.rbSimple);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.rbSimple]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.rbAutotools = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Autotools based"));
			this.rbAutotools.CanFocus = true;
			this.rbAutotools.Name = "rbAutotools";
			this.rbAutotools.DrawIndicator = true;
			this.rbAutotools.UseUnderline = true;
			this.rbAutotools.Group = this.rbSimple.Group;
			this.rbAutotools.Remove(this.rbAutotools.Child);
			// Container child rbAutotools.Gtk.Container+ContainerChild
			this.label5 = new global::Gtk.Label();
			this.label5.WidthRequest = 550;
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Autotools based Makefile</b>\nGenerates a Makefile structure based on Autotools" +
					", with the standard targets and configuration scripts.");
			this.label5.UseMarkup = true;
			this.label5.Wrap = true;
			this.rbAutotools.Add(this.label5);
			this.vbox3.Add(this.rbAutotools);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.rbAutotools]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox2.Add(this.vbox3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator1]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.WidthRequest = 580;
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Select the configuration that the Makefile will build by default. Other configura" +
					"tions can be selected via the \'--config\' option of the generated configure scrip" +
					"t.");
			this.label3.Wrap = true;
			this.vbox2.Add(this.label3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label3]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Default configuration:");
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboConfigs = global::Gtk.ComboBox.NewText();
			this.comboConfigs.Name = "comboConfigs";
			this.hbox1.Add(this.comboConfigs);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.comboConfigs]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w12.PackType = ((global::Gtk.PackType)(1));
			w12.Position = 4;
			w12.Expand = false;
			w12.Fill = false;
			w1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Internal child MonoDevelop.Autotools.GenerateMakefilesDialog.ActionArea
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
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14[this.buttonOk]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 614;
			this.DefaultHeight = 359;
			this.Hide();
		}
	}
}
#pragma warning restore 436
