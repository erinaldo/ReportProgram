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
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
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
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtTotal.Increment = 1D;
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.Name = "txtTotal";
            // 
            // NoOfPayments
            // 
            // 
            // 
            // 
            this.NoOfPayments.BackgroundStyle.Class = "DateTimeInputBackground";
            this.NoOfPayments.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this.NoOfPayments, "NoOfPayments");
            this.NoOfPayments.Name = "NoOfPayments";
            this.NoOfPayments.ShowUpDown = true;
            this.NoOfPayments.Value = 1;
            this.NoOfPayments.ValueChanged += new System.EventHandler(this.NoOfPayments_ValueChanged);
            this.NoOfPayments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NoOfPayments_KeyDown);
            // 
            // txtIntrestRate
            // 
            // 
            // 
            // 
            this.txtIntrestRate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtIntrestRate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtIntrestRate.DisplayFormat = "#,##0.0000";
            this.txtIntrestRate.Increment = 1D;
            resources.ApplyResources(this.txtIntrestRate, "txtIntrestRate");
            this.txtIntrestRate.Name = "txtIntrestRate";
            this.txtIntrestRate.ValueChanged += new System.EventHandler(this.txtIntrestRate_ValueChanged);
            this.txtIntrestRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIntrestRate_KeyDown);
            this.txtIntrestRate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIntrestRate_KeyUp);
            // 
            // txtLoanValue
            // 
            // 
            // 
            // 
            this.txtLoanValue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtLoanValue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtLoanValue.Increment = 1D;
            resources.ApplyResources(this.txtLoanValue, "txtLoanValue");
            this.txtLoanValue.Name = "txtLoanValue";
            this.txtLoanValue.ValueChanged += new System.EventHandler(this.txtLoanValue_ValueChanged);
            this.txtLoanValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoanValue_KeyDown);
            this.txtLoanValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLoanValue_KeyUp);
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.label35, "label35");
            this.label35.ForeColor = System.Drawing.SystemColors.Window;
            this.label35.Name = "label35";
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.label34, "label34");
            this.label34.ForeColor = System.Drawing.SystemColors.Window;
            this.label34.Name = "label34";
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.label33, "label33");
            this.label33.ForeColor = System.Drawing.SystemColors.Window;
            this.label33.Name = "label33";
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.label27, "label27");
            this.label27.ForeColor = System.Drawing.SystemColors.Window;
            this.label27.Name = "label27";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.label26, "label26");
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
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            this.label24.Click += new System.EventHandler(this.label24_Click);
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
            // 
            // 
            // 
            this.L_StartDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.L_StartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.L_StartDate.ButtonDropDown.Visible = true;
            resources.ApplyResources(this.L_StartDate, "L_StartDate");
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("L_StartDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.L_StartDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.L_StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.L_StartDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.L_StartDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("L_StartDate.MonthCalendar.MarkedDates")));
            this.L_StartDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("L_StartDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.L_StartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.L_StartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.L_StartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.L_StartDate.MonthCalendar.TodayButtonVisible = true;
            this.L_StartDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("L_StartDate.MonthCalendar.WeeklyMarkedDays")));
            this.L_StartDate.Name = "L_StartDate";
            this.L_StartDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.L_StartDate_KeyDown);
            this.L_StartDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.L_StartDate_KeyUp);
            // 
            // txtLoanRefrance
            // 
            resources.ApplyResources(this.txtLoanRefrance, "txtLoanRefrance");
            this.txtLoanRefrance.Name = "txtLoanRefrance";
            // 
            // txtLoanPurpose
            // 
            this.txtLoanPurpose.FormattingEnabled = true;
            resources.ApplyResources(this.txtLoanPurpose, "txtLoanPurpose");
            this.txtLoanPurpose.Name = "txtLoanPurpose";
            this.txtLoanPurpose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoanPurpose_KeyDown);
            // 
            // txtLoanAcc
            // 
            this.txtLoanAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtLoanAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.txtLoanAcc, "txtLoanAcc");
            this.txtLoanAcc.Name = "txtLoanAcc";
            this.txtLoanAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoanAcc_KeyDown);
            // 
            // BName
            // 
            this.BName.BackColor = System.Drawing.Color.Transparent;
            this.BName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.BName, "BName");
            this.BName.Name = "BName";
            this.BName.Load += new System.EventHandler(this.BName_Load);
            this.BName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BName_KeyDown);
            // 
            // txtLoanNo
            // 
            resources.ApplyResources(this.txtLoanNo, "txtLoanNo");
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoanNo_KeyDown);
            this.txtLoanNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLoanNo_KeyUp);
            // 
            // txtLoanId
            // 
            resources.ApplyResources(this.txtLoanId, "txtLoanId");
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.TextChanged += new System.EventHandler(this.txtLoanId_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dgAccNo);
            this.groupBox3.Controls.Add(this.checkBox1);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgAccNo
            // 
            this.dgAccNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAccNo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgAccNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgAccNo, "dgAccNo");
            this.dgAccNo.Name = "dgAccNo";
            this.dgAccNo.RowTemplate.Height = 29;
            this.dgAccNo.DoubleClick += new System.EventHandler(this.dgAccNo_DoubleClick);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.txtJorSer);
            this.groupBox2.Controls.Add(this.btnCreateJor);
            this.groupBox2.Controls.Add(this.btnPrintJor);
            this.groupBox2.Controls.Add(this.txtSanadSer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.jorDate);
            this.groupBox2.Controls.Add(this.label6);
            resources.ApplyResources(this.groupBox2, "groupBox2");
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
            this.btnCreateJor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreateJor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.btnCreateJor, "btnCreateJor");
            this.btnCreateJor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreateJor.Name = "btnCreateJor";
            this.btnCreateJor.UseVisualStyleBackColor = false;
            this.btnCreateJor.Click += new System.EventHandler(this.btnCreateJor_Click);
            // 
            // btnPrintJor
            // 
            this.btnPrintJor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrintJor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.btnPrintJor, "btnPrintJor");
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
            // 
            // 
            // 
            this.jorDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.jorDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.jorDate.ButtonDropDown.Visible = true;
            resources.ApplyResources(this.jorDate, "jorDate");
            // 
            // 
            // 
            this.jorDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("jorDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.jorDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.jorDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.jorDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.jorDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            this.jorDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("jorDate.MonthCalendar.MarkedDates")));
            this.jorDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("jorDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.jorDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.jorDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.jorDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.jorDate.MonthCalendar.TodayButtonVisible = true;
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