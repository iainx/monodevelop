#pragma warning disable 436

namespace MonoDevelop.Ide.Gui.OptionPanels
{
	internal partial class TextStylePolicyPanelWidget
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::Gtk.SpinButton columnWidthSpin;

		private global::Gtk.Label label5;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label6;

		private global::Gtk.ComboBox lineEndingCombo;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.Label label3;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Table table1;

		private global::Gtk.SpinButton indentWidthSpin;

		private global::Gtk.Label label7;

		private global::Gtk.Label label9;

		private global::Gtk.SpinButton tabWidthSpin;

		private global::Gtk.CheckButton tabsToSpaceCheck;

		private global::Gtk.CheckButton tabsAfterNonTabsCheck;

		private global::Gtk.CheckButton removeTrailingWhitespaceCheck;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Ide.Gui.OptionPanels.TextStylePolicyPanelWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "MonoDevelop.Ide.Gui.OptionPanels.TextStylePolicyPanelWidget";
			// Container child MonoDevelop.Ide.Gui.OptionPanels.TextStylePolicyPanelWidget.Gtk.Container+ContainerChild
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
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Desired _file width:");
			this.label1.UseUnderline = true;
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.columnWidthSpin = new global::Gtk.SpinButton(0D, 1000D, 1D);
			this.columnWidthSpin.CanFocus = true;
			this.columnWidthSpin.Name = "columnWidthSpin";
			this.columnWidthSpin.Adjustment.PageIncrement = 10D;
			this.columnWidthSpin.ClimbRate = 1D;
			this.columnWidthSpin.Numeric = true;
			this.columnWidthSpin.Value = 120D;
			this.hbox1.Add(this.columnWidthSpin);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.columnWidthSpin]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("columns");
			this.hbox1.Add(this.label5);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label5]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("_Line endings:");
			this.label6.UseUnderline = true;
			this.hbox2.Add(this.label6);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label6]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.lineEndingCombo = global::Gtk.ComboBox.NewText();
			this.lineEndingCombo.Name = "lineEndingCombo";
			this.hbox2.Add(this.lineEndingCombo);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.lineEndingCombo]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment2.TopPadding = ((uint)(6));
			// Container child alignment2.Gtk.Container+ContainerChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Whitespace</b>");
			this.label3.UseMarkup = true;
			this.alignment2.Add(this.label3);
			this.vbox1.Add(this.alignment2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.alignment2]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(12));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.indentWidthSpin = new global::Gtk.SpinButton(1D, 50D, 1D);
			this.indentWidthSpin.CanFocus = true;
			this.indentWidthSpin.Name = "indentWidthSpin";
			this.indentWidthSpin.Adjustment.PageIncrement = 2D;
			this.indentWidthSpin.ClimbRate = 1D;
			this.indentWidthSpin.Numeric = true;
			this.indentWidthSpin.Value = 4D;
			this.table1.Add(this.indentWidthSpin);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.indentWidthSpin]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("_Tab width:");
			this.label7.UseUnderline = true;
			this.table1.Add(this.label7);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.label7]));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("_Indent width:");
			this.label9.UseUnderline = true;
			this.table1.Add(this.label9);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.label9]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.tabWidthSpin = new global::Gtk.SpinButton(1D, 50D, 1D);
			this.tabWidthSpin.CanFocus = true;
			this.tabWidthSpin.Name = "tabWidthSpin";
			this.tabWidthSpin.Adjustment.PageIncrement = 2D;
			this.tabWidthSpin.ClimbRate = 1D;
			this.tabWidthSpin.Numeric = true;
			this.tabWidthSpin.Value = 4D;
			this.table1.Add(this.tabWidthSpin);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.tabWidthSpin]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add(this.table1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.table1]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.tabsToSpaceCheck = new global::Gtk.CheckButton();
			this.tabsToSpaceCheck.CanFocus = true;
			this.tabsToSpaceCheck.Name = "tabsToSpaceCheck";
			this.tabsToSpaceCheck.Label = global::Mono.Unix.Catalog.GetString("_Convert tabs to spaces");
			this.tabsToSpaceCheck.DrawIndicator = true;
			this.tabsToSpaceCheck.UseUnderline = true;
			this.vbox2.Add(this.tabsToSpaceCheck);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.tabsToSpaceCheck]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.tabsAfterNonTabsCheck = new global::Gtk.CheckButton();
			this.tabsAfterNonTabsCheck.CanFocus = true;
			this.tabsAfterNonTabsCheck.Name = "tabsAfterNonTabsCheck";
			this.tabsAfterNonTabsCheck.Label = global::Mono.Unix.Catalog.GetString("_Allow tabs after non-tabs");
			this.tabsAfterNonTabsCheck.DrawIndicator = true;
			this.tabsAfterNonTabsCheck.UseUnderline = true;
			this.vbox2.Add(this.tabsAfterNonTabsCheck);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.tabsAfterNonTabsCheck]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.removeTrailingWhitespaceCheck = new global::Gtk.CheckButton();
			this.removeTrailingWhitespaceCheck.CanFocus = true;
			this.removeTrailingWhitespaceCheck.Name = "removeTrailingWhitespaceCheck";
			this.removeTrailingWhitespaceCheck.Label = global::Mono.Unix.Catalog.GetString("_Remove trailing whitespace");
			this.removeTrailingWhitespaceCheck.DrawIndicator = true;
			this.removeTrailingWhitespaceCheck.UseUnderline = true;
			this.vbox2.Add(this.removeTrailingWhitespaceCheck);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.removeTrailingWhitespaceCheck]));
			w17.Position = 3;
			w17.Expand = false;
			w17.Fill = false;
			this.alignment1.Add(this.vbox2);
			this.vbox1.Add(this.alignment1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.alignment1]));
			w19.Position = 3;
			w19.Expand = false;
			w19.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.label7.MnemonicWidget = this.tabWidthSpin;
			this.label9.MnemonicWidget = this.tabWidthSpin;
			this.Hide();
			this.columnWidthSpin.ValueChanged += new global::System.EventHandler(this.UpdateState);
			this.lineEndingCombo.Changed += new global::System.EventHandler(this.UpdateState);
			this.tabWidthSpin.ValueChanged += new global::System.EventHandler(this.UpdateState);
			this.indentWidthSpin.ValueChanged += new global::System.EventHandler(this.UpdateState);
			this.tabsToSpaceCheck.Toggled += new global::System.EventHandler(this.UpdateState);
			this.tabsAfterNonTabsCheck.Toggled += new global::System.EventHandler(this.UpdateState);
			this.removeTrailingWhitespaceCheck.Toggled += new global::System.EventHandler(this.UpdateState);
		}
	}
}
#pragma warning restore 436
