#pragma warning disable 436

namespace MonoDevelop.Deployment.Gui
{
	public partial class FileCopyConfigurationSelector
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::Gtk.ComboBox comboHandlers;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.EventBox editorBox;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Deployment.Gui.FileCopyConfigurationSelector
			global::Stetic.BinContainer.Attach(this);
			this.Events = ((global::Gdk.EventMask)(256));
			this.Name = "MonoDevelop.Deployment.Gui.FileCopyConfigurationSelector";
			// Container child MonoDevelop.Deployment.Gui.FileCopyConfigurationSelector.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Target:");
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboHandlers = global::Gtk.ComboBox.NewText();
			this.comboHandlers.Name = "comboHandlers";
			this.hbox1.Add(this.comboHandlers);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.comboHandlers]));
			w2.Position = 1;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.editorBox = new global::Gtk.EventBox();
			this.editorBox.Name = "editorBox";
			this.vbox1.Add(this.editorBox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.editorBox]));
			w5.Position = 2;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
			this.comboHandlers.Changed += new global::System.EventHandler(this.OnComboHandlersChanged);
		}
	}
}
#pragma warning restore 436
