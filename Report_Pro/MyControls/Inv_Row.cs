using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class Inv_Row : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Inv_Row()
        {
            InitializeComponent();
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
           // get_desc();
        }

        private void get_desc()
        {
            try
            {
                txtUnit.Text = "";
                DataTable dt_ = dal.getDataTabl_1("SELECT item_no,descr,Descr_eng,isnull(Weight,0) as Weight,Unit,isnull(sale_price,0) as sale_price FROM wh_main_master where item_no = '" + ID.Text + "' or factory_no= '" + ID.Text + "' ");
                if (ID.Text!="" && dt_.Rows.Count > 0)
                {
                    

                    ID.Text= dt_.Rows[0]["item_no"].ToString();
                    Weight.Value = Convert.ToDouble(dt_.Rows[0]["Weight"].ToString());

                    txtUnit.SelectedText = dt_.Rows[0]["Unit"].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["descr"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["Descr_eng"].ToString();
                    }
                    txtNote.Focus();
                }
                else
                {

                    Desc.Clear();
                    Weight.Value = 0;
                    txtUnit.SelectedIndex=-1;
                   
                }
                clculat_amount();
        }

            catch { }
        }

    
      

        private void ID_TextChanged(object sender, EventArgs e)
        {
            //get_desc();
            //OnLoad(e);

        }

     

       

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                get_desc();
                
            }
            //else
            //{
            //    ID.Focus();
            //    ID.SelectAll();
            //}
           
        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_DoubleClick(object sender, EventArgs e)
        {
           //OnDoubleClick(e);
        }

        private void Inv_Row_Load(object sender, EventArgs e)
        {
            //txtUnit.DataSource = dal.getDataTabl_1("select * from wh_unit");
            //txtUnit.DisplayMember = "Wh_Unit";
            //txtUnit.ValueMember = "Wh_Unit";
            //txtUnit.SelectedIndex = -1;

        }

        private void Price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Price.Value > 0)
            {
                OnKeyDown(e);

            }
            
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            get_desc();
        }

        void clculat_amount()
        {
            try
            {
               txt_subTOt.Text = (Qty.Text.ToDecimal() * Price.Text.ToDecimal()).ToString("N" + dal.digits_);
               // Txtvalue.Text = (TxtQty.Text.ToDecimal() * TxtPrice.Text.ToDecimal() - TxtDisc.Text.ToDecimal()).ToString("N" + dal.digits_);
                //VatValue.Text = (Txtvalue.Text.ToDecimal() * VatRate.Text.ToDecimal()).ToString("N" + dal.digits_);
               TotalWeight.Text = (Qty.Text.ToDecimal() * Weight.Text.ToDecimal()).ToString("N3");
            }
            catch
            {
                return;
            }
        }

        private void Qty_KeyUp(object sender, KeyEventArgs e)
        {
            clculat_amount();
        }

        private void Price_KeyUp(object sender, KeyEventArgs e)
        {
            clculat_amount();
        }

        private void Inv_Row_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Qty.Focus();

            }
        }

        private void Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Qty.Value>0)
            {
                Price.Focus();

            }
        }
    }
}
