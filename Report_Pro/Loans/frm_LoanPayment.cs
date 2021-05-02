
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.Loans
{
    public partial class frm_LoanPayment : Form
    {
        CultureInfo cul;
        string _branch = Properties.Settings.Default.BranchAccID;
        Assembly a = Assembly.Load("Report_Pro");
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_LoanPayment()
        {
            InitializeComponent();


            txtLoanPurpose.DataSource = dal.getDataTabl_1(@"SELECT Id,Loan_Purpose,Loan_Purpose_E FROM LoanPurpose ");
            txtLoanPurpose.ValueMember = "Id";
            if (dal.languh_ == "0")
            {
                txtLoanPurpose.DisplayMember = "Loan_Purpose";
            }
            else
            {
                txtLoanPurpose.DisplayMember = "Loan_Purpose_E";
            }
        }

        private void getLoanData()
        {
            //try
            //{

            DataTable loanData = dal.getDataTabl_1(@"SELECT A.*,B.sanad_no,B.g_date FROM LoansTbl as A
               left Join(select * from (select p.ser_no,p.sanad_no,p.g_date,p.BRANCH_code, ROW_NUMBER() OVER(PARTITION BY p.ser_no ORDER BY p.ser_no) AS DuplicateCount 
                FROM daily_transaction As P) as t1  where t1.DuplicateCount = 1) as B on A.Jor_ser_no=B.ser_no and A.Branch_code=B.BRANCH_code 
                where LoanNo ='" + txtLoanNo.Text + "' and PaymentNo='" + txtPaymentNo.Text + "'");



            if (loanData.Rows.Count > 0)
            {

                BName.ID.Text = loanData.Rows[0]["BankId"].ToString();
                txtLoanAcc.ID.Text = loanData.Rows[0]["LoanACC"].ToString();
                txtLoanNo.Text = loanData.Rows[0]["LoanNo"].ToString();
                txtLoanPurpose.SelectedValue = loanData.Rows[0]["LoanPurpose"].ToString().ParseInt(0);
                txtLoanRefrance.Text = loanData.Rows[0]["LoanRefrance"].ToString();
                Amount.Text = loanData.Rows[0]["PaymentValue"].ToString();
                StartDate.Text = loanData.Rows[0]["StartDate"].ToString();
                MaturityDate.Text = loanData.Rows[0]["MaturityDate"].ToString();
                txtJorSer.Text= loanData.Rows[0]["Jor_ser_no"].ToString();
                txtSanadSer.Text= loanData.Rows[0]["sanad_no"].ToString();
                jorDate.Text = loanData.Rows[0]["g_date"].ToString();
                getBalance();
            }
            else
            {
                txtID.Clear();
                BName.ID.Clear();
                txtLoanAcc.ID.Clear();
                //txtLoanNo.Clear();
                txtLoanPurpose.SelectedIndex = -1;
                txtLoanRefrance.Clear();
                Amount.Value = 0;
                StartDate.Text = "";
                MaturityDate.Text = "";

            }
            getLoanPaymentID();
            // getPaymentData();
            //getBalance();
            //}
            //catch
            //{

            //}
        }


        private void getPaymentData()
        {
            //try
            //{

            DataTable PaymentData = dal.getDataTabl_1(@"SELECT *  FROM LoanPaymentTbl where id='" + txtID.Text.ParseInt(0) + "' ");
            if (PaymentData.Rows.Count > 0)
            {
                
                txtPaymentAmount.Text = PaymentData.Rows[0]["PaymentAmount"].ToString();
                PaymentInterest.Text = PaymentData.Rows[0]["PayMentInterest"].ToString();
                PaymentDate.Text = PaymentData.Rows[0]["PaymentDate"].ToString();
                txtJorSer.Text = PaymentData.Rows[0]["Jor_ser_no"].ToString();


            }
            else
            {
                txtID.Clear();
                txtPaymentAmount.Value = 0;
                PaymentInterest.Value = 0;
                PaymentDate.Text = "";


            }

            //}
            //catch
            //{

            //}
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
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;
                    else if (control is DevComponents.Editors.DateTimeAdv.DateTimeInput)
                        (control as DevComponents.Editors.DateTimeAdv.DateTimeInput).Text = "";
                    else if (control is DataGridView)
                        (control as DataGridView).DataSource = null;



                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void getBalance()
        {
            decimal paidAmount = 0;
            decimal interest = 0;
            int days = 0;
            DataTable dtBalance = dal.getDataTabl_1("select sum (PaymentAmount),sum(PayMentInterest) from LoanPaymentTbl where LoanNo = '" + txtLoanNo.Text + "' and PaymentNo ='" + txtPaymentNo.Value + "' and id <> '" + txtID.Text + "'");
            if (dtBalance.Rows.Count > 0)
            {
                paidAmount = dtBalance.Rows[0][0].ToString().ToDecimal();
                interest = dtBalance.Rows[0][1].ToString().ToDecimal() + PaymentInterest.Text.ToDecimal();

                days = System.Data.Linq.SqlClient.SqlMethods.DateDiffDay(StartDate.Value, PaymentDate.Value);

            }
            else
            {
                paidAmount = 0;
                interest = 0;
                days = 0;

            }
            BalanceBeforPay.Text = (Amount.Value.ToString().ToDecimal()-paidAmount).ToString(); ;
            LoanBalance.Text = (Amount.Value.ToString().ToDecimal() - paidAmount - txtPaymentAmount.Text.ToDecimal()).ToString("N2");
            if ((days * paidAmount) > 0)
            {
                InterestRate.Text = ((interest * 365 * 100) / (days * paidAmount)).ToString("N2");
            }

        }

        private void frm_LoanPayment_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtLoanNo_KeyUp(object sender, KeyEventArgs e)
        {
            getLoanData();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Loans.frmLoanSearch frm = new Loans.frmLoanSearch();
            frm.ShowDialog();
            try
            {
                txtLoanNo.Text = frm.DGV1.CurrentRow.Cells[2].Value.ToString();
                txtPaymentNo.Text = frm.DGV1.CurrentRow.Cells[3].Value.ToString();

                getLoanData();
            }
            catch { }
        }

        private void txtPaymentNo_ValueChanged(object sender, EventArgs e)
        {
            getLoanData();
            
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            getLoanPaymentID();

        }

        private void getLoanPaymentID()
        {
            txtID.Text = dal.GetCell_1("select isnull(MAX(id)+1,1) from LoanPaymentTbl").ToString();

        }


        private void BSave_Click(object sender, EventArgs e)
        {
            //ResourceManager rm = new ResourceManager("Report_Pro.Lang.Langres", a);

            if(txtPaymentAmount.Value > BalanceBeforPay.Value)
            {
                 MessageBox.Show("اجمالي السداد اكبر من قيمة القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;

            }
            if (txtPaymentAmount.Value > 0 && dal.IsDateTime(PaymentDate.Text))
            {
                DataTable dt_ = dal.getDataTabl_1(@"select * from LoanPaymentTbl where id='" + txtID.Text.ParseInt(0) + "'");
                if (dt_.Rows.Count > 0)
                {

                    dal.Execute_1(@"UPDATE LoanPaymentTbl set 
                      LoanNo ='" + txtLoanNo.Text +
                    "',PaymentNo ='" + txtPaymentNo.Value +
                    "',PaymentAmount='" + txtPaymentAmount.Value +
                    "',PayMentInterest='" + PaymentInterest.Value +
                    "',PaymentDate='" + PaymentDate.Value.ToString("yyyy/MM/dd") +
                     "',Branch_code='"+_branch+
                     "',Jor_ser_no='"+txtJorSer.Text+
                    "' where  id='" + txtID.Text + "'");

                 
                    UpdateJor();

                    MessageBox.Show(dal.rm.GetString("msgEdit", dal.cul), dal.rm.GetString("msgEdit_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    getLoanPaymentID();

                    dal.Execute_1(@"INSERT INTO LoanPaymentTbl(Id,LoanNo,PaymentNo,PaymentAmount,PayMentInterest,PaymentDate,Branch_code,Jor_ser_no)
                     VALUES ('" + txtID.Text+"','" + txtLoanNo.Text + "','" + txtPaymentNo.Value + "','" + txtPaymentAmount.Value + "','" + PaymentInterest.Value +
                        "','" + PaymentDate.Value.ToString("yyyy/MM/dd") + "','"+ _branch+"','"+txtJorSer.Text+"')");
                    MessageBox.Show(dal.rm.GetString("msgSave", dal.cul), "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                getBalance();
            }
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            Loans.frmLoanPaymentSearch frm = new Loans.frmLoanPaymentSearch();
            frm.ShowDialog();
            
            txtLoanNo.Text = frm.DGV1.CurrentRow.Cells[1].Value.ToString();
            txtPaymentNo.Text = frm.DGV1.CurrentRow.Cells[2].Value.ToString();
            getLoanData();
            txtID.Text = frm.DGV1.CurrentRow.Cells[0].Value.ToString();
            getPaymentData();
            getBalance();



        }


        private void PaymentAmount_Leave(object sender, EventArgs e)
        {
            getBalance();
        }

        private void PaymentInterest_Leave(object sender, EventArgs e)
        {
            getBalance();
        }

        private void PaymentDate_KeyUp(object sender, KeyEventArgs e)
        {
            getBalance();
        }

        private void btnCreateJor_Click(object sender, EventArgs e)
        {
            DataTable dt_1 = dal.getDataTabl_1(@"SELECT * FROM LoanPaymentTbl where id = '" + txtID.Text + "'");


            if (dt_1.Rows.Count > 0)
            {

                addJor();

                //getJorSer();
                //int JorSer;
                //if (txtJorSer.Text.Contains('M'))
                //{
                //    var Jor_ser = txtJorSer.Text.Split('M');
                //    JorSer = Convert.ToInt32(Jor_ser[1]);
                //}

                //else
                //{
                //    JorSer = Convert.ToInt32(txtJorSer.Text);
                //}



                //addJor();

                //dal.Execute_1(@"UPDATE serial_no SET daily_sn_ser='" + txtSanadSer.Text + "' , main_daily_ser = '" + JorSer + "' WHERE BRANCH_CODE=  '" + _branch + "' and ACC_YEAR='" + txtYear.Text + "' ");

                //    dal.Execute_1(@"UPDATE LoanPaymentTbl SET Jor_ser_no = '" + txtJorSer.Text + "' WHERE id =  '" + txtID.Text + "' ");


                //    MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else
            {
                MessageBox.Show("تاكد من حفظ السداد اولا");
            }
        }


       private void JorValidate()
        {
            if (txtPaymentAmount.Value <= 0)
            {
                MessageBox.Show("تأكد من مبلغ السداد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtLoanAcc.ID.Text == string.Empty)
            {
                MessageBox.Show("تأكد من حساب القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoanAcc.Focus();
                return;
            }
            if (BName.ID.Text == string.Empty)
            {
                MessageBox.Show("تأكد من حساب البنك", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BName.Focus();
                return;
            }
            if (!dal.IsDateTime(jorDate.Text))
            {
                MessageBox.Show("تأكد تاريخ القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                jorDate.Focus();
                return;
            }

            if (!dal.IsDateTime(PaymentDate.Text))
            {
                MessageBox.Show("تأكد تاريخ سدادالقرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PaymentDate.Focus();
                return;
            }
        }

        private void addJor()
        {

            //if (dal.sqlconn_1.State == ConnectionState.Closed)
            //{
            //    dal.sqlconn_1.Open();
            //}
            //SqlCommand cmd = dal.sqlconn_1.CreateCommand();
            //SqlTransaction trans;
            //trans = dal.sqlconn_1.BeginTransaction();
            //cmd.Connection = dal.sqlconn_1;
            //cmd.Transaction = trans;


            //try
            //{


                JorValidate();



                int JorSer;

                if (txtJorSer.Text != string.Empty)
                {
                dal.Execute_1(@"delete from daily_transaction where ser_no='" + txtJorSer.Text + "' and Branch_code='" + _branch + "'");
                    //cmd.ExecuteNonQuery();
                }
                else
                {
                    getJorSer();
                }   


                if (txtJorSer.Text.Contains('M'))
                {
                    var Jor_ser = txtJorSer.Text.Split('M');
                    JorSer = Convert.ToInt32(Jor_ser[1]);
                }

                else
                {
                    JorSer = Convert.ToInt32(txtJorSer.Text);
                }

                string DbDesc = "سداد قرض رقم " + txtLoanNo.Text + " - " + PaymentDate.Text.ToString();
                dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + txtLoanAcc.ID.Text + "','" + _branch + "','" +
                txtJorSer.Text + "','1','" + txtPaymentAmount.Value + "','0','" + txtPaymentAmount.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + DbDesc + "','0','1','" + JorSer + "')");
                //cmd.ExecuteNonQuery();

                if (PaymentInterest.Value > 0)
                {
                    string intrestDbDesc = "فائدة قرض رقم " + txtLoanNo.Text + " - " + PaymentDate.Text.ToString();
                dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + txtInterestAcc.ID.Text + "','" + _branch + "','" +
                txtJorSer.Text + "','1','" + PaymentInterest.Value + "','0','" + PaymentInterest.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + intrestDbDesc + "','0','1','" + JorSer + "')");

                    //cmd.ExecuteNonQuery();
                }




                string crDesc = "سداد الدفعة رقم " + txtPaymentNo.Text + " من القرض - " + PaymentDate.Text.ToString();
            dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + BName.ID.Text + "','" + _branch + "','" +
            txtJorSer.Text + "','1','0','" + txtPaymentAmount.Value + "','" + -txtPaymentAmount.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
            "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + crDesc + "','0','1','" + JorSer + "')");
                //cmd.ExecuteNonQuery();

                if (PaymentInterest.Value > 0)
                {
                    string intrestDbDesc = "فائدة قرض رقم " + txtLoanNo.Text + " - " + PaymentDate.Text.ToString();
                dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + BName.ID.Text + "','" + _branch + "','" +
                txtJorSer.Text + "','1','0','" + PaymentInterest.Value + "','" + -PaymentInterest.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + intrestDbDesc + "','0','1','" + JorSer + "')");

                    //cmd.ExecuteNonQuery();
                }

            dal.Execute_1(@"UPDATE LoanPaymentTbl SET Jor_ser_no = '" + txtJorSer.Text + "' WHERE id =  '" + txtID.Text + "' ");
           // cmd.ExecuteNonQuery();

            dal.Execute_1(@"UPDATE serial_no SET daily_sn_ser='" + txtSanadSer.Text + "' , main_daily_ser = '" + JorSer + "' WHERE BRANCH_CODE=  '" + _branch + "' and ACC_YEAR='" + txtYear.Text + "' ");
            //cmd.ExecuteNonQuery();

            MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //    trans.Commit();

            //}
            //catch (Exception ex)
            //{


            //    trans.Rollback();
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    dal.sqlconn_1.Close();
            //}


        }

        private void UpdateJor()
        {

            if (dal.sqlconn_1.State == ConnectionState.Closed)
            {
                dal.sqlconn_1.Open();
            }
            SqlCommand cmd = dal.sqlconn_1.CreateCommand();
            SqlTransaction trans;
            trans = dal.sqlconn_1.BeginTransaction();
            cmd.Connection = dal.sqlconn_1;
            cmd.Transaction = trans;


            try
            {

                JorValidate();


                //if (txtPaymentAmount.Value <= 0)
                //{
                //    MessageBox.Show("تأكد من مبلغ السداد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                //if (txtLoanAcc.ID.Text == string.Empty)
                //{
                //    MessageBox.Show("تأكد من حساب القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtLoanAcc.Focus();
                //    return;
                //}
                //if (BName.ID.Text == string.Empty)
                //{
                //    MessageBox.Show("تأكد من حساب البنك", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    BName.Focus();
                //    return;
                //}
                //if (!dal.IsDateTime(jorDate.Text))
                //{
                //    MessageBox.Show("تأكد تاريخ القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    jorDate.Focus();
                //    return;
                //}

                //if (!dal.IsDateTime(PaymentDate.Text))
                //{
                //    MessageBox.Show("تأكد تاريخ سدادالقرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    PaymentDate.Focus();
                //    return;
                //}

                int JorSer;

                if (txtJorSer.Text != string.Empty)
                {
                    cmd.CommandText = @"delete from daily_transaction where ser_no='" + txtJorSer.Text + "' and Branch_code='" + _branch + "'";
                    cmd.ExecuteNonQuery();



                    if (txtJorSer.Text.Contains('M'))
                    {
                        var Jor_ser = txtJorSer.Text.Split('M');
                        JorSer = Convert.ToInt32(Jor_ser[1]);
                    }

                    else
                    {
                        JorSer = Convert.ToInt32(txtJorSer.Text);
                    }

                    string DbDesc = "سداد قرض رقم " + txtLoanNo.Text + " - " + PaymentDate.Text.ToString();
                    cmd.CommandText = @"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + txtLoanAcc.ID.Text + "','" + _branch + "','" +
                    txtJorSer.Text + "','1','" + txtPaymentAmount.Value + "','0','" + txtPaymentAmount.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                    "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + DbDesc + "','0','1','" + JorSer + "')";
                    cmd.ExecuteNonQuery();

                    if (PaymentInterest.Value > 0)
                    {
                        string intrestDbDesc = "فائدة قرض رقم " + txtLoanNo.Text + " - " + PaymentDate.Text.ToString();
                        cmd.CommandText = @"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + txtInterestAcc.ID.Text + "','" + _branch + "','" +
                    txtJorSer.Text + "','1','" + PaymentInterest.Value + "','0','" + PaymentInterest.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                    "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + intrestDbDesc + "','0','1','" + JorSer + "')";

                        cmd.ExecuteNonQuery();
                    }




                    string crDesc = "سداد الدفعة رقم " + txtPaymentNo.Text + " من القرض - " + PaymentDate.Text.ToString();
                    cmd.CommandText = @"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + BName.ID.Text + "','" + _branch + "','" +
                txtJorSer.Text + "','1','0','" + txtPaymentAmount.Value + "','" + -txtPaymentAmount.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + crDesc + "','0','1','" + JorSer + "')";
                    cmd.ExecuteNonQuery();

                    if (PaymentInterest.Value > 0)
                    {
                        string intrestDbDesc = "فائدة قرض رقم " + txtLoanNo.Text + " - " + PaymentDate.Text.ToString();
                        cmd.CommandText = @"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + BName.ID.Text + "','" + _branch + "','" +
                    txtJorSer.Text + "','1','0','" + PaymentInterest.Value + "','" + -PaymentInterest.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                    "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + intrestDbDesc + "','0','1','" + JorSer + "')";

                        cmd.ExecuteNonQuery();
                    }

                    
                    MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    trans.Commit();
                }
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



        private void getJorSer()
        {

            txtJorSer.Text = "M" + dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) from serial_no where BRANCH_CODE='" + _branch
                     + "' and ACC_YEAR= '" + txtYear.Text + "'").Rows[0][0].ToString().PadLeft(4, '0');

            txtSanadSer.Text = dal.getDataTabl_1(@"select isnull(daily_sn_ser+1,1) from serial_no where BRANCH_CODE='" + _branch
                + "' and ACC_YEAR= '" + txtYear.Text + "' ").Rows[0][0].ToString();//.PadLeft(4, '0');


        }

        private void BName_Load(object sender, EventArgs e)
        {
            DataTable dtBank = dal.getDataTabl_1(@"select * from BanksTbl where Acc_nO='" + BName.ID.Text + "'");
            if (dtBank.Rows.Count > 0)
            {

               txtInterestAcc.ID.Text = dtBank.Rows[0]["LoanIntrestAccNo"].ToString();
                //clc_openFees();
            }
        }

        private void BalanceBeforPay_ValueChanged(object sender, EventArgs e)
        {
            if (BalanceBeforPay.Value <= 0)
            {
                lbl_1.Visible = true;
            }
            else
            {
                lbl_1.Visible = false;
            }
        }
    }
}