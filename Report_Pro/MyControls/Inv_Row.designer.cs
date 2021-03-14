namespace Report_Pro.MyControls
{
    partial class Inv_Row
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inv_Row));
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Weight = new DevComponents.Editors.DoubleInput();
            this.Qty = new DevComponents.Editors.DoubleInput();
            this.TotalWeight = new DevComponents.Editors.DoubleInput();
            this.Balance = new DevComponents.Editors.DoubleInput();
            this.Ser = new DevComponents.Editors.IntegerInput();
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Price_ton = new DevComponents.Editors.DoubleInput();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.TxtDisc = new DevComponents.Editors.DoubleInput();
            this.txt_subTOt = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.VatValue = new System.Windows.Forms.TextBox();
            this.Txtvalue = new System.Windows.Forms.TextBox();
            this.VatRate = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.ComboBox();
            this.Price = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_ton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            this.ID.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ID.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.ID.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ID.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ID.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ID.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.TabStop = false;
            this.ID.DoubleClick += new System.EventHandler(this.ID_DoubleClick);
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            // 
            // Weight
            // 
            // 
            // 
            // 
            this.Weight.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Weight.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Weight.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Weight.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Weight.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Weight.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Weight.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Weight.Increment = 1D;
            resources.ApplyResources(this.Weight, "Weight");
            this.Weight.Name = "Weight";
            this.Weight.TabStop = false;
            // 
            // Qty
            // 
            this.Qty.BackColor = System.Drawing.Color.MistyRose;
            // 
            // 
            // 
            this.Qty.BackgroundStyle.BackColor = System.Drawing.Color.LightYellow;
            this.Qty.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Qty.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Qty.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Qty.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Qty.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Qty.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Qty.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Qty.Increment = 1D;
            resources.ApplyResources(this.Qty, "Qty");
            this.Qty.Name = "Qty";
            this.Qty.TabStop = false;
            this.Qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Qty_KeyDown);
            this.Qty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Qty_KeyUp);
            // 
            // TotalWeight
            // 
            // 
            // 
            // 
            this.TotalWeight.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TotalWeight.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.TotalWeight.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TotalWeight.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TotalWeight.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TotalWeight.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TotalWeight.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TotalWeight.Increment = 1D;
            resources.ApplyResources(this.TotalWeight, "TotalWeight");
            this.TotalWeight.Name = "TotalWeight";
            this.TotalWeight.TabStop = false;
            // 
            // Balance
            // 
            // 
            // 
            // 
            this.Balance.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Balance.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Balance.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Balance.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Balance.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Balance.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Balance.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Balance.Increment = 1D;
            resources.ApplyResources(this.Balance, "Balance");
            this.Balance.Name = "Balance";
            this.Balance.TabStop = false;
            // 
            // Ser
            // 
            this.Ser.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.Ser.BackgroundStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.Ser.BackgroundStyle.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.Ser.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Ser.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Ser.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Ser.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Ser.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Ser.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Ser.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            resources.ApplyResources(this.Ser, "Ser");
            this.Ser.ForeColor = System.Drawing.Color.White;
            this.Ser.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.Ser.Name = "Ser";
            this.Ser.TabStop = false;
            // 
            // Desc
            // 
            // 
            // 
            // 
            this.Desc.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Desc.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Desc.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Desc.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Desc.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Desc.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.Desc, "Desc");
            this.Desc.Name = "Desc";
            this.Desc.TabStop = false;
            // 
            // Price_ton
            // 
            // 
            // 
            // 
            this.Price_ton.BackgroundStyle.BackColor = System.Drawing.SystemColors.Info;
            this.Price_ton.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Price_ton.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Price_ton.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Price_ton.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Price_ton.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Price_ton.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Price_ton.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Price_ton.DisplayFormat = "#,##0";
            this.Price_ton.Increment = 1D;
            resources.ApplyResources(this.Price_ton, "Price_ton");
            this.Price_ton.Name = "Price_ton";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txtNote, "txtNote");
            this.txtNote.Name = "txtNote";
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNote_KeyDown);
            // 
            // TxtDisc
            // 
            // 
            // 
            // 
            this.TxtDisc.BackgroundStyle.BackColor = System.Drawing.SystemColors.Info;
            this.TxtDisc.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDisc.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtDisc.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDisc.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDisc.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDisc.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtDisc.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtDisc.Increment = 1D;
            resources.ApplyResources(this.TxtDisc, "TxtDisc");
            this.TxtDisc.Name = "TxtDisc";
            // 
            // txt_subTOt
            // 
            this.txt_subTOt.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txt_subTOt, "txt_subTOt");
            this.txt_subTOt.Name = "txt_subTOt";
            this.txt_subTOt.ReadOnly = true;
            this.txt_subTOt.TabStop = false;
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txtCost, "txtCost");
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.TabStop = false;
            // 
            // VatValue
            // 
            this.VatValue.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.VatValue, "VatValue");
            this.VatValue.Name = "VatValue";
            this.VatValue.ReadOnly = true;
            this.VatValue.TabStop = false;
            // 
            // Txtvalue
            // 
            this.Txtvalue.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.Txtvalue, "Txtvalue");
            this.Txtvalue.Name = "Txtvalue";
            this.Txtvalue.ReadOnly = true;
            this.Txtvalue.TabStop = false;
            // 
            // VatRate
            // 
            this.VatRate.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.VatRate, "VatRate");
            this.VatRate.Name = "VatRate";
            this.VatRate.ReadOnly = true;
            this.VatRate.TabStop = false;
            // 
            // txtUnit
            // 
            this.txtUnit.FormattingEnabled = true;
            resources.ApplyResources(this.txtUnit, "txtUnit");
            this.txtUnit.Name = "txtUnit";
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.MistyRose;
            // 
            // 
            // 
            this.Price.BackgroundStyle.BackColor = System.Drawing.Color.LightYellow;
            this.Price.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Price.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Price.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Price.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Price.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Price.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Price.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Price.Increment = 1D;
            resources.ApplyResources(this.Price, "Price");
            this.Price.Name = "Price";
            this.Price.TabStop = false;
            this.Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Price_KeyDown);
            this.Price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Price_KeyUp);
            // 
            // Inv_Row
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.Price_ton);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.TxtDisc);
            this.Controls.Add(this.txt_subTOt);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.VatValue);
            this.Controls.Add(this.Txtvalue);
            this.Controls.Add(this.VatRate);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.Ser);
            this.Controls.Add(this.TotalWeight);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.ID);
            this.Name = "Inv_Row";
            this.Load += new System.EventHandler(this.Inv_Row_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Inv_Row_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_ton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
        public DevComponents.Editors.DoubleInput Weight;
        public DevComponents.Editors.DoubleInput Qty;
        public DevComponents.Editors.DoubleInput TotalWeight;
        public DevComponents.Editors.DoubleInput Balance;
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        public DevComponents.Editors.IntegerInput Ser;
        private DevComponents.Editors.DoubleInput Price_ton;
        private System.Windows.Forms.TextBox txtNote;
        private DevComponents.Editors.DoubleInput TxtDisc;
        private System.Windows.Forms.TextBox txt_subTOt;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox VatValue;
        private System.Windows.Forms.TextBox Txtvalue;
        private System.Windows.Forms.TextBox VatRate;
        private System.Windows.Forms.ComboBox txtUnit;
        public DevComponents.Editors.DoubleInput Price;
    }
}
