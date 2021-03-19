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
            this.Ser = new DevComponents.Editors.IntegerInput();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.VatValue = new System.Windows.Forms.TextBox();
            this.VatRate = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.Price_ton = new DevComponents.Editors.DoubleInput();
            this.Weight_ = new DevComponents.Editors.DoubleInput();
            this.TxtPrice = new DevComponents.Editors.DoubleInput();
            this.TxtDisc = new DevComponents.Editors.DoubleInput();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_subTOt = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.Txtvalue = new System.Windows.Forms.TextBox();
            this.KM_TYPE_ITEMS = new System.Windows.Forms.TextBox();
            this.qty = new DevComponents.Editors.DoubleInput();
            this.totWeight = new DevComponents.Editors.DoubleInput();
            this.VatAccRate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_ton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totWeight)).BeginInit();
            this.SuspendLayout();
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
            this.Ser.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Ser.BackgroundStyle.TextColor = System.Drawing.SystemColors.Window;
            this.Ser.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Ser.ForeColor = System.Drawing.Color.White;
            this.Ser.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            resources.ApplyResources(this.Ser, "Ser");
            this.Ser.Name = "Ser";
            this.Ser.TabStop = false;
            // 
            // txtNote
            // 
            resources.ApplyResources(this.txtNote, "txtNote");
            this.txtNote.Name = "txtNote";
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNote_KeyDown);
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
            this.txtUnit.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txtUnit, "txtUnit");
            this.txtUnit.Name = "txtUnit";
            // 
            // Price_ton
            // 
            // 
            // 
            // 
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
            this.Price_ton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Price_ton_KeyDown);
            this.Price_ton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Price_ton_KeyUp);
            // 
            // Weight_
            // 
            this.Weight_.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.Weight_.BackgroundStyle.BackColor = System.Drawing.SystemColors.Info;
            this.Weight_.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.Info;
            this.Weight_.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Weight_.BackgroundStyle.Class = "TextBoxBorder";
            this.Weight_.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Weight_.Increment = 1D;
            resources.ApplyResources(this.Weight_, "Weight_");
            this.Weight_.Name = "Weight_";
            // 
            // TxtPrice
            // 
            // 
            // 
            // 
            this.TxtPrice.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtPrice.BackgroundStyle.Class = "TextBoxBorder";
            this.TxtPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtPrice.DisplayFormat = "#,##0.0000 ";
            this.TxtPrice.Increment = 1D;
            resources.ApplyResources(this.TxtPrice, "TxtPrice");
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPrice_KeyDown);
            this.TxtPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPrice_KeyUp);
            // 
            // TxtDisc
            // 
            // 
            // 
            // 
            this.TxtDisc.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDisc.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtDisc.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDisc.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDisc.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.TxtDisc.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtDisc.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtDisc.DisplayFormat = "#,##0 ";
            this.TxtDisc.Increment = 1D;
            resources.ApplyResources(this.TxtDisc, "TxtDisc");
            this.TxtDisc.Name = "TxtDisc";
            this.TxtDisc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDisc_KeyDown);
            // 
            // TxtDesc
            // 
            this.TxtDesc.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.TxtDesc, "TxtDesc");
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.ReadOnly = true;
            this.TxtDesc.TabStop = false;
            // 
            // txt_Code
            // 
            resources.ApplyResources(this.txt_Code, "txt_Code");
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.DoubleClick += new System.EventHandler(this.txt_Code_DoubleClick);
            this.txt_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Code_KeyDown);
            // 
            // txt_subTOt
            // 
            this.txt_subTOt.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txt_subTOt, "txt_subTOt");
            this.txt_subTOt.Name = "txt_subTOt";
            this.txt_subTOt.ReadOnly = true;
            this.txt_subTOt.TabStop = false;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txtBalance, "txtBalance");
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.TabStop = false;
            // 
            // Txtvalue
            // 
            this.Txtvalue.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.Txtvalue, "Txtvalue");
            this.Txtvalue.Name = "Txtvalue";
            this.Txtvalue.ReadOnly = true;
            this.Txtvalue.TabStop = false;
            // 
            // KM_TYPE_ITEMS
            // 
            this.KM_TYPE_ITEMS.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.KM_TYPE_ITEMS, "KM_TYPE_ITEMS");
            this.KM_TYPE_ITEMS.Name = "KM_TYPE_ITEMS";
            this.KM_TYPE_ITEMS.ReadOnly = true;
            this.KM_TYPE_ITEMS.TabStop = false;
            // 
            // qty
            // 
            // 
            // 
            // 
            this.qty.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.qty.BackgroundStyle.Class = "TextBoxBorder";
            this.qty.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.qty.DisplayFormat = "#,##0 ";
            this.qty.Increment = 1D;
            resources.ApplyResources(this.qty, "qty");
            this.qty.Name = "qty";
            this.qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Qty_KeyDown);
            this.qty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Qty_KeyUp);
            // 
            // totWeight
            // 
            // 
            // 
            // 
            this.totWeight.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.totWeight.BackgroundStyle.Class = "TextBoxBorder";
            this.totWeight.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.totWeight.Increment = 1D;
            resources.ApplyResources(this.totWeight, "totWeight");
            this.totWeight.Name = "totWeight";
            this.totWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.totWeight_KeyDown);
            this.totWeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.totWeight_KeyUp);
            // 
            // VatAccRate
            // 
            this.VatAccRate.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.VatAccRate, "VatAccRate");
            this.VatAccRate.Name = "VatAccRate";
            this.VatAccRate.ReadOnly = true;
            this.VatAccRate.TabStop = false;
            // 
            // Inv_Row
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.VatAccRate);
            this.Controls.Add(this.totWeight);
            this.Controls.Add(this.KM_TYPE_ITEMS);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.Price_ton);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.Weight_);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.VatValue);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.VatRate);
            this.Controls.Add(this.Ser);
            this.Controls.Add(this.TxtDisc);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.Txtvalue);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txt_subTOt);
            this.Name = "Inv_Row";
            this.Load += new System.EventHandler(this.Inv_Row_Load);
            this.Enter += new System.EventHandler(this.Inv_Row_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.Ser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_ton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevComponents.Editors.IntegerInput Ser;
        public System.Windows.Forms.TextBox txt_Code;
        public System.Windows.Forms.TextBox txtNote;
        public System.Windows.Forms.TextBox txtCost;
        public System.Windows.Forms.TextBox VatValue;
        public System.Windows.Forms.TextBox VatRate;
        public System.Windows.Forms.TextBox txtUnit;
        public DevComponents.Editors.DoubleInput Price_ton;
        public DevComponents.Editors.DoubleInput Weight_;
        public DevComponents.Editors.DoubleInput TxtPrice;
        public DevComponents.Editors.DoubleInput TxtDisc;
        public System.Windows.Forms.TextBox TxtDesc;
        public System.Windows.Forms.TextBox txt_subTOt;
        public System.Windows.Forms.TextBox txtBalance;
        public System.Windows.Forms.TextBox Txtvalue;
        public System.Windows.Forms.TextBox KM_TYPE_ITEMS;
        public DevComponents.Editors.DoubleInput qty;
        public DevComponents.Editors.DoubleInput totWeight;
        public System.Windows.Forms.TextBox VatAccRate;
    }
}
