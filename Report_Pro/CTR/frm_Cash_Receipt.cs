using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.CTR
{
    public partial class frm_Cash_Receipt : Form
    {

        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        int currencyNo = 2;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string searchType;

        public frm_Cash_Receipt()
        {
            InitializeComponent();






            cmb_Pay.DataSource = dal.getDataTabl_1("SELECT * FROM pay_method");
            if (Properties.Settings.Default.lungh == "0")
            {
                cmb_Pay.DisplayMember = "Pay_name";
            }
            else
            {
                cmb_Pay.DisplayMember = "Pay_name_E";
            }
            cmb_Pay.ValueMember = "Pay_ID";
            cmb_Pay.SelectedIndex = -1;

            //cmb_Bank.DataSource = dal.getDataTabl_1("SELECT * FROM SHEEK_BANKS_TYPE");

            //if (Properties.Settings.Default.lungh == "0")
            //{
            //    cmb_Bank.DisplayMember = "BANK_NAME";
            //}
            //else
            //{
            //    cmb_Bank.DisplayMember = "BANK_NAME_E";
            //}
            //cmb_Bank.ValueMember = "BANK_NO";
            //cmb_Bank.SelectedIndex = -1;

            
            
            
            txt_sandDate.Value = DateTime.Today;
            acc_year.Text = "cy";
            Payment_Type.Text = "2";
            user_id.Text = Program.userID;
            txtStore_ID.Text = Properties.Settings.Default.BranchId;
            txt_source_code.Text = "CR";
            txtCashAcc.ID.Text = dal.getDataTabl_1(@"select Cash_acc_no from Wh_branches where branch_code='" + Properties.Settings.Default.BranchId + "' ").Rows[0][0].ToString();
            getJorSer();

          //txtCashAcc.ID.Text = dal.getDataTabl("Get_Branche_data", Properties.Settings.Default.BranchId).Rows[0][14].ToString();
          //txt_sandNo.Text = dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + txtStore_ID.Text
          //          + "' and Cyear= '" + acc_year.Text + "' and doc_Id =  '"+txt_source_code.Text+" '").Rows[0][0].ToString();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeInput1_Click(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_recet_Load(object sender, EventArgs e)
        {
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.s));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Bahrain));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Oman));

            switch (Properties.Settings.Default.Currency)
            {
                case "s":
                    currencyNo = 2;
                    break;
                case "BH":
                    currencyNo = 5;
                    break;
                case "OM":
                    currencyNo = 6;
                    break;
                case "DR":
                    currencyNo = 1;
                    break;
            }

            Acc_Cr.txtFinal.Text = "1";
            Acc_Cr.txtMainAcc.Text = dal.GetCell_1(@"select Costmers_acc_no from wh_BRANCHES where Branch_code= '"+Properties.Settings.Default.BranchId+"' ").ToString();
            txtCashAcc.ID.Text = dal.GetCell_1(@"select Cash_acc_no from wh_BRANCHES where Branch_code= '" + Properties.Settings.Default.BranchId + "' ").ToString();

        }

        private void txtCost_Load(object sender, EventArgs e)
        {

        }

        private void BSave_Click(object sender, EventArgs e)
        {
            
       
            if (paied_amount.Value<=0)
            {
                MessageBox.Show("فضلا.. تاكد من مبلغ السند", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmb_Pay.SelectedIndex < 0)
            {
                MessageBox.Show("فضلا.. تاكد من طريقة السداد", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (Acc_Cr.ID.Text=="")
            {
                MessageBox.Show("فضلا.. تاكد من الحساب ", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCust.Text == "")
            {
                MessageBox.Show("فضلا.. تاكد من اسم العميل ", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtDescr.Text == "")
            {
                MessageBox.Show("فضلا.. تاكد من البيان ", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Add_sands();
            Add_Jor();
            BSave.Enabled = false;
        }
        private void Add_sands()
        {
            txt_sandNo.Text = dal.getDataTabl_1(@"select isnull((BOX_ED_SER)+1,1) from serial_no where Branch_code='" + txtStore_ID.Text
              + "' and ACC_YEAR= '" + acc_year.Text + "' ").Rows[0][0].ToString();


            //txt_sandNo.Text = dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + Properties.Settings.Default.BranchId
            //           + "' and Cyear= '" + acc_year.Text + "' and doc_Id =  'CR'").Rows[0][0].ToString();

            this.AccSer_No.Text = dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + Properties.Settings.Default.BranchId
                 + "' and Cyear= '" + acc_year.Text + "' and doc_Id =  'ENT'").Rows[0][0].ToString();//.PadLeft(4, '0');

            dal.Execute_1(@"Insert into Sands_tbl values( '" + acc_year.Text + "', '" + Acc_Cr.ID.Text + "','"
             + txtStore_ID.Text + "', '" + AccSer_No.Text + "','" + Cost.ID.Text + "',0, '" + paied_amount.Text + "','" + txt_sandDate.Value.Date.ToString("yyyy/MM/dd")
            + "' , '" + txt_sandNo.Text + "','" + Payment_Type.Text + "','" + user_id.Text + "','"+ txtDescr.Text + "', '" + txt_Check.Text + "' ,'" +
            Convert.ToString(cmb_Bank.SelectedValue) + "','" + (Check_Date.Value > Check_Date.MinDate ? Check_Date.Value.Date.ToString("yyyy/MM/dd") : Check_Date.MinDate.Date.ToString("yyyy/MM/dd"))
            + "','" + Convert.ToString(cmb_Pay.SelectedValue) + "','','','"+ txt_source_code.Text+"','" + txtStore_ID.Text 
            + "','','" + txtCashAcc.ID.Text + "','','" + paied_amount.Text + "','"+ txtCust.Text +"','','','','','','','','','','','','','')");

            DataTable dt_= dal.getDataTabl_1("Select * from Serails_tbl where Baranch_ID= '" + txtStore_ID.Text + "' and Cyear='" + acc_year.Text 
                + "' and doc_Id = '" + txt_source_code.Text + "'");
            if (dt_.Rows.Count > 0)
            {

                dal.Execute_1(@"UPDATE Serails_tbl SET last_ser = '" + txt_sandNo.Text + "' WHERE Baranch_ID= '" +
                    txtStore_ID.Text + "' and Cyear='" + acc_year.Text + "' and doc_Id = '" + txt_source_code.Text + "'");
            }

            else
            {
                dal.Execute_1(@"INSERT INTO Serails_tbl  Values ('" + txtStore_ID.Text + "' , '" + acc_year.Text + "' ,  '" + txt_source_code.Text + "','','','" + txt_sandNo.Text + "'");
            }


            MessageBox.Show("تم الحفظ بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

        private void Add_Jor()
        {
            //string cyear = txt_InvDate.Value.Year.ToString();
            string H_Date;
            DataTable dtCurrntdate_ = dal.getDataTabl("convertdate_G", txt_sandDate.Value);
            H_Date = dtCurrntdate_.Rows[0][0].ToString();
            //this.AccSer_No.Text = dal.getDataTabl("get_ser", Properties.Settings.Default.BranchId, txt_InvDate.Value.Year.ToString(), "ENT").Rows[0][0].ToString().PadLeft(4, '0');


            //     }

            dal.Execute("Add_daily_transaction",
            acc_year.Text,
            txtCashAcc.ID.Text,
            txtStore_ID.Text,
            AccSer_No.Text,
            "",
            "",
            "",
            paied_amount.Text,
            0,
            paied_amount.Text,
            H_Date,
            txt_sandDate.Value,
            txt_sandNo.Text,
            txt_source_code.Text,
            txt_source_code.Text + txt_sandNo.Text,
            user_id.Text,
            txtDescr.Text,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            String.Empty, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
           txt_source_code.Text, txtStore_ID.Text, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, '0', DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            txtCust.Text, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
            DBNull.Value, DBNull.Value, DBNull.Value, AccSer_No.Text);

            dal.Execute("Add_daily_transaction",
         acc_year.Text,
         Acc_Cr.ID.Text,
         txtStore_ID.Text,
         AccSer_No.Text,
         "",
         "",
         "",
         0,
         paied_amount.Value,
         -paied_amount.Value,
         H_Date,
         txt_sandDate.Value,
         txt_sandNo.Text,
         txt_source_code.Text,
         txt_source_code.Text + txt_sandNo.Text,
         user_id.Text,
         txtDescr.Text,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         String.Empty, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
        txt_source_code.Text, txtStore_ID.Text, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, '0', DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         txtCust.Text, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
         DBNull.Value, DBNull.Value, DBNull.Value, AccSer_No.Text);

            dal.Execute_1(@"UPDATE Serails_tbl SET last_ser = '" + AccSer_No.Text + "' WHERE Baranch_ID= '" + txtStore_ID.Text + "' and Cyear='" + acc_year.Text + "' and doc_Id = 'ENT'");


        }


        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Pay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cmb_Pay.SelectedValue) == "04")
            {
                txt_Check.Enabled = true;
                cmb_Bank.Enabled = true;
                Check_Date.Enabled = true;
            }
            else
            {

                txt_Check.Enabled = false;
                cmb_Bank.Enabled = false;
                Check_Date.Enabled = false;
                txt_Check.Clear();
                cmb_Bank.SelectedIndex = -1;
                Check_Date.Text = "";

            }
        }

        private void txtAcc_Load(object sender, EventArgs e)
        {
            txtCust.Text = Acc_Cr.Desc.Text;
        }

      

   

      

     
      

          

     

        private void print_sand_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (Properties.Settings.Default.lungh == "0")
            {

                Form1 frmSand = new Form1();
                CrystalReport5 rpt = new CrystalReport5();
                DataTable dt1 = new DataTable();

                dt1 = dal.getDataTabl_1(@"select A.*,B.*,P.PAYER_NAME,C.branch_name from (SELECT ACC_YEAR,ACC_NO,BRANCH_code,ser_no,COST_CENTER,meno,g_date,sanad_no,SANAD_TYPE,sp_ser_no
                ,user_name,desc2,sheek_no,sheek_bank,sheek_date,sheek_or_cash,notes,SOURCE_CODE,Wh_Branch_Code,Sheek
                ,Dafter_no,Dafter_ser,SANAD_TYPE2  FROM daily_transaction where SANAD_TYPE2='" + txt_sanad_type2.Text + "' and BRANCH_code='" + txtStore_ID.Text + "' and  ser_no='" + AccSer_No.Text + "' and  meno>0) as A " +
                "inner join wh_BRANCHES as C on C.Branch_code=A.Branch_code " +
                ",(select acc_no as acc_cr,desc2 as desc_cr  from daily_transaction where SANAD_TYPE2='" + txt_sanad_type2.Text + "' and BRANCH_code='" + txtStore_ID.Text + "' and  ser_no='" + AccSer_No.Text + "' and loh>0)  as B " +
                "inner join payer2 as P on P.ACC_NO=B.acc_cr");


                decimal balance_ = Convert.ToDecimal(dt1.Rows[0]["meno"].ToString());
                ToWord toWord = new ToWord(Math.Abs(Math.Round(balance_, dal.digits_)), currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["Tafqeet"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";


                DataSet ds = new DataSet("sanads");
                ds.Tables.Add(dt1);
                rpt.SetDataSource(ds);
                frmSand.crystalReportViewer1.ReportSource = rpt;
                frmSand.ShowDialog();

                //rpt.PrintOptions.PrinterName = Properties.Settings.Default.Report_P;
                //rpt.PrintToPrinter(2, true, 0, 15);


                ds.WriteXmlSchema("schema3.xml");
            }
            else
            {
                Form1 frmSand = new Form1();
                CTR.print_CashReceipt rpt = new CTR.print_CashReceipt();
                DataTable dt1 = new DataTable();

                dt1 = dal.getDataTabl_1(@"select A.*,B.*,P.PAYER_NAME,p.PAYER_l_NAME,C.branch_name from (SELECT ACC_YEAR,ACC_NO,BRANCH_code,ser_no,COST_CENTER,meno,g_date,sanad_no,SANAD_TYPE,sp_ser_no
                ,user_name,desc2,sheek_no,sheek_bank,sheek_date,sheek_or_cash,notes,SOURCE_CODE,Wh_Branch_Code,Sheek
                ,Dafter_no,Dafter_ser,SANAD_TYPE2  FROM daily_transaction where SANAD_TYPE2='" + txt_sanad_type2.Text + "' and BRANCH_code='" + txtStore_ID.Text + "' and  ser_no='" + AccSer_No.Text + "' and  meno>0) as A " +
                "inner join wh_BRANCHES as C on C.Branch_code=A.Branch_code " +
                ",(select acc_no as acc_cr,desc2 as desc_cr  from daily_transaction where SANAD_TYPE2='" + txt_sanad_type2.Text + "' and BRANCH_code='" + txtStore_ID.Text + "' and  ser_no='" + AccSer_No.Text + "' and loh>0)  as B " +
                "inner join payer2 as P on P.ACC_NO=B.acc_cr");


                decimal balance_ = Convert.ToDecimal(dt1.Rows[0]["meno"].ToString());
                ToWord toWord = new ToWord(Math.Abs(Math.Round(balance_, dal.digits_)), currencies[currencyNo]);
                rpt.DataDefinition.FormulaFields["Tafqeet"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";


                DataSet ds = new DataSet("sanads");
                ds.Tables.Add(dt1);
                rpt.SetDataSource(ds);
                frmSand.crystalReportViewer1.ReportSource = rpt;
                frmSand.ShowDialog();




                ds.WriteXmlSchema("schema3.xml");
                //}
                //catch { }
            }
            //}
            //catch { }
        
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            BSave.Enabled = true;
            Payment_Type.Text = "2";
            txtCashAcc.ID.Text = dal.getDataTabl_1(@"select Cash_acc_no from Wh_branches where branch_code='" + Properties.Settings.Default.BranchId + "' ").Rows[0][0].ToString();
            //txtCashAcc.ID.Text = dal.getDataTabl("Get_Branche_data", Properties.Settings.Default.BranchId).Rows[0][14].ToString();
            txt_sandNo.Text = dal.getDataTabl_1(@"select isnull((BOX_ED_SER)+1,1) from serial_no where Branch_code='" + txtStore_ID.Text
                 + "' and ACC_YEAR= '" + acc_year.Text + "' ").Rows[0][0].ToString();
        }


         private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DateTimeAdv.DateTimeInput)
                        (control as DevComponents.Editors.DateTimeAdv.DateTimeInput).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;

                    else
                        func(control.Controls);
            };
            func(Controls);
            // txtCoId.Text = Properties.Settings.Default.CoId;
            //BranchId.Text = Properties.Settings.Default.BranchId;
        }


        private void BSearch_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    frm_search_recect frm_recet = new frm_search_recect();
            //    frm_recet.txt_source_code.Text = "CR";
            //    frm_recet.ShowDialog();
               

            //    int ii = frm_recet.DGV1.CurrentRow.Index;

                DataTable dt_ = dal.getDataTabl_1(@"select * from (SELECT ACC_YEAR,ACC_NO,BRANCH_code,ser_no,COST_CENTER,meno,g_date,sanad_no,SANAD_TYPE,sp_ser_no
                ,user_name,desc2,sheek_no,sheek_bank,sheek_date,sheek_or_cash,notes,SOURCE_CODE,Wh_Branch_Code,Sheek
                ,Dafter_no,Dafter_ser,SANAD_TYPE2  FROM daily_transaction where SANAD_TYPE2='cr' and BRANCH_code='a21106' and  ser_no='74654'and  meno>0) as A
                , (select acc_no as acc_cr  from daily_transaction where SANAD_TYPE2='cr' and BRANCH_code='a21106' and  ser_no='74654' and loh>0)  as cr_acc ");

                if (dt_.Rows.Count > 0)
                {

                    acc_year.Text = dt_.Rows[0]["ACC_YEAR"].ToString();
                    Acc_Cr.ID.Text = dt_.Rows[0]["acc_cr"].ToString();
                    AccSer_No.Text = dt_.Rows[0]["ser_no"].ToString();
                    Cost.ID.Text = dt_.Rows[0]["COST_CENTER"].ToString();
                    paied_amount.Text = dt_.Rows[0]["meno"].ToString();
                    txt_sandDate.Text = dt_.Rows[0]["g_date"].ToString();
                    txt_sandNo.Text = dt_.Rows[0]["sanad_no"].ToString();
                    Payment_Type.Text = "2";
                    user_id.Text = dt_.Rows[0]["user_name"].ToString();
                    txtDescr.Text = dt_.Rows[0]["desc2"].ToString();
                    txt_Check.Text = dt_.Rows[0]["sheek_no"].ToString();
                    cmb_Bank.Text = dt_.Rows[0]["sheek_bank"].ToString();
                    Check_Date.Text = dt_.Rows[0]["sheek_date"].ToString();
                    cmb_Pay.Text = dt_.Rows[0]["Sheek"].ToString();
                    txt_source_code.Text = dt_.Rows[0]["SOURCE_CODE"].ToString();
                    txtStore_ID.Text = dt_.Rows[0]["Wh_Branch_Code"].ToString();
                    txtCashAcc.ID.Text = dt_.Rows[0]["ACC_NO"].ToString();
                    txt_sanad_type2.Text = dt_.Rows[0]["SANAD_TYPE2"].ToString();
                    txtCust.Text = dt_.Rows[0]["notes"].ToString();
                }
            //}
            //catch { }
        }

        private void Acc_no_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void search_1_Click(object sender, EventArgs e)
        {
            searchType = "1";
            G_Search.Visible = true;
            txtsearch.Focus();
            int px = this.search_1.Location.X - 90;
            int py = this.search_1.Location.Y + 25;
            G_Search.Location = new Point(px, py);
            
            
        }

        private void search_2_Click(object sender, EventArgs e)
        {
            searchType = "2";
            G_Search.Visible = true;
            txtsearch.Focus();
            int px = this.search_2.Location.X-90;
            int py = this.search_2.Location.Y + 25;
            G_Search.Location = new Point(px, py);
                              
        }


        private void G_Search_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           if(searchType == "1"){
            DataTable dt_ = dal.getDataTabl_1(@"  select * from (SELECT ACC_YEAR,ACC_NO,BRANCH_code,ser_no,COST_CENTER,meno,g_date,sanad_no,SANAD_TYPE,sp_ser_no
                ,user_name,desc2,sheek_no,sheek_bank,sheek_date,sheek_or_cash,notes,SOURCE_CODE,Wh_Branch_Code,Sheek
                ,Dafter_no,Dafter_ser,SANAD_TYPE2  FROM daily_transaction where SANAD_TYPE2 in('CR','BR') and BRANCH_code='" + txtStore_ID.Text + "' and  sanad_no ='" + txtsearch.Text + "' and  meno>0) as A , (select acc_no as acc_cr,desc2 as desc_cr   from daily_transaction where SANAD_TYPE2 in('CR','BR') and BRANCH_code='" + txtStore_ID.Text + "' and  sanad_no ='" + txtsearch.Text + "' and loh>0)  as cr_acc ");

            ClearTextBoxes();
            G_Search.Visible = false;
            if (dt_.Rows.Count > 0)
            {
                acc_year.Text = dt_.Rows[0]["ACC_YEAR"].ToString();
                Acc_Cr.ID.Text = dt_.Rows[0]["acc_cr"].ToString();
                AccSer_No.Text = dt_.Rows[0]["ser_no"].ToString();
                Cost.ID.Text = dt_.Rows[0]["COST_CENTER"].ToString();
                paied_amount.Text = dt_.Rows[0]["meno"].ToString();
                txt_sandDate.Text = dt_.Rows[0]["g_date"].ToString();
                txt_sandNo.Text = dt_.Rows[0]["sanad_no"].ToString();
                Payment_Type.Text = "2";
                user_id.Text = dt_.Rows[0]["user_name"].ToString();
                txtDescr.Text = dt_.Rows[0]["desc_cr"].ToString();
                txt_Check.Text = dt_.Rows[0]["sheek_no"].ToString();
                cmb_Bank.Text = dt_.Rows[0]["sheek_bank"].ToString();
                Check_Date.Text = dt_.Rows[0]["sheek_date"].ToString();
                cmb_Pay.Text = dt_.Rows[0]["Sheek"].ToString();
                txt_source_code.Text = dt_.Rows[0]["SOURCE_CODE"].ToString();
                txtStore_ID.Text = dt_.Rows[0]["Wh_Branch_Code"].ToString();
                txtCashAcc.ID.Text = dt_.Rows[0]["ACC_NO"].ToString();
                txt_sanad_type2.Text = dt_.Rows[0]["SANAD_TYPE2"].ToString();
                txtCust.Text = dt_.Rows[0]["notes"].ToString();
            }
           }
           else if (searchType == "2")
           {
               DataTable dt_ = dal.getDataTabl_1(@"  select * from (SELECT ACC_YEAR,ACC_NO,BRANCH_code,ser_no,COST_CENTER,meno,g_date,sanad_no,SANAD_TYPE,sp_ser_no
                ,user_name,desc2,sheek_no,sheek_bank,sheek_date,sheek_or_cash,notes,SOURCE_CODE,Wh_Branch_Code,Sheek
                ,Dafter_no,Dafter_ser,SANAD_TYPE2  FROM daily_transaction where SANAD_TYPE2 in('CR','BR') and BRANCH_code='" + txtStore_ID.Text + "' and  ser_no ='" + txtsearch.Text + "' and  meno>0) as A , (select acc_no as acc_cr,desc2 as desc_cr   from daily_transaction where SANAD_TYPE2 in('CR','BR') and BRANCH_code='" + txtStore_ID.Text + "' and  ser_no ='" + txtsearch.Text + "' and loh>0)  as cr_acc ");

               ClearTextBoxes();
               G_Search.Visible = false;
               if (dt_.Rows.Count > 0)
               {
                   acc_year.Text = dt_.Rows[0]["ACC_YEAR"].ToString();
                   Acc_Cr.ID.Text = dt_.Rows[0]["acc_cr"].ToString();
                   AccSer_No.Text = dt_.Rows[0]["ser_no"].ToString();
                   Cost.ID.Text = dt_.Rows[0]["COST_CENTER"].ToString();
                   paied_amount.Text = dt_.Rows[0]["meno"].ToString();
                   txt_sandDate.Text = dt_.Rows[0]["g_date"].ToString();
                   txt_sandNo.Text = dt_.Rows[0]["sanad_no"].ToString();
                   Payment_Type.Text = "2";
                   user_id.Text = dt_.Rows[0]["user_name"].ToString();
                   txtDescr.Text = dt_.Rows[0]["desc_cr"].ToString();
                   txt_Check.Text = dt_.Rows[0]["sheek_no"].ToString();
                   cmb_Bank.Text = dt_.Rows[0]["sheek_bank"].ToString();
                   Check_Date.Text = dt_.Rows[0]["sheek_date"].ToString();
                   cmb_Pay.Text = dt_.Rows[0]["Sheek"].ToString();
                   txt_source_code.Text = dt_.Rows[0]["SOURCE_CODE"].ToString();
                   txtStore_ID.Text = dt_.Rows[0]["Wh_Branch_Code"].ToString();
                   txtCashAcc.ID.Text = dt_.Rows[0]["ACC_NO"].ToString();
                   txt_sanad_type2.Text = dt_.Rows[0]["SANAD_TYPE2"].ToString();
                   txtCust.Text = dt_.Rows[0]["notes"].ToString();
               }
           }
            



        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            G_Search.Visible = false;
        }





        private void getJorSer()
        {

           AccSer_No.Text = "M" + dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) from serial_no where BRANCH_CODE='" + Properties.Settings.Default.BranchId
                  + "' and ACC_YEAR= '" + acc_year.Text + "'").Rows[0][0].ToString().PadLeft(4, '0');

           txt_sandNo.Text = dal.getDataTabl_1(@"select isnull((BOX_ED_SER)+1,1) from serial_no where Branch_code='" + txtStore_ID.Text
                         + "' and ACC_YEAR= '" + acc_year.Text + "' ").Rows[0][0].ToString();



        }

 
        

    
    }
}
