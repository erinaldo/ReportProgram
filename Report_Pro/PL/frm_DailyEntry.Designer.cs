namespace Report_Pro.PL
{
    partial class frm_DailyEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DailyEntry));
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BNew = new DevComponents.DotNetBar.ButtonItem();
            this.BSave = new DevComponents.DotNetBar.ButtonItem();
            this.BEdit = new DevComponents.DotNetBar.ButtonItem();
            this.BSearch = new DevComponents.DotNetBar.ButtonItem();
            this.BtnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.BtnEmail = new DevComponents.DotNetBar.ButtonItem();
            this.BtnAttache = new DevComponents.DotNetBar.ButtonItem();
            this.BtnCalc = new DevComponents.DotNetBar.ButtonItem();
            this.BExit = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtBranchName = new DevComponents.DotNetBar.LabelX();
            this.txtBranchCode = new DevComponents.DotNetBar.LabelX();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txt_sp_ser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.mTxt_H = new System.Windows.Forms.MaskedTextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMainNote = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSerNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Main_serNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.last_ = new System.Windows.Forms.PictureBox();
            this.next_ = new System.Windows.Forms.PictureBox();
            this.first_ = new System.Windows.Forms.PictureBox();
            this.previous_ = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.jorDebit1 = new Report_Pro.MyControls.jorDebit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.last_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ribbonBar1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BNew,
            this.BSave,
            this.BEdit,
            this.BSearch,
            this.BtnPrint,
            this.BtnEmail,
            this.BtnAttache,
            this.BtnCalc,
            this.BExit});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(1571, 36);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 102;
            this.ribbonBar1.Text = "ribbonBar1";
            this.ribbonBar1.TitleVisible = false;
            // 
            // BNew
            // 
            this.BNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BNew.Image = global::Report_Pro.Properties.Resources.Add_Icon;
            this.BNew.ImagePaddingHorizontal = 15;
            this.BNew.Name = "BNew";
            this.BNew.SubItemsExpandWidth = 14;
            this.BNew.Text = "Add";
            // 
            // BSave
            // 
            this.BSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSave.Image = global::Report_Pro.Properties.Resources.save_Icon;
            this.BSave.ImagePaddingHorizontal = 15;
            this.BSave.Name = "BSave";
            this.BSave.SubItemsExpandWidth = 14;
            this.BSave.Text = "Update";
            // 
            // BEdit
            // 
            this.BEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BEdit.Enabled = false;
            this.BEdit.FontBold = true;
            this.BEdit.Image = global::Report_Pro.Properties.Resources.update;
            this.BEdit.ImagePaddingHorizontal = 15;
            this.BEdit.Name = "BEdit";
            this.BEdit.SubItemsExpandWidth = 14;
            this.BEdit.Text = "Edit";
            // 
            // BSearch
            // 
            this.BSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BSearch.Image = global::Report_Pro.Properties.Resources.search_16;
            this.BSearch.ImagePaddingHorizontal = 15;
            this.BSearch.Name = "BSearch";
            this.BSearch.SubItemsExpandWidth = 14;
            this.BSearch.Text = "Search";
            // 
            // BtnPrint
            // 
            this.BtnPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnPrint.Image = global::Report_Pro.Properties.Resources.printer_icon;
            this.BtnPrint.ImagePaddingHorizontal = 15;
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.SubItemsExpandWidth = 14;
            this.BtnPrint.Text = "Print";
            // 
            // BtnEmail
            // 
            this.BtnEmail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnEmail.Image = global::Report_Pro.Properties.Resources.Mail_icon;
            this.BtnEmail.ImagePaddingHorizontal = 15;
            this.BtnEmail.Name = "BtnEmail";
            this.BtnEmail.SubItemsExpandWidth = 14;
            this.BtnEmail.Text = "Send Email";
            // 
            // BtnAttache
            // 
            this.BtnAttache.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnAttache.Image = global::Report_Pro.Properties.Resources.Attachment_icon1;
            this.BtnAttache.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.BtnAttache.ImagePaddingHorizontal = 15;
            this.BtnAttache.Name = "BtnAttache";
            this.BtnAttache.SubItemsExpandWidth = 14;
            this.BtnAttache.Text = "Attachments";
            // 
            // BtnCalc
            // 
            this.BtnCalc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnCalc.Image = global::Report_Pro.Properties.Resources.CalcImg;
            this.BtnCalc.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.BtnCalc.ImagePaddingHorizontal = 15;
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.SubItemsExpandWidth = 14;
            this.BtnCalc.Text = "Calculater";
            // 
            // BExit
            // 
            this.BExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BExit.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.BExit.ImagePaddingHorizontal = 15;
            this.BExit.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.BExit.Name = "BExit";
            this.BExit.RibbonWordWrap = false;
            this.BExit.SubItemsExpandWidth = 14;
            this.BExit.Text = "Exit";
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.buttonX3);
            this.groupPanel1.Controls.Add(this.buttonX2);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.txtBranchName);
            this.groupPanel1.Controls.Add(this.txtBranchCode);
            this.groupPanel1.Controls.Add(this.labelX20);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.txt_sp_ser);
            this.groupPanel1.Controls.Add(this.dateTimePicker1);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.mTxt_H);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtMainNote);
            this.groupPanel1.Controls.Add(this.txtSerNo);
            this.groupPanel1.Controls.Add(this.Main_serNo);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.previous_);
            this.groupPanel1.Controls.Add(this.first_);
            this.groupPanel1.Controls.Add(this.next_);
            this.groupPanel1.Controls.Add(this.last_);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 36);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1571, 140);
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
            this.groupPanel1.TabIndex = 103;
            // 
            // txtBranchName
            // 
            this.txtBranchName.BackColor = System.Drawing.SystemColors.Info;
            this.txtBranchName.Location = new System.Drawing.Point(197, 109);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBranchName.Size = new System.Drawing.Size(481, 22);
            this.txtBranchName.TabIndex = 154;
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.BackColor = System.Drawing.SystemColors.Info;
            this.txtBranchCode.Location = new System.Drawing.Point(134, 109);
            this.txtBranchCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBranchCode.Size = new System.Drawing.Size(59, 22);
            this.txtBranchCode.TabIndex = 153;
            // 
            // labelX20
            // 
            this.labelX20.AutoSize = true;
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            this.labelX20.Location = new System.Drawing.Point(70, 112);
            this.labelX20.Margin = new System.Windows.Forms.Padding(2);
            this.labelX20.Name = "labelX20";
            this.labelX20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX20.Size = new System.Drawing.Size(57, 20);
            this.labelX20.TabIndex = 152;
            this.labelX20.Text = "Branch ";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Location = new System.Drawing.Point(796, 70);
            this.labelX9.Margin = new System.Windows.Forms.Padding(2);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(69, 20);
            this.labelX9.TabIndex = 150;
            this.labelX9.Text = "Private No";
            // 
            // txt_sp_ser
            // 
            // 
            // 
            // 
            this.txt_sp_ser.Border.Class = "TextBoxBorder";
            this.txt_sp_ser.Location = new System.Drawing.Point(870, 66);
            this.txt_sp_ser.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sp_ser.Name = "txt_sp_ser";
            this.txt_sp_ser.Size = new System.Drawing.Size(115, 24);
            this.txt_sp_ser.TabIndex = 149;
            this.txt_sp_ser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 8);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 24);
            this.dateTimePicker1.TabIndex = 148;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(23, 10);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(107, 20);
            this.labelX5.TabIndex = 137;
            this.labelX5.Text = "Gregorian Date ";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(58, 38);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(72, 20);
            this.labelX4.TabIndex = 136;
            this.labelX4.Text = "Hijri Date ";
            // 
            // mTxt_H
            // 
            this.mTxt_H.Location = new System.Drawing.Point(136, 36);
            this.mTxt_H.Margin = new System.Windows.Forms.Padding(2);
            this.mTxt_H.Mask = "00/00/0000";
            this.mTxt_H.Name = "mTxt_H";
            this.mTxt_H.Size = new System.Drawing.Size(95, 24);
            this.mTxt_H.TabIndex = 139;
            this.mTxt_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTxt_H.ValidatingType = typeof(System.DateTime);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(88, 70);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(42, 20);
            this.labelX1.TabIndex = 135;
            this.labelX1.Text = "Notes";
            // 
            // txtMainNote
            // 
            // 
            // 
            // 
            this.txtMainNote.Border.Class = "TextBoxBorder";
            this.txtMainNote.Location = new System.Drawing.Point(136, 66);
            this.txtMainNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtMainNote.Name = "txtMainNote";
            this.txtMainNote.Size = new System.Drawing.Size(311, 24);
            this.txtMainNote.TabIndex = 138;
            // 
            // txtSerNo
            // 
            // 
            // 
            // 
            this.txtSerNo.Border.Class = "TextBoxBorder";
            this.txtSerNo.Location = new System.Drawing.Point(870, 8);
            this.txtSerNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerNo.Name = "txtSerNo";
            this.txtSerNo.Size = new System.Drawing.Size(115, 24);
            this.txtSerNo.TabIndex = 142;
            this.txtSerNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Main_serNo
            // 
            // 
            // 
            // 
            this.Main_serNo.Border.Class = "TextBoxBorder";
            this.Main_serNo.Location = new System.Drawing.Point(870, 36);
            this.Main_serNo.Margin = new System.Windows.Forms.Padding(2);
            this.Main_serNo.Name = "Main_serNo";
            this.Main_serNo.Size = new System.Drawing.Size(115, 24);
            this.Main_serNo.TabIndex = 143;
            this.Main_serNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(793, 10);
            this.labelX6.Margin = new System.Windows.Forms.Padding(2);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(72, 20);
            this.labelX6.TabIndex = 141;
            this.labelX6.Text = "Journal No";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(800, 38);
            this.labelX7.Margin = new System.Windows.Forms.Padding(2);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(65, 20);
            this.labelX7.TabIndex = 140;
            this.labelX7.Text = "Sanad No";
            // 
            // last_
            // 
            this.last_.BackColor = System.Drawing.Color.Transparent;
            this.last_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.last_.Image = ((System.Drawing.Image)(resources.GetObject("last_.Image")));
            this.last_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.last_.Location = new System.Drawing.Point(466, 24);
            this.last_.Margin = new System.Windows.Forms.Padding(2);
            this.last_.Name = "last_";
            this.last_.Size = new System.Drawing.Size(26, 33);
            this.last_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.last_.TabIndex = 147;
            this.last_.TabStop = false;
            // 
            // next_
            // 
            this.next_.BackColor = System.Drawing.Color.Transparent;
            this.next_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.next_.Image = ((System.Drawing.Image)(resources.GetObject("next_.Image")));
            this.next_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.next_.Location = new System.Drawing.Point(492, 24);
            this.next_.Margin = new System.Windows.Forms.Padding(2);
            this.next_.Name = "next_";
            this.next_.Size = new System.Drawing.Size(26, 33);
            this.next_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.next_.TabIndex = 146;
            this.next_.TabStop = false;
            // 
            // first_
            // 
            this.first_.BackColor = System.Drawing.Color.Transparent;
            this.first_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.first_.Image = ((System.Drawing.Image)(resources.GetObject("first_.Image")));
            this.first_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.first_.Location = new System.Drawing.Point(697, 24);
            this.first_.Margin = new System.Windows.Forms.Padding(2);
            this.first_.Name = "first_";
            this.first_.Size = new System.Drawing.Size(26, 33);
            this.first_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.first_.TabIndex = 144;
            this.first_.TabStop = false;
            // 
            // previous_
            // 
            this.previous_.BackColor = System.Drawing.Color.Transparent;
            this.previous_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previous_.Image = ((System.Drawing.Image)(resources.GetObject("previous_.Image")));
            this.previous_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.previous_.Location = new System.Drawing.Point(671, 24);
            this.previous_.Margin = new System.Windows.Forms.Padding(2);
            this.previous_.Name = "previous_";
            this.previous_.Size = new System.Drawing.Size(26, 33);
            this.previous_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previous_.TabIndex = 145;
            this.previous_.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(521, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 151;
            this.label1.Text = "Journal Entry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.buttonX1.Location = new System.Drawing.Point(989, 9);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(35, 23);
            this.buttonX1.TabIndex = 155;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.buttonX2.Location = new System.Drawing.Point(989, 37);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(35, 23);
            this.buttonX2.TabIndex = 156;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Image = global::Report_Pro.Properties.Resources.Search_icon1;
            this.buttonX3.Location = new System.Drawing.Point(989, 67);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(35, 23);
            this.buttonX3.TabIndex = 157;
            // 
            // jorDebit1
            // 
            this.jorDebit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.jorDebit1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.jorDebit1.Location = new System.Drawing.Point(0, 176);
            this.jorDebit1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.jorDebit1.Name = "jorDebit1";
            this.jorDebit1.Size = new System.Drawing.Size(1571, 639);
            this.jorDebit1.TabIndex = 104;
            // 
            // frm_DailyEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 813);
            this.ControlBox = false;
            this.Controls.Add(this.jorDebit1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.ribbonBar1);
            this.Name = "frm_DailyEntry";
            this.Text = "frm_DailyEntry";
            this.Load += new System.EventHandler(this.frm_DailyEntry_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.last_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previous_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem BNew;
        private DevComponents.DotNetBar.ButtonItem BSave;
        private DevComponents.DotNetBar.ButtonItem BEdit;
        private DevComponents.DotNetBar.ButtonItem BSearch;
        private DevComponents.DotNetBar.ButtonItem BtnPrint;
        private DevComponents.DotNetBar.ButtonItem BtnEmail;
        private DevComponents.DotNetBar.ButtonItem BtnAttache;
        private DevComponents.DotNetBar.ButtonItem BtnCalc;
        private DevComponents.DotNetBar.ButtonItem BExit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private MyControls.jorDebit jorDebit1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX txtBranchName;
        private DevComponents.DotNetBar.LabelX txtBranchCode;
        private DevComponents.DotNetBar.LabelX labelX20;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sp_ser;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.MaskedTextBox mTxt_H;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMainNote;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerNo;
        private DevComponents.DotNetBar.Controls.TextBoxX Main_serNo;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        internal System.Windows.Forms.PictureBox previous_;
        internal System.Windows.Forms.PictureBox first_;
        internal System.Windows.Forms.PictureBox next_;
        internal System.Windows.Forms.PictureBox last_;
    }
}