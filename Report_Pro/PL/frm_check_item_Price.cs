using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
   
    public partial class frm_check_item_Price : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        int days = 1;

        DataTable dt_;
        DataTable dt_1 =  new DataTable();
        DataTable dt = new DataTable();
        string db1 = Properties.Settings.Default.Database_1;
        public frm_check_item_Price()
        {
            InitializeComponent();
          
        }

      

        void total_()
        {
            days = Convert.ToInt32((ToDate.Value - FromDate.Value).TotalDays);


            txtBalance.Text =
            (from DataGridViewRow row in DGV_b.Rows
            where row.Cells[0].FormattedValue.ToString() != string.Empty
            select (row.Cells[1].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            txtBalance_weight.Text =
            (from DataGridViewRow row in DGV_b.Rows
            where row.Cells[0].FormattedValue.ToString() != string.Empty
            select (row.Cells[2].FormattedValue).ToString().ToDecimal()).Sum().ToString();


            totalSales.Text =
            (from DataGridViewRow row in DGV_b.Rows
            where row.Cells[0].FormattedValue.ToString() != string.Empty
            select (row.Cells[3].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            totalSales_weight.Text = (totalSales.Text.ToDecimal() * txtWeight.Text.ToDecimal()).ToString("N0");

            if (totalSales.Value > 0)
            {
                Monthely_Sales.Value = Math.Round(totalSales.Value * 30 / days,0);
                balance_period.Value = Math.Round(txtBalance.Value / Monthely_Sales.Value,2);
            }
            else
            {
                Monthely_Sales.Value = 0;
                balance_period.Value = 0;

            }
            if (totalSales_weight.Value > 0)
            {
                Monthely_Sales_weight.Value = Math.Round(totalSales_weight.Value * 30 / days, 0);
            }
            else
            {
                Monthely_Sales_weight.Value = 0;

            }

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void unit_price_KeyUp(object sender, KeyEventArgs e)
        {
            ton_price.Value = unit_price.Value / txtWeight.Value*1000;

            if (unit_price.Value > txtCost_1.Value)
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Ok_icon1;
            }
            else
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Cross_icon;

            }

        }

        private void ton_price_KeyUp(object sender, KeyEventArgs e)
        {
            unit_price.Value = ton_price.Value * txtWeight.Value / 1000;
            if (unit_price.Value > txtCost_1.Value)
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Ok_icon1;
            }
            else
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Cross_icon;

            }
        }

      

        private void mRrate_KeyUp_1(object sender, KeyEventArgs e)
        {
            txtCost_1.Value = txtCost.Value* (1 + mRrate.Value / 100);
            txtTonCost_1.Value = txtTonCost.Value* (1 + mRrate.Value / 100);
            if (unit_price.Value > txtCost_1.Value)
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Ok_icon1;
            }
            else
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Cross_icon;

            }
        }

        private void Uc_Items_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        { 
                dt_ = dal.getDataTabl_1("SELECT *  FROM wh_main_master where item_no = '"+Uc_Items.ID.Text+"'");
                if (dt_.Rows.Count > 0)
                {
                    txtCost.Value = Convert.ToDouble(dt_.Rows[0][7].ToString());
                    txtLong.Value = Convert.ToDouble(dt_.Rows[0][19].ToString());
                    txtWeight.Value = Convert.ToDouble(dt_.Rows[0][20].ToString());
                    txtThickness.Value = Convert.ToDouble(dt_.Rows[0][21].ToString());
                    txtWeight.Value = Convert.ToDouble(dt_.Rows[0][22].ToString());
                    txtTonCost.Value = Convert.ToDouble(dt_.Rows[0][7].ToString()) / txtWeight.Value * 1000;
                    txtCost_1.Value = txtCost.Value * (1 + mRrate.Value / 100);
                    txtTonCost_1.Value = txtTonCost.Value * (1 + mRrate.Value / 100);
                    unit_price.Value = 0;
                    ton_price.Value = 0;

                }
                else
                {
                    txtCost.Value = 0;
                    txtLong.Value = 0;
                    txtWeight.Value = 0;
                    txtThickness.Value = 0;
                    txtWeight.Value = 0;
                    unit_price.Value = 0;
                    ton_price.Value = 0;
                    txtTonCost.Value = 0;


                }
                get_balance();
            get_last_Purch(Uc_Items.ID.Text);
            get_last_Sales(Uc_Items.ID.Text);


        }

        private void get_balance()
        {

            DataTable dt_b = dal.getDataTabl_1(@"select T.Branch_code,t.branch_name,T.balance,X.Sales_ from ( SELECT  D.Branch_code,A.branch_name,sum(D.QTY_BALANCE) as balance
            FROM VIEW_balance As D inner join wh_BRANCHES As A on A.Branch_code = D.Branch_code
            where D.item_no = '"+Uc_Items.ID.Text+"' group by D.Branch_code, A.branch_name) as T " +
            "left join (select Branch_code,SUM(QTY_TAKE-QTY_ADD) as Sales_ " +
            "from wh_material_transaction  where TRANSACTION_CODE like 'xs%'  and cast(G_DATE as date) between '"+ FromDate.Value.ToString("yyyy-MM-dd")+"' and '"+ ToDate.Value.ToString("yyyy-MM-dd")+"'	and item_no = '"+ Uc_Items.ID.Text + "'		group by Branch_code) as X " +
            "on T.Branch_code=X.Branch_code where t.balance <> 0 or X.Sales_<>0 ");
            if (dt_b.Rows.Count > 0)
            {
                
                days =Convert.ToInt32 ((ToDate.Value - FromDate.Value).TotalDays);
                DGV_b.RowCount = dt_b.Rows.Count;

                for (int i = 0; i < DGV_b.RowCount; i++)
                {
                    DGV_b.Rows[i].Cells[0].Value = dt_b.Rows[i]["branch_name"];
                    DGV_b.Rows[i].Cells[1].Value = dt_b.Rows[i]["balance"];
                    DGV_b.Rows[i].Cells[2].Value = Convert.ToDouble(dt_b.Rows[i]["balance"]) * txtWeight.Value;
                    DGV_b.Rows[i].Cells[3].Value = dt_b.Rows[i]["Sales_"].ToString().ToDecimal();
                   
                    DGV_b.Rows[i].Cells[4].Value = Math.Round(dt_b.Rows[i]["Sales_"].ToString().ToDecimal() * 30 / days,0) ;
                    if (dt_b.Rows[i]["Sales_"].ToString().ToDecimal() > 0)
                    {
                        DGV_b.Rows[i].Cells[5].Value = dt_b.Rows[i]["balance"].ToString().ToDecimal() / dt_b.Rows[i]["Sales_"].ToString().ToDecimal() * 30 / days;
                    }
                    else
                    {
                        DGV_b.Rows[i].Cells[5].Value = "-";
                    }
                }
            }
            else
            {
                DGV_b.DataSource = null;
                DGV_b.Rows.Clear();
            }
                                                                    
            total_();


        }
        private void get_last_Purch(string item_no)
        {
            int X = nRow.Value;
            if (X > 0)
            {
                X = nRow.Value;
            }
            else
            {
                X = 1000;
            }
            DataTable dt_LP = dal.getDataTabl_1(" DECLARE  @X int ='" + X + @"' select top (isnull(@X,1000))  A.ser_no,A.G_DATE,A.QTY_ADD,A.Local_Price,P.PAYER_NAME,C.branch_name from wh_material_transaction as A
            inner join wh_inv_data as B on A.SER_NO=B.Ser_no and A.TRANSACTION_CODE=B.TRANSACTION_CODE and a.Branch_code=b.Branch_code and a.Cyear=b.Cyear
            inner join payer2 as P on p.ACC_NO=b.Acc_no and b.Acc_Branch_code=p.BRANCH_code 
            inner join wh_BRANCHES As C on A.Branch_code=C.Branch_code 
            where item_no='" + item_no + "' and (A.TRANSACTION_CODE='Xpc' or A.TRANSACTION_CODE='XpE') order by G_DATE desc");



            if (dt_LP.Rows.Count > 0)
            {

                dgv_LP.RowCount = dt_LP.Rows.Count;

                for (int ii = 0; ii < dgv_LP.RowCount; ii++)
                {
                    dgv_LP.Rows[ii].Cells[0].Value = dt_LP.Rows[ii]["branch_name"].ToString();
                    dgv_LP.Rows[ii].Cells[1].Value = dt_LP.Rows[ii]["ser_no"].ToString();
                    dgv_LP.Rows[ii].Cells[2].Value = dt_LP.Rows[ii]["G_DATE"].ToString();
                    dgv_LP.Rows[ii].Cells[3].Value = dt_LP.Rows[ii]["QTY_ADD"].ToString();
                    dgv_LP.Rows[ii].Cells[4].Value = dt_LP.Rows[ii]["Local_Price"].ToString();

                    if (txtWeight.Value > 0)
                    {
                        dgv_LP.Rows[ii].Cells[5].Value = (Math.Round(dt_LP.Rows[ii]["Local_Price"].ToString().ToDecimal() / txtWeight.Text.ToDecimal() * 1000, 0)).ToString("N0");
                    }
                    else
                    {
                        dgv_LP.Rows[ii].Cells[5].Value = 0;
                    }
                    dgv_LP.Rows[ii].Cells[6].Value = dt_LP.Rows[ii]["PAYER_NAME"].ToString();


                }
            }
            else
            {
                dgv_LP.DataSource = null;
                dgv_LP.Rows.Clear();
            }



        }


        private void get_last_Sales(string item_no)
        {
            int X = nRow.Value;
            if (X > 0)
            {
                X = nRow.Value;
            }
            else
            {
                X = 1000;
            }
            DataTable dt_Ls = dal.getDataTabl_1(" DECLARE  @X int ='" + X + @"' select top (isnull(@X,1000))  A.ser_no,A.G_DATE,A.QTY_TAKE,A.Local_Price,P.PAYER_NAME,C.branch_name,A.Branch_code,a.Cyear, A.TRANSACTION_CODE  from wh_material_transaction as A
            inner join wh_inv_data as B on A.SER_NO=B.Ser_no and A.TRANSACTION_CODE=B.TRANSACTION_CODE and a.Branch_code=b.Branch_code and a.Cyear=b.Cyear
            inner join payer2 as P on p.ACC_NO=b.Acc_no and b.Acc_Branch_code=p.BRANCH_code
            inner join wh_BRANCHES As C on A.Branch_code=C.Branch_code 
            where item_no='" + item_no + "' and (A.TRANSACTION_CODE='XSC' or A.TRANSACTION_CODE='XSD') order by G_DATE desc");



            if (dt_Ls.Rows.Count > 0)
            {

                dgv_LS.RowCount = dt_Ls.Rows.Count;

                for (int ii = 0; ii < dgv_LS.RowCount; ii++)
                {
                    dgv_LS.Rows[ii].Cells[0].Value = dt_Ls.Rows[ii]["branch_name"].ToString();
                    dgv_LS.Rows[ii].Cells[1].Value = dt_Ls.Rows[ii]["ser_no"].ToString();
                    dgv_LS.Rows[ii].Cells[2].Value = dt_Ls.Rows[ii]["G_DATE"].ToString();
                    dgv_LS.Rows[ii].Cells[3].Value = dt_Ls.Rows[ii]["QTY_TAKE"].ToString();
                    dgv_LS.Rows[ii].Cells[4].Value = dt_Ls.Rows[ii]["Local_Price"].ToString();

                    if (txtWeight.Value > 0)
                    {
                        dgv_LS.Rows[ii].Cells[5].Value = (Math.Round(dt_Ls.Rows[ii]["Local_Price"].ToString().ToDecimal() / txtWeight.Text.ToDecimal() * 1000, 0)).ToString("N0");
                    }
                    else
                    {
                        dgv_LS.Rows[ii].Cells[5].Value = 0;
                    }
                    dgv_LS.Rows[ii].Cells[6].Value = dt_Ls.Rows[ii]["PAYER_NAME"].ToString();
                    dgv_LS.Rows[ii].Cells[7].Value = dt_Ls.Rows[ii]["Branch_code"].ToString();
                    dgv_LS.Rows[ii].Cells[8].Value = dt_Ls.Rows[ii]["Cyear"].ToString();
                    dgv_LS.Rows[ii].Cells[9].Value = dt_Ls.Rows[ii]["TRANSACTION_CODE"].ToString();
                }
            }
            else
            {
                dgv_LS.DataSource = null;
                dgv_LS.Rows.Clear();
            }





        }





        private void Uc_Items_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    dt_ = dal.getDataTabl_1("SELECT *  FROM wh_main_master where item_no = '"+ Uc_Items.ID.Text + "'");
                    if (dt_.Rows.Count > 0)
                    {
                        txtCost.Value = Convert.ToDouble(dt_.Rows[0][7].ToString());
                        txtLong.Value = Convert.ToDouble(dt_.Rows[0][19].ToString());
                        txtWeight.Value = Convert.ToDouble(dt_.Rows[0][20].ToString());
                        txtThickness.Value = Convert.ToDouble(dt_.Rows[0][21].ToString());
                        txtWeight.Value = Convert.ToDouble(dt_.Rows[0][22].ToString());
                        txtTonCost.Value = Convert.ToDouble(dt_.Rows[0][7].ToString()) / txtWeight.Value * 1000;
                        txtCost_1.Value = txtCost.Value * (1 + mRrate.Value / 100);
                        txtTonCost_1.Value = txtTonCost.Value * (1 + mRrate.Value / 100);
                        unit_price.Value = 0;
                        ton_price.Value = 0;
                        get_balance();
                    }
                    else
                    {
                        txtCost.Value = 0;
                        txtLong.Value = 0;
                        txtWeight.Value = 0;
                        txtThickness.Value = 0;
                        txtWeight.Value = 0;
                        unit_price.Value = 0;
                        ton_price.Value = 0;
                        txtTonCost.Value = 0;
                        PL.frm_search_items frm = new PL.frm_search_items();
                        frm.ShowDialog();
                        Uc_Items.ID.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                        get_balance();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Uc_Items_Click(object sender, EventArgs e)
        {
            try
            {
                PL.frm_search_items frm = new PL.frm_search_items();
                frm.ShowDialog();
                Uc_Items.ID.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                get_balance();
            }
            catch { }
        }

        private void labelX16_Click(object sender, EventArgs e)
        {

        }

        private void labelX17_Click(object sender, EventArgs e)
        {

        }

        private void frm_check_item_Price_Load(object sender, EventArgs e)
        {
            FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            ToDate.Value = DateTime.Today;
        }

        private void txtTonCost_1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DGV_b_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nRow_ValueChanged(object sender, EventArgs e)
        {
            get_last_Purch(Uc_Items.ID.Text);
            get_last_Sales(Uc_Items.ID.Text);
        }

        private void labelX15_Click(object sender, EventArgs e)
        {

        }

        private void labelX25_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
