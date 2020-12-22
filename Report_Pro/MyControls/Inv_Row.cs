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
            get_desc();
        }

        private void get_desc()
        {
            try
            {
                Unit.Text = "";
                DataTable dt_ = dal.getDataTabl_1("SELECT item_no,descr,Descr_eng,isnull(Weight,0) as Weight,Unit,isnull(sale_price,0) as sale_price FROM wh_main_master where item_no = '" + ID.Text + "' or factory_no= '" + ID.Text + "' ");
                if (ID.Text!="" && dt_.Rows.Count > 0)
                {
                    

                    ID.Text= dt_.Rows[0]["item_no"].ToString();
                    Weight.Value = Convert.ToDouble(dt_.Rows[0]["Weight"].ToString());
                
                    Unit.SelectedText = dt_.Rows[0]["Unit"].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["descr"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["Descr_eng"].ToString();
                    }
                }
                else
                {

                    Desc.Clear();
                    Weight.Value = 0;
                  
                    Unit.SelectedIndex=-1;

                }
            }

            catch { }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OnClick(e);

        }

       
       

      

       
      

        private void ID_TextChanged(object sender, EventArgs e)
        {
            //get_desc();
            //OnLoad(e);

        }

     

       

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_DoubleClick(object sender, EventArgs e)
        {
           OnDoubleClick(e);
        }

        private void Inv_Row_Load(object sender, EventArgs e)
        {
            Unit.DataSource = dal.getDataTabl_1("select * from " + dal.db1 + ".dbo.wh_unit");
            Unit.DisplayMember = "Wh_Unit";
            Unit.ValueMember = "Wh_Unit";
            Unit.SelectedIndex = -1;

        }
    }
}
