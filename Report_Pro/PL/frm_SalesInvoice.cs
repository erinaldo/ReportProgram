using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace Report_Pro.PL
{
    public partial class frm_SalesInvoice : Form
    {
        string btntype = "0";
        Int32 m;
        //string Jor_no;
        string btn_name;
        decimal old_balance, old_cost, new_balance, new_cost;
        Dates date_ = new Dates();

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();




        public frm_SalesInvoice()
        {

            InitializeComponent();


          


            txt_InvSM.Text = Program.salesman;
            txtStore_ID.Text = Properties.Settings.Default.BranchId;
            txtBranch_Id.Text = Properties.Settings.Default.BranchAccID;
            userID.Text = Program.userID;
          
            Payment_Type.DataSource = dal.getDataTabl_1("SELECT * FROM wh_Payment_type");

            if (Properties.Settings.Default.lungh == "0")
            {
                Payment_Type.DisplayMember = "Payment_name";
            }
            else
            {
                Payment_Type.DisplayMember = "Payment_name";
            }
            Payment_Type.ValueMember = "Payment_type";
            Payment_Type.SelectedIndex = -1;

            

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
           

            cmb_Bank.DataSource = dal.getDataTabl_1("SELECT * FROM SHEEK_BANKS_TYPE");

            if (Properties.Settings.Default.lungh == "0")
            {
                cmb_Bank.DisplayMember = "BANK_NAME";
            }
            else
            {
                cmb_Bank.DisplayMember = "BANK_NAME";
            }
            cmb_Bank.ValueMember = "BANK_NO";
            cmb_Bank.SelectedIndex = -1;




        }





  


      



     





        private void txt_InvNot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                //Btn_srch_cust.Focus();
            }
        }





        private void get_invSer()
        {
            try
            {
                txtMainSer.Text = dal.getDataTabl_1(@"select isnull(XS+1,1) from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();
                if (Convert.ToString(Payment_Type.SelectedValue) == "2")
                {
                    Doc_Type.Text = "XSD";
                    this.txt_InvNu.Text = dal.getDataTabl_1(@"select isnull(XSD+1,1) from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();
                }
                else if (Convert.ToString(Payment_Type.SelectedValue) == "11" || Convert.ToString(Payment_Type.SelectedValue) == "12")
                {
                    Doc_Type.Text = "XSC";
                    this.txt_InvNu.Text = dal.getDataTabl_1(@"select isnull(XSC+1,1) from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();

                }
            }
            catch { }


        }

        private void Payment_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_invSer();
           // total_inv();
        }

       


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void BNew_Click(object sender, EventArgs e)
        {
           
            btntype = "0";
            get_invSer();
            tabControlPanel1.Enabled = true;
            tabControlPanel2.Enabled = true;
            tabControlPanel3.Enabled = true;
           

            dt.Clear();
          


            BSave.Enabled = true;
            txt_InvNot.Focus();
            
        }


        bool IsGridValid()
        {

            int countR = 0;

            foreach (MyControls.Inv_Row c in inv_Grid1.flowLayoutPanel1.Controls)
            {
                if (c.txt_Code.Text != String.Empty && c.qty.Value > 0 && c.TxtPrice.Value > 0)
                {
                    countR++;
                }

            }
            if (countR > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(dal.rm.GetString("msgError") + " No Items", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }



        private void BSave_Click(object sender, EventArgs e)
        {

            
                if (Uc_Customer.ID.Text == string.Empty)
                {
                    MessageBox.Show("فضلا.. تاكد من اختيار العميل ", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            

                if (Payment_Type.SelectedIndex < 0)
                {
                    MessageBox.Show("فضلا.. تاكد من نوع الفاتورة", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (inv_Grid1.txtNetTotal.Text.ToDecimal() <= 0)
                {
                    MessageBox.Show("لايمكن حفظ فاتورة بقيمة اقل من او يساوي صفر", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               



                if (Convert.ToString(Payment_Type.SelectedValue) == "11")
                {
                    if (cmb_Pay.SelectedIndex < 0)
                    {
                        MessageBox.Show("فضلا.. تاكد من طريقة السداد", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (cashCustomer.Desc.Text.Replace(" ", string.Empty) == "")
                    {
                        MessageBox.Show("تأكد من اسم العميل النقدي", "خطأ !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }



                }


                if (IsGridValid() == false)
                {
                    return;
                }



                if (Convert.ToString(Payment_Type.SelectedValue) == "2")
                {
                    Doc_Type.Text = "XSD";
                    this.txt_InvNu.Text = dal.getDataTabl_1(@"select isnull(XSD+1,1) from wh_Serial where Branch_code= '"+txtStore_ID.Text+"' and Cyear='"+ txt_InvDate.Value.Date.ToString("yy")+"'").Rows[0][0].ToString();
                }
                else if (Convert.ToString(Payment_Type.SelectedValue) == "11" || Convert.ToString(Payment_Type.SelectedValue) == "12")
                {
                    Doc_Type.Text = "XSC";
                    this.txt_InvNu.Text = dal.getDataTabl_1(@"select isnull(XSC+1,1) from wh_Serial where Branch_code= '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.Date.ToString("yy") + "'").Rows[0][0].ToString();
                    
                }

                get_invSer();

                this.AccSer_No.Text = dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) from serial_no where BRANCH_CODE='" + Properties.Settings.Default.BranchId
                 + "' and ACC_YEAR= '" + acc_year.Text + "' ").Rows[0][0].ToString();//.PadLeft(4, '0');



            
                SqlCommand cmd = dal.sqlconn_1.CreateCommand();
                SqlTransaction trans;
                trans = dal.sqlconn_1.BeginTransaction();
                cmd.Connection = dal.sqlconn_1;
                cmd.Transaction = trans;

                try
                {
                cmd.CommandText = @"insert into wh_inv_data(Ser_no, Branch_code, Transaction_code, Cyear, Sanad_no, G_date, ACC_TYPE, Acc_no,
                        Acc_Branch_code, Payment_Type, Sales_man_Id, acc_serial_no, Po_no, User_id, NetAmount, PanyedAmount,
                        Cash_costomer_name, total_cost, Inv_Notes, Costmer_No, Phone, Adress, K_M_ACC_NO, K_M_Credit_TAX,
                        K_M_Debit_TAX, COSTMER_K_M_NO, K_M_SER, KM_CODE_ACC, MAIN_KM_CODE)
                        values('" + txt_InvNu.Text + "', '" + txtStore_ID.Text + "', '" + Doc_Type.Text +
                    "', '" + txt_InvDate.Value.ToString("yy") + "' ,'" + txtMainSer.Text +
                    "', '" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','A', '" + Uc_Customer.ID.Text +
                    "', '" + txtBranch_Id.Text + "', '" + Convert.ToString(Payment_Type.SelectedValue) +
                    "', '" + Uc_Cost.ID.Text + "', '" + AccSer_No.Text + "', '" + Po_No.Text + "' , '" + userID.Text +
                    "', '" + inv_Grid1.txtNetTotal.Text.ToDecimal() + "', '" + inv_Grid1.paied_amount.Text.ToDecimal() +
                    "', '" + cashCustomer.Desc.Text + "', '0', '" + txt_InvNot.Text + "', '" + cashCustomer.ID.Text +
                    "', '" + txt_custTel.Text + "', '" + txt_address.Text + "', '" + Vat_acc.Text + "', '" + inv_Grid1.txtTotalVAT.Text.ToDecimal() +
                    "', '0', '" + Cust_Vat_No.Text + "', '0','" + txtKmCode.Text + "','" + Vat_Class.Text + "')";

                cmd.ExecuteNonQuery();


                foreach (MyControls.Inv_Row r in inv_Grid1.flowLayoutPanel1.Controls)
                {

                    if (r.txt_Code.Text != string.Empty && r.qty.Value > 0 && r.TxtPrice.Value > 0)
                    {
                        cmd.CommandText = @" insert into wh_material_transaction (SER_NO,Branch_code,TRANSACTION_CODE,Cyear,SANAD_NO,ITEM_NO,QTY_ADD,QTY_TAKE,COST_PRICE,total_disc,DISC_R,DISC_R2,DISC_R3,
            G_DATE,Unit,Local_Price,USER_ID,main_counter,balance,Store_Code,Weight,K_M_TYPE_ITEMS,TAX_IN,TAX_OUT) 
           values( '" + txt_InvNu.Text + "', '" + txtStore_ID.Text + "', '" + Doc_Type.Text + "', '" + txt_InvDate.Value.ToString("yy") +
            "' ,'" + txtMainSer.Text + "','" + r.txt_Code.Text + "' ,'0','" +
           r.qty.Text + "','" + r.txtCost.Text +
            "','" + ((r.TxtDisc.Text.ToDecimal() / r.txt_subTOt.Text.ToDecimal()) + inv_Grid1.disc_Rate.Text.ToDecimal()) * 100 +
            "' ,'" + (r.TxtDisc.Text.ToDecimal() / r.txt_subTOt.Text.ToDecimal()) * 100 + "' ,'0','" + (inv_Grid1.disc_Rate.Text.ToDecimal()) * 100 +
            "', '" + txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + r.txtUnit.Text +
            "' ,'" + r.TxtPrice.Text.ToDecimal() + "' , '" + userID.Text + "','" +
            inv_Grid1.flowLayoutPanel1.Controls.GetChildIndex(r) + "', '" + r.qty.Text.ToDecimal() + "', '" + txtStore_ID.Text +
            "','" +r.Weight_.Text.ToDecimal() + "','" + r.KM_TYPE_ITEMS.Text +
            "' ,'0','" + r.VatValue.Text.ToDecimal() + "')";

                        cmd.ExecuteNonQuery();

                    }

                }



                cmd.CommandText = @"UPDATE  wh_Serial SET  PER= '" + txt_InvNu.Text + "' WHERE Branch_code = '" + txtStore_ID.Text + "' and Cyear='" + txt_InvDate.Value.ToString("yy") + "' ";
                cmd.ExecuteNonQuery();


                trans.Commit();
                MessageBox.Show(dal.rm.GetString("msgSave", dal.cul), dal.rm.GetString("msgSave_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dal.sqlconn_1.Close();
                }


            }








        



        //private void Add_sands()
        //{

        //    txt_sandNo.Text = dal.getDataTabl_1(@"select isnull(max(last_ser)+1,1) from Serails_tbl where Baranch_ID='" + Properties.Settings.Default.BranchId
        //               + "' and Cyear= '" + acc_year.Text + "' and doc_Id =  'CR'").Rows[0][0].ToString();

        //    dal.Execute_1(@"Insert into Sands_tbl values( '" + acc_year.Text + "', '" + Uc_Customer.ID.Text + "','"
        //     + txtBranch_Id.Text + "', '" + AccSer_No.Text + "','"+ Uc_Cost.ID.Text +"',0, '" + txtNetTotal.Text + "','"
        //     + txt_InvDate.Value.Date.ToString("yyyy/MM/dd") + "' , '" + txt_sandNo.Text + "','" 
        //     + Convert.ToString(Payment_Type.SelectedValue) + "','" + userID.Text + "',  'سداد فاتورة مبيعات ' +'" 
        //     + Payment_Type.Text + "' + ' رقم ' + '" + txt_InvNu.Text + "', '" + txt_Check.Text + "' ,'" 
        //     + Convert.ToString(cmb_Bank.SelectedValue) + "','" + (Check_Date.Value > Check_Date.MinDate ? 
        //     Check_Date.Value.Date.ToString("yyyy/MM/dd") : Check_Date.MinDate.Date.ToString("yyyy/MM/dd")) + "','" 
        //     + Convert.ToString(cmb_Pay.SelectedValue) + "','','" + txt_InvNot.Text + "','CR','" + txtStore_ID.Text 
        //     + "','" +Net_Vat.Text.ToDecimal() + "','" + txt_CashAcc_ID.Text + "','" + txt_InvNu.Text + "','" 
        //     + paied_amount.Text + "','"+ cashCustomer.Desc.Text +"','','','','','','','','','','','','','')");


        //    DataTable dt_ = dal.getDataTabl_1("Select * from Serails_tbl where Baranch_ID= '" + txtStore_ID.Text + "' and Cyear='" + acc_year.Text
        //                  + "' and doc_Id = 'CR'");
        //    if (dt_.Rows.Count > 0)
        //    {


        //        dal.Execute_1(@"UPDATE Serails_tbl SET last_ser = '" + txt_sandNo.Text + "' WHERE Baranch_ID= '" +
        //            Properties.Settings.Default.BranchId + "' and Cyear='" + acc_year.Text + "' and doc_Id = 'CR'");


        //    }

        //    else
        //    {
        //        dal.Execute_1(@"INSERT INTO Serails_tbl  Values ('" + txtStore_ID.Text + "' , '" + acc_year.Text + "' ,  'CR','','','" + txt_sandNo.Text + "'");
        //    }


        //}



   
   
    
     
    

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

    

        private void invoice_frm_Load(object sender, EventArgs e)
        {

            string Acc_main = (dal.getDataTabl("Get_Main_acc", Properties.Settings.Default.BranchId, dal.db1)).Rows[0][0].ToString();
            string Acc_cash = (dal.getDataTabl("Get_Main_acc", Properties.Settings.Default.BranchId, dal.db1)).Rows[0][2].ToString();



            Uc_Customer.txtMainAcc.Text = Acc_main;
            Uc_Customer.txtAccCash.Text = Acc_cash;
            Uc_Customer.txtFinal.Text = "1";
            Uc_Customer.branchID.Text = Properties.Settings.Default.BranchAccID;
            
            DataTable Dt_1 = dal.getDataTabl_1(@"SELECT B.SALES_ACC_NO , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.SALES_ACC_NO=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code where B.BRANCH_code= '" + Properties.Settings.Default.BranchId+"'");
            if (Dt_1.Rows.Count > 0)
            {
                txtAcc2_ID.Text = Dt_1.Rows[0][0].ToString();
                txtAcc2_Desc.Text = Dt_1.Rows[0][1].ToString();
            }
            DataTable Dt_2 = dal.getDataTabl_1(@"SELECT B.Cash_acc_no , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.Cash_acc_no=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code where B.BRANCH_code= '" + Properties.Settings.Default.BranchId + "'");
            if (Dt_2.Rows.Count > 0)
            {
                txt_CashAcc_ID.Text = Dt_2.Rows[0][0].ToString();
                txt_CashAcc_Desc.Text = Dt_2.Rows[0][1].ToString();
            }

            DataTable Dt_3 = dal.getDataTabl_1(@"SELECT B.K_M_ACC_NO_SALES , PAYER_NAME FROM wh_BRANCHES AS B inner join payer2 AS P on B.K_M_ACC_NO_SALES=P.ACC_NO and B.ACC_BRANCH=P.BRANCH_code where B.BRANCH_code= '" + Properties.Settings.Default.BranchId + "'");
            if (Dt_3.Rows.Count>0)
            {
                Vat_acc.Text = Dt_3.Rows[0][0].ToString();
                Vat_acc_Desc.Text = Dt_3.Rows[0][1].ToString();
            }

            //txt_CashAcc.ID.Text = dal.getDataTabl_1("SELECT* FROM wh_BRANCHES where  Branch_code='" + Properties.Settings.Default.BranchId + "'").Rows[0][14].ToString();
           // Vat_acc.Text = dal.getDataTabl_1("SELECT* FROM wh_BRANCHES where  Branch_code='" + Properties.Settings.Default.BranchId + "'").Rows[0][87].ToString();
        }

        private void Uc_Customer_Load(object sender, EventArgs e)
        {
            DataTable dt_M = dal.getDataTabl_1(@"select Costmers_acc_no,Suppliers_acc_no,Cash_acc_no FROM wh_BRANCHES where BRANCH_code like '" + Properties.Settings.Default.BranchId + "%'");
            if (dt_M.Rows.Count > 0)
            {
                string Acc_main = dt_M.Rows[0][0].ToString();
                string Acc_cash = dt_M.Rows[0][2].ToString();
                DataTable dt_cust = dal.getDataTabl_1(@"select P.*,A.MAIN_KM_CODE,a.MAIN_KM_DESC,b.KM_RATIO,b.KM_CODE FROM payer2 As P left join KM_MAIN_ACC_CODE as A on  ISNULL(NULLIF(P.KM_CODE_Sales, ''), 11) = A.MAIN_KM_CODE
                left join  KM_ACC_CODE as b on b.KM_CODE = a.KM_CODE where P.BRANCH_code like '" + Properties.Settings.Default.BranchId + "%' and P.ACC_NO = '" + Uc_Customer.ID.Text + "' and(P.ACC_NO like '" + Acc_main + "%' or P.ACC_NO like '" + Acc_cash + "%') and P.t_final ='1'");
                txtBranch_Id.Text = Properties.Settings.Default.BranchId;
                if (dt_cust.Rows.Count > 0)
                {
                    if (Uc_Customer.ID.Text == Acc_cash)
                    {
                        cashCustomer.Enabled = true;
                        Payment_Type.SelectedValue = "11";
                        Payment_Type.Enabled = false;
                        Vat_Class.Text = dt_cust.Rows[0][68].ToString();
                        Vat_Class_Desc.Text = dt_cust.Rows[0][69].ToString();
                        if (dt_cust.Rows[0][70].ToString() == string.Empty)
                        { Cust_Vat_Rate.Text = "0.05";
                            inv_Grid1.txtAccVat_Rate.Text = Cust_Vat_Rate.Text;                      }
                        else
                        {
                            Cust_Vat_Rate.Text = dt_cust.Rows[0][70].ToString().ToDecimal().ToString("N2");
                            inv_Grid1.txtAccVat_Rate.Text = Cust_Vat_Rate.Text;
                        }
                        txtKmCode.Text = dt_cust.Rows[0][71].ToString();
                    }
                    else
                    {
                        cashCustomer.Enabled = false;
                        Payment_Type.SelectedValue = "2";
                        Payment_Type.Enabled = true;

                        txt_custTel.Text = dt_cust.Rows[0][14].ToString();
                        txt_address.Text = dt_cust.Rows[0][11].ToString();
                        txt_custFax.Text = dt_cust.Rows[0][16].ToString();
                        txt_CustEmail.Text = dt_cust.Rows[0][15].ToString();
                        txt_BoBox.Text = dt_cust.Rows[0][12].ToString();
                        txt_area_code.Text = dt_cust.Rows[0][19].ToString();
                        Cust_Vat_No.Text = dt_cust.Rows[0][60].ToString();
                        Vat_Class.Text = dt_cust.Rows[0][68].ToString();
                        Vat_Class_Desc.Text = dt_cust.Rows[0][69].ToString();
                        if (dt_cust.Rows[0][70].ToString() == string.Empty)
                        { Cust_Vat_Rate.Text = "0.05";
                            inv_Grid1.txtAccVat_Rate.Text = Cust_Vat_Rate.Text;
                        }
                        else
                        {
                            Cust_Vat_Rate.Text = dt_cust.Rows[0][70].ToString().ToDecimal().ToString("N2");
                            inv_Grid1.txtAccVat_Rate.Text = Cust_Vat_Rate.Text;
                        }
                        txtKmCode.Text = dt_cust.Rows[0][71].ToString();
                    }
                }
                else
                {
                    cashCustomer.Enabled = false;
                    txt_custTel.Clear();
                    txt_address.Clear();
                    txt_custFax.Clear();
                    txt_CustEmail.Clear();
                    txt_BoBox.Clear();
                    txt_area_code.Clear();
                    Cust_Vat_No.Clear();
                    Vat_Class.Clear();
                    Vat_Class_Desc.Clear();
                    Cust_Vat_Rate.Clear();
                    inv_Grid1.txtAccVat_Rate.Clear();

                }
               inv_Grid1.total_inv();
            }

        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //private void Add_Jor()
        //{
        //    string cyear = txt_InvDate.Value.Year.ToString("yy");
        //    string H_Date = date_.GregToHijri(txt_InvDate.Text);
           

        //    dal.Execute_1(@"INSERT INTO daily_transaction ( ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh,
        //    balance, h_date,g_date,sanad_no, SANAD_TYPE, sp_ser_no, user_name, desc2,POASTING,SOURCE_CODE, Wh_Branch_Code, MAIN_SER_NO )
        //    Values('" + acc_year.Text+"', '"+Uc_Customer.ID.Text+"', '"+ txtBranch_Id.Text + "','" + AccSer_No.Text + "','" + 
        //    Uc_Cost.ID.Text + "','" + NetValue.Text + "','" + 0 + "','" + NetValue.Text + "','" + H_Date + "','" + 
        //    txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txt_InvNu.Text + "','" + Doc_Type.Text + "','" + Doc_Type.Text + txt_InvNu.Text + "','" + 
        //    userID.Text + "','" + "فاتورة مبيعات " + Payment_Type.Text + " رقم " + txt_InvNu.Text + "','0','" + Doc_Type.Text + "','" + 
        //    txtStore_ID.Text + "','" + AccSer_No.Text + "')");


        //    dal.Execute_1(@"INSERT INTO daily_transaction ( ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh,
        //    balance, h_date,g_date,sanad_no, SANAD_TYPE, sp_ser_no, user_name, desc2,POASTING, SOURCE_CODE, Wh_Branch_Code, MAIN_SER_NO )
        //    Values('" + acc_year.Text + "', '" + txtAcc2_ID.Text + "', '" + txtBranch_Id.Text + "','" + AccSer_No.Text + "','" +
        //    Uc_Cost.ID.Text + "','" + 0 + "','" + txtNetTotal.Text.ToDecimal() + "','" + -txtNetTotal.Text.ToDecimal() + "','" + H_Date + "','" +
        //    txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txt_InvNu.Text + "','" + Doc_Type.Text + "','" + Doc_Type.Text + txt_InvNu.Text + "','" +
        //    userID.Text + "','" + "فاتورة مبيعات " + Payment_Type.Text + " رقم " + txt_InvNu.Text + "','0','" + Doc_Type.Text + "','" +
        //    txtStore_ID.Text + "','" + AccSer_No.Text + "')");

        //    dal.Execute_1(@"INSERT INTO daily_transaction ( ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh,
        //    balance, h_date,g_date,sanad_no, SANAD_TYPE, sp_ser_no, user_name, desc2,POASTING, SOURCE_CODE, Wh_Branch_Code, MAIN_SER_NO )
        //    Values('" + acc_year.Text + "', '" + Vat_acc.Text + "', '" + txtBranch_Id.Text + "','" + AccSer_No.Text + "','" +
        //    Uc_Cost.ID.Text + "','" + 0 + "','" + Net_Vat.Text.ToDecimal() + "','" + -Net_Vat.Text.ToDecimal() + "','" + H_Date + "','" +
        //    txt_InvDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txt_InvNu.Text + "','" + Doc_Type.Text + "','" + Doc_Type.Text + txt_InvNu.Text + "','" +
        //    userID.Text + "','" + "ضريبة فاتورة مبيعات " + Payment_Type.Text + " رقم " + txt_InvNu.Text + "','0','" + Doc_Type.Text + "','" +
        //    txtStore_ID.Text + "','" + AccSer_No.Text + "')");




        //}


    
        private void txtStore_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = dal.getDataTabl("GetStores", txtStore_ID.Text.ToString());
                if (dt.Rows.Count > 0)
                {
                    // txtStore_Desc.Text = dt.Rows[0][2].ToString();
                    txtAcc2_ID.Text = dt.Rows[0][9].ToString();
                    txt_CashAcc_ID.Text = dt.Rows[0][12].ToString();
                    txt_CustAcc_ID.Text = dt.Rows[0][13].ToString();
                }
                else
                {
                    // txtStore_Desc.Text = "";
                }
            }
            catch
            {

            }
        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

       
      
        
    }
}


     