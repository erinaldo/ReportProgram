namespace Report_Pro.Loans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LoanPayment));
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.BSearch = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.btnStatment = new DevComponents.DotNetBar.ButtonItem();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLoanNo = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtJorSer = new System.Windows.Forms.TextBox();
            this.btnCreateJor = new System.Windows.Forms.Button();
            this.btnPrintJor = new System.Windows.Forms.Button();
            this.txtSanadSer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.jorDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label18 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLoanAcc = new Report_Pro.MyControls.UC_Acc();
            this.BName = new Report_Pro.MyControls.UC_Acc();
            this.txtInterestAcc = new Report_Pro.MyControls.UC_Acc();
            ((System.ComponentModel.ISupportInitialize)(this.MaturityDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jorDate)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.AutoSizeItems = false;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            resources.ApplyResources(this.ribbonBar1, "ribbonBar1");
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BNew,
            this.BSave,
            this.BSearch,
            this.BExit,
            this.btnStatment});
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TitleVisible = false;
            // 
            // BNew
            // 
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            resources.ApplyResources(this.BNew, "BNew");
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // BSave
            // 
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSave.Name = "BSave";
            this.BSave.SubItemsExpandWidth = 14;
            resources.ApplyResources(this.BSave, "BSave");
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BSearch
            // 
            this.BSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSearch.Name = "BSearch";
            this.BSearch.SubItemsExpandWidth = 14;
            resources.ApplyResources(this.BSearch, "BSearch");
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // BExit
            // 
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BExit.Name = "BExit";
            resources.ApplyResources(this.BExit, "BExit");
            this.BExit.SubItemsExpandWidth = 14;
            // 
            // btnStatment
            // 
            this.btnStatment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStatment.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnStatment.Name = "btnStatment";
            this.btnStatment.SubItemsExpandWidth = 14;
            resources.ApplyResources(this.btnStatment, "btnStatment");
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.buttonX1, "buttonX1");
            this.buttonX1.Name = "buttonX1";
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
            resources.ApplyResources(this.MaturityDate, "MaturityDate");
            // 
            // 
            // 
            this.MaturityDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("MaturityDate.MonthCalendar.AnnuallyMarkedDates")));
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
            this.MaturityDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("MaturityDate.MonthCalendar.MarkedDates")));
            this.MaturityDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("MaturityDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.MaturityDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.MaturityDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.MaturityDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.MaturityDate.MonthCalendar.TodayButtonVisible = true;
            this.MaturityDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("MaturityDate.MonthCalendar.WeeklyMarkedDays")));
            this.MaturityDate.Name = "MaturityDate";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Name = "label4";
            // 
            // Amount
            // 
            this.Amount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this.Amount, "Amount");
            this.Amount.Increment = 1D;
            this.Amount.Name = "Amount";
            // 
            // labelX4
            // 
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Name = "labelX4";
            // 
            // StartDate
            // 
            // 
            // 
            // 
            this.StartDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.StartDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.StartDate.ButtonDropDown.Visible = true;
            resources.ApplyResources(this.StartDate, "StartDate");
            // 
            // 
            // 
            this.StartDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("StartDate.MonthCalendar.AnnuallyMarkedDates")));
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
            this.StartDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("StartDate.MonthCalendar.MarkedDates")));
            this.StartDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("StartDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.StartDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.StartDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.StartDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.StartDate.MonthCalendar.TodayButtonVisible = true;
            this.StartDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("StartDate.MonthCalendar.WeeklyMarkedDays")));
            this.StartDate.Name = "StartDate";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Name = "label5";
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
            resources.ApplyResources(this.txtPaymentNo, "txtPaymentNo");
            this.txtPaymentNo.MinValue = 1;
            this.txtPaymentNo.Name = "txtPaymentNo";
            this.txtPaymentNo.ShowUpDown = true;
            this.txtPaymentNo.Value = 1;
            this.txtPaymentNo.ValueChanged += new System.EventHandler(this.txtPaymentNo_ValueChanged);
            // 
            // txtLoanRefrance
            // 
            resources.ApplyResources(this.txtLoanRefrance, "txtLoanRefrance");
            this.txtLoanRefrance.Name = "txtLoanRefrance";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Name = "label1";
            // 
            // txtLoanPurpose
            // 
            resources.ApplyResources(this.txtLoanPurpose, "txtLoanPurpose");
            this.txtLoanPurpose.FormattingEnabled = true;
            this.txtLoanPurpose.Items.AddRange(new object[] {
            resources.GetString("txtLoanPurpose.Items"),
            resources.GetString("txtLoanPurpose.Items1"),
            resources.GetString("txtLoanPurpose.Items2")});
            this.txtLoanPurpose.Name = "txtLoanPurpose";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Name = "label2";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Name = "label13";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Name = "label9";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.Name = "label12";
            // 
            // txtLoanNo
            // 
            // 
            // 
            // 
            this.txtLoanNo.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtLoanNo, "txtLoanNo");
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLoanNo_KeyUp);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label14.Name = "label14";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Name = "label10";
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
            resources.ApplyResources(this.InterestRate, "InterestRate");
            this.InterestRate.Increment = 1D;
            this.InterestRate.Name = "InterestRate";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Name = "label11";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
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
            resources.ApplyResources(this.LoanBalance, "LoanBalance");
            this.LoanBalance.Increment = 1D;
            this.LoanBalance.Name = "LoanBalance";
            // 
            // PaymentDate
            // 
            // 
            // 
            // 
            this.PaymentDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.PaymentDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.PaymentDate.ButtonDropDown.Visible = true;
            resources.ApplyResources(this.PaymentDate, "PaymentDate");
            // 
            // 
            // 
            this.PaymentDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("PaymentDate.MonthCalendar.AnnuallyMarkedDates")));
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
            this.PaymentDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("PaymentDate.MonthCalendar.MarkedDates")));
            this.PaymentDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("PaymentDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.PaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.PaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PaymentDate.MonthCalendar.TodayButtonVisible = true;
            this.PaymentDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("PaymentDate.MonthCalendar.WeeklyMarkedDays")));
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PaymentDate_KeyUp);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Name = "label7";
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
            resources.ApplyResources(this.PaymentInterest, "PaymentInterest");
            this.PaymentInterest.Name = "PaymentInterest";
            this.PaymentInterest.Leave += new System.EventHandler(this.PaymentInterest_Leave);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Name = "label3";
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
            resources.ApplyResources(this.PaymentAmount, "PaymentAmount");
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.Leave += new System.EventHandler(this.PaymentAmount_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.PaymentAmount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.InterestRate);
            this.groupBox1.Controls.Add(this.PaymentInterest);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LoanBalance);
            this.groupBox1.Controls.Add(this.PaymentDate);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtInterestAcc);
            this.groupBox2.Controls.Add(this.buttonX1);
            this.groupBox2.Controls.Add(this.txtLoanNo);
            this.groupBox2.Controls.Add(this.MaturityDate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BName);
            this.groupBox2.Controls.Add(this.Amount);
            this.groupBox2.Controls.Add(this.txtLoanAcc);
            this.groupBox2.Controls.Add(this.labelX4);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.StartDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLoanPurpose);
            this.groupBox2.Controls.Add(this.txtPaymentNo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtLoanRefrance);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox3.Controls.Add(this.txtJorSer);
            this.groupBox3.Controls.Add(this.btnCreateJor);
            this.groupBox3.Controls.Add(this.btnPrintJor);
            this.groupBox3.Controls.Add(this.txtSanadSer);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.jorDate);
            this.groupBox3.Controls.Add(this.label18);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // txtJorSer
            // 
            resources.ApplyResources(this.txtJorSer, "txtJorSer");
            this.txtJorSer.Name = "txtJorSer";
            // 
            // btnCreateJor
            // 
            this.btnCreateJor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateJor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.btnCreateJor, "btnCreateJor");
            this.btnCreateJor.Name = "btnCreateJor";
            this.btnCreateJor.UseVisualStyleBackColor = false;
            this.btnCreateJor.Click += new System.EventHandler(this.btnCreateJor_Click);
            // 
            // btnPrintJor
            // 
            this.btnPrintJor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrintJor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.btnPrintJor, "btnPrintJor");
            this.btnPrintJor.Name = "btnPrintJor";
            this.btnPrintJor.UseVisualStyleBackColor = false;
            this.btnPrintJor.Click += new System.EventHandler(this.btnPrintJor_Click);
            // 
            // txtSanadSer
            // 
            resources.ApplyResources(this.txtSanadSer, "txtSanadSer");
            this.txtSanadSer.Name = "txtSanadSer";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Name = "label17";
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
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Name = "label18";
            // 
            // txtYear
            // 
            resources.ApplyResources(this.txtYear, "txtYear");
            this.txtYear.BackColor = System.Drawing.Color.Transparent;
            this.txtYear.Name = "txtYear";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label19.Name = "label19";
            // 
            // txtLoanAcc
            // 
            this.txtLoanAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtLoanAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.txtLoanAcc, "txtLoanAcc");
            this.txtLoanAcc.Name = "txtLoanAcc";
            // 
            // BName
            // 
            this.BName.BackColor = System.Drawing.Color.Transparent;
            this.BName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.BName, "BName");
            this.BName.Name = "BName";
            this.BName.Load += new System.EventHandler(this.BName_Load);
            // 
            // txtInterestAcc
            // 
            this.txtInterestAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtInterestAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.txtInterestAcc, "txtInterestAcc");
            this.txtInterestAcc.Name = "txtInterestAcc";
            // 
            // frm_LoanPayment
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbonBar1);
            this.Name = "frm_LoanPayment";
            this.Load += new System.EventHandler(this.frm_LoanPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaturityDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoanBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jorDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem BSearch;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private DevComponents.DotNetBar.ButtonItem btnStatment;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtJorSer;
        private System.Windows.Forms.Button btnCreateJor;
        private System.Windows.Forms.Button btnPrintJor;
        private System.Windows.Forms.TextBox txtSanadSer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput jorDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txtYear;
        private System.Windows.Forms.Label label19;
        private MyControls.UC_Acc txtInterestAcc;
    }
}