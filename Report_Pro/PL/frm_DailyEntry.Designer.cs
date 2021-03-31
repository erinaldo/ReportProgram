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
            this.jorDebit1 = new Report_Pro.MyControls.jorDebit();
            this.SuspendLayout();
            // 
            // jorDebit1
            // 
            this.jorDebit1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.jorDebit1.Location = new System.Drawing.Point(1, 11);
            this.jorDebit1.Margin = new System.Windows.Forms.Padding(2);
            this.jorDebit1.Name = "jorDebit1";
            this.jorDebit1.Size = new System.Drawing.Size(1312, 638);
            this.jorDebit1.TabIndex = 0;
            // 
            // frm_DailyEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 660);
            this.Controls.Add(this.jorDebit1);
            this.Name = "frm_DailyEntry";
            this.Text = "frm_DailyEntry";
            this.Load += new System.EventHandler(this.frm_DailyEntry_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.jorDebit jorDebit1;
    }
}