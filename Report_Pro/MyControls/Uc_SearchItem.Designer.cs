namespace Report_Pro.MyControls
{
    partial class Uc_SearchItem
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
            this.dGV_pro_list = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.ch_SaveSearch = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnSrch = new DevComponents.DotNetBar.ButtonX();
            this.txtserch_4 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radiobalance = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsrch_1 = new System.Windows.Forms.TextBox();
            this.txtSrch_3 = new System.Windows.Forms.TextBox();
            this.txtserch_2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_pro_list)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_pro_list
            // 
            this.dGV_pro_list.AllowUserToAddRows = false;
            this.dGV_pro_list.AllowUserToDeleteRows = false;
            this.dGV_pro_list.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGV_pro_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_pro_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_pro_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGV_pro_list.Location = new System.Drawing.Point(0, 107);
            this.dGV_pro_list.MultiSelect = false;
            this.dGV_pro_list.Name = "dGV_pro_list";
            this.dGV_pro_list.ReadOnly = true;
            this.dGV_pro_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_pro_list.Size = new System.Drawing.Size(1047, 691);
            this.dGV_pro_list.TabIndex = 3;
            this.dGV_pro_list.DoubleClick += new System.EventHandler(this.dGV_pro_list_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupPanel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 107);
            this.panel1.TabIndex = 2;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.ch_SaveSearch);
            this.groupPanel1.Controls.Add(this.btnSrch);
            this.groupPanel1.Controls.Add(this.txtserch_4);
            this.groupPanel1.Controls.Add(this.panel3);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.txtSrch);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.txtsrch_1);
            this.groupPanel1.Controls.Add(this.txtSrch_3);
            this.groupPanel1.Controls.Add(this.txtserch_2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1047, 107);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(198)))));
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(198)))));
            this.groupPanel1.Style.BackColorGradientAngle = 90;
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
            this.groupPanel1.TabIndex = 0;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.buttonX1.Location = new System.Drawing.Point(267, 20);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(93, 37);
            this.buttonX1.TabIndex = 31;
            this.buttonX1.Text = "Close";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // ch_SaveSearch
            // 
            this.ch_SaveSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ch_SaveSearch.AutoSize = true;
            this.ch_SaveSearch.BackColor = System.Drawing.Color.Transparent;
            this.ch_SaveSearch.Location = new System.Drawing.Point(440, 69);
            this.ch_SaveSearch.Name = "ch_SaveSearch";
            this.ch_SaveSearch.Size = new System.Drawing.Size(133, 17);
            this.ch_SaveSearch.TabIndex = 30;
            this.ch_SaveSearch.Text = "عدم مسح بيانات البحث";
            // 
            // btnSrch
            // 
            this.btnSrch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSrch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSrch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSrch.Image = global::Report_Pro.Properties.Resources.search;
            this.btnSrch.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnSrch.Location = new System.Drawing.Point(419, 20);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(93, 37);
            this.btnSrch.TabIndex = 29;
            this.btnSrch.Text = "Search";
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // txtserch_4
            // 
            this.txtserch_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtserch_4.Location = new System.Drawing.Point(537, 35);
            this.txtserch_4.Name = "txtserch_4";
            this.txtserch_4.Size = new System.Drawing.Size(83, 20);
            this.txtserch_4.TabIndex = 3;
            this.txtserch_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtserch_4_KeyDown);
            this.txtserch_4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtserch_4_KeyUp);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.radioAll);
            this.panel3.Controls.Add(this.radiobalance);
            this.panel3.Location = new System.Drawing.Point(689, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 33);
            this.panel3.TabIndex = 27;
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioAll.Location = new System.Drawing.Point(164, 8);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(55, 17);
            this.radioAll.TabIndex = 24;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "الجميع";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radiobalance
            // 
            this.radiobalance.AutoSize = true;
            this.radiobalance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radiobalance.Location = new System.Drawing.Point(12, 8);
            this.radiobalance.Name = "radiobalance";
            this.radiobalance.Size = new System.Drawing.Size(95, 17);
            this.radiobalance.TabIndex = 23;
            this.radiobalance.Text = "اصناف لها رصيد";
            this.radiobalance.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(892, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "رقم الصنف/رقم المورد";
            // 
            // txtSrch
            // 
            this.txtSrch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSrch.Location = new System.Drawing.Point(766, 9);
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.Size = new System.Drawing.Size(118, 20);
            this.txtSrch.TabIndex = 3;
            this.txtSrch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrch_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(892, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "الوصف";
            // 
            // txtsrch_1
            // 
            this.txtsrch_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsrch_1.Location = new System.Drawing.Point(801, 35);
            this.txtsrch_1.Name = "txtsrch_1";
            this.txtsrch_1.Size = new System.Drawing.Size(83, 20);
            this.txtsrch_1.TabIndex = 0;
            this.txtsrch_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsrch_1_KeyDown);
            this.txtsrch_1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsrch_1_KeyUp);
            // 
            // txtSrch_3
            // 
            this.txtSrch_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSrch_3.Location = new System.Drawing.Point(625, 35);
            this.txtSrch_3.Name = "txtSrch_3";
            this.txtSrch_3.Size = new System.Drawing.Size(83, 20);
            this.txtSrch_3.TabIndex = 2;
            this.txtSrch_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSrch_3_KeyDown);
            this.txtSrch_3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSrch_3_KeyUp);
            // 
            // txtserch_2
            // 
            this.txtserch_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtserch_2.Location = new System.Drawing.Point(713, 35);
            this.txtserch_2.Name = "txtserch_2";
            this.txtserch_2.Size = new System.Drawing.Size(83, 20);
            this.txtserch_2.TabIndex = 1;
            this.txtserch_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtserch_2_KeyDown);
            this.txtserch_2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtserch_2_KeyUp);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(51, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "اضافة صنف جديد";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Uc_SearchItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGV_pro_list);
            this.Controls.Add(this.panel1);
            this.Name = "Uc_SearchItem";
            this.Size = new System.Drawing.Size(1047, 798);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_pro_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dGV_pro_list;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnSrch;
        private System.Windows.Forms.TextBox txtserch_4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radiobalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSrch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsrch_1;
        private System.Windows.Forms.TextBox txtSrch_3;
        private System.Windows.Forms.TextBox txtserch_2;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        public DevComponents.DotNetBar.Controls.CheckBoxX ch_SaveSearch;
    }
}
