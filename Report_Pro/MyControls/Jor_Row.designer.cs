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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jor_Row));
            this.ser_ = new DevComponents.DotNetBar.LabelX();
            this.txtDocDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.branchID = new System.Windows.Forms.TextBox();
            this.txtBalance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Acc_ = new Report_Pro.MyControls.Jor_Acc();
            this.txtVatNo = new Report_Pro.MyControls.myText();
            this.txtDocument = new Report_Pro.MyControls.myText();
            this.txtCost = new Report_Pro.MyControls.Jor_Cost();
            this.txtCat = new Report_Pro.MyControls.Jor_Cat();
            this.txtAcc_2 = new Report_Pro.MyControls.myText();
            this.txtDescription = new Report_Pro.MyControls.myText();
            this.txtCr = new Report_Pro.MyControls.mDouble();
            this.txtDb = new Report_Pro.MyControls.mDouble();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ser_
            // 
            resources.ApplyResources(this.ser_, "ser_");
            this.ser_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ser_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ser_.Name = "ser_";
            this.ser_.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ser_.TextChanged += new System.EventHandler(this.ser__TextChanged);
            this.ser_.Click += new System.EventHandler(this.ser__Click);
            // 
            // txtDocDate
            // 
            resources.ApplyResources(this.txtDocDate, "txtDocDate");
            // 
            // 
            // 
            this.txtDocDate.BackgroundStyle.Class = "TextBoxBorder";
            this.txtDocDate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("txtDocDate.ButtonClear.DisplayPosition")));
            this.txtDocDate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("txtDocDate.ButtonClear.Image")));
            this.txtDocDate.ButtonClear.Text = resources.GetString("txtDocDate.ButtonClear.Text");
            this.txtDocDate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtDocDate.ButtonCustom.DisplayPosition")));
            this.txtDocDate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtDocDate.ButtonCustom.Image")));
            this.txtDocDate.ButtonCustom.Text = resources.GetString("txtDocDate.ButtonCustom.Text");
            this.txtDocDate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtDocDate.ButtonCustom2.DisplayPosition")));
            this.txtDocDate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtDocDate.ButtonCustom2.Image")));
            this.txtDocDate.ButtonCustom2.Text = resources.GetString("txtDocDate.ButtonCustom2.Text");
            this.txtDocDate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("txtDocDate.ButtonDropDown.DisplayPosition")));
            this.txtDocDate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("txtDocDate.ButtonDropDown.Image")));
            this.txtDocDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtDocDate.ButtonDropDown.Text = resources.GetString("txtDocDate.ButtonDropDown.Text");
            this.txtDocDate.ButtonDropDown.Visible = true;
            this.txtDocDate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("txtDocDate.ButtonFreeText.DisplayPosition")));
            this.txtDocDate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("txtDocDate.ButtonFreeText.Image")));
            this.txtDocDate.ButtonFreeText.Text = resources.GetString("txtDocDate.ButtonFreeText.Text");
            this.txtDocDate.ForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("txtDocDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtDocDate.MonthCalendar.Category = resources.GetString("txtDocDate.MonthCalendar.Category");
            this.txtDocDate.MonthCalendar.ClearButtonVisible = true;
            this.txtDocDate.MonthCalendar.CommandParameter = ((object)(resources.GetObject("txtDocDate.MonthCalendar.CommandParameter")));
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtDocDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtDocDate.MonthCalendar.DayNames = ((string[])(resources.GetObject("txtDocDate.MonthCalendar.DayNames")));
            this.txtDocDate.MonthCalendar.Description = resources.GetString("txtDocDate.MonthCalendar.Description");
            this.txtDocDate.MonthCalendar.DisplayMonth = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.txtDocDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("txtDocDate.MonthCalendar.MarkedDates")));
            this.txtDocDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("txtDocDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtDocDate.MonthCalendar.Tag = resources.GetString("txtDocDate.MonthCalendar.Tag");
            this.txtDocDate.MonthCalendar.Text = resources.GetString("txtDocDate.MonthCalendar.Text");
            this.txtDocDate.MonthCalendar.TodayButtonVisible = true;
            this.txtDocDate.MonthCalendar.Tooltip = resources.GetString("txtDocDate.MonthCalendar.Tooltip");
            this.txtDocDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("txtDocDate.MonthCalendar.WeeklyMarkedDays")));
            this.txtDocDate.Name = "txtDocDate";
            this.txtDocDate.Click += new System.EventHandler(this.txtDocDate_Click);
            this.txtDocDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocDate_KeyDown);
            // 
            // branchID
            // 
            resources.ApplyResources(this.branchID, "branchID");
            this.branchID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.branchID.Name = "branchID";
            // 
            // txtBalance
            // 
            resources.ApplyResources(this.txtBalance, "txtBalance");
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtBalance.Border.Class = "TextBoxBorder";
            this.txtBalance.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtBalance.ButtonCustom.DisplayPosition")));
            this.txtBalance.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtBalance.ButtonCustom.Image")));
            this.txtBalance.ButtonCustom.Text = resources.GetString("txtBalance.ButtonCustom.Text");
            this.txtBalance.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtBalance.ButtonCustom2.DisplayPosition")));
            this.txtBalance.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtBalance.ButtonCustom2.Image")));
            this.txtBalance.ButtonCustom2.Text = resources.GetString("txtBalance.ButtonCustom2.Text");
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // labelX4
            // 
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Name = "labelX4";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // labelX6
            // 
            resources.ApplyResources(this.labelX6, "labelX6");
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Name = "labelX6";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX7
            // 
            resources.ApplyResources(this.labelX7, "labelX7");
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Name = "labelX7";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX8
            // 
            resources.ApplyResources(this.labelX8, "labelX8");
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Name = "labelX8";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Report_Pro.Properties.Resources.arow_green;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Report_Pro.Properties.Resources.arow_red;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Acc_
            // 
            resources.ApplyResources(this.Acc_, "Acc_");
            this.Acc_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Acc_.Name = "Acc_";
            this.Acc_.Load += new System.EventHandler(this.Acc__Load);
            this.Acc_.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Acc__KeyDown);
            // 
            // txtVatNo
            // 
            resources.ApplyResources(this.txtVatNo, "txtVatNo");
            this.txtVatNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtVatNo.Name = "txtVatNo";
            this.txtVatNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVatNo_KeyDown);
            // 
            // txtDocument
            // 
            resources.ApplyResources(this.txtDocument, "txtDocument");
            this.txtDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocument_KeyDown);
            // 
            // txtCost
            // 
            resources.ApplyResources(this.txtCost, "txtCost");
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCost.Name = "txtCost";
            this.txtCost.Load += new System.EventHandler(this.txtCost_Load);
            this.txtCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCost_KeyDown);
            // 
            // txtCat
            // 
            resources.ApplyResources(this.txtCat, "txtCat");
            this.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCat.Name = "txtCat";
            this.txtCat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCat_KeyDown);
            // 
            // txtAcc_2
            // 
            resources.ApplyResources(this.txtAcc_2, "txtAcc_2");
            this.txtAcc_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAcc_2.Name = "txtAcc_2";
            this.txtAcc_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcc_2_KeyDown);
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // txtCr
            // 
            resources.ApplyResources(this.txtCr, "txtCr");
            this.txtCr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCr.Name = "txtCr";
            this.txtCr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCr_KeyDown);
            this.txtCr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCr_KeyUp);
            this.txtCr.Leave += new System.EventHandler(this.txtCr_Leave);
            // 
            // txtDb
            // 
            resources.ApplyResources(this.txtDb, "txtDb");
            this.txtDb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDb.Name = "txtDb";
            this.txtDb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDb_KeyDown);
            this.txtDb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDb_KeyUp);
            this.txtDb.Leave += new System.EventHandler(this.txtDb_Leave);
            // 
            // Jor_Row
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Acc_);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtVatNo);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtAcc_2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCr);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.branchID);
            this.Controls.Add(this.txtDocDate);
            this.Controls.Add(this.ser_);
            this.Name = "Jor_Row";
            this.Load += new System.EventHandler(this.Jor_Row_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDocDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevComponents.DotNetBar.LabelX ser_;
        public System.Windows.Forms.TextBox branchID;
        public mDouble txtDb;
        public mDouble txtCr;
        public myText txtDescription;
        public myText txtAcc_2;
        public myText txtDocument;
        public myText txtVatNo;
        public Jor_Cat txtCat;
        public Jor_Cost txtCost;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput txtDocDate;
        public DevComponents.DotNetBar.Controls.TextBoxX txtBalance;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public Jor_Acc Acc_;
    }
}
