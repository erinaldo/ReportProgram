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
            this.Desc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.itemPrice = new DevComponents.Editors.DoubleInput();
            this.Weight = new DevComponents.Editors.DoubleInput();
            this.Unit = new System.Windows.Forms.ComboBox();
            this.Qty = new DevComponents.Editors.DoubleInput();
            this.doubleInput1 = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.itemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput1)).BeginInit();
            this.SuspendLayout();
            // 
            // Desc
            // 
            // 
            // 
            // 
            this.Desc.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Desc.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Desc.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Desc.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Desc.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Desc.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.Desc, "Desc");
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.TextChanged += new System.EventHandler(this.Desc_TextChanged);
            // 
            // btn1
            // 
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn1.Image = global::Report_Pro.Properties.Resources.search_16;
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.Name = "btn1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // ID
            // 
            // 
            // 
            // 
            this.ID.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ID.Border.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ID.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ID.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ID.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ID.Border.Class = "TextBoxBorder";
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
            this.ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ID_KeyUp);
            // 
            // itemPrice
            // 
            // 
            // 
            // 
            this.itemPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itemPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.itemPrice.Increment = 1D;
            resources.ApplyResources(this.itemPrice, "itemPrice");
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ShowUpDown = true;
            // 
            // Weight
            // 
            // 
            // 
            // 
            this.Weight.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Weight.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Weight.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Weight.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Weight.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Weight.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Weight.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Weight.Increment = 1D;
            resources.ApplyResources(this.Weight, "Weight");
            this.Weight.Name = "Weight";
            // 
            // Unit
            // 
            this.Unit.FormattingEnabled = true;
            resources.ApplyResources(this.Unit, "Unit");
            this.Unit.Name = "Unit";
            // 
            // Qty
            // 
            // 
            // 
            // 
            this.doubleInput1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.doubleInput1.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.doubleInput1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.doubleInput1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.doubleInput1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.doubleInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.Qty.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.Qty.Increment = 1D;
            resources.ApplyResources(this.Qty, "Qty");
            this.Qty.Name = "Qty";
            // 
            // doubleInput1
            // 
            // 
            // 
            // 
            this.doubleInput1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.doubleInput1.BackgroundStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.doubleInput1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.doubleInput1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.doubleInput1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.doubleInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.doubleInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.doubleInput1.Increment = 1D;
            resources.ApplyResources(this.doubleInput1, "doubleInput1");
            this.doubleInput1.Name = "doubleInput1";
            // 
            // Inv_Row
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.doubleInput1);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.ID);
            this.Name = "Inv_Row";
            this.Load += new System.EventHandler(this.UC_Catogry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleInput1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevComponents.DotNetBar.Controls.TextBoxX Desc;
        private DevComponents.DotNetBar.ButtonX btn1;
        public DevComponents.DotNetBar.Controls.TextBoxX ID;
        public DevComponents.Editors.DoubleInput itemPrice;
        public DevComponents.Editors.DoubleInput Weight;
        private System.Windows.Forms.ComboBox Unit;
        public DevComponents.Editors.DoubleInput Qty;
        public DevComponents.Editors.DoubleInput doubleInput1;
    }
}
