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
            this.ser_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ser_.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ser_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ser_.Location = new System.Drawing.Point(3, 7);
            this.ser_.Margin = new System.Windows.Forms.Padding(0);
            this.ser_.Name = "ser_";
            this.ser_.Size = new System.Drawing.Size(57, 72);
            this.ser_.TabIndex = 6;
            this.ser_.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.txtDocDate.Location = new System.Drawing.Point(1130, 43);
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
            this.txtDocDate.Size = new System.Drawing.Size(141, 27);
            this.txtDocDate.TabIndex = 18;
            this.txtDocDate.Click += new System.EventHandler(this.txtDocDate_Click);
            this.txtDocDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocDate_KeyDown);
            // 
            // branchID
            // 
            this.branchID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.branchID.Location = new System.Drawing.Point(1887, 28);
            this.branchID.Margin = new System.Windows.Forms.Padding(0);
            this.branchID.Name = "branchID";
            this.branchID.Size = new System.Drawing.Size(88, 27);
            this.branchID.TabIndex = 19;
            this.branchID.Visible = false;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtBalance.Border.Class = "TextBoxBorder";
            this.txtBalance.Enabled = false;
            this.txtBalance.Location = new System.Drawing.Point(1810, 3);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(0);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(171, 27);
            this.txtBalance.TabIndex = 150;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(825, 45);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(82, 24);
            this.labelX4.TabIndex = 168;
            this.labelX4.Text = "Document";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(1083, 45);
            this.labelX6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(42, 24);
            this.labelX6.TabIndex = 169;
            this.labelX6.Text = "Date";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(1301, 45);
            this.labelX7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(60, 24);
            this.labelX7.TabIndex = 170;
            this.labelX7.Text = "VAT ID";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Location = new System.Drawing.Point(1554, 45);
            this.labelX8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(80, 24);
            this.labelX8.TabIndex = 171;
            this.labelX8.Text = "Account 2";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Report_Pro.Properties.Resources.arow_green;
            this.pictureBox2.Location = new System.Drawing.Point(64, 36);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 173;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Report_Pro.Properties.Resources.arow_red;
            this.pictureBox1.Location = new System.Drawing.Point(757, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 172;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Acc_
            // 
            this.Acc_.AutoSize = true;
            this.Acc_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Acc_.Location = new System.Drawing.Point(404, 0);
            this.Acc_.Margin = new System.Windows.Forms.Padding(0);
            this.Acc_.Name = "Acc_";
            this.Acc_.Size = new System.Drawing.Size(655, 32);
            this.Acc_.TabIndex = 174;
            this.Acc_.Load += new System.EventHandler(this.Acc__Load);
            this.Acc_.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Acc__KeyDown);
            // 
            // txtVatNo
            // 
            this.txtVatNo.AutoSize = true;
            this.txtVatNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtVatNo.Location = new System.Drawing.Point(1368, 42);
            this.txtVatNo.Margin = new System.Windows.Forms.Padding(0);
            this.txtVatNo.Name = "txtVatNo";
            this.txtVatNo.Size = new System.Drawing.Size(163, 30);
            this.txtVatNo.TabIndex = 163;
            this.txtVatNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVatNo_KeyDown);
            // 
            // txtDocument
            // 
            this.txtDocument.AutoSize = true;
            this.txtDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDocument.Location = new System.Drawing.Point(917, 42);
            this.txtDocument.Margin = new System.Windows.Forms.Padding(0);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(145, 30);
            this.txtDocument.TabIndex = 162;
            this.txtDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocument_KeyDown);
            // 
            // txtCost
            // 
            this.txtCost.AutoSize = true;
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCost.Location = new System.Drawing.Point(1435, 0);
            this.txtCost.Margin = new System.Windows.Forms.Padding(0);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(374, 31);
            this.txtCost.TabIndex = 161;
            this.txtCost.Load += new System.EventHandler(this.txtCost_Load);
            this.txtCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCost_KeyDown);
            // 
            // txtCat
            // 
            this.txtCat.AutoSize = true;
            this.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCat.Location = new System.Drawing.Point(1059, 0);
            this.txtCat.Margin = new System.Windows.Forms.Padding(0);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(374, 32);
            this.txtCat.TabIndex = 160;
            this.txtCat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCat_KeyDown);
            // 
            // txtAcc_2
            // 
            this.txtAcc_2.AutoSize = true;
            this.txtAcc_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAcc_2.Location = new System.Drawing.Point(1647, 42);
            this.txtAcc_2.Margin = new System.Windows.Forms.Padding(0);
            this.txtAcc_2.Name = "txtAcc_2";
            this.txtAcc_2.Size = new System.Drawing.Size(333, 30);
            this.txtAcc_2.TabIndex = 158;
            this.txtAcc_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcc_2_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDescription.Location = new System.Drawing.Point(99, 42);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(655, 30);
            this.txtDescription.TabIndex = 157;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // txtCr
            // 
            this.txtCr.AutoSize = true;
            this.txtCr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCr.Location = new System.Drawing.Point(233, 0);
            this.txtCr.Margin = new System.Windows.Forms.Padding(0);
            this.txtCr.Name = "txtCr";
            this.txtCr.Size = new System.Drawing.Size(170, 32);
            this.txtCr.TabIndex = 153;
            this.txtCr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCr_KeyDown);
            this.txtCr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCr_KeyUp);
            this.txtCr.Leave += new System.EventHandler(this.txtCr_Leave);
            // 
            // txtDb
            // 
            this.txtDb.AutoSize = true;
            this.txtDb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtDb.Location = new System.Drawing.Point(62, 0);
            this.txtDb.Margin = new System.Windows.Forms.Padding(0);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(170, 32);
            this.txtDb.TabIndex = 152;
            this.txtDb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDb_KeyDown);
            this.txtDb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDb_KeyUp);
            this.txtDb.Leave += new System.EventHandler(this.txtDb_Leave);
            // 
            // Jor_Row
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Jor_Row";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.Size = new System.Drawing.Size(1990, 91);
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
