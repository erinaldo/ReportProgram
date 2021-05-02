namespace Report_Pro.Loans
{
    partial class frm_Loan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Loan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BNew = new System.Windows.Forms.ToolStripMenuItem();
            this.BSave = new System.Windows.Forms.ToolStripMenuItem();
            this.BSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.BStatment = new System.Windows.Forms.ToolStripMenuItem();
            this.BPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.BExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new DevComponents.Editors.DoubleInput();
            this.NoOfPayments = new DevComponents.Editors.IntegerInput();
            this.txtIntrestRate = new DevComponents.Editors.DoubleInput();
            this.txtLoanValue = new DevComponents.Editors.DoubleInput();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_StartDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtLoanRefrance = new System.Windows.Forms.TextBox();
            this.txtLoanPurpose = new System.Windows.Forms.ComboBox();
            this.txtLoanAcc = new Report_Pro.MyControls.UC_Acc();
            this.BName = new Report_Pro.MyControls.UC_Acc();
            this.txtLoanNo = new System.Windows.Forms.TextBox();
            this.txtLoanId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgAccNo = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtJorSer = new System.Windows.Forms.TextBox();
            this.btnCreateJor = new System.Windows.Forms.Button();
            this.btnPrintJor = new System.Windows.Forms.Button();
            this.txtSanadSer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jorDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMainLoanAccNo = new System.Windows.Forms.TextBox();
            this.chLoanSave = new System.Windows.Forms.CheckBox();
            this.txtYear = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntrestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_StartDate)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccNo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jorDate)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BNew,
            this.BSave,
            this.BSearch,
            this.BStatment,
            this.BPrint,
            this.BExit});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // BNew
            // 
            resources.ApplyResources(this.BNew, "BNew");
            this.BNew.ForeColor = System.Drawing.SystemColors.Window;
            this.BNew.Image = global::Report_Pro.Properties.Resources.Add_Icon;
            this.BNew.Name = "BNew";
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // BSave
            // 
            resources.ApplyResources(this.BSave, "BSave");
            this.BSave.ForeColor = System.Drawing.SystemColors.Window;
            this.BSave.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.BSave.Name = "BSave";
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BSearch
            // 
            resources.ApplyResources(this.BSearch, "BSearch");
            this.BSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.BSearch.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.BSearch.Name = "BSearch";
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // BStatment
            // 
            resources.ApplyResources(this.BStatment, "BStatment");
            this.BStatment.ForeColor = System.Drawing.SystemColors.Window;
            this.BStatment.Image = global::Report_Pro.Properties.Resources.Reports1;
            this.BStatment.Name = "BStatment";
            this.BStatment.Click += new System.EventHandler(this.BStatment_Click);
            // 
            // BPrint
            // 
            resources.ApplyResources(this.BPrint, "BPrint");
            this.BPrint.ForeColor = System.Drawing.SystemColors.Window;
            this.BPrint.Image = global::Report_Pro.Properties.Resources.printer_icon;
            this.BPrint.Name = "BPrint";
            this.BPrint.Click += new System.EventHandler(this.BPrint_Click);
            // 
            // BExit
            // 
            resources.ApplyResources(this.BExit, "BExit");
            this.BExit.ForeColor = System.Drawing.SystemColors.Window;
            this.BExit.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.BExit.Name = "BExit";
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.NoOfPayments);
            this.groupBox4.Controls.Add(this.txtIntrestRate);
            this.groupBox4.Controls.Add(this.txtLoanValue);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.flowLayoutPanel1);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.L_StartDate);
            this.groupBox4.Controls.Add(this.txtLoanRefrance);
            this.groupBox4.Controls.Add(this.txtLoanPurpose);
            this.groupBox4.Controls.Add(this.txtLoanAcc);
            this.groupBox4.Controls.Add(this.BName);
            this.groupBox4.Controls.Add(this.txtLoanNo);
            this.groupBox4.Controls.Add(this.txtLoanId);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            // 
            // 
            // 
            this.txtTotal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTotal.ButtonClear.DisplayPosition = ((int)(resources.GetObject("txtTotal.ButtonClear.DisplayPosition")));
            this.txtTotal.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("txtTotal.ButtonClear.Image")));
            this.txtTotal.ButtonClear.Text = resources.GetString("txtTotal.ButtonClear.Text");
            this.txtTotal.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtTotal.ButtonCustom.DisplayPosition")));
            this.txtTotal.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtTotal.ButtonCustom.Image")));
            this.txtTotal.ButtonCustom.Text = resources.GetString("txtTotal.ButtonCustom.Text");
            this.txtTotal.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtTotal.ButtonCustom2.DisplayPosition")));
            this.txtTotal.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtTotal.ButtonCustom2.Image")));
            this.txtTotal.ButtonCustom2.Text = resources.GetString("txtTotal.ButtonCustom2.Text");
            this.txtTotal.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("txtTotal.ButtonDropDown.DisplayPosition")));
            this.txtTotal.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("txtTotal.ButtonDropDown.Image")));
            this.txtTotal.ButtonDropDown.Text = resources.GetString("txtTotal.ButtonDropDown.Text");
            this.txtTotal.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("txtTotal.ButtonFreeText.DisplayPosition")));
            this.txtTotal.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("txtTotal.ButtonFreeText.Image")));
            this.txtTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtTotal.ButtonFreeText.Text = resources.GetString("txtTotal.ButtonFreeText.Text");
            this.txtTotal.Increment = 1D;
            this.txtTotal.Name = "txtTotal";
            // 
            // NoOfPayments
            // 
            resources.ApplyResources(this.NoOfPayments, "NoOfPayments");
            // 
            // 
            // 
            this.NoOfPayments.BackgroundStyle.Class = "DateTimeInputBackground";
            this.NoOfPayments.ButtonClear.DisplayPosition = ((int)(resources.GetObject("NoOfPayments.ButtonClear.DisplayPosition")));
            this.NoOfPayments.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("NoOfPayments.ButtonClear.Image")));
            this.NoOfPayments.ButtonClear.Text = resources.GetString("NoOfPayments.ButtonClear.Text");
            this.NoOfPayments.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("NoOfPayments.ButtonCustom.DisplayPosition")));
            this.NoOfPayments.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("NoOfPayments.ButtonCustom.Image")));
            this.NoOfPayments.ButtonCustom.Text = resources.GetString("NoOfPayments.ButtonCustom.Text");
            this.NoOfPayments.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("NoOfPayments.ButtonCustom2.DisplayPosition")));
            this.NoOfPayments.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("NoOfPayments.ButtonCustom2.Image")));
            this.NoOfPayments.ButtonCustom2.Text = resources.GetString("NoOfPayments.ButtonCustom2.Text");
            this.NoOfPayments.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("NoOfPayments.ButtonDropDown.DisplayPosition")));
            this.NoOfPayments.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("NoOfPayments.ButtonDropDown.Image")));
            this.NoOfPayments.ButtonDropDown.Text = resources.GetString("NoOfPayments.ButtonDropDown.Text");
            this.NoOfPayments.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("NoOfPayments.ButtonFreeText.DisplayPosition")));
            this.NoOfPayments.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("NoOfPayments.ButtonFreeText.Image")));
            this.NoOfPayments.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.NoOfPayments.ButtonFreeText.Text = resources.GetString("NoOfPayments.ButtonFreeText.Text");
            this.NoOfPayments.Name = "NoOfPayments";
            this.NoOfPayments.ShowUpDown = true;
            this.NoOfPayments.ValueChanged += new System.EventHandler(this.NoOfPayments_ValueChanged);
            // 
            // txtIntrestRate
            // 
            resources.ApplyResources(this.txtIntrestRate, "txtIntrestRate");
            // 
            // 
            // 
            this.txtIntrestRate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtIntrestRate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("txtIntrestRate.ButtonClear.DisplayPosition")));
            this.txtIntrestRate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("txtIntrestRate.ButtonClear.Image")));
            this.txtIntrestRate.ButtonClear.Text = resources.GetString("txtIntrestRate.ButtonClear.Text");
            this.txtIntrestRate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtIntrestRate.ButtonCustom.DisplayPosition")));
            this.txtIntrestRate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtIntrestRate.ButtonCustom.Image")));
            this.txtIntrestRate.ButtonCustom.Text = resources.GetString("txtIntrestRate.ButtonCustom.Text");
            this.txtIntrestRate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtIntrestRate.ButtonCustom2.DisplayPosition")));
            this.txtIntrestRate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtIntrestRate.ButtonCustom2.Image")));
            this.txtIntrestRate.ButtonCustom2.Text = resources.GetString("txtIntrestRate.ButtonCustom2.Text");
            this.txtIntrestRate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("txtIntrestRate.ButtonDropDown.DisplayPosition")));
            this.txtIntrestRate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("txtIntrestRate.ButtonDropDown.Image")));
            this.txtIntrestRate.ButtonDropDown.Text = resources.GetString("txtIntrestRate.ButtonDropDown.Text");
            this.txtIntrestRate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("txtIntrestRate.ButtonFreeText.DisplayPosition")));
            this.txtIntrestRate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("txtIntrestRate.ButtonFreeText.Image")));
            this.txtIntrestRate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtIntrestRate.ButtonFreeText.Text = resources.GetString("txtIntrestRate.ButtonFreeText.Text");
            this.txtIntrestRate.Increment = 1D;
            this.txtIntrestRate.Name = "txtIntrestRate";
            // 
            // txtLoanValue
            // 
            resources.ApplyResources(this.txtLoanValue, "txtLoanValue");
            // 
            // 
            // 
            this.txtLoanValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtLoanValue.ButtonClear.DisplayPosition = ((int)(resources.GetObject("txtLoanValue.ButtonClear.DisplayPosition")));
            this.txtLoanValue.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("txtLoanValue.ButtonClear.Image")));
            this.txtLoanValue.ButtonClear.Text = resources.GetString("txtLoanValue.ButtonClear.Text");
            this.txtLoanValue.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtLoanValue.ButtonCustom.DisplayPosition")));
            this.txtLoanValue.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtLoanValue.ButtonCustom.Image")));
            this.txtLoanValue.ButtonCustom.Text = resources.GetString("txtLoanValue.ButtonCustom.Text");
            this.txtLoanValue.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtLoanValue.ButtonCustom2.DisplayPosition")));
            this.txtLoanValue.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtLoanValue.ButtonCustom2.Image")));
            this.txtLoanValue.ButtonCustom2.Text = resources.GetString("txtLoanValue.ButtonCustom2.Text");
            this.txtLoanValue.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("txtLoanValue.ButtonDropDown.DisplayPosition")));
            this.txtLoanValue.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("txtLoanValue.ButtonDropDown.Image")));
            this.txtLoanValue.ButtonDropDown.Text = resources.GetString("txtLoanValue.ButtonDropDown.Text");
            this.txtLoanValue.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("txtLoanValue.ButtonFreeText.DisplayPosition")));
            this.txtLoanValue.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("txtLoanValue.ButtonFreeText.Image")));
            this.txtLoanValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtLoanValue.ButtonFreeText.Text = resources.GetString("txtLoanValue.ButtonFreeText.Text");
            this.txtLoanValue.Increment = 1D;
            this.txtLoanValue.Name = "txtLoanValue";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.BackColor = System.Drawing.SystemColors.Highlight;
            this.label35.ForeColor = System.Drawing.SystemColors.Window;
            this.label35.Name = "label35";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.BackColor = System.Drawing.SystemColors.Highlight;
            this.label34.ForeColor = System.Drawing.SystemColors.Window;
            this.label34.Name = "label34";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.BackColor = System.Drawing.SystemColors.Highlight;
            this.label33.ForeColor = System.Drawing.SystemColors.Window;
            this.label33.Name = "label33";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.BackColor = System.Drawing.SystemColors.Highlight;
            this.label27.ForeColor = System.Drawing.SystemColors.Window;
            this.label27.Name = "label27";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.BackColor = System.Drawing.SystemColors.Highlight;
            this.label26.ForeColor = System.Drawing.SystemColors.Window;
            this.label26.Name = "label26";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // L_StartDate
            // 
            resources.ApplyResources(this.L_StartDate, "L_StartDate");
            // 
            // 
            // 
            this.L_StartDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.L_StartDate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("L_StartDate.ButtonClear.DisplayPosition")));
            this.L_StartDate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("L_StartDate.ButtonClear.Image")));
            this.L_StartDate.ButtonClear.Text = resources.GetString("L_StartDate.ButtonClear.Text");
            this.L_StartDate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("L_StartDate.ButtonCustom.DisplayPosition")));
            this.L_StartDate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("L_StartDate.ButtonCustom.Image")));
            this.L_StartDate.ButtonCustom.Text = resources.GetString("L_StartDate.ButtonCustom.Text");
            this.L_StartDate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("L_StartDate.ButtonCustom2.DisplayPosition")));
            this.L_StartDate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("L_StartDate.ButtonCustom2.Image")));
            this.L_StartDate.ButtonCustom2.Text = resources.GetString("L_StartDate.ButtonCustom2.Text");
            this.L_StartDate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("L_StartDate.ButtonDropDown.DisplayPosition")));
            this.L_StartDate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("L_StartDate.ButtonDropDown.Image")));
            this.L_StartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.L_StartDate.ButtonDropDown.Text = resources.GetString("L_StartDate.ButtonDropDown.Text");
            this.L_StartDate.ButtonDropDown.Visible = true;
            this.L_StartDate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("L_StartDate.ButtonFreeText.DisplayPosition")));
            this.L_StartDate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("L_StartDate.ButtonFreeText.Image")));
            this.L_StartDate.ButtonFreeText.Text = resources.GetString("L_StartDate.ButtonFreeText.Text");
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("L_StartDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.L_StartDate.MonthCalendar.Category = resources.GetString("L_StartDate.MonthCalendar.Category");
            this.L_StartDate.MonthCalendar.ClearButtonVisible = true;
            this.L_StartDate.MonthCalendar.CommandParameter = ((object)(resources.GetObject("L_StartDate.MonthCalendar.CommandParameter")));
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.L_StartDate.MonthCalendar.DayNames = ((string[])(resources.GetObject("L_StartDate.MonthCalendar.DayNames")));
            this.L_StartDate.MonthCalendar.Description = resources.GetString("L_StartDate.MonthCalendar.Description");
            this.L_StartDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.L_StartDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("L_StartDate.MonthCalendar.MarkedDates")));
            this.L_StartDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("L_StartDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.L_StartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.L_StartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.L_StartDate.MonthCalendar.Tag = resources.GetString("L_StartDate.MonthCalendar.Tag");
            this.L_StartDate.MonthCalendar.Text = resources.GetString("L_StartDate.MonthCalendar.Text");
            this.L_StartDate.MonthCalendar.TodayButtonVisible = true;
            this.L_StartDate.MonthCalendar.Tooltip = resources.GetString("L_StartDate.MonthCalendar.Tooltip");
            this.L_StartDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("L_StartDate.MonthCalendar.WeeklyMarkedDays")));
            this.L_StartDate.Name = "L_StartDate";
            // 
            // txtLoanRefrance
            // 
            resources.ApplyResources(this.txtLoanRefrance, "txtLoanRefrance");
            this.txtLoanRefrance.Name = "txtLoanRefrance";
            // 
            // txtLoanPurpose
            // 
            resources.ApplyResources(this.txtLoanPurpose, "txtLoanPurpose");
            this.txtLoanPurpose.FormattingEnabled = true;
            this.txtLoanPurpose.Name = "txtLoanPurpose";
            // 
            // txtLoanAcc
            // 
            resources.ApplyResources(this.txtLoanAcc, "txtLoanAcc");
            this.txtLoanAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtLoanAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtLoanAcc.Name = "txtLoanAcc";
            // 
            // BName
            // 
            resources.ApplyResources(this.BName, "BName");
            this.BName.BackColor = System.Drawing.Color.Transparent;
            this.BName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BName.Name = "BName";
            this.BName.Load += new System.EventHandler(this.BName_Load);
            // 
            // txtLoanNo
            // 
            resources.ApplyResources(this.txtLoanNo, "txtLoanNo");
            this.txtLoanNo.Name = "txtLoanNo";
            // 
            // txtLoanId
            // 
            resources.ApplyResources(this.txtLoanId, "txtLoanId");
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.TextChanged += new System.EventHandler(this.txtLoanId_TextChanged);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dgAccNo);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgAccNo
            // 
            resources.ApplyResources(this.dgAccNo, "dgAccNo");
            this.dgAccNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAccNo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgAccNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccNo.Name = "dgAccNo";
            this.dgAccNo.RowTemplate.Height = 29;
            this.dgAccNo.DoubleClick += new System.EventHandler(this.dgAccNo_DoubleClick);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.txtJorSer);
            this.groupBox2.Controls.Add(this.btnCreateJor);
            this.groupBox2.Controls.Add(this.btnPrintJor);
            this.groupBox2.Controls.Add(this.txtSanadSer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.jorDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txtJorSer
            // 
            resources.ApplyResources(this.txtJorSer, "txtJorSer");
            this.txtJorSer.Name = "txtJorSer";
            this.txtJorSer.TextChanged += new System.EventHandler(this.txtJorSer_TextChanged);
            // 
            // btnCreateJor
            // 
            resources.ApplyResources(this.btnCreateJor, "btnCreateJor");
            this.btnCreateJor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreateJor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCreateJor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreateJor.Name = "btnCreateJor";
            this.btnCreateJor.UseVisualStyleBackColor = false;
            this.btnCreateJor.Click += new System.EventHandler(this.btnCreateJor_Click);
            // 
            // btnPrintJor
            // 
            resources.ApplyResources(this.btnPrintJor, "btnPrintJor");
            this.btnPrintJor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrintJor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPrintJor.ForeColor = System.Drawing.Color.White;
            this.btnPrintJor.Name = "btnPrintJor";
            this.btnPrintJor.UseVisualStyleBackColor = false;
            this.btnPrintJor.Click += new System.EventHandler(this.btnPrintJor_Click);
            // 
            // txtSanadSer
            // 
            resources.ApplyResources(this.txtSanadSer, "txtSanadSer");
            this.txtSanadSer.Name = "txtSanadSer";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // jorDate
            // 
            resources.ApplyResources(this.jorDate, "jorDate");
            // 
            // 
            // 
            this.jorDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.jorDate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("jorDate.ButtonClear.DisplayPosition")));
            this.jorDate.ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("jorDate.ButtonClear.Image")));
            this.jorDate.ButtonClear.Text = resources.GetString("jorDate.ButtonClear.Text");
            this.jorDate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("jorDate.ButtonCustom.DisplayPosition")));
            this.jorDate.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("jorDate.ButtonCustom.Image")));
            this.jorDate.ButtonCustom.Text = resources.GetString("jorDate.ButtonCustom.Text");
            this.jorDate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("jorDate.ButtonCustom2.DisplayPosition")));
            this.jorDate.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("jorDate.ButtonCustom2.Image")));
            this.jorDate.ButtonCustom2.Text = resources.GetString("jorDate.ButtonCustom2.Text");
            this.jorDate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("jorDate.ButtonDropDown.DisplayPosition")));
            this.jorDate.ButtonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("jorDate.ButtonDropDown.Image")));
            this.jorDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.jorDate.ButtonDropDown.Text = resources.GetString("jorDate.ButtonDropDown.Text");
            this.jorDate.ButtonDropDown.Visible = true;
            this.jorDate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("jorDate.ButtonFreeText.DisplayPosition")));
            this.jorDate.ButtonFreeText.Image = ((System.Drawing.Image)(resources.GetObject("jorDate.ButtonFreeText.Image")));
            this.jorDate.ButtonFreeText.Text = resources.GetString("jorDate.ButtonFreeText.Text");
            // 
            // 
            // 
            this.jorDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("jorDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.jorDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.jorDate.MonthCalendar.Category = resources.GetString("jorDate.MonthCalendar.Category");
            this.jorDate.MonthCalendar.ClearButtonVisible = true;
            this.jorDate.MonthCalendar.CommandParameter = ((object)(resources.GetObject("jorDate.MonthCalendar.CommandParameter")));
            // 
            // 
            // 
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.jorDate.MonthCalendar.DayNames = ((string[])(resources.GetObject("jorDate.MonthCalendar.DayNames")));
            this.jorDate.MonthCalendar.Description = resources.GetString("jorDate.MonthCalendar.Description");
            this.jorDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.jorDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("jorDate.MonthCalendar.MarkedDates")));
            this.jorDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("jorDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.jorDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.jorDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.jorDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.jorDate.MonthCalendar.Tag = resources.GetString("jorDate.MonthCalendar.Tag");
            this.jorDate.MonthCalendar.Text = resources.GetString("jorDate.MonthCalendar.Text");
            this.jorDate.MonthCalendar.TodayButtonVisible = true;
            this.jorDate.MonthCalendar.Tooltip = resources.GetString("jorDate.MonthCalendar.Tooltip");
            this.jorDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("jorDate.MonthCalendar.WeeklyMarkedDays")));
            this.jorDate.Name = "jorDate";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Name = "label8";
            // 
            // txtMainLoanAccNo
            // 
            resources.ApplyResources(this.txtMainLoanAccNo, "txtMainLoanAccNo");
            this.txtMainLoanAccNo.Name = "txtMainLoanAccNo";
            // 
            // chLoanSave
            // 
            resources.ApplyResources(this.chLoanSave, "chLoanSave");
            this.chLoanSave.BackColor = System.Drawing.Color.Transparent;
            this.chLoanSave.Name = "chLoanSave";
            this.chLoanSave.UseVisualStyleBackColor = false;
            this.chLoanSave.CheckedChanged += new System.EventHandler(this.chLoanSave_CheckedChanged);
            // 
            // txtYear
            // 
            resources.ApplyResources(this.txtYear, "txtYear");
            this.txtYear.BackColor = System.Drawing.Color.Transparent;
            this.txtYear.Name = "txtYear";
            // 
            // frm_Loan
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chLoanSave);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtMainLoanAccNo);
            this.Name = "frm_Loan";
            this.Load += new System.EventHandler(this.frm_Loan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntrestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_StartDate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccNo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jorDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BNew;
        private System.Windows.Forms.ToolStripMenuItem BSave;
        private System.Windows.Forms.ToolStripMenuItem BSearch;
        private System.Windows.Forms.ToolStripMenuItem BStatment;
        private System.Windows.Forms.ToolStripMenuItem BPrint;
        private System.Windows.Forms.ToolStripMenuItem BExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput L_StartDate;
        private System.Windows.Forms.TextBox txtLoanRefrance;
        private System.Windows.Forms.ComboBox txtLoanPurpose;
        private MyControls.UC_Acc txtLoanAcc;
        private MyControls.UC_Acc BName;
        private System.Windows.Forms.TextBox txtLoanNo;
        private System.Windows.Forms.TextBox txtLoanId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgAccNo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtJorSer;
        private System.Windows.Forms.Button btnCreateJor;
        private System.Windows.Forms.Button btnPrintJor;
        private System.Windows.Forms.TextBox txtSanadSer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput jorDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMainLoanAccNo;
        private System.Windows.Forms.CheckBox chLoanSave;
        private System.Windows.Forms.Label txtYear;
        private DevComponents.Editors.IntegerInput NoOfPayments;
        private DevComponents.Editors.DoubleInput txtIntrestRate;
        private DevComponents.Editors.DoubleInput txtLoanValue;
        private DevComponents.Editors.DoubleInput txtTotal;
    }
}