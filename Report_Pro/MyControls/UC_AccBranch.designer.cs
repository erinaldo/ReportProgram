﻿namespace Report_Pro.MyControls
{
    partial class UC_AccBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AccBranch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFinal = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
            // 
            // Desc
            // 
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
            this.Desc.Leave += new System.EventHandler(this.Desc_Leave);
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
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.Enter += new System.EventHandler(this.ID_Enter);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
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
            // UC_AccBranch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.ID);
            this.Name = "UC_AccBranch";
            this.DoubleClick += new System.EventHandler(this.UC_AccBranch_DoubleClick);
            this.Leave += new System.EventHandler(this.UC_AccBranch_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv1;
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        private DevComponents.DotNetBar.ButtonX btn1;
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
        public DevComponents.DotNetBar.Controls.TextBoxX txtFinal;
    }
}
