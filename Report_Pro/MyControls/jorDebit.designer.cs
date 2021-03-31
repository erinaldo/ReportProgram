namespace Report_Pro.MyControls
{
    partial class jorDebit
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtDebitTotal = new DevComponents.Editors.DoubleInput();
            this.jorHead1 = new Report_Pro.MyControls.JorHead();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 34);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1303, 556);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(874, 594);
            this.labelX2.Margin = new System.Windows.Forms.Padding(0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(125, 22);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "اجمالي المدين";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtDebitTotal
            // 
            // 
            // 
            // 
            this.txtDebitTotal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDebitTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtDebitTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebitTotal.Increment = 1D;
            this.txtDebitTotal.Location = new System.Drawing.Point(1002, 594);
            this.txtDebitTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtDebitTotal.Name = "txtDebitTotal";
            this.txtDebitTotal.Size = new System.Drawing.Size(125, 22);
            this.txtDebitTotal.TabIndex = 3;
            // 
            // jorHead1
            // 
            this.jorHead1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.jorHead1.Location = new System.Drawing.Point(3, 8);
            this.jorHead1.Margin = new System.Windows.Forms.Padding(0);
            this.jorHead1.Name = "jorHead1";
            this.jorHead1.Size = new System.Drawing.Size(1157, 24);
            this.jorHead1.TabIndex = 1;
            // 
            // jorDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDebitTotal);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.jorHead1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "jorDebit";
            this.Size = new System.Drawing.Size(1312, 628);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jorDebit_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.jorDebit_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private JorHead jorHead1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DoubleInput txtDebitTotal;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
