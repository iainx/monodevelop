#pragma warning disable 436

namespace MonoDevelop.Autotools
{
	public partial class MakefileOptionPanelWidget
	{
		private global::Gtk.Notebook notebook1;

		private global::Gtk.VBox vbox1;

		private global::Gtk.CheckButton cbEnableMakefileIntegration;

		private global::Gtk.HSeparator headerSep1;

		private global::Gtk.Table table1;

		private global::Gtk.CheckButton cbBuildTarget;

		private global::Gtk.CheckButton cbCleanTarget;

		private global::Gtk.CheckButton cbRunTarget;

		private global::MonoDevelop.Components.FileEntry fileEntryMakefilePath;

		private global::Gtk.HBox hbox1;

		private global::Gtk.ComboBox comboAssemblyName;

		private global::Gtk.HBox hbox2;

		private global::Gtk.ComboBox comboOutputDir;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Entry BuildTargetName;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Entry ExecuteTargetName;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Entry CleanTargetName;

		private global::Gtk.HSeparator headerSep2;

		private global::Gtk.Label label8;

		private global::Gtk.Label label9;

		private global::Gtk.Label lblAssemblyNameVar;

		private global::Gtk.Label lblMakefileName;

		private global::Gtk.Label lblOutputDirVar;

		private global::Gtk.SpinButton spinProcesses;

		private global::Gtk.Label label1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.CheckButton cbFileSync;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.Table table3;

		private global::Gtk.CheckButton cbKeepDeployFilesSync;

		private global::Gtk.CheckButton cbKeepFilesSync;

		private global::Gtk.CheckButton cbKeepOthersSync;

		private global::Gtk.CheckButton cbKeepResourcesSync;

		private global::Gtk.ComboBox comboDeployFilesVar;

		private global::Gtk.ComboBox comboFilesVar;

		private global::Gtk.ComboBox comboOthersVar;

		private global::Gtk.ComboBox comboResourcesVar;

		private global::Gtk.Entry entryDeployFilesPattern;

		private global::Gtk.Entry entryFilesPattern;

		private global::Gtk.Entry entryResourcesPattern;

		private global::Gtk.EventBox eventbox1;

		private global::Gtk.Entry entryOthersPattern;

		private global::Gtk.Label label5;

		private global::Gtk.Label lblCol2;

		private global::Gtk.Label lblCol3;

		private global::Gtk.Label label2;

		private global::Gtk.VBox vbox4;

		private global::Gtk.CheckButton cbKeepRefSync;

		private global::Gtk.HSeparator hseparator5;

		private global::Gtk.Table table4;

		private global::Gtk.CheckButton cbAutotoolsProject;

		private global::Gtk.ComboBox comboAsmRefVar;

		private global::Gtk.ComboBox comboPackageRefVar;

		private global::Gtk.ComboBox comboProjectRefVar;

		private global::Gtk.Entry entryAsmRefPattern;

		private global::Gtk.Entry entryPackageRefPattern;

		private global::Gtk.Entry entryProjectRefPattern;

		private global::MonoDevelop.Components.FolderEntry fileEntryConfigureInPath;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Label label6;

		private global::Gtk.Label lblAsmRef;

		private global::Gtk.Label lblCol5;

		private global::Gtk.Label lblCol6;

		private global::Gtk.Label lblConfigureInPath;

		private global::Gtk.Label lblPackageRef;

		private global::Gtk.Label lblProjectRef;

		private global::Gtk.Label label3;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Label label7;

		private global::Gtk.Table table2;

		private global::Gtk.Entry entryErrorRegex;

		private global::Gtk.Entry entryWarningRegex;

		private global::Gtk.HBox hbox6;

		private global::Gtk.ComboBox comboMessageType;

		private global::Gtk.Label lblErrorRegex;

		private global::Gtk.Label lblMessageType;

		private global::Gtk.Label lblWarningRegex;

		private global::Gtk.Label label4;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Autotools.MakefileOptionPanelWidget
			global::Stetic.BinContainer.Attach(this);
			this.Events = ((global::Gdk.EventMask)(256));
			this.Name = "MonoDevelop.Autotools.MakefileOptionPanelWidget";
			// Container child MonoDevelop.Autotools.MakefileOptionPanelWidget.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.cbEnableMakefileIntegration = new global::Gtk.CheckButton();
			this.cbEnableMakefileIntegration.CanFocus = true;
			this.cbEnableMakefileIntegration.Name = "cbEnableMakefileIntegration";
			this.cbEnableMakefileIntegration.Label = global::Mono.Unix.Catalog.GetString("Enable makefile Integration in this project");
			this.cbEnableMakefileIntegration.DrawIndicator = true;
			this.vbox1.Add(this.cbEnableMakefileIntegration);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.cbEnableMakefileIntegration]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.headerSep1 = new global::Gtk.HSeparator();
			this.headerSep1.Name = "headerSep1";
			this.vbox1.Add(this.headerSep1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.headerSep1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(9)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.cbBuildTarget = new global::Gtk.CheckButton();
			this.cbBuildTarget.CanFocus = true;
			this.cbBuildTarget.Name = "cbBuildTarget";
			this.cbBuildTarget.Label = global::Mono.Unix.Catalog.GetString("Build target name:");
			this.cbBuildTarget.DrawIndicator = true;
			this.cbBuildTarget.UseUnderline = true;
			this.table1.Add(this.cbBuildTarget);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.cbBuildTarget]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.cbCleanTarget = new global::Gtk.CheckButton();
			this.cbCleanTarget.CanFocus = true;
			this.cbCleanTarget.Name = "cbCleanTarget";
			this.cbCleanTarget.Label = global::Mono.Unix.Catalog.GetString("Clean target name:");
			this.cbCleanTarget.DrawIndicator = true;
			this.cbCleanTarget.UseUnderline = true;
			this.table1.Add(this.cbCleanTarget);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.cbCleanTarget]));
			w4.TopAttach = ((uint)(4));
			w4.BottomAttach = ((uint)(5));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.cbRunTarget = new global::Gtk.CheckButton();
			this.cbRunTarget.CanFocus = true;
			this.cbRunTarget.Name = "cbRunTarget";
			this.cbRunTarget.Label = global::Mono.Unix.Catalog.GetString("Execute target name:");
			this.cbRunTarget.DrawIndicator = true;
			this.cbRunTarget.UseUnderline = true;
			this.table1.Add(this.cbRunTarget);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.cbRunTarget]));
			w5.TopAttach = ((uint)(5));
			w5.BottomAttach = ((uint)(6));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.fileEntryMakefilePath = new global::MonoDevelop.Components.FileEntry();
			this.fileEntryMakefilePath.CanFocus = true;
			this.fileEntryMakefilePath.Name = "fileEntryMakefilePath";
			this.table1.Add(this.fileEntryMakefilePath);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.fileEntryMakefilePath]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboAssemblyName = global::Gtk.ComboBox.NewText();
			this.comboAssemblyName.WidthRequest = 300;
			this.comboAssemblyName.Name = "comboAssemblyName";
			this.hbox1.Add(this.comboAssemblyName);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.comboAssemblyName]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			this.table1.Add(this.hbox1);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox1]));
			w8.TopAttach = ((uint)(6));
			w8.BottomAttach = ((uint)(7));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboOutputDir = global::Gtk.ComboBox.NewText();
			this.comboOutputDir.WidthRequest = 300;
			this.comboOutputDir.Name = "comboOutputDir";
			this.hbox2.Add(this.comboOutputDir);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.comboOutputDir]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			this.table1.Add(this.hbox2);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox2]));
			w10.TopAttach = ((uint)(7));
			w10.BottomAttach = ((uint)(8));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			// Container child hbox3.Gtk.Box+BoxChild
			this.BuildTargetName = new global::Gtk.Entry();
			this.BuildTargetName.WidthRequest = 200;
			this.BuildTargetName.CanFocus = true;
			this.BuildTargetName.Name = "BuildTargetName";
			this.BuildTargetName.IsEditable = true;
			this.BuildTargetName.InvisibleChar = '●';
			this.hbox3.Add(this.BuildTargetName);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.BuildTargetName]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			this.table1.Add(this.hbox3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox3]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			// Container child hbox4.Gtk.Box+BoxChild
			this.ExecuteTargetName = new global::Gtk.Entry();
			this.ExecuteTargetName.WidthRequest = 200;
			this.ExecuteTargetName.CanFocus = true;
			this.ExecuteTargetName.Name = "ExecuteTargetName";
			this.ExecuteTargetName.IsEditable = true;
			this.ExecuteTargetName.InvisibleChar = '●';
			this.hbox4.Add(this.ExecuteTargetName);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.ExecuteTargetName]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			this.table1.Add(this.hbox4);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox4]));
			w14.TopAttach = ((uint)(5));
			w14.BottomAttach = ((uint)(6));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			// Container child hbox5.Gtk.Box+BoxChild
			this.CleanTargetName = new global::Gtk.Entry();
			this.CleanTargetName.WidthRequest = 200;
			this.CleanTargetName.CanFocus = true;
			this.CleanTargetName.Name = "CleanTargetName";
			this.CleanTargetName.IsEditable = true;
			this.CleanTargetName.InvisibleChar = '●';
			this.hbox5.Add(this.CleanTargetName);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.CleanTargetName]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			this.table1.Add(this.hbox5);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox5]));
			w16.TopAttach = ((uint)(4));
			w16.BottomAttach = ((uint)(5));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.headerSep2 = new global::Gtk.HSeparator();
			this.headerSep2.Name = "headerSep2";
			this.table1.Add(this.headerSep2);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.headerSep2]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.WidthRequest = 500;
			this.label8.Name = "label8";
			this.label8.Xalign = 0F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Select the makefile targets that should be executed for the build and clean opera" +
					"tions:");
			this.label8.Wrap = true;
			this.table1.Add(this.label8);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.label8]));
			w18.TopAttach = ((uint)(2));
			w18.BottomAttach = ((uint)(3));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Build processes:");
			this.table1.Add(this.label9);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.label9]));
			w19.TopAttach = ((uint)(8));
			w19.BottomAttach = ((uint)(9));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblAssemblyNameVar = new global::Gtk.Label();
			this.lblAssemblyNameVar.Name = "lblAssemblyNameVar";
			this.lblAssemblyNameVar.Xalign = 0F;
			this.lblAssemblyNameVar.LabelProp = global::Mono.Unix.Catalog.GetString("Assembly Name variable:");
			this.table1.Add(this.lblAssemblyNameVar);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.lblAssemblyNameVar]));
			w20.TopAttach = ((uint)(6));
			w20.BottomAttach = ((uint)(7));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblMakefileName = new global::Gtk.Label();
			this.lblMakefileName.Name = "lblMakefileName";
			this.lblMakefileName.Xalign = 0F;
			this.lblMakefileName.LabelProp = global::Mono.Unix.Catalog.GetString("Makefile path:");
			this.table1.Add(this.lblMakefileName);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.lblMakefileName]));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblOutputDirVar = new global::Gtk.Label();
			this.lblOutputDirVar.Name = "lblOutputDirVar";
			this.lblOutputDirVar.Xalign = 0F;
			this.lblOutputDirVar.LabelProp = global::Mono.Unix.Catalog.GetString("Output directory variable:");
			this.table1.Add(this.lblOutputDirVar);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.lblOutputDirVar]));
			w22.TopAttach = ((uint)(7));
			w22.BottomAttach = ((uint)(8));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinProcesses = new global::Gtk.SpinButton(1D, 64D, 1D);
			this.spinProcesses.CanFocus = true;
			this.spinProcesses.Name = "spinProcesses";
			this.spinProcesses.Adjustment.PageIncrement = 1D;
			this.spinProcesses.ClimbRate = 1D;
			this.spinProcesses.Numeric = true;
			this.spinProcesses.Value = 1D;
			this.table1.Add(this.spinProcesses);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.spinProcesses]));
			w23.TopAttach = ((uint)(8));
			w23.BottomAttach = ((uint)(9));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table1]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			this.notebook1.Add(this.vbox1);
			// Notebook tab
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Makefile");
			this.notebook1.SetTabLabel(this.vbox1, this.label1);
			this.label1.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.cbFileSync = new global::Gtk.CheckButton();
			this.cbFileSync.CanFocus = true;
			this.cbFileSync.Name = "cbFileSync";
			this.cbFileSync.Label = global::Mono.Unix.Catalog.GetString("Enable project file synchronization");
			this.cbFileSync.DrawIndicator = true;
			this.cbFileSync.UseUnderline = true;
			this.vbox2.Add(this.cbFileSync);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.cbFileSync]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.vbox2.Add(this.hseparator2);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator2]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table(((uint)(6)), ((uint)(3)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.cbKeepDeployFilesSync = new global::Gtk.CheckButton();
			this.cbKeepDeployFilesSync.CanFocus = true;
			this.cbKeepDeployFilesSync.Name = "cbKeepDeployFilesSync";
			this.cbKeepDeployFilesSync.Label = global::Mono.Unix.Catalog.GetString("Deployment files");
			this.cbKeepDeployFilesSync.DrawIndicator = true;
			this.table3.Add(this.cbKeepDeployFilesSync);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table3[this.cbKeepDeployFilesSync]));
			w28.TopAttach = ((uint)(4));
			w28.BottomAttach = ((uint)(5));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.cbKeepFilesSync = new global::Gtk.CheckButton();
			this.cbKeepFilesSync.CanFocus = true;
			this.cbKeepFilesSync.Name = "cbKeepFilesSync";
			this.cbKeepFilesSync.Label = global::Mono.Unix.Catalog.GetString("Source code files");
			this.cbKeepFilesSync.DrawIndicator = true;
			this.table3.Add(this.cbKeepFilesSync);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table3[this.cbKeepFilesSync]));
			w29.TopAttach = ((uint)(2));
			w29.BottomAttach = ((uint)(3));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.cbKeepOthersSync = new global::Gtk.CheckButton();
			this.cbKeepOthersSync.CanFocus = true;
			this.cbKeepOthersSync.Name = "cbKeepOthersSync";
			this.cbKeepOthersSync.Label = global::Mono.Unix.Catalog.GetString("Other Files");
			this.cbKeepOthersSync.DrawIndicator = true;
			this.table3.Add(this.cbKeepOthersSync);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table3[this.cbKeepOthersSync]));
			w30.TopAttach = ((uint)(5));
			w30.BottomAttach = ((uint)(6));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.cbKeepResourcesSync = new global::Gtk.CheckButton();
			this.cbKeepResourcesSync.CanFocus = true;
			this.cbKeepResourcesSync.Name = "cbKeepResourcesSync";
			this.cbKeepResourcesSync.Label = global::Mono.Unix.Catalog.GetString("Resources");
			this.cbKeepResourcesSync.DrawIndicator = true;
			this.table3.Add(this.cbKeepResourcesSync);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table3[this.cbKeepResourcesSync]));
			w31.TopAttach = ((uint)(3));
			w31.BottomAttach = ((uint)(4));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.comboDeployFilesVar = global::Gtk.ComboBox.NewText();
			this.comboDeployFilesVar.WidthRequest = 200;
			this.comboDeployFilesVar.Name = "comboDeployFilesVar";
			this.table3.Add(this.comboDeployFilesVar);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table3[this.comboDeployFilesVar]));
			w32.TopAttach = ((uint)(4));
			w32.BottomAttach = ((uint)(5));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.comboFilesVar = global::Gtk.ComboBox.NewText();
			this.comboFilesVar.WidthRequest = 200;
			this.comboFilesVar.Name = "comboFilesVar";
			this.table3.Add(this.comboFilesVar);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table3[this.comboFilesVar]));
			w33.TopAttach = ((uint)(2));
			w33.BottomAttach = ((uint)(3));
			w33.LeftAttach = ((uint)(1));
			w33.RightAttach = ((uint)(2));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.comboOthersVar = global::Gtk.ComboBox.NewText();
			this.comboOthersVar.WidthRequest = 200;
			this.comboOthersVar.Name = "comboOthersVar";
			this.table3.Add(this.comboOthersVar);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table3[this.comboOthersVar]));
			w34.TopAttach = ((uint)(5));
			w34.BottomAttach = ((uint)(6));
			w34.LeftAttach = ((uint)(1));
			w34.RightAttach = ((uint)(2));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.comboResourcesVar = global::Gtk.ComboBox.NewText();
			this.comboResourcesVar.WidthRequest = 200;
			this.comboResourcesVar.Name = "comboResourcesVar";
			this.table3.Add(this.comboResourcesVar);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table3[this.comboResourcesVar]));
			w35.TopAttach = ((uint)(3));
			w35.BottomAttach = ((uint)(4));
			w35.LeftAttach = ((uint)(1));
			w35.RightAttach = ((uint)(2));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.entryDeployFilesPattern = new global::Gtk.Entry();
			this.entryDeployFilesPattern.CanFocus = true;
			this.entryDeployFilesPattern.Name = "entryDeployFilesPattern";
			this.entryDeployFilesPattern.IsEditable = true;
			this.entryDeployFilesPattern.InvisibleChar = '●';
			this.table3.Add(this.entryDeployFilesPattern);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.table3[this.entryDeployFilesPattern]));
			w36.TopAttach = ((uint)(4));
			w36.BottomAttach = ((uint)(5));
			w36.LeftAttach = ((uint)(2));
			w36.RightAttach = ((uint)(3));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.entryFilesPattern = new global::Gtk.Entry();
			this.entryFilesPattern.CanFocus = true;
			this.entryFilesPattern.Name = "entryFilesPattern";
			this.entryFilesPattern.IsEditable = true;
			this.entryFilesPattern.InvisibleChar = '●';
			this.table3.Add(this.entryFilesPattern);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.table3[this.entryFilesPattern]));
			w37.TopAttach = ((uint)(2));
			w37.BottomAttach = ((uint)(3));
			w37.LeftAttach = ((uint)(2));
			w37.RightAttach = ((uint)(3));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.entryResourcesPattern = new global::Gtk.Entry();
			this.entryResourcesPattern.CanFocus = true;
			this.entryResourcesPattern.Name = "entryResourcesPattern";
			this.entryResourcesPattern.IsEditable = true;
			this.entryResourcesPattern.InvisibleChar = '●';
			this.table3.Add(this.entryResourcesPattern);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table3[this.entryResourcesPattern]));
			w38.TopAttach = ((uint)(3));
			w38.BottomAttach = ((uint)(4));
			w38.LeftAttach = ((uint)(2));
			w38.RightAttach = ((uint)(3));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.eventbox1 = new global::Gtk.EventBox();
			this.eventbox1.Name = "eventbox1";
			// Container child eventbox1.Gtk.Container+ContainerChild
			this.entryOthersPattern = new global::Gtk.Entry();
			this.entryOthersPattern.CanFocus = true;
			this.entryOthersPattern.Name = "entryOthersPattern";
			this.entryOthersPattern.IsEditable = true;
			this.entryOthersPattern.InvisibleChar = '●';
			this.eventbox1.Add(this.entryOthersPattern);
			this.table3.Add(this.eventbox1);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.table3[this.eventbox1]));
			w40.TopAttach = ((uint)(5));
			w40.BottomAttach = ((uint)(6));
			w40.LeftAttach = ((uint)(2));
			w40.RightAttach = ((uint)(3));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.WidthRequest = 500;
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Select the kind of files you want to synchronize with the makefile. For each file" +
					" kind please specify the makefile variable that holds the list and optionally a " +
					"prefix to be prepended to each file name.");
			this.label5.Wrap = true;
			this.table3.Add(this.label5);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table3[this.label5]));
			w41.RightAttach = ((uint)(3));
			w41.YPadding = ((uint)(9));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblCol2 = new global::Gtk.Label();
			this.lblCol2.Name = "lblCol2";
			this.lblCol2.Xalign = 0F;
			this.lblCol2.LabelProp = global::Mono.Unix.Catalog.GetString("Makefile variable name:");
			this.table3.Add(this.lblCol2);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.table3[this.lblCol2]));
			w42.TopAttach = ((uint)(1));
			w42.BottomAttach = ((uint)(2));
			w42.LeftAttach = ((uint)(1));
			w42.RightAttach = ((uint)(2));
			w42.XOptions = ((global::Gtk.AttachOptions)(4));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblCol3 = new global::Gtk.Label();
			this.lblCol3.Name = "lblCol3";
			this.lblCol3.Xalign = 0F;
			this.lblCol3.LabelProp = global::Mono.Unix.Catalog.GetString("Prefix:");
			this.table3.Add(this.lblCol3);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.table3[this.lblCol3]));
			w43.TopAttach = ((uint)(1));
			w43.BottomAttach = ((uint)(2));
			w43.LeftAttach = ((uint)(2));
			w43.RightAttach = ((uint)(3));
			w43.XOptions = ((global::Gtk.AttachOptions)(4));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add(this.table3);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table3]));
			w44.Position = 2;
			w44.Expand = false;
			w44.Fill = false;
			this.notebook1.Add(this.vbox2);
			global::Gtk.Notebook.NotebookChild w45 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox2]));
			w45.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Files");
			this.notebook1.SetTabLabel(this.vbox2, this.label2);
			this.label2.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			this.vbox4.BorderWidth = ((uint)(6));
			// Container child vbox4.Gtk.Box+BoxChild
			this.cbKeepRefSync = new global::Gtk.CheckButton();
			this.cbKeepRefSync.CanFocus = true;
			this.cbKeepRefSync.Name = "cbKeepRefSync";
			this.cbKeepRefSync.Label = global::Mono.Unix.Catalog.GetString("Enable references synchronization");
			this.cbKeepRefSync.DrawIndicator = true;
			this.vbox4.Add(this.cbKeepRefSync);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.cbKeepRefSync]));
			w46.Position = 0;
			w46.Expand = false;
			w46.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hseparator5 = new global::Gtk.HSeparator();
			this.hseparator5.Name = "hseparator5";
			this.vbox4.Add(this.hseparator5);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hseparator5]));
			w47.Position = 1;
			w47.Expand = false;
			w47.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.table4 = new global::Gtk.Table(((uint)(8)), ((uint)(3)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.cbAutotoolsProject = new global::Gtk.CheckButton();
			this.cbAutotoolsProject.CanFocus = true;
			this.cbAutotoolsProject.Name = "cbAutotoolsProject";
			this.cbAutotoolsProject.Label = global::Mono.Unix.Catalog.GetString("Look for packages in configure.in");
			this.cbAutotoolsProject.DrawIndicator = true;
			this.table4.Add(this.cbAutotoolsProject);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.table4[this.cbAutotoolsProject]));
			w48.TopAttach = ((uint)(6));
			w48.BottomAttach = ((uint)(7));
			w48.RightAttach = ((uint)(3));
			w48.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.comboAsmRefVar = global::Gtk.ComboBox.NewText();
			this.comboAsmRefVar.WidthRequest = 200;
			this.comboAsmRefVar.Name = "comboAsmRefVar";
			this.table4.Add(this.comboAsmRefVar);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.table4[this.comboAsmRefVar]));
			w49.TopAttach = ((uint)(3));
			w49.BottomAttach = ((uint)(4));
			w49.LeftAttach = ((uint)(1));
			w49.RightAttach = ((uint)(2));
			w49.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.comboPackageRefVar = global::Gtk.ComboBox.NewText();
			this.comboPackageRefVar.WidthRequest = 200;
			this.comboPackageRefVar.Name = "comboPackageRefVar";
			this.table4.Add(this.comboPackageRefVar);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.table4[this.comboPackageRefVar]));
			w50.TopAttach = ((uint)(2));
			w50.BottomAttach = ((uint)(3));
			w50.LeftAttach = ((uint)(1));
			w50.RightAttach = ((uint)(2));
			w50.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.comboProjectRefVar = global::Gtk.ComboBox.NewText();
			this.comboProjectRefVar.WidthRequest = 200;
			this.comboProjectRefVar.Name = "comboProjectRefVar";
			this.table4.Add(this.comboProjectRefVar);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.table4[this.comboProjectRefVar]));
			w51.TopAttach = ((uint)(4));
			w51.BottomAttach = ((uint)(5));
			w51.LeftAttach = ((uint)(1));
			w51.RightAttach = ((uint)(2));
			w51.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryAsmRefPattern = new global::Gtk.Entry();
			this.entryAsmRefPattern.CanFocus = true;
			this.entryAsmRefPattern.Name = "entryAsmRefPattern";
			this.entryAsmRefPattern.IsEditable = true;
			this.entryAsmRefPattern.InvisibleChar = '●';
			this.table4.Add(this.entryAsmRefPattern);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.table4[this.entryAsmRefPattern]));
			w52.TopAttach = ((uint)(3));
			w52.BottomAttach = ((uint)(4));
			w52.LeftAttach = ((uint)(2));
			w52.RightAttach = ((uint)(3));
			w52.XOptions = ((global::Gtk.AttachOptions)(4));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryPackageRefPattern = new global::Gtk.Entry();
			this.entryPackageRefPattern.CanFocus = true;
			this.entryPackageRefPattern.Name = "entryPackageRefPattern";
			this.entryPackageRefPattern.IsEditable = true;
			this.entryPackageRefPattern.InvisibleChar = '●';
			this.table4.Add(this.entryPackageRefPattern);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.table4[this.entryPackageRefPattern]));
			w53.TopAttach = ((uint)(2));
			w53.BottomAttach = ((uint)(3));
			w53.LeftAttach = ((uint)(2));
			w53.RightAttach = ((uint)(3));
			w53.XOptions = ((global::Gtk.AttachOptions)(4));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryProjectRefPattern = new global::Gtk.Entry();
			this.entryProjectRefPattern.CanFocus = true;
			this.entryProjectRefPattern.Name = "entryProjectRefPattern";
			this.entryProjectRefPattern.IsEditable = true;
			this.entryProjectRefPattern.InvisibleChar = '●';
			this.table4.Add(this.entryProjectRefPattern);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.table4[this.entryProjectRefPattern]));
			w54.TopAttach = ((uint)(4));
			w54.BottomAttach = ((uint)(5));
			w54.LeftAttach = ((uint)(2));
			w54.RightAttach = ((uint)(3));
			w54.XOptions = ((global::Gtk.AttachOptions)(4));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.fileEntryConfigureInPath = new global::MonoDevelop.Components.FolderEntry();
			this.fileEntryConfigureInPath.Name = "fileEntryConfigureInPath";
			this.table4.Add(this.fileEntryConfigureInPath);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.table4[this.fileEntryConfigureInPath]));
			w55.TopAttach = ((uint)(7));
			w55.BottomAttach = ((uint)(8));
			w55.LeftAttach = ((uint)(1));
			w55.RightAttach = ((uint)(3));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.table4.Add(this.hseparator1);
			global::Gtk.Table.TableChild w56 = ((global::Gtk.Table.TableChild)(this.table4[this.hseparator1]));
			w56.TopAttach = ((uint)(5));
			w56.BottomAttach = ((uint)(6));
			w56.RightAttach = ((uint)(3));
			w56.XOptions = ((global::Gtk.AttachOptions)(4));
			w56.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.WidthRequest = 500;
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString(@"Select the kind of references you want to synchronize with the makefile. For each reference type please specify the makefile variable that holds the list, and optionally a prefix to be prepended to each reference name. You can specify the same variable name for several types of references.");
			this.label6.Wrap = true;
			this.table4.Add(this.label6);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.table4[this.label6]));
			w57.RightAttach = ((uint)(3));
			w57.YPadding = ((uint)(9));
			w57.XOptions = ((global::Gtk.AttachOptions)(4));
			w57.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.lblAsmRef = new global::Gtk.Label();
			this.lblAsmRef.Name = "lblAsmRef";
			this.lblAsmRef.Xalign = 0F;
			this.lblAsmRef.LabelProp = global::Mono.Unix.Catalog.GetString("Assembly References");
			this.table4.Add(this.lblAsmRef);
			global::Gtk.Table.TableChild w58 = ((global::Gtk.Table.TableChild)(this.table4[this.lblAsmRef]));
			w58.TopAttach = ((uint)(3));
			w58.BottomAttach = ((uint)(4));
			w58.XOptions = ((global::Gtk.AttachOptions)(4));
			w58.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.lblCol5 = new global::Gtk.Label();
			this.lblCol5.Name = "lblCol5";
			this.lblCol5.Xalign = 0F;
			this.lblCol5.LabelProp = global::Mono.Unix.Catalog.GetString("Makefile variable name:");
			this.table4.Add(this.lblCol5);
			global::Gtk.Table.TableChild w59 = ((global::Gtk.Table.TableChild)(this.table4[this.lblCol5]));
			w59.TopAttach = ((uint)(1));
			w59.BottomAttach = ((uint)(2));
			w59.LeftAttach = ((uint)(1));
			w59.RightAttach = ((uint)(2));
			w59.XOptions = ((global::Gtk.AttachOptions)(4));
			w59.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.lblCol6 = new global::Gtk.Label();
			this.lblCol6.Name = "lblCol6";
			this.lblCol6.Xalign = 0F;
			this.lblCol6.LabelProp = global::Mono.Unix.Catalog.GetString("Prefix:");
			this.table4.Add(this.lblCol6);
			global::Gtk.Table.TableChild w60 = ((global::Gtk.Table.TableChild)(this.table4[this.lblCol6]));
			w60.TopAttach = ((uint)(1));
			w60.BottomAttach = ((uint)(2));
			w60.LeftAttach = ((uint)(2));
			w60.RightAttach = ((uint)(3));
			w60.XOptions = ((global::Gtk.AttachOptions)(4));
			w60.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.lblConfigureInPath = new global::Gtk.Label();
			this.lblConfigureInPath.Name = "lblConfigureInPath";
			this.lblConfigureInPath.Xalign = 0F;
			this.lblConfigureInPath.LabelProp = global::Mono.Unix.Catalog.GetString("Path for configure.in");
			this.table4.Add(this.lblConfigureInPath);
			global::Gtk.Table.TableChild w61 = ((global::Gtk.Table.TableChild)(this.table4[this.lblConfigureInPath]));
			w61.TopAttach = ((uint)(7));
			w61.BottomAttach = ((uint)(8));
			w61.XOptions = ((global::Gtk.AttachOptions)(4));
			w61.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.lblPackageRef = new global::Gtk.Label();
			this.lblPackageRef.Name = "lblPackageRef";
			this.lblPackageRef.Xalign = 0F;
			this.lblPackageRef.LabelProp = global::Mono.Unix.Catalog.GetString("Package References");
			this.table4.Add(this.lblPackageRef);
			global::Gtk.Table.TableChild w62 = ((global::Gtk.Table.TableChild)(this.table4[this.lblPackageRef]));
			w62.TopAttach = ((uint)(2));
			w62.BottomAttach = ((uint)(3));
			w62.XOptions = ((global::Gtk.AttachOptions)(4));
			w62.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.lblProjectRef = new global::Gtk.Label();
			this.lblProjectRef.Name = "lblProjectRef";
			this.lblProjectRef.Xalign = 0F;
			this.lblProjectRef.LabelProp = global::Mono.Unix.Catalog.GetString("Project References");
			this.table4.Add(this.lblProjectRef);
			global::Gtk.Table.TableChild w63 = ((global::Gtk.Table.TableChild)(this.table4[this.lblProjectRef]));
			w63.TopAttach = ((uint)(4));
			w63.BottomAttach = ((uint)(5));
			w63.XOptions = ((global::Gtk.AttachOptions)(4));
			w63.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add(this.table4);
			global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.table4]));
			w64.Position = 2;
			w64.Expand = false;
			w64.Fill = false;
			this.notebook1.Add(this.vbox4);
			global::Gtk.Notebook.NotebookChild w65 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox4]));
			w65.Position = 2;
			// Notebook tab
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("References");
			this.notebook1.SetTabLabel(this.vbox4, this.label3);
			this.label3.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.BorderWidth = ((uint)(6));
			// Container child vbox3.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.WidthRequest = 500;
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString(@"Select the Compiler message format for parsing the compiler errors and warnings. You can either select one of the built-in options, or specify custom regular expressions for errors and warnings. The regex must be the .net style regex. The following named groups are relevant : file, line, column, number (error number) and message.");
			this.label7.Wrap = true;
			this.label7.Justify = ((global::Gtk.Justification)(3));
			this.vbox3.Add(this.label7);
			global::Gtk.Box.BoxChild w66 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.label7]));
			w66.Position = 0;
			w66.Expand = false;
			w66.Fill = false;
			w66.Padding = ((uint)(6));
			// Container child vbox3.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.entryErrorRegex = new global::Gtk.Entry();
			this.entryErrorRegex.WidthRequest = 350;
			this.entryErrorRegex.CanFocus = true;
			this.entryErrorRegex.Name = "entryErrorRegex";
			this.entryErrorRegex.IsEditable = true;
			this.entryErrorRegex.InvisibleChar = '●';
			this.table2.Add(this.entryErrorRegex);
			global::Gtk.Table.TableChild w67 = ((global::Gtk.Table.TableChild)(this.table2[this.entryErrorRegex]));
			w67.TopAttach = ((uint)(1));
			w67.BottomAttach = ((uint)(2));
			w67.LeftAttach = ((uint)(1));
			w67.RightAttach = ((uint)(3));
			w67.XOptions = ((global::Gtk.AttachOptions)(4));
			w67.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryWarningRegex = new global::Gtk.Entry();
			this.entryWarningRegex.WidthRequest = 350;
			this.entryWarningRegex.CanFocus = true;
			this.entryWarningRegex.Name = "entryWarningRegex";
			this.entryWarningRegex.IsEditable = true;
			this.entryWarningRegex.InvisibleChar = '●';
			this.table2.Add(this.entryWarningRegex);
			global::Gtk.Table.TableChild w68 = ((global::Gtk.Table.TableChild)(this.table2[this.entryWarningRegex]));
			w68.TopAttach = ((uint)(2));
			w68.BottomAttach = ((uint)(3));
			w68.LeftAttach = ((uint)(1));
			w68.RightAttach = ((uint)(3));
			w68.XOptions = ((global::Gtk.AttachOptions)(4));
			w68.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			// Container child hbox6.Gtk.Box+BoxChild
			this.comboMessageType = global::Gtk.ComboBox.NewText();
			this.comboMessageType.WidthRequest = 150;
			this.comboMessageType.Name = "comboMessageType";
			this.hbox6.Add(this.comboMessageType);
			global::Gtk.Box.BoxChild w69 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.comboMessageType]));
			w69.Position = 0;
			w69.Expand = false;
			w69.Fill = false;
			this.table2.Add(this.hbox6);
			global::Gtk.Table.TableChild w70 = ((global::Gtk.Table.TableChild)(this.table2[this.hbox6]));
			w70.LeftAttach = ((uint)(1));
			w70.RightAttach = ((uint)(2));
			w70.XOptions = ((global::Gtk.AttachOptions)(4));
			w70.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.lblErrorRegex = new global::Gtk.Label();
			this.lblErrorRegex.Name = "lblErrorRegex";
			this.lblErrorRegex.Xalign = 0F;
			this.lblErrorRegex.LabelProp = global::Mono.Unix.Catalog.GetString("Error regex :");
			this.table2.Add(this.lblErrorRegex);
			global::Gtk.Table.TableChild w71 = ((global::Gtk.Table.TableChild)(this.table2[this.lblErrorRegex]));
			w71.TopAttach = ((uint)(1));
			w71.BottomAttach = ((uint)(2));
			w71.XOptions = ((global::Gtk.AttachOptions)(4));
			w71.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.lblMessageType = new global::Gtk.Label();
			this.lblMessageType.Name = "lblMessageType";
			this.lblMessageType.Xalign = 0F;
			this.lblMessageType.LabelProp = global::Mono.Unix.Catalog.GetString("Compiler :");
			this.table2.Add(this.lblMessageType);
			global::Gtk.Table.TableChild w72 = ((global::Gtk.Table.TableChild)(this.table2[this.lblMessageType]));
			w72.XOptions = ((global::Gtk.AttachOptions)(4));
			w72.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.lblWarningRegex = new global::Gtk.Label();
			this.lblWarningRegex.Name = "lblWarningRegex";
			this.lblWarningRegex.Xalign = 0F;
			this.lblWarningRegex.LabelProp = global::Mono.Unix.Catalog.GetString("Warnings regex :");
			this.table2.Add(this.lblWarningRegex);
			global::Gtk.Table.TableChild w73 = ((global::Gtk.Table.TableChild)(this.table2[this.lblWarningRegex]));
			w73.TopAttach = ((uint)(2));
			w73.BottomAttach = ((uint)(3));
			w73.XOptions = ((global::Gtk.AttachOptions)(4));
			w73.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add(this.table2);
			global::Gtk.Box.BoxChild w74 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.table2]));
			w74.Position = 1;
			this.notebook1.Add(this.vbox3);
			global::Gtk.Notebook.NotebookChild w75 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox3]));
			w75.Position = 3;
			// Notebook tab
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Messages Regex");
			this.notebook1.SetTabLabel(this.vbox3, this.label4);
			this.label4.ShowAll();
			this.Add(this.notebook1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.comboAssemblyName.Hide();
			this.comboOutputDir.Hide();
			this.lblAssemblyNameVar.Hide();
			this.lblOutputDirVar.Hide();
			this.Show();
			this.cbEnableMakefileIntegration.Clicked += new global::System.EventHandler(this.OnEnableMakefileIntegrationClicked);
			this.fileEntryMakefilePath.FocusOutEvent += new global::Gtk.FocusOutEventHandler(this.OnFileEntryMakefilePathFocusOutEvent);
			this.cbRunTarget.Clicked += new global::System.EventHandler(this.OnCbRunTargetClicked);
			this.cbCleanTarget.Clicked += new global::System.EventHandler(this.OnCbCleanTargetClicked);
			this.cbBuildTarget.Clicked += new global::System.EventHandler(this.OnCbBuildTargetClicked);
			this.cbFileSync.Clicked += new global::System.EventHandler(this.OnCbFileSyncClicked);
			this.comboResourcesVar.Changed += new global::System.EventHandler(this.OnComboResourcesVarChanged);
			this.cbKeepResourcesSync.Clicked += new global::System.EventHandler(this.OnCbKeepResourcesSyncClicked);
			this.cbKeepOthersSync.Clicked += new global::System.EventHandler(this.OnCbKeepOthersSyncClicked);
			this.cbKeepFilesSync.Clicked += new global::System.EventHandler(this.OnCbKeepFilesSyncClicked);
			this.cbKeepDeployFilesSync.Clicked += new global::System.EventHandler(this.OnCbKeepDeployFilesSyncClicked);
			this.cbKeepRefSync.Clicked += new global::System.EventHandler(this.OnCbKeepRefSyncClicked);
			this.comboProjectRefVar.Changed += new global::System.EventHandler(this.OnComboProjectRefVarChanged);
			this.comboPackageRefVar.Changed += new global::System.EventHandler(this.OnComboPackageRefVarChanged);
			this.comboAsmRefVar.Changed += new global::System.EventHandler(this.OnComboAsmRefVarChanged);
			this.cbAutotoolsProject.Clicked += new global::System.EventHandler(this.OnCbAutotoolsProjectClicked);
			this.comboMessageType.Changed += new global::System.EventHandler(this.OnComboMessageTypeChanged);
		}
	}
}
#pragma warning restore 436
