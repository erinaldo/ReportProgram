namespace Report_Pro.MyControls
{
    partial class Jor_Row
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDebit = new DevComponents.Editors.DoubleInput();
            this.ser_ = new DevComponents.DotNetBar.LabelX();
            this.txtAccDesc = new DevComponents.DotNetBar.LabelX();
            this.txtCostDesc = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtBalance = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtCatDesc = new DevComponents.DotNetBar.LabelX();
            this.txtDocDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.button1 = new System.Windows.Forms.Button();
            this.branchID = new System.Windows.Forms.TextBox();
            this.txtAccNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCatID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCostID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDocument = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCredit = new DevComponents.Editors.DoubleInput();
            this.txtAcc_2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtVatNo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDebit
            // 
            // 
            // 
            // 
            this.txtDebit.BackgroundStyle.Class = "TextBoxBorder";
            this.txtDebit.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtDebit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDebit.Increment = 1D;
            this.txtDebit.Location = new System.Drawing.Point(1139, 5);
            this.txtDebit.Margin = new System.Windows.Forms.Padding(0);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(87, 20);
            this.txtDebit.TabIndex = 5;
            this.txtDebit.ValueChanged += new System.EventHandler(this.txtDebit_ValueChanged);
            this.txtDebit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDebit_KeyDown);
            this.txtDebit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDebit_KeyUp);
            this.txtDebit.Leave += new System.EventHandler(this.txtDebit_Leave);
            // 
            // ser_
            // 
            this.ser_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ser_.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ser_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ser_.Location = new System.Drawing.Point(1228, 1);
            this.ser_.Margin = new System.Windows.Forms.Padding(0);
            this.ser_.Name = "ser_";
            this.ser_.Size = new System.Drawing.Size(37, 51);
            this.ser_.TabIndex = 6;
            this.ser_.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtAccDesc
            // 
            this.txtAccDesc.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtAccDesc.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccDesc.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtAccDesc.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccDesc.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccDesc.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccDesc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAccDesc.Location = new System.Drawing.Point(597, 30);
            this.txtAccDesc.Margin = new System.Windows.Forms.Padding(0);
            this.txtAccDesc.Name = "txtAccDesc";
            this.txtAccDesc.Size = new System.Drawing.Size(457, 20);
            this.txtAccDesc.TabIndex = 7;
            this.txtAccDesc.Click += new System.EventHandler(this.txtAccDesc_Click);
            // 
            // txtCostDesc
            // 
            this.txtCostDesc.BackColor = System.Drawing.Color.LightCyan;
            // 
            // 
            // 
            this.txtCostDesc.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCostDesc.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtCostDesc.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCostDesc.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCostDesc.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCostDesc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCostDesc.Location = new System.Drawing.Point(315, 30);
            this.txtCostDesc.Margin = new System.Windows.Forms.Padding(0);
            this.txtCostDesc.Name = "txtCostDesc";
            this.txtCostDesc.Size = new System.Drawing.Size(202, 20);
            this.txtCostDesc.TabIndex = 8;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX3.Location = new System.Drawing.Point(649, 32);
            this.labelX3.Margin = new System.Windows.Forms.Padding(0);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(63, 17);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "رقم المستند";
            this.labelX3.Visible = false;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.LightCyan;
            // 
            // 
            // 
            this.txtBalance.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBalance.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtBalance.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBalance.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBalance.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBalance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBalance.Location = new System.Drawing.Point(1060, 30);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(0);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(114, 20);
            this.txtBalance.TabIndex = 11;
            this.txtBalance.Click += new System.EventHandler(this.txtBalance_Click);
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelX5.Location = new System.Drawing.Point(722, 32);
            this.labelX5.Margin = new System.Windows.Forms.Padding(0);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(68, 17);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "تاريخ المستند";
            this.labelX5.Visible = false;
            // 
            // txtCatDesc
            // 
            this.txtCatDesc.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtCatDesc.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCatDesc.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtCatDesc.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCatDesc.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCatDesc.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCatDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCatDesc.Location = new System.Drawing.Point(315, 5);
            this.txtCatDesc.Margin = new System.Windows.Forms.Padding(0);
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.Size = new System.Drawing.Size(202, 20);
            this.txtCatDesc.TabIndex = 15;
            // 
            // txtDocDate
            // 
            // 
            // 
            // 
            this.txtDocDate.BackgroundStyle.Class = "TextBoxBorder";
            this.txtDocDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtDocDate.ButtonDropDown.Visible = true;
            this.txtDocDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDocDate.Location = new System.Drawing.Point(118, 5);
            this.txtDocDate.Margin = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtDocDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtDocDate.MonthCalendar.DisplayMonth = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.txtDocDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtDocDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtDocDate.MonthCalendar.TodayButtonVisible = true;
            this.txtDocDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtDocDate.Name = "txtDocDate";
            this.txtDocDate.Size = new System.Drawing.Size(95, 20);
            this.txtDocDate.TabIndex = 18;
            this.txtDocDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocDate_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.BackgroundImage = global::Report_Pro.Properties.Resources.Cross_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(1266, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 45);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // branchID
            // 
            this.branchID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.branchID.Location = new System.Drawing.Point(1177, 30);
            this.branchID.Margin = new System.Windows.Forms.Padding(2);
            this.branchID.Name = "branchID";
            this.branchID.Size = new System.Drawing.Size(50, 20);
            this.branchID.TabIndex = 19;
            // 
            // txtAccNo
            // 
            // 
            // 
            // 
            this.txtAccNo.Border.Class = "TextBoxBorder";
            this.txtAccNo.Location = new System.Drawing.Point(946, 5);
            this.txtAccNo.Margin = new System.Windows.Forms.Padding(0);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(106, 20);
            this.txtAccNo.TabIndex = 25;
            this.txtAccNo.TextChanged += new System.EventHandler(this.txtAccNo_TextChanged);
            this.txtAccNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccNo_KeyDown);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.Border.Class = "TextBoxBorder";
            this.txtDescription.Location = new System.Drawing.Point(594, 5);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(352, 20);
            this.txtDescription.TabIndex = 26;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // txtCatID
            // 
            this.txtCatID.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtCatID.Border.Class = "TextBoxBorder";
            this.txtCatID.Location = new System.Drawing.Point(519, 5);
            this.txtCatID.Margin = new System.Windows.Forms.Padding(0);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(72, 20);
            this.txtCatID.TabIndex = 27;
            this.txtCatID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCatID_KeyDown);
            // 
            // txtCostID
            // 
            this.txtCostID.BackColor = System.Drawing.Color.LightCyan;
            // 
            // 
            // 
            this.txtCostID.Border.Class = "TextBoxBorder";
            this.txtCostID.Location = new System.Drawing.Point(519, 30);
            this.txtCostID.Margin = new System.Windows.Forms.Padding(0);
            this.txtCostID.Name = "txtCostID";
            this.txtCostID.Size = new System.Drawing.Size(72, 20);
            this.txtCostID.TabIndex = 28;
            this.txtCostID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCostID_KeyDown);
            // 
            // txtDocument
            // 
            // 
            // 
            // 
            this.txtDocument.Border.Class = "TextBoxBorder";
            this.txtDocument.Location = new System.Drawing.Point(214, 5);
            this.txtDocument.Margin = new System.Windows.Forms.Padding(0);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(97, 20);
            this.txtDocument.TabIndex = 29;
            this.txtDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocument_KeyDown);
            // 
            // txtCredit
            // 
            // 
            // 
            // 
            this.txtCredit.BackgroundStyle.Class = "TextBoxBorder";
            this.txtCredit.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCredit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCredit.Increment = 1D;
            this.txtCredit.Location = new System.Drawing.Point(1052, 5);
            this.txtCredit.Margin = new System.Windows.Forms.Padding(0);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(87, 20);
            this.txtCredit.TabIndex = 30;
            this.txtCredit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCredit_KeyDown);
            this.txtCredit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCredit_KeyUp);
            this.txtCredit.Leave += new System.EventHandler(this.txtCredit_Leave);
            // 
            // txtAcc_2
            // 
            // 
            // 
            // 
            this.txtAcc_2.Border.Class = "TextBoxBorder";
            this.txtAcc_2.Location = new System.Drawing.Point(4, 30);
            this.txtAcc_2.Margin = new System.Windows.Forms.Padding(0);
            this.txtAcc_2.Name = "txtAcc_2";
            this.txtAcc_2.Size = new System.Drawing.Size(307, 20);
            this.txtAcc_2.TabIndex = 31;
            this.txtAcc_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcc_2_KeyDown);
            // 
            // txtVatNo
            // 
            this.txtVatNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVatNo.Location = new System.Drawing.Point(4, 5);
            this.txtVatNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtVatNo.Mask = "00000-00000-00000";
            this.txtVatNo.Name = "txtVatNo";
            this.txtVatNo.Size = new System.Drawing.Size(113, 20);
            this.txtVatNo.TabIndex = 146;
            this.txtVatNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVatNo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtVatNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVatNo_KeyDown);
            // 
            // Jor_Row
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtVatNo);
            this.Controls.Add(this.txtAcc_2);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.txtCostID);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.branchID);
            this.Controls.Add(this.txtDocDate);
            this.Controls.Add(this.txtCatDesc);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtCostDesc);
            this.Controls.Add(this.txtAccDesc);
            this.Controls.Add(this.ser_);
            this.Controls.Add(this.txtDebit);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Jor_Row";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(1294, 53);
            this.Load += new System.EventHandler(this.Jor_Row_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDebit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public DevComponents.Editors.DoubleInput txtDebit;
        private DevComponents.DotNetBar.LabelX txtAccDesc;
        private DevComponents.DotNetBar.LabelX txtCostDesc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX txtBalance;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX txtCatDesc;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtDocDate;
        public DevComponents.DotNetBar.LabelX ser_;
        public System.Windows.Forms.TextBox branchID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccNo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescription;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCatID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCostID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDocument;
        public DevComponents.Editors.DoubleInput txtCredit;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAcc_2;
        private System.Windows.Forms.MaskedTextBox txtVatNo;
    }
}
