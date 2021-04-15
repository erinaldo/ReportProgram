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
            this.branchID = new System.Windows.Forms.TextBox();
            this.txtDocDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.ser_ = new DevComponents.DotNetBar.LabelX();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBalance = new Report_Pro.MyControls.myText();
            this.txtCr = new Report_Pro.MyControls.mDouble();
            this.txtDb = new Report_Pro.MyControls.mDouble();
            this.txtDocument = new Report_Pro.MyControls.myText();
            this.txtVatNo = new Report_Pro.MyControls.myText();
            this.Acc_ = new Report_Pro.MyControls.Jor_Acc();
            this.txtCat = new Report_Pro.MyControls.Jor_Cat();
            this.txtAcc_2 = new Report_Pro.MyControls.myText();
            this.txtCost = new Report_Pro.MyControls.Jor_Cost();
            this.txtDescription = new Report_Pro.MyControls.myText();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // branchID
            // 
            this.branchID.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.branchID, "branchID");
            this.branchID.Name = "branchID";
            // 
            // txtDocDate
            // 
            // 
            // 
            // 
            this.txtDocDate.BackgroundStyle.Class = "TextBoxBorder";
            this.txtDocDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtDocDate.ButtonDropDown.Visible = true;
            this.tablePanel1.SetColumn(this.txtDocDate, 11);
            resources.ApplyResources(this.txtDocDate, "txtDocDate");
            this.txtDocDate.FocusHighlightEnabled = true;
            this.txtDocDate.ForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("txtDocDate.MonthCalendar.AnnuallyMarkedDates")));
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
            this.txtDocDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("txtDocDate.MonthCalendar.MarkedDates")));
            this.txtDocDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("txtDocDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDocDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtDocDate.MonthCalendar.TodayButtonVisible = true;
            this.txtDocDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("txtDocDate.MonthCalendar.WeeklyMarkedDays")));
            this.txtDocDate.Name = "txtDocDate";
            this.tablePanel1.SetRow(this.txtDocDate, 2);
            this.txtDocDate.Click += new System.EventHandler(this.txtDocDate_Click);
            this.txtDocDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocDate_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.SetColumn(this.pictureBox2, 1);
            //this.pictureBox2.Image = global::Report_Pro.Properties.Resources.arow_green;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.tablePanel1.SetRow(this.pictureBox2, 1);
            this.tablePanel1.SetRowSpan(this.pictureBox2, 2);
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.SetColumn(this.pictureBox1, 7);
           // this.pictureBox1.Image = global::Report_Pro.Properties.Resources.arow_red;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.tablePanel1.SetRow(this.pictureBox1, 1);
            this.tablePanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelX6
            // 
            resources.ApplyResources(this.labelX6, "labelX6");
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.SetColumn(this.labelX6, 10);
            this.labelX6.Name = "labelX6";
            this.tablePanel1.SetRow(this.labelX6, 2);
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ser_
            // 
            this.ser_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablePanel1.SetColumn(this.ser_, 0);
            resources.ApplyResources(this.ser_, "ser_");
            this.ser_.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ser_.Name = "ser_";
            this.tablePanel1.SetRow(this.ser_, 0);
            this.tablePanel1.SetRowSpan(this.ser_, 3);
            this.ser_.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ser_.Click += new System.EventHandler(this.ser__Click);
            // 
            // tablePanel1
            // 
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15.72F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 73.37F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 42.41F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 46.55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 53.45F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 54.76F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15.34F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.35F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 77.95F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 76.65F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 44.15F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 64.49F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.02F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.21F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.06F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 59.22F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Controls.Add(this.txtBalance);
            this.tablePanel1.Controls.Add(this.txtCr);
            this.tablePanel1.Controls.Add(this.txtDb);
            this.tablePanel1.Controls.Add(this.ser_);
            this.tablePanel1.Controls.Add(this.labelX6);
            this.tablePanel1.Controls.Add(this.txtDocument);
            this.tablePanel1.Controls.Add(this.pictureBox1);
            this.tablePanel1.Controls.Add(this.pictureBox2);
            this.tablePanel1.Controls.Add(this.txtDocDate);
            this.tablePanel1.Controls.Add(this.txtVatNo);
            this.tablePanel1.Controls.Add(this.Acc_);
            this.tablePanel1.Controls.Add(this.txtCat);
            this.tablePanel1.Controls.Add(this.txtAcc_2);
            this.tablePanel1.Controls.Add(this.txtCost);
            this.tablePanel1.Controls.Add(this.txtDescription);
            resources.ApplyResources(this.tablePanel1, "tablePanel1");
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 24F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 15F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 24F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 15F)});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablePanel1.SetColumn(this.label1, 0);
            this.tablePanel1.SetColumnSpan(this.label1, 19);
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 3);
            // 
            // txtBalance
            // 
            resources.ApplyResources(this.txtBalance, "txtBalance");
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtBalance, 18);
            this.txtBalance.labelBackColor = System.Drawing.SystemColors.Window;
            this.txtBalance.lblControl = "";
            this.txtBalance.Name = "txtBalance";
            this.tablePanel1.SetRow(this.txtBalance, 0);
            // 
            // txtCr
            // 
            resources.ApplyResources(this.txtCr, "txtCr");
            this.txtCr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtCr, 3);
            this.tablePanel1.SetColumnSpan(this.txtCr, 2);
            this.txtCr.Name = "txtCr";
            this.tablePanel1.SetRow(this.txtCr, 0);
            this.txtCr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCr_KeyDown);
            this.txtCr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCr_KeyUp);
            // 
            // txtDb
            // 
            resources.ApplyResources(this.txtDb, "txtDb");
            this.txtDb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtDb, 1);
            this.tablePanel1.SetColumnSpan(this.txtDb, 2);
            this.txtDb.Name = "txtDb";
            this.tablePanel1.SetRow(this.txtDb, 0);
            this.txtDb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDb_KeyDown);
            this.txtDb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDb_KeyUp);
            // 
            // txtDocument
            // 
            resources.ApplyResources(this.txtDocument, "txtDocument");
            this.txtDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtDocument, 8);
            this.tablePanel1.SetColumnSpan(this.txtDocument, 2);
            this.txtDocument.labelBackColor = System.Drawing.SystemColors.Control;
            this.txtDocument.lblControl = "Document";
            this.txtDocument.Name = "txtDocument";
            this.tablePanel1.SetRow(this.txtDocument, 2);
            this.txtDocument.Load += new System.EventHandler(this.txtDocument_Load);
            this.txtDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocument_KeyDown);
            // 
            // txtVatNo
            // 
            resources.ApplyResources(this.txtVatNo, "txtVatNo");
            this.txtVatNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtVatNo, 12);
            this.tablePanel1.SetColumnSpan(this.txtVatNo, 3);
            this.txtVatNo.labelBackColor = System.Drawing.SystemColors.Control;
            this.txtVatNo.lblControl = "VAT ID";
            this.txtVatNo.Name = "txtVatNo";
            this.tablePanel1.SetRow(this.txtVatNo, 2);
            this.txtVatNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVatNo_KeyDown);
            // 
            // Acc_
            // 
            resources.ApplyResources(this.Acc_, "Acc_");
            this.Acc_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.Acc_, 5);
            this.tablePanel1.SetColumnSpan(this.Acc_, 6);
            this.Acc_.Name = "Acc_";
            this.tablePanel1.SetRow(this.Acc_, 0);
            this.Acc_.Load += new System.EventHandler(this.Acc__Load);
            this.Acc_.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Acc__KeyDown);
            // 
            // txtCat
            // 
            resources.ApplyResources(this.txtCat, "txtCat");
            this.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtCat, 11);
            this.tablePanel1.SetColumnSpan(this.txtCat, 3);
            this.txtCat.Name = "txtCat";
            this.tablePanel1.SetRow(this.txtCat, 0);
            this.txtCat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCat_KeyDown);
            // 
            // txtAcc_2
            // 
            resources.ApplyResources(this.txtAcc_2, "txtAcc_2");
            this.txtAcc_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtAcc_2, 15);
            this.tablePanel1.SetColumnSpan(this.txtAcc_2, 4);
            this.txtAcc_2.labelBackColor = System.Drawing.SystemColors.Control;
            this.txtAcc_2.lblControl = "Account 2";
            this.txtAcc_2.Name = "txtAcc_2";
            this.tablePanel1.SetRow(this.txtAcc_2, 2);
            this.txtAcc_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcc_2_KeyDown);
            // 
            // txtCost
            // 
            resources.ApplyResources(this.txtCost, "txtCost");
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtCost, 14);
            this.tablePanel1.SetColumnSpan(this.txtCost, 4);
            this.txtCost.Name = "txtCost";
            this.tablePanel1.SetRow(this.txtCost, 0);
            this.txtCost.Load += new System.EventHandler(this.txtCost_Load);
            this.txtCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCost_KeyDown);
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel1.SetColumn(this.txtDescription, 2);
            this.tablePanel1.SetColumnSpan(this.txtDescription, 5);
            this.txtDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDescription.labelBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescription.lblControl = "";
            this.txtDescription.Name = "txtDescription";
            this.tablePanel1.SetRow(this.txtDescription, 2);
            this.txtDescription.Load += new System.EventHandler(this.txtDescription_Load);
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // Jor_Row
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.branchID);
            this.Name = "Jor_Row";
            this.Load += new System.EventHandler(this.Jor_Row_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDocDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox branchID;
        public myText txtDescription;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        public mDouble txtCr;
        public mDouble txtDb;
        public DevComponents.DotNetBar.LabelX ser_;
        private DevComponents.DotNetBar.LabelX labelX6;
        public myText txtDocument;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public DevComponents.Editors.DateTimeAdv.DateTimeInput txtDocDate;
        public myText txtVatNo;
        public Jor_Acc Acc_;
        public Jor_Cat txtCat;
        public myText txtAcc_2;
        public Jor_Cost txtCost;
        public myText txtBalance;
        private System.Windows.Forms.Label label1;
    }
}
