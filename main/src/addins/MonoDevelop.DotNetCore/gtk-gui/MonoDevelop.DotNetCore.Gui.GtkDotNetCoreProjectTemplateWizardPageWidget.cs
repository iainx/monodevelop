#pragma warning disable 436

namespace MonoDevelop.DotNetCore.Gui
{
	public partial class GtkDotNetCoreProjectTemplateWizardPageWidget
	{
		private global::Gtk.HBox mainHBox;

		private global::Gtk.EventBox leftBorderEventBox;

		private global::Gtk.VBox configurationVBox;

		private global::Gtk.EventBox configurationTopEventBox;

		private global::Gtk.EventBox configurationTableEventBox;

		private global::Gtk.Table configurationTable;

		private global::Gtk.ComboBox targetFrameworkComboBox;

		private global::Gtk.Label targetFrameworkInformationLabel;

		private global::Gtk.Label targetFrameworkLabel;

		private global::Gtk.EventBox configurationBottomEventBox;

		private global::Gtk.EventBox backgroundLargeImageEventBox;

		private global::Gtk.VBox backgroundLargeImageVBox;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.DotNetCore.Gui.GtkDotNetCoreProjectTemplateWizardPageWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "MonoDevelop.DotNetCore.Gui.GtkDotNetCoreProjectTemplateWizardPageWidget";
			// Container child MonoDevelop.DotNetCore.Gui.GtkDotNetCoreProjectTemplateWizardPageWidget.Gtk.Container+ContainerChild
			this.mainHBox = new global::Gtk.HBox();
			this.mainHBox.Name = "mainHBox";
			// Container child mainHBox.Gtk.Box+BoxChild
			this.leftBorderEventBox = new global::Gtk.EventBox();
			this.leftBorderEventBox.WidthRequest = 30;
			this.leftBorderEventBox.Name = "leftBorderEventBox";
			this.mainHBox.Add(this.leftBorderEventBox);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.mainHBox[this.leftBorderEventBox]));
			w1.Position = 0;
			w1.Expand = false;
			// Container child mainHBox.Gtk.Box+BoxChild
			this.configurationVBox = new global::Gtk.VBox();
			this.configurationVBox.WidthRequest = 440;
			this.configurationVBox.Name = "configurationVBox";
			// Container child configurationVBox.Gtk.Box+BoxChild
			this.configurationTopEventBox = new global::Gtk.EventBox();
			this.configurationTopEventBox.Name = "configurationTopEventBox";
			this.configurationVBox.Add(this.configurationTopEventBox);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.configurationVBox[this.configurationTopEventBox]));
			w2.Position = 0;
			// Container child configurationVBox.Gtk.Box+BoxChild
			this.configurationTableEventBox = new global::Gtk.EventBox();
			this.configurationTableEventBox.Name = "configurationTableEventBox";
			// Container child configurationTableEventBox.Gtk.Container+ContainerChild
			this.configurationTable = new global::Gtk.Table(((uint)(2)), ((uint)(3)), false);
			this.configurationTable.Name = "configurationTable";
			this.configurationTable.RowSpacing = ((uint)(7));
			this.configurationTable.ColumnSpacing = ((uint)(6));
			// Container child configurationTable.Gtk.Table+TableChild
			this.targetFrameworkComboBox = global::Gtk.ComboBox.NewText();
			this.targetFrameworkComboBox.WidthRequest = 250;
			this.targetFrameworkComboBox.Name = "targetFrameworkComboBox";
			this.configurationTable.Add(this.targetFrameworkComboBox);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.configurationTable[this.targetFrameworkComboBox]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child configurationTable.Gtk.Table+TableChild
			this.targetFrameworkInformationLabel = new global::Gtk.Label();
			this.targetFrameworkInformationLabel.Name = "targetFrameworkInformationLabel";
			this.targetFrameworkInformationLabel.Xpad = 5;
			this.targetFrameworkInformationLabel.Xalign = 0F;
			this.targetFrameworkInformationLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Select the target framework for your project.");
			this.targetFrameworkInformationLabel.Justify = ((global::Gtk.Justification)(1));
			this.configurationTable.Add(this.targetFrameworkInformationLabel);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.configurationTable[this.targetFrameworkInformationLabel]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child configurationTable.Gtk.Table+TableChild
			this.targetFrameworkLabel = new global::Gtk.Label();
			this.targetFrameworkLabel.WidthRequest = 132;
			this.targetFrameworkLabel.Name = "targetFrameworkLabel";
			this.targetFrameworkLabel.Xpad = 5;
			this.targetFrameworkLabel.Xalign = 1F;
			this.targetFrameworkLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Target Framework:");
			this.targetFrameworkLabel.Justify = ((global::Gtk.Justification)(1));
			this.configurationTable.Add(this.targetFrameworkLabel);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.configurationTable[this.targetFrameworkLabel]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			this.configurationTableEventBox.Add(this.configurationTable);
			this.configurationVBox.Add(this.configurationTableEventBox);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.configurationVBox[this.configurationTableEventBox]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child configurationVBox.Gtk.Box+BoxChild
			this.configurationBottomEventBox = new global::Gtk.EventBox();
			this.configurationBottomEventBox.Name = "configurationBottomEventBox";
			this.configurationVBox.Add(this.configurationBottomEventBox);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.configurationVBox[this.configurationBottomEventBox]));
			w8.Position = 2;
			this.mainHBox.Add(this.configurationVBox);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.mainHBox[this.configurationVBox]));
			w9.Position = 1;
			// Container child mainHBox.Gtk.Box+BoxChild
			this.backgroundLargeImageEventBox = new global::Gtk.EventBox();
			this.backgroundLargeImageEventBox.Name = "backgroundLargeImageEventBox";
			// Container child backgroundLargeImageEventBox.Gtk.Container+ContainerChild
			this.backgroundLargeImageVBox = new global::Gtk.VBox();
			this.backgroundLargeImageVBox.Name = "backgroundLargeImageVBox";
			this.backgroundLargeImageEventBox.Add(this.backgroundLargeImageVBox);
			this.mainHBox.Add(this.backgroundLargeImageEventBox);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.mainHBox[this.backgroundLargeImageEventBox]));
			w11.Position = 2;
			this.Add(this.mainHBox);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
#pragma warning restore 436
