namespace Report_Pro.PL
{
    partial class frm_LoanPayment
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
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.BSearch = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.btnStatment = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.MaturityDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount = new DevComponents.Editors.DoubleInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.StartDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaymentNo = new DevComponents.Editors.IntegerInput();
            this.txtLoanRefrance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoanPurpose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLoanAcc = new Report_Pro.MyControls.UC_Acc();
            this.BName = new Report_Pro.MyControls.UC_Acc();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLoanNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.InterestRate = new DevComponents.Editors.DoubleInput();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LoanBalance = new DevComponents.Editors.DoubleInput();
            this.PaymentDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PaymentInterest = new DevComponents.Editors.DoubleInput();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentAmount = new DevComponents.Editors.DoubleInput();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaturityDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentNo)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.AutoSizeItems = false;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BNew,
            this.BSave,
            this.BSearch,
            this.BExit,
            this.btnStatment});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(800, 40);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 36;
            this.ribbonBar1.Text = "ribbonBar1";
            this.ribbonBar1.TitleVisible = false;
            // 
            // BNew
            // 
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            //this.BNew.Image = global::Report_Pro.Properties.Resources.Add_Icon;
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            this.BNew.Text = "New";
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // BSave
            // 
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            //this.BSave.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.BSave.Name = "BSave";
            this.BSave.SubItemsExpandWidth = 14;
            this.BSave.Text = "Save";
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BSearch
            // 
            this.BSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            //this.BSearch.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.BSearch.Name = "BSearch";
            this.BSearch.SubItemsExpandWidth = 14;
            this.BSearch.Text = "Search";
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // BExit
            // 
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            //this.BExit.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.BExit.Name = "BExit";
            this.BExit.RibbonWordWrap = false;
            this.BExit.SubItemsExpandWidth = 14;
            this.BExit.Text = "Exit";
            // 
            // btnStatment
            // 
            this.btnStatment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            //this.btnStatment.Image = global::Report_Pro.Properties.Resources.Reports2;
            this.btnStatment.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnStatment.Name = "btnStatment";
            this.btnStatment.SubItemsExpandWidth = 14;
            this.btnStatment.Text = "Statment";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.MaturityDate);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.Amount);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.StartDate);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.txtPaymentNo);
            this.groupPanel1.Controls.Add(this.txtLoanRefrance);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.txtLoanPurpose);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.label13);
            this.groupPanel1.Controls.Add(this.txtLoanAcc);
            this.groupPanel1.Controls.Add(this.BName);
            this.groupPanel1.Controls.Add(this.label9);
            this.groupPanel1.Controls.Add(this.label12);
            this.groupPanel1.Controls.Add(this.txtLoanNo);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 40);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(800, 308);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 37;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            //this.buttonX1.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.buttonX1.Location = new System.Drawing.Point(359, 27);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(44, 23);
            this.buttonX1.TabIndex = 133;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // MaturityDate
            // 
            // 
            // 
            // 
            this.MaturityDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.MaturityDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.MaturityDate.ButtonDropDown.Visible = true;
            this.MaturityDate.Enabled = false;
            this.MaturityDate.Location = new System.Drawing.Point(450, 251);
            // 
            // 
            // 
            this.MaturityDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.MaturityDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.MaturityDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.MaturityDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.MaturityDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.MaturityDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.MaturityDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.MaturityDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.MaturityDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.MaturityDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 2, 1, 0, 0, 0, 0);
            this.MaturityDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.MaturityDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.MaturityDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.MaturityDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.MaturityDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.MaturityDate.MonthCalendar.TodayButtonVisible = true;
            this.MaturityDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.MaturityDate.Name = "MaturityDate";
            this.MaturityDate.Size = new System.Drawing.Size(162, 27);
            this.MaturityDate.TabIndex = 132;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(340, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 130;
            this.label6.Text = "Maturity Date";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(66, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 128;
            this.label4.Text = "Amount";
            // 
            // Amount
            // 
            this.Amount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Amount.Enabled = false;
            this.Amount.Increment = 1D;
            this.Amount.Location = new System.Drawing.Point(145, 218);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(208, 27);
            this.Amount.TabIndex = 127;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(450, 26);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(101, 24);
            this.labelX4.TabIndex = 126;
            this.labelX4.Text = "Payment No.";
            // 
            // StartDate
            // 
            // 
            // 
            // 
            this.StartDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.StartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.StartDate.ButtonDropDown.Visible = true;
            this.StartDate.Enabled = false;
            this.StartDate.Location = new System.Drawing.Point(145, 255);
            // 
            // 
            // 
            this.StartDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.StartDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.StartDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.StartDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.StartDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.StartDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.StartDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.StartDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 2, 1, 0, 0, 0, 0);
            this.StartDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.StartDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.StartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.StartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.StartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.StartDate.MonthCalendar.TodayButtonVisible = true;
            this.StartDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(155, 27);
            this.StartDate.TabIndex = 131;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(29, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 129;
            this.label5.Text = "Start Date";
            // 
            // txtPaymentNo
            // 
            // 
            // 
            // 
            this.txtPaymentNo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPaymentNo.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.txtPaymentNo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtPaymentNo.IsInputReadOnly = true;
            this.txtPaymentNo.Location = new System.Drawing.Point(553, 25);
            this.txtPaymentNo.MinValue = 1;
            this.txtPaymentNo.Name = "txtPaymentNo";
            this.txtPaymentNo.ShowUpDown = true;
            this.txtPaymentNo.Size = new System.Drawing.Size(74, 27);
            this.txtPaymentNo.TabIndex = 125;
            this.txtPaymentNo.Value = 1;
            this.txtPaymentNo.ValueChanged += new System.EventHandler(this.txtPaymentNo_ValueChanged);
            // 
            // txtLoanRefrance
            // 
            this.txtLoanRefrance.Enabled = false;
            this.txtLoanRefrance.Location = new System.Drawing.Point(146, 184);
            this.txtLoanRefrance.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoanRefrance.Name = "txtLoanRefrance";
            this.txtLoanRefrance.Size = new System.Drawing.Size(480, 27);
            this.txtLoanRefrance.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(23, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 119;
            this.label1.Text = "Loan Refrance";
            // 
            // txtLoanPurpose
            // 
            this.txtLoanPurpose.Enabled = false;
            this.txtLoanPurpose.FormattingEnabled = true;
            this.txtLoanPurpose.Items.AddRange(new object[] {
            "lc Pyment",
            "local purchase Pymeny",
            "Long Tearm Loan"});
            this.txtLoanPurpose.Location = new System.Drawing.Point(146, 146);
            this.txtLoanPurpose.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoanPurpose.Name = "txtLoanPurpose";
            this.txtLoanPurpose.Size = new System.Drawing.Size(480, 27);
            this.txtLoanPurpose.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(27, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 122;
            this.label2.Text = "Loan Purpose";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(27, 107);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 19);
            this.label13.TabIndex = 117;
            this.label13.Text = "Loan Account";
            // 
            // txtLoanAcc
            // 
            this.txtLoanAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtLoanAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtLoanAcc.Enabled = false;
            this.txtLoanAcc.Location = new System.Drawing.Point(146, 100);
            this.txtLoanAcc.Margin = new System.Windows.Forms.Padding(0);
            this.txtLoanAcc.Name = "txtLoanAcc";
            this.txtLoanAcc.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLoanAcc.Size = new System.Drawing.Size(480, 32);
            this.txtLoanAcc.TabIndex = 115;
            // 
            // BName
            // 
            this.BName.BackColor = System.Drawing.Color.Transparent;
            this.BName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BName.Enabled = false;
            this.BName.Location = new System.Drawing.Point(145, 59);
            this.BName.Margin = new System.Windows.Forms.Padding(0);
            this.BName.Name = "BName";
            this.BName.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BName.Size = new System.Drawing.Size(480, 32);
            this.BName.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(89, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 19);
            this.label9.TabIndex = 120;
            this.label9.Text = "Bank";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(59, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 19);
            this.label12.TabIndex = 111;
            this.label12.Text = "Loan No.";
            // 
            // txtLoanNo
            // 
            // 
            // 
            // 
            this.txtLoanNo.Border.Class = "TextBoxBorder";
            this.txtLoanNo.Location = new System.Drawing.Point(145, 25);
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.Size = new System.Drawing.Size(208, 27);
            this.txtLoanNo.TabIndex = 110;
            this.txtLoanNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLoanNo_KeyUp);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.label15);
            this.groupPanel2.Controls.Add(this.label14);
            this.groupPanel2.Controls.Add(this.label10);
            this.groupPanel2.Controls.Add(this.InterestRate);
            this.groupPanel2.Controls.Add(this.label11);
            this.groupPanel2.Controls.Add(this.txtID);
            this.groupPanel2.Controls.Add(this.LoanBalance);
            this.groupPanel2.Controls.Add(this.PaymentDate);
            this.groupPanel2.Controls.Add(this.label8);
            this.groupPanel2.Controls.Add(this.label7);
            this.groupPanel2.Controls.Add(this.PaymentInterest);
            this.groupPanel2.Controls.Add(this.label3);
            this.groupPanel2.Controls.Add(this.PaymentAmount);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 348);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(800, 190);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(78, 18);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 19);
            this.label15.TabIndex = 144;
            this.label15.Text = "Payment ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(632, 86);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 19);
            this.label14.TabIndex = 143;
            this.label14.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(415, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 19);
            this.label10.TabIndex = 142;
            this.label10.Text = "Payment Interest";
            // 
            // InterestRate
            // 
            this.InterestRate.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.InterestRate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.InterestRate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.InterestRate.DisabledBackColor = System.Drawing.SystemColors.Info;
            this.InterestRate.DisabledForeColor = System.Drawing.SystemColors.Desktop;
            this.InterestRate.Enabled = false;
            this.InterestRate.Increment = 1D;
            this.InterestRate.Location = new System.Drawing.Point(553, 80);
            this.InterestRate.Name = "InterestRate";
            this.InterestRate.Size = new System.Drawing.Size(74, 27);
            this.InterestRate.TabIndex = 141;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(443, 51);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 140;
            this.label11.Text = "Loan Balance";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(183, 10);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(77, 27);
            this.txtID.TabIndex = 138;
            // 
            // LoanBalance
            // 
            this.LoanBalance.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.LoanBalance.BackgroundStyle.Class = "DateTimeInputBackground";
            this.LoanBalance.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.LoanBalance.DisabledBackColor = System.Drawing.SystemColors.Info;
            this.LoanBalance.DisabledForeColor = System.Drawing.SystemColors.Desktop;
            this.LoanBalance.Enabled = false;
            this.LoanBalance.Increment = 1D;
            this.LoanBalance.Location = new System.Drawing.Point(553, 47);
            this.LoanBalance.Name = "LoanBalance";
            this.LoanBalance.Size = new System.Drawing.Size(197, 27);
            this.LoanBalance.TabIndex = 139;
            // 
            // PaymentDate
            // 
            // 
            // 
            // 
            this.PaymentDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.PaymentDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.PaymentDate.ButtonDropDown.Visible = true;
            this.PaymentDate.Location = new System.Drawing.Point(183, 109);
            // 
            // 
            // 
            this.PaymentDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.PaymentDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.PaymentDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.PaymentDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.PaymentDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.PaymentDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.PaymentDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PaymentDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.PaymentDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.PaymentDate.MonthCalendar.DisplayMonth = new System.DateTime(2021, 2, 1, 0, 0, 0, 0);
            this.PaymentDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.PaymentDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.PaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.PaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PaymentDate.MonthCalendar.TodayButtonVisible = true;
            this.PaymentDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Size = new System.Drawing.Size(155, 27);
            this.PaymentDate.TabIndex = 135;
            this.PaymentDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PaymentDate_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(63, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 134;
            this.label8.Text = "Payment Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(41, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 133;
            this.label7.Text = "Payment Interest";
            // 
            // PaymentInterest
            // 
            // 
            // 
            // 
            this.PaymentInterest.BackgroundStyle.Class = "DateTimeInputBackground";
            this.PaymentInterest.ButtonFreeText.Checked = true;
            this.PaymentInterest.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.PaymentInterest.FreeTextEntryMode = true;
            this.PaymentInterest.Increment = 1D;
            this.PaymentInterest.Location = new System.Drawing.Point(183, 76);
            this.PaymentInterest.Name = "PaymentInterest";
            this.PaymentInterest.Size = new System.Drawing.Size(208, 27);
            this.PaymentInterest.TabIndex = 132;
            this.PaymentInterest.Leave += new System.EventHandler(this.PaymentInterest_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(38, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 130;
            this.label3.Text = "Payment Amount";
            // 
            // PaymentAmount
            // 
            // 
            // 
            // 
            this.PaymentAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.PaymentAmount.ButtonFreeText.Checked = true;
            this.PaymentAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.PaymentAmount.FreeTextEntryMode = true;
            this.PaymentAmount.Increment = 1D;
            this.PaymentAmount.Location = new System.Drawing.Point(183, 43);
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.Size = new System.Drawing.Size(208, 27);
            this.PaymentAmount.TabIndex = 129;
            this.PaymentAmount.Leave += new System.EventHandler(this.PaymentAmount_Leave);
            // 
            // frm_LoanPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.ribbonBar1);
            this.Name = "frm_LoanPayment";
            this.Text = "frm_LoanPayment";
            this.Load += new System.EventHandler(this.frm_LoanPayment_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaturityDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentNo)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem BSearch;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private DevComponents.DotNetBar.ButtonItem btnStatment;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLoanNo;
        private System.Windows.Forms.TextBox txtLoanRefrance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtLoanPurpose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private MyControls.UC_Acc txtLoanAcc;
        private MyControls.UC_Acc BName;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput txtPaymentNo;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.DoubleInput Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput MaturityDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput StartDate;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput PaymentDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevComponents.Editors.DoubleInput PaymentInterest;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.DoubleInput PaymentAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private System.Windows.Forms.Label label10;
        private DevComponents.Editors.DoubleInput InterestRate;
        private System.Windows.Forms.Label label11;
        private DevComponents.Editors.DoubleInput LoanBalance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}