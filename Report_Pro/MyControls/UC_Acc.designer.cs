namespace Report_Pro.MyControls
{
    partial class UC_Acc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Acc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.branchID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMainAcc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.txtFinal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Code_Sales = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Desc_Sales = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Ratio_Sales = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Ratio_Purch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Desc_Purch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_Code_Purch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAccCash = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            resources.ApplyResources(this.dgv1, "dgv1");
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            // 
            // 
            // 
            this.ID.Border.Class = "TextBoxBorder";
            this.ID.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("ID.ButtonCustom.DisplayPosition")));
            this.ID.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("ID.ButtonCustom.Image")));
            this.ID.ButtonCustom.Text = resources.GetString("ID.ButtonCustom.Text");
            this.ID.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("ID.ButtonCustom2.DisplayPosition")));
            this.ID.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("ID.ButtonCustom2.Image")));
            this.ID.ButtonCustom2.Text = resources.GetString("ID.ButtonCustom2.Text");
            this.ID.Name = "ID";
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged_1);
            this.ID.Enter += new System.EventHandler(this.ID_Enter);
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
            // 
            // branchID
            // 
            resources.ApplyResources(this.branchID, "branchID");
            // 
            // 
            // 
            this.branchID.Border.Class = "TextBoxBorder";
            this.branchID.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("branchID.ButtonCustom.DisplayPosition")));
            this.branchID.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("branchID.ButtonCustom.Image")));
            this.branchID.ButtonCustom.Text = resources.GetString("branchID.ButtonCustom.Text");
            this.branchID.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("branchID.ButtonCustom2.DisplayPosition")));
            this.branchID.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("branchID.ButtonCustom2.Image")));
            this.branchID.ButtonCustom2.Text = resources.GetString("branchID.ButtonCustom2.Text");
            this.branchID.Name = "branchID";
            // 
            // txtMainAcc
            // 
            resources.ApplyResources(this.txtMainAcc, "txtMainAcc");
            // 
            // 
            // 
            this.txtMainAcc.Border.Class = "TextBoxBorder";
            this.txtMainAcc.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtMainAcc.ButtonCustom.DisplayPosition")));
            this.txtMainAcc.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtMainAcc.ButtonCustom.Image")));
            this.txtMainAcc.ButtonCustom.Text = resources.GetString("txtMainAcc.ButtonCustom.Text");
            this.txtMainAcc.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtMainAcc.ButtonCustom2.DisplayPosition")));
            this.txtMainAcc.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtMainAcc.ButtonCustom2.Image")));
            this.txtMainAcc.ButtonCustom2.Text = resources.GetString("txtMainAcc.ButtonCustom2.Text");
            this.txtMainAcc.Name = "txtMainAcc";
            // 
            // Desc
            // 
            this.Desc.AcceptsReturn = true;
            resources.ApplyResources(this.Desc, "Desc");
            // 
            // 
            // 
            this.Desc.Border.Class = "TextBoxBorder";
            this.Desc.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("Desc.ButtonCustom.DisplayPosition")));
            this.Desc.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("Desc.ButtonCustom.Image")));
            this.Desc.ButtonCustom.Text = resources.GetString("Desc.ButtonCustom.Text");
            this.Desc.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("Desc.ButtonCustom2.DisplayPosition")));
            this.Desc.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("Desc.ButtonCustom2.Image")));
            this.Desc.ButtonCustom2.Text = resources.GetString("Desc.ButtonCustom2.Text");
            this.Desc.Name = "Desc";
            this.Desc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Desc_KeyUp);
            // 
            // btn1
            // 
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn1.Image = global::Report_Pro.Properties.Resources.search_16;
            this.btn1.Name = "btn1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtFinal
            // 
            resources.ApplyResources(this.txtFinal, "txtFinal");
            // 
            // 
            // 
            this.txtFinal.Border.Class = "TextBoxBorder";
            this.txtFinal.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtFinal.ButtonCustom.DisplayPosition")));
            this.txtFinal.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtFinal.ButtonCustom.Image")));
            this.txtFinal.ButtonCustom.Text = resources.GetString("txtFinal.ButtonCustom.Text");
            this.txtFinal.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtFinal.ButtonCustom2.DisplayPosition")));
            this.txtFinal.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtFinal.ButtonCustom2.Image")));
            this.txtFinal.ButtonCustom2.Text = resources.GetString("txtFinal.ButtonCustom2.Text");
            this.txtFinal.Name = "txtFinal";
            // 
            // KM_Code_Sales
            // 
            resources.ApplyResources(this.KM_Code_Sales, "KM_Code_Sales");
            // 
            // 
            // 
            this.KM_Code_Sales.Border.Class = "TextBoxBorder";
            this.KM_Code_Sales.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("KM_Code_Sales.ButtonCustom.DisplayPosition")));
            this.KM_Code_Sales.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("KM_Code_Sales.ButtonCustom.Image")));
            this.KM_Code_Sales.ButtonCustom.Text = resources.GetString("KM_Code_Sales.ButtonCustom.Text");
            this.KM_Code_Sales.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("KM_Code_Sales.ButtonCustom2.DisplayPosition")));
            this.KM_Code_Sales.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("KM_Code_Sales.ButtonCustom2.Image")));
            this.KM_Code_Sales.ButtonCustom2.Text = resources.GetString("KM_Code_Sales.ButtonCustom2.Text");
            this.KM_Code_Sales.Name = "KM_Code_Sales";
            // 
            // KM_Desc_Sales
            // 
            resources.ApplyResources(this.KM_Desc_Sales, "KM_Desc_Sales");
            // 
            // 
            // 
            this.KM_Desc_Sales.Border.Class = "TextBoxBorder";
            this.KM_Desc_Sales.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("KM_Desc_Sales.ButtonCustom.DisplayPosition")));
            this.KM_Desc_Sales.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("KM_Desc_Sales.ButtonCustom.Image")));
            this.KM_Desc_Sales.ButtonCustom.Text = resources.GetString("KM_Desc_Sales.ButtonCustom.Text");
            this.KM_Desc_Sales.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("KM_Desc_Sales.ButtonCustom2.DisplayPosition")));
            this.KM_Desc_Sales.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("KM_Desc_Sales.ButtonCustom2.Image")));
            this.KM_Desc_Sales.ButtonCustom2.Text = resources.GetString("KM_Desc_Sales.ButtonCustom2.Text");
            this.KM_Desc_Sales.Name = "KM_Desc_Sales";
            // 
            // KM_Ratio_Sales
            // 
            resources.ApplyResources(this.KM_Ratio_Sales, "KM_Ratio_Sales");
            // 
            // 
            // 
            this.KM_Ratio_Sales.Border.Class = "TextBoxBorder";
            this.KM_Ratio_Sales.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("KM_Ratio_Sales.ButtonCustom.DisplayPosition")));
            this.KM_Ratio_Sales.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("KM_Ratio_Sales.ButtonCustom.Image")));
            this.KM_Ratio_Sales.ButtonCustom.Text = resources.GetString("KM_Ratio_Sales.ButtonCustom.Text");
            this.KM_Ratio_Sales.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("KM_Ratio_Sales.ButtonCustom2.DisplayPosition")));
            this.KM_Ratio_Sales.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("KM_Ratio_Sales.ButtonCustom2.Image")));
            this.KM_Ratio_Sales.ButtonCustom2.Text = resources.GetString("KM_Ratio_Sales.ButtonCustom2.Text");
            this.KM_Ratio_Sales.Name = "KM_Ratio_Sales";
            // 
            // KM_Ratio_Purch
            // 
            resources.ApplyResources(this.KM_Ratio_Purch, "KM_Ratio_Purch");
            // 
            // 
            // 
            this.KM_Ratio_Purch.Border.Class = "TextBoxBorder";
            this.KM_Ratio_Purch.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("KM_Ratio_Purch.ButtonCustom.DisplayPosition")));
            this.KM_Ratio_Purch.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("KM_Ratio_Purch.ButtonCustom.Image")));
            this.KM_Ratio_Purch.ButtonCustom.Text = resources.GetString("KM_Ratio_Purch.ButtonCustom.Text");
            this.KM_Ratio_Purch.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("KM_Ratio_Purch.ButtonCustom2.DisplayPosition")));
            this.KM_Ratio_Purch.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("KM_Ratio_Purch.ButtonCustom2.Image")));
            this.KM_Ratio_Purch.ButtonCustom2.Text = resources.GetString("KM_Ratio_Purch.ButtonCustom2.Text");
            this.KM_Ratio_Purch.Name = "KM_Ratio_Purch";
            // 
            // KM_Desc_Purch
            // 
            resources.ApplyResources(this.KM_Desc_Purch, "KM_Desc_Purch");
            // 
            // 
            // 
            this.KM_Desc_Purch.Border.Class = "TextBoxBorder";
            this.KM_Desc_Purch.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("KM_Desc_Purch.ButtonCustom.DisplayPosition")));
            this.KM_Desc_Purch.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("KM_Desc_Purch.ButtonCustom.Image")));
            this.KM_Desc_Purch.ButtonCustom.Text = resources.GetString("KM_Desc_Purch.ButtonCustom.Text");
            this.KM_Desc_Purch.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("KM_Desc_Purch.ButtonCustom2.DisplayPosition")));
            this.KM_Desc_Purch.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("KM_Desc_Purch.ButtonCustom2.Image")));
            this.KM_Desc_Purch.ButtonCustom2.Text = resources.GetString("KM_Desc_Purch.ButtonCustom2.Text");
            this.KM_Desc_Purch.Name = "KM_Desc_Purch";
            // 
            // KM_Code_Purch
            // 
            resources.ApplyResources(this.KM_Code_Purch, "KM_Code_Purch");
            // 
            // 
            // 
            this.KM_Code_Purch.Border.Class = "TextBoxBorder";
            this.KM_Code_Purch.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("KM_Code_Purch.ButtonCustom.DisplayPosition")));
            this.KM_Code_Purch.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("KM_Code_Purch.ButtonCustom.Image")));
            this.KM_Code_Purch.ButtonCustom.Text = resources.GetString("KM_Code_Purch.ButtonCustom.Text");
            this.KM_Code_Purch.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("KM_Code_Purch.ButtonCustom2.DisplayPosition")));
            this.KM_Code_Purch.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("KM_Code_Purch.ButtonCustom2.Image")));
            this.KM_Code_Purch.ButtonCustom2.Text = resources.GetString("KM_Code_Purch.ButtonCustom2.Text");
            this.KM_Code_Purch.Name = "KM_Code_Purch";
            // 
            // txtAccCash
            // 
            resources.ApplyResources(this.txtAccCash, "txtAccCash");
            // 
            // 
            // 
            this.txtAccCash.Border.Class = "TextBoxBorder";
            this.txtAccCash.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtAccCash.ButtonCustom.DisplayPosition")));
            this.txtAccCash.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtAccCash.ButtonCustom.Image")));
            this.txtAccCash.ButtonCustom.Text = resources.GetString("txtAccCash.ButtonCustom.Text");
            this.txtAccCash.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtAccCash.ButtonCustom2.DisplayPosition")));
            this.txtAccCash.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtAccCash.ButtonCustom2.Image")));
            this.txtAccCash.ButtonCustom2.Text = resources.GetString("txtAccCash.ButtonCustom2.Text");
            this.txtAccCash.Name = "txtAccCash";
            // 
            // UC_Acc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtAccCash);
            this.Controls.Add(this.KM_Ratio_Purch);
            this.Controls.Add(this.KM_Desc_Purch);
            this.Controls.Add(this.KM_Code_Purch);
            this.Controls.Add(this.KM_Ratio_Sales);
            this.Controls.Add(this.KM_Desc_Sales);
            this.Controls.Add(this.KM_Code_Sales);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtMainAcc);
            this.Controls.Add(this.branchID);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.ID);
            this.Name = "UC_Acc";
            this.Leave += new System.EventHandler(this.UC_Acc_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
        public DevComponents.DotNetBar.Controls.TextBoxX branchID;
        public DevComponents.DotNetBar.Controls.TextBoxX txtMainAcc;
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        private DevComponents.DotNetBar.ButtonX btn1;
        public DevComponents.DotNetBar.Controls.TextBoxX txtFinal;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Code_Sales;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Desc_Sales;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Ratio_Sales;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Ratio_Purch;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Desc_Purch;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_Code_Purch;
        public DevComponents.DotNetBar.Controls.TextBoxX txtAccCash;
    }
}
