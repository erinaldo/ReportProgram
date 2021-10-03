namespace Report_Pro.Loans
{
    partial class frm_Accrued_Interest
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.txtBank = new Report_Pro.MyControls.UC_Acc();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMaturityLoans = new System.Windows.Forms.Button();
            this.btnAccruedIntrrest = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.toDate);
            this.groupBox2.Controls.Add(this.fromDate);
            this.groupBox2.Controls.Add(this.txtBank);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 141);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "To Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bank";
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(347, 46);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(104, 20);
            this.toDate.TabIndex = 2;
            // 
            // txtBank
            // 
            this.txtBank.BackColor = System.Drawing.Color.Transparent;
            this.txtBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBank.Location = new System.Drawing.Point(127, 18);
            this.txtBank.Margin = new System.Windows.Forms.Padding(0);
            this.txtBank.Name = "txtBank";
            this.txtBank.Padding = new System.Windows.Forms.Padding(1);
            this.txtBank.Size = new System.Drawing.Size(324, 25);
            this.txtBank.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.btnMaturityLoans);
            this.groupBox1.Controls.Add(this.btnAccruedIntrrest);
            this.groupBox1.Controls.Add(this.btnOption);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnMaturityLoans
            // 
            this.btnMaturityLoans.Location = new System.Drawing.Point(208, 13);
            this.btnMaturityLoans.Name = "btnMaturityLoans";
            this.btnMaturityLoans.Size = new System.Drawing.Size(75, 23);
            this.btnMaturityLoans.TabIndex = 2;
            this.btnMaturityLoans.Text = "Maturity Loans";
            this.btnMaturityLoans.UseVisualStyleBackColor = true;
            // 
            // btnAccruedIntrrest
            // 
            this.btnAccruedIntrrest.Location = new System.Drawing.Point(106, 13);
            this.btnAccruedIntrrest.Name = "btnAccruedIntrrest";
            this.btnAccruedIntrrest.Size = new System.Drawing.Size(98, 23);
            this.btnAccruedIntrrest.TabIndex = 1;
            this.btnAccruedIntrrest.Text = "Accrued Intrrest";
            this.btnAccruedIntrrest.UseVisualStyleBackColor = true;
            this.btnAccruedIntrrest.Click += new System.EventHandler(this.btnAccruedIntrrest_Click);
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(24, 12);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(75, 23);
            this.btnOption.TabIndex = 0;
            this.btnOption.Text = "Option";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 186);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 458);
            this.crystalReportViewer1.TabIndex = 5;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(127, 46);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(104, 20);
            this.fromDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From Date";
            // 
            // frm_Accrued_Interest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Accrued_Interest";
            this.Text = "frm_Accrued_Interest";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDate;
        private MyControls.UC_Acc txtBank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMaturityLoans;
        private System.Windows.Forms.Button btnAccruedIntrrest;
        private System.Windows.Forms.Button btnOption;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromDate;
    }
}