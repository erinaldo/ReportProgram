namespace Report_Pro.CTR
{
    partial class frm_Cash_Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cash_Receipt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.G_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_1 = new DevComponents.DotNetBar.LabelX();
            this.btnCancelSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtsearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.search_2 = new DevComponents.DotNetBar.ButtonX();
            this.search_1 = new DevComponents.DotNetBar.ButtonX();
            this.txt_sanad_type2 = new DevComponents.DotNetBar.LabelX();
            this.Cost = new MyControls.UC_cost();
            this.Acc_Cr = new MyControls.UC_Acc();
            this.txtCashAcc = new MyControls.UC_Acc();
            this.txtCust = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_source_code = new DevComponents.DotNetBar.LabelX();
            this.user_id = new DevComponents.DotNetBar.LabelX();
            this.txtStore_ID = new DevComponents.DotNetBar.LabelX();
            this.acc_year = new DevComponents.DotNetBar.LabelX();
            this.Payment_Type = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtDescr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX44 = new DevComponents.DotNetBar.LabelX();
            this.cmb_Bank = new System.Windows.Forms.ComboBox();
            this.Check_Date = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX43 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txt_Check = new System.Windows.Forms.TextBox();
            this.labelX42 = new DevComponents.DotNetBar.LabelX();
            this.txt_sandNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX41 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cmb_Pay = new System.Windows.Forms.ComboBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.paied_amount = new DevComponents.Editors.DoubleInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_sandDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.AccSer_No = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.BEdit = new DevComponents.DotNetBar.ButtonItem();
            this.print_sand = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.G_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paied_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sandDate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.AccessibleDescription = null;
            this.groupPanel1.AccessibleName = null;
            resources.ApplyResources(this.groupPanel1, "groupPanel1");
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.G_Search);
            this.groupPanel1.Controls.Add(this.dgv2);
            this.groupPanel1.Controls.Add(this.dgv1);
            this.groupPanel1.Controls.Add(this.search_2);
            this.groupPanel1.Controls.Add(this.search_1);
            this.groupPanel1.Controls.Add(this.txt_sanad_type2);
            this.groupPanel1.Controls.Add(this.Cost);
            this.groupPanel1.Controls.Add(this.Acc_Cr);
            this.groupPanel1.Controls.Add(this.txtCashAcc);
            this.groupPanel1.Controls.Add(this.txtCust);
            this.groupPanel1.Controls.Add(this.txt_source_code);
            this.groupPanel1.Controls.Add(this.user_id);
            this.groupPanel1.Controls.Add(this.txtStore_ID);
            this.groupPanel1.Controls.Add(this.acc_year);
            this.groupPanel1.Controls.Add(this.Payment_Type);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.txtDescr);
            this.groupPanel1.Controls.Add(this.labelX44);
            this.groupPanel1.Controls.Add(this.cmb_Bank);
            this.groupPanel1.Controls.Add(this.Check_Date);
            this.groupPanel1.Controls.Add(this.labelX43);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.txt_Check);
            this.groupPanel1.Controls.Add(this.labelX42);
            this.groupPanel1.Controls.Add(this.txt_sandNo);
            this.groupPanel1.Controls.Add(this.labelX41);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.cmb_Pay);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.paied_amount);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txt_sandDate);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.AccSer_No);
            this.groupPanel1.Font = null;
            this.groupPanel1.Name = "groupPanel1";
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
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // dgv2
            // 
            this.dgv2.AccessibleDescription = null;
            this.dgv2.AccessibleName = null;
            resources.ApplyResources(this.dgv2, "dgv2");
            this.dgv2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv2.BackgroundImage = null;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv2.Font = null;
            this.dgv2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv2.Name = "dgv2";
            // 
            // dgv1
            // 
            this.dgv1.AccessibleDescription = null;
            this.dgv1.AccessibleName = null;
            resources.ApplyResources(this.dgv1, "dgv1");
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv1.BackgroundImage = null;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.Font = null;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv1.Name = "dgv1";
            // 
            // G_Search
            // 
            this.G_Search.AccessibleDescription = null;
            this.G_Search.AccessibleName = null;
            resources.ApplyResources(this.G_Search, "G_Search");
            this.G_Search.BackColor = System.Drawing.Color.Transparent;
            this.G_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.G_Search.Controls.Add(this.lbl_1);
            this.G_Search.Controls.Add(this.btnCancelSearch);
            this.G_Search.Controls.Add(this.btnSearch);
            this.G_Search.Controls.Add(this.txtsearch);
            this.G_Search.Font = null;
            this.G_Search.Name = "G_Search";
            // 
            // 
            // 
            this.G_Search.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.G_Search.Style.BackColorGradientAngle = 90;
            this.G_Search.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.G_Search.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.G_Search.Style.BorderBottomWidth = 1;
            this.G_Search.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.G_Search.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.G_Search.Style.BorderLeftWidth = 1;
            this.G_Search.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.G_Search.Style.BorderRightWidth = 1;
            this.G_Search.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.G_Search.Style.BorderTopWidth = 1;
            this.G_Search.Style.CornerDiameter = 4;
            this.G_Search.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.G_Search.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.G_Search.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.G_Search.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.G_Search.Click += new System.EventHandler(this.G_Search_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AccessibleDescription = null;
            this.lbl_1.AccessibleName = null;
            resources.ApplyResources(this.lbl_1, "lbl_1");
            this.lbl_1.BackgroundImage = null;
            this.lbl_1.CommandParameter = null;
            this.lbl_1.Font = null;
            this.lbl_1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_1.Name = "lbl_1";
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.AccessibleDescription = null;
            this.btnCancelSearch.AccessibleName = null;
            this.btnCancelSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.btnCancelSearch, "btnCancelSearch");
            this.btnCancelSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelSearch.CommandParameter = null;
            this.btnCancelSearch.Font = null;
            this.btnCancelSearch.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleDescription = null;
            this.btnSearch.AccessibleName = null;
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.CommandParameter = null;
            this.btnSearch.Font = null;
            this.btnSearch.Image = global::Report_Pro.Properties.Resources.search_16;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.AccessibleDescription = null;
            this.txtsearch.AccessibleName = null;
            resources.ApplyResources(this.txtsearch, "txtsearch");
            this.txtsearch.BackgroundImage = null;
            // 
            // 
            // 
            this.txtsearch.Border.Class = "TextBoxBorder";
            this.txtsearch.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtsearch.ButtonCustom.DisplayPosition")));
            this.txtsearch.ButtonCustom.Image = null;
            this.txtsearch.ButtonCustom.Text = resources.GetString("txtsearch.ButtonCustom.Text");
            this.txtsearch.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtsearch.ButtonCustom2.DisplayPosition")));
            this.txtsearch.ButtonCustom2.Image = null;
            this.txtsearch.ButtonCustom2.Text = resources.GetString("txtsearch.ButtonCustom2.Text");
            this.txtsearch.Font = null;
            this.txtsearch.Name = "txtsearch";
            // 
            // search_2
            // 
            this.search_2.AccessibleDescription = null;
            this.search_2.AccessibleName = null;
            this.search_2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.search_2, "search_2");
            this.search_2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.search_2.CommandParameter = null;
            this.search_2.Font = null;
            this.search_2.Image = global::Report_Pro.Properties.Resources.search_16;
            this.search_2.Name = "search_2";
            this.search_2.Click += new System.EventHandler(this.search_2_Click);
            // 
            // search_1
            // 
            this.search_1.AccessibleDescription = null;
            this.search_1.AccessibleName = null;
            this.search_1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.search_1, "search_1");
            this.search_1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.search_1.CommandParameter = null;
            this.search_1.Font = null;
            this.search_1.Image = global::Report_Pro.Properties.Resources.search_16;
            this.search_1.Name = "search_1";
            this.search_1.Click += new System.EventHandler(this.search_1_Click);
            // 
            // txt_sanad_type2
            // 
            this.txt_sanad_type2.AccessibleDescription = null;
            this.txt_sanad_type2.AccessibleName = null;
            resources.ApplyResources(this.txt_sanad_type2, "txt_sanad_type2");
            this.txt_sanad_type2.BackColor = System.Drawing.Color.Transparent;
            this.txt_sanad_type2.BackgroundImage = null;
            // 
            // 
            // 
            this.txt_sanad_type2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sanad_type2.BackgroundStyle.BorderBottomWidth = 1;
            this.txt_sanad_type2.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_sanad_type2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sanad_type2.BackgroundStyle.BorderLeftWidth = 1;
            this.txt_sanad_type2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sanad_type2.BackgroundStyle.BorderRightWidth = 1;
            this.txt_sanad_type2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sanad_type2.BackgroundStyle.BorderTopWidth = 1;
            this.txt_sanad_type2.CommandParameter = null;
            this.txt_sanad_type2.Font = null;
            this.txt_sanad_type2.Name = "txt_sanad_type2";
            // 
            // Cost
            // 
            this.Cost.AccessibleDescription = null;
            this.Cost.AccessibleName = null;
            resources.ApplyResources(this.Cost, "Cost");
            this.Cost.BackgroundImage = null;
            this.Cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cost.Font = null;
            this.Cost.Name = "Cost";
            // 
            // Acc_Cr
            // 
            this.Acc_Cr.AccessibleDescription = null;
            this.Acc_Cr.AccessibleName = null;
            resources.ApplyResources(this.Acc_Cr, "Acc_Cr");
            this.Acc_Cr.BackColor = System.Drawing.Color.Transparent;
            this.Acc_Cr.BackgroundImage = null;
            this.Acc_Cr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Acc_Cr.Font = null;
            this.Acc_Cr.Name = "Acc_Cr";
            this.Acc_Cr.Load += new System.EventHandler(this.txtAcc_Load);
            // 
            // txtCashAcc
            // 
            this.txtCashAcc.AccessibleDescription = null;
            this.txtCashAcc.AccessibleName = null;
            resources.ApplyResources(this.txtCashAcc, "txtCashAcc");
            this.txtCashAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtCashAcc.BackgroundImage = null;
            this.txtCashAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCashAcc.Font = null;
            this.txtCashAcc.Name = "txtCashAcc";
            // 
            // txtCust
            // 
            this.txtCust.AccessibleDescription = null;
            this.txtCust.AccessibleName = null;
            resources.ApplyResources(this.txtCust, "txtCust");
            this.txtCust.BackgroundImage = null;
            // 
            // 
            // 
            this.txtCust.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCust.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCust.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCust.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCust.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtCust.Border.Class = "TextBoxBorder";
            this.txtCust.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtCust.ButtonCustom.DisplayPosition")));
            this.txtCust.ButtonCustom.Image = null;
            this.txtCust.ButtonCustom.Text = resources.GetString("txtCust.ButtonCustom.Text");
            this.txtCust.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtCust.ButtonCustom2.DisplayPosition")));
            this.txtCust.ButtonCustom2.Image = null;
            this.txtCust.ButtonCustom2.Text = resources.GetString("txtCust.ButtonCustom2.Text");
            this.txtCust.Font = null;
            this.txtCust.Name = "txtCust";
            // 
            // txt_source_code
            // 
            this.txt_source_code.AccessibleDescription = null;
            this.txt_source_code.AccessibleName = null;
            resources.ApplyResources(this.txt_source_code, "txt_source_code");
            this.txt_source_code.BackColor = System.Drawing.Color.Transparent;
            this.txt_source_code.BackgroundImage = null;
            // 
            // 
            // 
            this.txt_source_code.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_source_code.BackgroundStyle.BorderBottomWidth = 1;
            this.txt_source_code.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_source_code.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_source_code.BackgroundStyle.BorderLeftWidth = 1;
            this.txt_source_code.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_source_code.BackgroundStyle.BorderRightWidth = 1;
            this.txt_source_code.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_source_code.BackgroundStyle.BorderTopWidth = 1;
            this.txt_source_code.CommandParameter = null;
            this.txt_source_code.Font = null;
            this.txt_source_code.Name = "txt_source_code";
            // 
            // user_id
            // 
            this.user_id.AccessibleDescription = null;
            this.user_id.AccessibleName = null;
            resources.ApplyResources(this.user_id, "user_id");
            this.user_id.BackColor = System.Drawing.Color.Transparent;
            this.user_id.BackgroundImage = null;
            // 
            // 
            // 
            this.user_id.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.user_id.BackgroundStyle.BorderBottomWidth = 1;
            this.user_id.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.user_id.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.user_id.BackgroundStyle.BorderLeftWidth = 1;
            this.user_id.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.user_id.BackgroundStyle.BorderRightWidth = 1;
            this.user_id.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.user_id.BackgroundStyle.BorderTopWidth = 1;
            this.user_id.CommandParameter = null;
            this.user_id.Font = null;
            this.user_id.Name = "user_id";
            // 
            // txtStore_ID
            // 
            this.txtStore_ID.AccessibleDescription = null;
            this.txtStore_ID.AccessibleName = null;
            resources.ApplyResources(this.txtStore_ID, "txtStore_ID");
            this.txtStore_ID.BackColor = System.Drawing.Color.Transparent;
            this.txtStore_ID.BackgroundImage = null;
            // 
            // 
            // 
            this.txtStore_ID.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderBottomWidth = 1;
            this.txtStore_ID.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtStore_ID.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderLeftWidth = 1;
            this.txtStore_ID.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderRightWidth = 1;
            this.txtStore_ID.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtStore_ID.BackgroundStyle.BorderTopWidth = 1;
            this.txtStore_ID.CommandParameter = null;
            this.txtStore_ID.Font = null;
            this.txtStore_ID.Name = "txtStore_ID";
            // 
            // acc_year
            // 
            this.acc_year.AccessibleDescription = null;
            this.acc_year.AccessibleName = null;
            resources.ApplyResources(this.acc_year, "acc_year");
            this.acc_year.BackColor = System.Drawing.Color.Transparent;
            this.acc_year.BackgroundImage = null;
            // 
            // 
            // 
            this.acc_year.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.acc_year.BackgroundStyle.BorderBottomWidth = 1;
            this.acc_year.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.acc_year.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.acc_year.BackgroundStyle.BorderLeftWidth = 1;
            this.acc_year.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.acc_year.BackgroundStyle.BorderRightWidth = 1;
            this.acc_year.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.acc_year.BackgroundStyle.BorderTopWidth = 1;
            this.acc_year.CommandParameter = null;
            this.acc_year.Font = null;
            this.acc_year.Name = "acc_year";
            // 
            // Payment_Type
            // 
            this.Payment_Type.AccessibleDescription = null;
            this.Payment_Type.AccessibleName = null;
            resources.ApplyResources(this.Payment_Type, "Payment_Type");
            this.Payment_Type.BackColor = System.Drawing.Color.Transparent;
            this.Payment_Type.BackgroundImage = null;
            // 
            // 
            // 
            this.Payment_Type.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Payment_Type.BackgroundStyle.BorderBottomWidth = 1;
            this.Payment_Type.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Payment_Type.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Payment_Type.BackgroundStyle.BorderLeftWidth = 1;
            this.Payment_Type.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Payment_Type.BackgroundStyle.BorderRightWidth = 1;
            this.Payment_Type.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Payment_Type.BackgroundStyle.BorderTopWidth = 1;
            this.Payment_Type.CommandParameter = null;
            this.Payment_Type.Font = null;
            this.Payment_Type.Name = "Payment_Type";
            // 
            // labelX9
            // 
            this.labelX9.AccessibleDescription = null;
            this.labelX9.AccessibleName = null;
            resources.ApplyResources(this.labelX9, "labelX9");
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.BackgroundImage = null;
            this.labelX9.CommandParameter = null;
            this.labelX9.Font = null;
            this.labelX9.Name = "labelX9";
            // 
            // txtDescr
            // 
            this.txtDescr.AccessibleDescription = null;
            this.txtDescr.AccessibleName = null;
            resources.ApplyResources(this.txtDescr, "txtDescr");
            this.txtDescr.BackgroundImage = null;
            // 
            // 
            // 
            this.txtDescr.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDescr.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescr.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDescr.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDescr.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDescr.Border.Class = "TextBoxBorder";
            this.txtDescr.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtDescr.ButtonCustom.DisplayPosition")));
            this.txtDescr.ButtonCustom.Image = null;
            this.txtDescr.ButtonCustom.Text = resources.GetString("txtDescr.ButtonCustom.Text");
            this.txtDescr.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtDescr.ButtonCustom2.DisplayPosition")));
            this.txtDescr.ButtonCustom2.Image = null;
            this.txtDescr.ButtonCustom2.Text = resources.GetString("txtDescr.ButtonCustom2.Text");
            this.txtDescr.Font = null;
            this.txtDescr.Name = "txtDescr";
            // 
            // labelX44
            // 
            this.labelX44.AccessibleDescription = null;
            this.labelX44.AccessibleName = null;
            resources.ApplyResources(this.labelX44, "labelX44");
            this.labelX44.BackColor = System.Drawing.Color.Transparent;
            this.labelX44.BackgroundImage = null;
            this.labelX44.CommandParameter = null;
            this.labelX44.Font = null;
            this.labelX44.Name = "labelX44";
            // 
            // cmb_Bank
            // 
            this.cmb_Bank.AccessibleDescription = null;
            this.cmb_Bank.AccessibleName = null;
            resources.ApplyResources(this.cmb_Bank, "cmb_Bank");
            this.cmb_Bank.BackgroundImage = null;
            this.cmb_Bank.Font = null;
            this.cmb_Bank.FormattingEnabled = true;
            this.cmb_Bank.Name = "cmb_Bank";
            // 
            // Check_Date
            // 
            this.Check_Date.AccessibleDescription = null;
            this.Check_Date.AccessibleName = null;
            resources.ApplyResources(this.Check_Date, "Check_Date");
            this.Check_Date.BackgroundImage = null;
            // 
            // 
            // 
            this.Check_Date.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Check_Date.ButtonClear.DisplayPosition = ((int)(resources.GetObject("Check_Date.ButtonClear.DisplayPosition")));
            this.Check_Date.ButtonClear.Image = null;
            this.Check_Date.ButtonClear.Text = resources.GetString("Check_Date.ButtonClear.Text");
            this.Check_Date.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("Check_Date.ButtonCustom.DisplayPosition")));
            this.Check_Date.ButtonCustom.Image = null;
            this.Check_Date.ButtonCustom.Text = resources.GetString("Check_Date.ButtonCustom.Text");
            this.Check_Date.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("Check_Date.ButtonCustom2.DisplayPosition")));
            this.Check_Date.ButtonCustom2.Image = null;
            this.Check_Date.ButtonCustom2.Text = resources.GetString("Check_Date.ButtonCustom2.Text");
            this.Check_Date.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("Check_Date.ButtonDropDown.DisplayPosition")));
            this.Check_Date.ButtonDropDown.Image = null;
            this.Check_Date.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.Check_Date.ButtonDropDown.Text = resources.GetString("Check_Date.ButtonDropDown.Text");
            this.Check_Date.ButtonDropDown.Visible = true;
            this.Check_Date.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("Check_Date.ButtonFreeText.DisplayPosition")));
            this.Check_Date.ButtonFreeText.Image = null;
            this.Check_Date.ButtonFreeText.Text = resources.GetString("Check_Date.ButtonFreeText.Text");
            this.Check_Date.CommandParameter = null;
            this.Check_Date.Font = null;
            // 
            // 
            // 
            this.Check_Date.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("Check_Date.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.Check_Date.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Check_Date.MonthCalendar.Category = resources.GetString("Check_Date.MonthCalendar.Category");
            this.Check_Date.MonthCalendar.ClearButtonVisible = true;
            this.Check_Date.MonthCalendar.CommandParameter = null;
            // 
            // 
            // 
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.Check_Date.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.Check_Date.MonthCalendar.DayNames = null;
            this.Check_Date.MonthCalendar.Description = resources.GetString("Check_Date.MonthCalendar.Description");
            this.Check_Date.MonthCalendar.DisplayMonth = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.Check_Date.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("Check_Date.MonthCalendar.MarkedDates")));
            this.Check_Date.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("Check_Date.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.Check_Date.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Check_Date.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.Check_Date.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Check_Date.MonthCalendar.Tag = resources.GetString("Check_Date.MonthCalendar.Tag");
            this.Check_Date.MonthCalendar.Text = resources.GetString("Check_Date.MonthCalendar.Text");
            this.Check_Date.MonthCalendar.TodayButtonVisible = true;
            this.Check_Date.MonthCalendar.Tooltip = resources.GetString("Check_Date.MonthCalendar.Tooltip");
            this.Check_Date.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("Check_Date.MonthCalendar.WeeklyMarkedDays")));
            this.Check_Date.Name = "Check_Date";
            // 
            // labelX43
            // 
            this.labelX43.AccessibleDescription = null;
            this.labelX43.AccessibleName = null;
            resources.ApplyResources(this.labelX43, "labelX43");
            this.labelX43.BackColor = System.Drawing.Color.Transparent;
            this.labelX43.BackgroundImage = null;
            this.labelX43.CommandParameter = null;
            this.labelX43.Font = null;
            this.labelX43.Name = "labelX43";
            // 
            // labelX8
            // 
            this.labelX8.AccessibleDescription = null;
            this.labelX8.AccessibleName = null;
            resources.ApplyResources(this.labelX8, "labelX8");
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.BackgroundImage = null;
            this.labelX8.CommandParameter = null;
            this.labelX8.Font = null;
            this.labelX8.Name = "labelX8";
            // 
            // txt_Check
            // 
            this.txt_Check.AccessibleDescription = null;
            this.txt_Check.AccessibleName = null;
            resources.ApplyResources(this.txt_Check, "txt_Check");
            this.txt_Check.BackgroundImage = null;
            this.txt_Check.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Check.Font = null;
            this.txt_Check.Name = "txt_Check";
            this.txt_Check.TabStop = false;
            // 
            // labelX42
            // 
            this.labelX42.AccessibleDescription = null;
            this.labelX42.AccessibleName = null;
            resources.ApplyResources(this.labelX42, "labelX42");
            this.labelX42.BackColor = System.Drawing.Color.Transparent;
            this.labelX42.BackgroundImage = null;
            this.labelX42.CommandParameter = null;
            this.labelX42.Font = null;
            this.labelX42.Name = "labelX42";
            // 
            // txt_sandNo
            // 
            this.txt_sandNo.AccessibleDescription = null;
            this.txt_sandNo.AccessibleName = null;
            resources.ApplyResources(this.txt_sandNo, "txt_sandNo");
            this.txt_sandNo.BackgroundImage = null;
            // 
            // 
            // 
            this.txt_sandNo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandNo.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_sandNo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandNo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandNo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandNo.Border.Class = "TextBoxBorder";
            this.txt_sandNo.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txt_sandNo.ButtonCustom.DisplayPosition")));
            this.txt_sandNo.ButtonCustom.Image = null;
            this.txt_sandNo.ButtonCustom.Text = resources.GetString("txt_sandNo.ButtonCustom.Text");
            this.txt_sandNo.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txt_sandNo.ButtonCustom2.DisplayPosition")));
            this.txt_sandNo.ButtonCustom2.Image = null;
            this.txt_sandNo.ButtonCustom2.Text = resources.GetString("txt_sandNo.ButtonCustom2.Text");
            this.txt_sandNo.Font = null;
            this.txt_sandNo.Name = "txt_sandNo";
            this.txt_sandNo.TextChanged += new System.EventHandler(this.textBoxX2_TextChanged);
            // 
            // labelX41
            // 
            this.labelX41.AccessibleDescription = null;
            this.labelX41.AccessibleName = null;
            resources.ApplyResources(this.labelX41, "labelX41");
            this.labelX41.BackColor = System.Drawing.Color.Transparent;
            this.labelX41.BackgroundImage = null;
            this.labelX41.CommandParameter = null;
            this.labelX41.Font = null;
            this.labelX41.Name = "labelX41";
            // 
            // labelX7
            // 
            this.labelX7.AccessibleDescription = null;
            this.labelX7.AccessibleName = null;
            resources.ApplyResources(this.labelX7, "labelX7");
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.BackgroundImage = null;
            this.labelX7.CommandParameter = null;
            this.labelX7.Font = null;
            this.labelX7.Name = "labelX7";
            // 
            // cmb_Pay
            // 
            this.cmb_Pay.AccessibleDescription = null;
            this.cmb_Pay.AccessibleName = null;
            resources.ApplyResources(this.cmb_Pay, "cmb_Pay");
            this.cmb_Pay.BackgroundImage = null;
            this.cmb_Pay.Font = null;
            this.cmb_Pay.FormattingEnabled = true;
            this.cmb_Pay.Name = "cmb_Pay";
            this.cmb_Pay.SelectedIndexChanged += new System.EventHandler(this.cmb_Pay_SelectedIndexChanged);
            // 
            // labelX6
            // 
            this.labelX6.AccessibleDescription = null;
            this.labelX6.AccessibleName = null;
            resources.ApplyResources(this.labelX6, "labelX6");
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.BackgroundImage = null;
            this.labelX6.CommandParameter = null;
            this.labelX6.Font = null;
            this.labelX6.Name = "labelX6";
            this.labelX6.Click += new System.EventHandler(this.labelX6_Click);
            // 
            // labelX5
            // 
            this.labelX5.AccessibleDescription = null;
            this.labelX5.AccessibleName = null;
            resources.ApplyResources(this.labelX5, "labelX5");
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.BackgroundImage = null;
            this.labelX5.CommandParameter = null;
            this.labelX5.Font = null;
            this.labelX5.Name = "labelX5";
            // 
            // labelX4
            // 
            this.labelX4.AccessibleDescription = null;
            this.labelX4.AccessibleName = null;
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.BackgroundImage = null;
            this.labelX4.CommandParameter = null;
            this.labelX4.Font = null;
            this.labelX4.Name = "labelX4";
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // paied_amount
            // 
            this.paied_amount.AccessibleDescription = null;
            this.paied_amount.AccessibleName = null;
            resources.ApplyResources(this.paied_amount, "paied_amount");
            this.paied_amount.BackgroundImage = null;
            // 
            // 
            // 
            this.paied_amount.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.paied_amount.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paied_amount.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.paied_amount.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.paied_amount.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.paied_amount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.paied_amount.ButtonClear.DisplayPosition = ((int)(resources.GetObject("paied_amount.ButtonClear.DisplayPosition")));
            this.paied_amount.ButtonClear.Image = null;
            this.paied_amount.ButtonClear.Text = resources.GetString("paied_amount.ButtonClear.Text");
            this.paied_amount.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("paied_amount.ButtonCustom.DisplayPosition")));
            this.paied_amount.ButtonCustom.Image = null;
            this.paied_amount.ButtonCustom.Text = resources.GetString("paied_amount.ButtonCustom.Text");
            this.paied_amount.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("paied_amount.ButtonCustom2.DisplayPosition")));
            this.paied_amount.ButtonCustom2.Image = null;
            this.paied_amount.ButtonCustom2.Text = resources.GetString("paied_amount.ButtonCustom2.Text");
            this.paied_amount.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("paied_amount.ButtonDropDown.DisplayPosition")));
            this.paied_amount.ButtonDropDown.Image = null;
            this.paied_amount.ButtonDropDown.Text = resources.GetString("paied_amount.ButtonDropDown.Text");
            this.paied_amount.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("paied_amount.ButtonFreeText.DisplayPosition")));
            this.paied_amount.ButtonFreeText.Image = null;
            this.paied_amount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.paied_amount.ButtonFreeText.Text = resources.GetString("paied_amount.ButtonFreeText.Text");
            this.paied_amount.CommandParameter = null;
            this.paied_amount.Font = null;
            this.paied_amount.Increment = 1;
            this.paied_amount.Name = "paied_amount";
            // 
            // labelX3
            // 
            this.labelX3.AccessibleDescription = null;
            this.labelX3.AccessibleName = null;
            resources.ApplyResources(this.labelX3, "labelX3");
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.BackgroundImage = null;
            this.labelX3.CommandParameter = null;
            this.labelX3.Font = null;
            this.labelX3.Name = "labelX3";
            // 
            // labelX2
            // 
            this.labelX2.AccessibleDescription = null;
            this.labelX2.AccessibleName = null;
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.BackgroundImage = null;
            this.labelX2.CommandParameter = null;
            this.labelX2.Font = null;
            this.labelX2.Name = "labelX2";
            // 
            // txt_sandDate
            // 
            this.txt_sandDate.AccessibleDescription = null;
            this.txt_sandDate.AccessibleName = null;
            resources.ApplyResources(this.txt_sandDate, "txt_sandDate");
            this.txt_sandDate.BackgroundImage = null;
            // 
            // 
            // 
            this.txt_sandDate.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_sandDate.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txt_sandDate.ButtonClear.DisplayPosition = ((int)(resources.GetObject("txt_sandDate.ButtonClear.DisplayPosition")));
            this.txt_sandDate.ButtonClear.Image = null;
            this.txt_sandDate.ButtonClear.Text = resources.GetString("txt_sandDate.ButtonClear.Text");
            this.txt_sandDate.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txt_sandDate.ButtonCustom.DisplayPosition")));
            this.txt_sandDate.ButtonCustom.Image = null;
            this.txt_sandDate.ButtonCustom.Text = resources.GetString("txt_sandDate.ButtonCustom.Text");
            this.txt_sandDate.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txt_sandDate.ButtonCustom2.DisplayPosition")));
            this.txt_sandDate.ButtonCustom2.Image = null;
            this.txt_sandDate.ButtonCustom2.Text = resources.GetString("txt_sandDate.ButtonCustom2.Text");
            this.txt_sandDate.ButtonDropDown.DisplayPosition = ((int)(resources.GetObject("txt_sandDate.ButtonDropDown.DisplayPosition")));
            this.txt_sandDate.ButtonDropDown.Image = null;
            this.txt_sandDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txt_sandDate.ButtonDropDown.Text = resources.GetString("txt_sandDate.ButtonDropDown.Text");
            this.txt_sandDate.ButtonDropDown.Visible = true;
            this.txt_sandDate.ButtonFreeText.DisplayPosition = ((int)(resources.GetObject("txt_sandDate.ButtonFreeText.DisplayPosition")));
            this.txt_sandDate.ButtonFreeText.Image = null;
            this.txt_sandDate.ButtonFreeText.Text = resources.GetString("txt_sandDate.ButtonFreeText.Text");
            this.txt_sandDate.CommandParameter = null;
            this.txt_sandDate.Font = null;
            // 
            // 
            // 
            this.txt_sandDate.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("txt_sandDate.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.txt_sandDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sandDate.MonthCalendar.Category = resources.GetString("txt_sandDate.MonthCalendar.Category");
            this.txt_sandDate.MonthCalendar.ClearButtonVisible = true;
            this.txt_sandDate.MonthCalendar.CommandParameter = null;
            // 
            // 
            // 
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txt_sandDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txt_sandDate.MonthCalendar.DayNames = null;
            this.txt_sandDate.MonthCalendar.Description = resources.GetString("txt_sandDate.MonthCalendar.Description");
            this.txt_sandDate.MonthCalendar.DisplayMonth = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.txt_sandDate.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("txt_sandDate.MonthCalendar.MarkedDates")));
            this.txt_sandDate.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("txt_sandDate.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.txt_sandDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txt_sandDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txt_sandDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txt_sandDate.MonthCalendar.Tag = resources.GetString("txt_sandDate.MonthCalendar.Tag");
            this.txt_sandDate.MonthCalendar.Text = resources.GetString("txt_sandDate.MonthCalendar.Text");
            this.txt_sandDate.MonthCalendar.TodayButtonVisible = true;
            this.txt_sandDate.MonthCalendar.Tooltip = resources.GetString("txt_sandDate.MonthCalendar.Tooltip");
            this.txt_sandDate.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("txt_sandDate.MonthCalendar.WeeklyMarkedDays")));
            this.txt_sandDate.Name = "txt_sandDate";
            this.txt_sandDate.Click += new System.EventHandler(this.dateTimeInput1_Click);
            // 
            // labelX1
            // 
            this.labelX1.AccessibleDescription = null;
            this.labelX1.AccessibleName = null;
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.BackgroundImage = null;
            this.labelX1.CommandParameter = null;
            this.labelX1.Font = null;
            this.labelX1.Name = "labelX1";
            // 
            // AccSer_No
            // 
            this.AccSer_No.AccessibleDescription = null;
            this.AccSer_No.AccessibleName = null;
            resources.ApplyResources(this.AccSer_No, "AccSer_No");
            this.AccSer_No.BackgroundImage = null;
            // 
            // 
            // 
            this.AccSer_No.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.AccSer_No.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AccSer_No.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.AccSer_No.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.AccSer_No.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.AccSer_No.Border.Class = "TextBoxBorder";
            this.AccSer_No.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("AccSer_No.ButtonCustom.DisplayPosition")));
            this.AccSer_No.ButtonCustom.Image = null;
            this.AccSer_No.ButtonCustom.Text = resources.GetString("AccSer_No.ButtonCustom.Text");
            this.AccSer_No.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("AccSer_No.ButtonCustom2.DisplayPosition")));
            this.AccSer_No.ButtonCustom2.Image = null;
            this.AccSer_No.ButtonCustom2.Text = resources.GetString("AccSer_No.ButtonCustom2.Text");
            this.AccSer_No.Font = null;
            this.AccSer_No.Name = "AccSer_No";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AccessibleDescription = null;
            this.ribbonBar1.AccessibleName = null;
            resources.ApplyResources(this.ribbonBar1, "ribbonBar1");
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.BackgroundImage = null;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BNew,
            this.BSave,
            this.BEdit,
            this.print_sand,
            this.BExit});
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TitleVisible = false;
            // 
            // BNew
            // 
            resources.ApplyResources(this.BNew, "BNew");
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BNew.CommandParameter = null;
            this.BNew.Image = global::Report_Pro.Properties.Resources.Add_Icon;
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // BSave
            // 
            resources.ApplyResources(this.BSave, "BSave");
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSave.CommandParameter = null;
            this.BSave.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.BSave.Name = "BSave";
            this.BSave.SubItemsExpandWidth = 14;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BEdit
            // 
            resources.ApplyResources(this.BEdit, "BEdit");
            this.BEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BEdit.CommandParameter = null;
            this.BEdit.Enabled = false;
            this.BEdit.Image = global::Report_Pro.Properties.Resources.update;
            this.BEdit.Name = "BEdit";
            this.BEdit.SubItemsExpandWidth = 14;
            // 
            // print_sand
            // 
            resources.ApplyResources(this.print_sand, "print_sand");
            this.print_sand.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.print_sand.CommandParameter = null;
            this.print_sand.Image = ((System.Drawing.Image)(resources.GetObject("print_sand.Image")));
            this.print_sand.ImagePaddingHorizontal = 15;
            this.print_sand.Name = "print_sand";
            this.print_sand.SubItemsExpandWidth = 14;
            this.print_sand.Click += new System.EventHandler(this.print_sand_Click);
            // 
            // BExit
            // 
            resources.ApplyResources(this.BExit, "BExit");
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BExit.CommandParameter = null;
            this.BExit.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.BExit.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.BExit.Name = "BExit";
            this.BExit.SubItemsExpandWidth = 14;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // frm_Cash_Receipt
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.ControlBox = false;
            this.Controls.Add(this.ribbonBar1);
            this.Controls.Add(this.groupPanel1);
            this.Font = null;
            this.Icon = null;
            this.Name = "frm_Cash_Receipt";
            this.Tag = "";
            this.Load += new System.EventHandler(this.frm_recet_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.G_Search.ResumeLayout(false);
            this.G_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Check_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paied_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sandDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX AccSer_No;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txt_sandDate;
        private DevComponents.Editors.DoubleInput paied_amount;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sandNo;
        private DevComponents.DotNetBar.LabelX labelX44;
        private System.Windows.Forms.ComboBox cmb_Bank;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput Check_Date;
        private DevComponents.DotNetBar.LabelX labelX43;
        private System.Windows.Forms.TextBox txt_Check;
        private DevComponents.DotNetBar.LabelX labelX42;
        private DevComponents.DotNetBar.LabelX labelX41;
        private System.Windows.Forms.ComboBox cmb_Pay;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescr;
        private DevComponents.DotNetBar.LabelX labelX9;
        public DevComponents.DotNetBar.LabelX txtStore_ID;
        public DevComponents.DotNetBar.LabelX acc_year;
        public DevComponents.DotNetBar.LabelX Payment_Type;
        private DevComponents.DotNetBar.LabelX user_id;
        private DevComponents.DotNetBar.LabelX txt_source_code;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCust;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem BEdit;
        private DevComponents.DotNetBar.ButtonItem print_sand;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private MyControls.UC_Acc txtCashAcc;
        private MyControls.UC_Acc Acc_Cr;
        private MyControls.UC_cost Cost;
        private DevComponents.DotNetBar.LabelX txt_sanad_type2;
        private DevComponents.DotNetBar.ButtonX search_1;
        private DevComponents.DotNetBar.ButtonX search_2;
        private DevComponents.DotNetBar.Controls.GroupPanel G_Search;
        public DevComponents.DotNetBar.LabelX lbl_1;
        private DevComponents.DotNetBar.ButtonX btnCancelSearch;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        public DevComponents.DotNetBar.Controls.TextBoxX txtsearch;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv2;
    }
}