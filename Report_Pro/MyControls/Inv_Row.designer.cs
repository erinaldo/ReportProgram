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
            this.Price_ton = new DevComponents.Editors.DoubleInput();
            this.Weight_ = new DevComponents.Editors.DoubleInput();
            this.TxtPrice = new DevComponents.Editors.DoubleInput();
            this.TxtDisc = new DevComponents.Editors.DoubleInput();
            this.qty = new DevComponents.Editors.DoubleInput();
            this.totWeight = new DevComponents.Editors.DoubleInput();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.txt_subTOt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.VatValue = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBalance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCost = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.KM_TYPE_ITEMS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUnit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNote = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Code = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.VatAccRate = new DevComponents.Editors.DoubleInput();
            this.VatRate = new DevComponents.Editors.DoubleInput();
            this.Txtvalue = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.Ser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_ton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VatAccRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VatRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtvalue)).BeginInit();
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
            this.Ser.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
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
            // Price_ton
            // 
            // 
            // 
            // 
            this.Price_ton.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Price_ton.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Price_ton.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.Price_ton.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Price_ton.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Price_ton.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Price_ton.DisplayFormat = "#,##0";
            this.Price_ton.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.Price_ton.FocusHighlightEnabled = true;
            this.Price_ton.Increment = 1D;
            resources.ApplyResources(this.Price_ton, "Price_ton");
            this.Price_ton.Name = "Price_ton";
            this.Price_ton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Price_ton_KeyDown);
            this.Price_ton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Price_ton_KeyUp);
            // 
            // Weight_
            // 
            this.Weight_.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.Weight_.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Weight_.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Weight_.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.Weight_.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Weight_.BackgroundStyle.Class = "TextBoxBorder";
            this.Weight_.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Weight_.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Weight_.DisabledBackColor = System.Drawing.Color.Ivory;
            this.Weight_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.Weight_, "Weight_");
            this.Weight_.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.Weight_.FocusHighlightEnabled = true;
            this.Weight_.Increment = 1D;
            this.Weight_.Name = "Weight_";
            // 
            // TxtPrice
            // 
            this.TxtPrice.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.TxtPrice.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtPrice.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtPrice.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.TxtPrice.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtPrice.BackgroundStyle.Class = "TextBoxBorder";
            this.TxtPrice.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.TxtPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtPrice.DisplayFormat = "#,##0.0000 ";
            this.TxtPrice.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.TxtPrice.FocusHighlightEnabled = true;
            this.TxtPrice.Increment = 1D;
            resources.ApplyResources(this.TxtPrice, "TxtPrice");
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPrice_KeyDown);
            this.TxtPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPrice_KeyUp);
            // 
            // TxtDisc
            // 
            this.TxtDisc.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.TxtDisc.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtDisc.BackgroundStyle.Class = "DateTimeInputBackground";
            this.TxtDisc.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.TxtDisc.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.TxtDisc.DisplayFormat = "#,##0 ";
            this.TxtDisc.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.TxtDisc.FocusHighlightEnabled = true;
            this.TxtDisc.Increment = 1D;
            resources.ApplyResources(this.TxtDisc, "TxtDisc");
            this.TxtDisc.Name = "TxtDisc";
            this.TxtDisc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDisc_KeyDown);
            // 
            // qty
            // 
            this.qty.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.qty.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.qty.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.qty.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.qty.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.qty.BackgroundStyle.Class = "TextBoxBorder";
            this.qty.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.qty.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.qty.DisplayFormat = "#,##0 ";
            this.qty.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.qty.FocusHighlightEnabled = true;
            this.qty.Increment = 1D;
            resources.ApplyResources(this.qty, "qty");
            this.qty.Name = "qty";
            this.qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Qty_KeyDown);
            this.qty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Qty_KeyUp);
            // 
            // totWeight
            // 
            this.totWeight.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.totWeight.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.totWeight.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.totWeight.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.totWeight.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.totWeight.BackgroundStyle.Class = "TextBoxBorder";
            this.totWeight.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.totWeight.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.totWeight.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.totWeight.FocusHighlightEnabled = true;
            this.totWeight.Increment = 1D;
            resources.ApplyResources(this.totWeight, "totWeight");
            this.totWeight.Name = "totWeight";
            this.totWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.totWeight_KeyDown);
            this.totWeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.totWeight_KeyUp);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = global::Report_Pro.Properties.Resources.Cross_icon1;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txt_subTOt
            // 
            this.txt_subTOt.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.txt_subTOt.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_subTOt.Border.Class = "TextBoxBorder";
            this.txt_subTOt.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txt_subTOt.FocusHighlightEnabled = true;
            resources.ApplyResources(this.txt_subTOt, "txt_subTOt");
            this.txt_subTOt.Name = "txt_subTOt";
            this.txt_subTOt.ReadOnly = true;
            // 
            // VatValue
            // 
            this.VatValue.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.VatValue.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.VatValue.Border.Class = "TextBoxBorder";
            this.VatValue.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.VatValue.FocusHighlightEnabled = true;
            resources.ApplyResources(this.VatValue, "VatValue");
            this.VatValue.Name = "VatValue";
            this.VatValue.ReadOnly = true;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtBalance.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBalance.Border.Class = "TextBoxBorder";
            this.txtBalance.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtBalance.FocusHighlightEnabled = true;
            resources.ApplyResources(this.txtBalance, "txtBalance");
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.txtCost.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtCost.Border.Class = "TextBoxBorder";
            this.txtCost.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtCost.FocusHighlightEnabled = true;
            resources.ApplyResources(this.txtCost, "txtCost");
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            // 
            // KM_TYPE_ITEMS
            // 
            this.KM_TYPE_ITEMS.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.KM_TYPE_ITEMS.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.KM_TYPE_ITEMS.Border.Class = "TextBoxBorder";
            this.KM_TYPE_ITEMS.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.KM_TYPE_ITEMS.FocusHighlightEnabled = true;
            resources.ApplyResources(this.KM_TYPE_ITEMS, "KM_TYPE_ITEMS");
            this.KM_TYPE_ITEMS.Name = "KM_TYPE_ITEMS";
            this.KM_TYPE_ITEMS.ReadOnly = true;
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.txtUnit.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUnit.Border.Class = "TextBoxBorder";
            this.txtUnit.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtUnit.FocusHighlightEnabled = true;
            resources.ApplyResources(this.txtUnit, "txtUnit");
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            // 
            // txtNote
            // 
            // 
            // 
            // 
            this.txtNote.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtNote.Border.Class = "TextBoxBorder";
            this.txtNote.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txtNote.FocusHighlightEnabled = true;
            resources.ApplyResources(this.txtNote, "txtNote");
            this.txtNote.Name = "txtNote";
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNote_KeyDown);
            // 
            // TxtDesc
            // 
            this.TxtDesc.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.TxtDesc.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtDesc.Border.BorderRightColor = System.Drawing.SystemColors.Window;
            this.TxtDesc.Border.Class = "TextBoxBorder";
            this.TxtDesc.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.TxtDesc.FocusHighlightEnabled = true;
            resources.ApplyResources(this.TxtDesc, "TxtDesc");
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.ReadOnly = true;
            // 
            // txt_Code
            // 
            // 
            // 
            // 
            this.txt_Code.Border.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Code.Border.Class = "TextBoxBorder";
            this.txt_Code.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.txt_Code.FocusHighlightEnabled = true;
            resources.ApplyResources(this.txt_Code, "txt_Code");
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.DoubleClick += new System.EventHandler(this.txt_Code_DoubleClick);
            this.txt_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Code_KeyDown);
            // 
            // VatAccRate
            // 
            this.VatAccRate.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.VatAccRate.BackgroundStyle.BackColor = System.Drawing.Color.Ivory;
            this.VatAccRate.BackgroundStyle.BackColor2 = System.Drawing.Color.Ivory;
            this.VatAccRate.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VatAccRate.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.VatAccRate.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.VatAccRate.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VatAccRate.BackgroundStyle.Class = "TextBoxBorder";
            this.VatAccRate.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.VatAccRate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.VatAccRate.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.VatAccRate.FocusHighlightEnabled = true;
            this.VatAccRate.Increment = 1D;
            resources.ApplyResources(this.VatAccRate, "VatAccRate");
            this.VatAccRate.Name = "VatAccRate";
            // 
            // VatRate
            // 
            this.VatRate.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.VatRate.BackgroundStyle.BackColor = System.Drawing.Color.Ivory;
            this.VatRate.BackgroundStyle.BackColor2 = System.Drawing.Color.Ivory;
            this.VatRate.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VatRate.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.VatRate.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.VatRate.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VatRate.BackgroundStyle.Class = "TextBoxBorder";
            this.VatRate.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.VatRate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.VatRate.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.VatRate.FocusHighlightEnabled = true;
            this.VatRate.Increment = 1D;
            resources.ApplyResources(this.VatRate, "VatRate");
            this.VatRate.Name = "VatRate";
            // 
            // Txtvalue
            // 
            this.Txtvalue.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.Txtvalue.BackgroundStyle.BackColor = System.Drawing.Color.Ivory;
            this.Txtvalue.BackgroundStyle.BackColor2 = System.Drawing.Color.Ivory;
            this.Txtvalue.BackgroundStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Txtvalue.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Txtvalue.BackgroundStyle.BorderRightColor = System.Drawing.SystemColors.Highlight;
            this.Txtvalue.BackgroundStyle.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Txtvalue.BackgroundStyle.Class = "TextBoxBorder";
            this.Txtvalue.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Txtvalue.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Txtvalue.DisplayFormat = "#,##0 ";
            this.Txtvalue.FocusHighlightColor = System.Drawing.Color.Yellow;
            this.Txtvalue.FocusHighlightEnabled = true;
            this.Txtvalue.Increment = 1D;
            resources.ApplyResources(this.Txtvalue, "Txtvalue");
            this.Txtvalue.Name = "Txtvalue";
            // 
            // Inv_Row
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Txtvalue);
            this.Controls.Add(this.VatRate);
            this.Controls.Add(this.VatAccRate);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.KM_TYPE_ITEMS);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.VatValue);
            this.Controls.Add(this.txt_subTOt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.totWeight);
            this.Controls.Add(this.Price_ton);
            this.Controls.Add(this.Weight_);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.Ser);
            this.Controls.Add(this.TxtDisc);
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
            ((System.ComponentModel.ISupportInitialize)(this.VatAccRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VatRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtvalue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevComponents.Editors.IntegerInput Ser;
        public DevComponents.Editors.DoubleInput Price_ton;
        public DevComponents.Editors.DoubleInput Weight_;
        public DevComponents.Editors.DoubleInput TxtPrice;
        public DevComponents.Editors.DoubleInput TxtDisc;
        public DevComponents.Editors.DoubleInput qty;
        public DevComponents.Editors.DoubleInput totWeight;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_subTOt;
        public DevComponents.DotNetBar.Controls.TextBoxX VatValue;
        public DevComponents.DotNetBar.Controls.TextBoxX txtBalance;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCost;
        public DevComponents.DotNetBar.Controls.TextBoxX KM_TYPE_ITEMS;
        public DevComponents.DotNetBar.Controls.TextBoxX txtUnit;
        public DevComponents.DotNetBar.Controls.TextBoxX txtNote;
        public DevComponents.DotNetBar.Controls.TextBoxX TxtDesc;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_Code;
        public DevComponents.Editors.DoubleInput VatAccRate;
        public DevComponents.Editors.DoubleInput VatRate;
        public DevComponents.Editors.DoubleInput Txtvalue;
    }
}
