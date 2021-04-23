﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                DataTable loanData = dal.getDataTabl_1(@"SELECT *  FROM LoansTbl where LoanNo='" + txtLoanNo.Text + "' and PaymentNo='" + txtPaymentNo.Text + "'");
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
                    PaymentAmount.Text = loanData.Rows[0]["PaymentValue"].ToString();
                    PaymentDate.Value = DateTime.Today;
              
                }
                else
                {
                    BName.ID.Clear();
                    txtLoanAcc.ID.Clear();
                    //txtLoanNo.Clear();
                    txtLoanPurpose.SelectedIndex = -1;
                    txtLoanRefrance.Clear();
                    Amount.Value = 0;
                    StartDate.Text = "";
                    MaturityDate.Text = "";

                }
            getPaymentData();
            getBalance();
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

                PaymentAmount.Text = PaymentData.Rows[0]["PaymentAmount"].ToString();
                PaymentInterest.Text = PaymentData.Rows[0]["PayMentInterest"].ToString();
                PaymentDate.Text = PaymentData.Rows[0]["PaymentDate"].ToString();
                txtJorSer.Text = PaymentData.Rows[0]["Jor_ser_no"].ToString();


            }
                else
                {
                    txtID.Clear();
                    PaymentAmount.Value = 0;
                    PaymentInterest.Value = 0;
                    PaymentDate.Text = "";
               

                }

            //}
            //catch
            //{

            //}
        }


        private void clearData()
        {
            BName.ID.Clear();
            txtPaymentNo.Value = 1;
            txtLoanAcc.ID.Clear();
            txtLoanNo.Clear();
            txtLoanPurpose.SelectedIndex = -1;
            txtLoanRefrance.Clear();
            Amount.Value = 0;
            StartDate.Text = "";
            MaturityDate.Text = "";
            txtID.Clear();
            PaymentAmount.Value = 0;
            PaymentInterest.Value = 0;
            PaymentDate.Text = "";

        }

        private  void getBalance()
        {
            decimal paidAmount = 0;
            decimal interest = 0;
            int days = 0;
            DataTable dtBalance = dal.getDataTabl_1("select sum (PaymentAmount),sum(PayMentInterest) from LoanPaymentTbl where LoanNo = '" + txtLoanNo.Text+"' and PaymentNo ='"+txtPaymentNo.Value+"' and id <> '"+txtID.Text+"'");
            if (dtBalance.Rows.Count > 0)
            {
                paidAmount = dtBalance.Rows[0][0].ToString().ToDecimal()+PaymentAmount.Text.ToDecimal();
                interest = dtBalance.Rows[0][1].ToString().ToDecimal() + PaymentInterest.Text.ToDecimal();

                days = System.Data.Linq.SqlClient.SqlMethods.DateDiffDay(StartDate.Value, PaymentDate.Value);
                
            }
            else
            {
                paidAmount= 0;
                interest = 0;
                days = 0;

            }
            LoanBalance.Text = (Amount.Value.ToString().ToDecimal() - paidAmount).ToString("N2");
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
            clearData();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            //ResourceManager rm = new ResourceManager("Report_Pro.Lang.Langres", a);


            if (PaymentAmount.Value > 0 && dal.IsDateTime(PaymentDate.Text))
            {
                DataTable dt_ = dal.getDataTabl_1(@"select * from LoanPaymentTbl where id='" + txtID.Text.ParseInt(0) + "'");
                if (dt_.Rows.Count > 0)
                {

                        dal.Execute_1(@"UPDATE LoanPaymentTbl set 
                        LoanNo ='" + txtLoanNo.Text + 
                        "',PaymentNo ='" + txtPaymentNo.Value + 
                        "',PaymentAmount='" + PaymentAmount.Value + 
                        "',PayMentInterest='" + PaymentInterest.Value + 
                        "',PaymentDate='" + PaymentDate.Value.ToString("yyyy/MM/dd") +
                        "' where  id='" +txtID.Text+"'");

                    if (txtJorSer.Text != string.Empty)
                    {
                        dal.Execute_1(@"delete from daily_transaction where ser_no='" + txtJorSer.Text + "' and Branch_code='" + _branch + "'");
                    }
                    addJor();

                    MessageBox.Show(dal.rm.GetString("msgEdit", dal.cul), dal.rm.GetString("msgEdit_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    dal.Execute_1(@"INSERT INTO LoanPaymentTbl(LoanNo,PaymentNo,PaymentAmount,PayMentInterest,PaymentDate)
                     VALUES ('" + txtLoanNo.Text + "','" + txtPaymentNo.Value + "','" + PaymentAmount.Value + "','" + PaymentInterest.Value +
                        "','" + PaymentDate.Value.ToString("yyyy/MM/dd") + "')");
                    MessageBox.Show(dal.rm.GetString("msgSave", dal.cul), "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                getBalance();
            }
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            Loans.frmLoanPaymentSearch frm = new Loans.frmLoanPaymentSearch();
            frm.ShowDialog();
            txtID.Text = frm.DGV1.CurrentRow.Cells[0].Value.ToString();
            txtLoanNo.Text= frm.DGV1.CurrentRow.Cells[1].Value.ToString();
            txtPaymentNo.Text = frm.DGV1.CurrentRow.Cells[2].Value.ToString();
            getLoanData();
            
           
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
            DataTable dt_1 = dal.getDataTabl_1(@"SELECT * FROM LoanPaymentTbl where id = '"+txtID.Text+"'");

            if (dt_1.Rows.Count > 0)
            {
                int JorSer;
                if (txtJorSer.Text.Contains('M'))
                {
                    var Jor_ser = txtJorSer.Text.Split('M');
                    JorSer = Convert.ToInt32(Jor_ser[1]);
                }

                else
                {
                    JorSer = Convert.ToInt32(txtJorSer.Text);
                }

                getJorSer();

                addJor();

                dal.Execute_1(@"UPDATE serial_no SET daily_sn_ser='" + txtSanadSer.Text + "' , main_daily_ser = '" + JorSer + "' WHERE BRANCH_CODE=  '" + _branch + "' and ACC_YEAR='" + txtYear.Text + "' ");

                    dal.Execute_1(@"UPDATE LoanPaymentTbl SET Jor_ser_no = '" + txtJorSer.Text + "' WHERE id =  '" + txtID.Text + "' ");


                    MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            else
            {
                MessageBox.Show("تاكد من حفظ السداد اولا");
            }
        }


        private void addJor()
        {

           
            if (PaymentAmount.Value <= 0)
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

            int JorSer;
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
            txtJorSer.Text + "','1','" + PaymentAmount.Value + "','0','" + PaymentAmount.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
            "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + DbDesc + "','0','1','" + JorSer + "')");

            if (PaymentInterest.Value > 0)
            {
                string intrestDbDesc = "فائدة قرض رقم " + txtLoanNo.Text + " - " + PaymentDate.Text.ToString();
                dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + txtInterestAcc.ID.Text + "','" + _branch + "','" +
                txtJorSer.Text + "','1','" + PaymentInterest.Value + "','0','" + PaymentInterest.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + intrestDbDesc + "','0','1','" + JorSer + "')");

            }




            string crDesc = "سداد الدفعة رقم " + txtPaymentNo.Text + " من القرض - " + PaymentDate.Text.ToString();
            dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + BName.ID.Text + "','" + _branch + "','" +
            txtJorSer.Text + "','1','0','" + PaymentAmount.Value + "','" + -PaymentAmount.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
            "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + crDesc + "','0','1','" + JorSer + "')");

            if (PaymentInterest.Value > 0)
            {
                string intrestDbDesc = "فائدة قرض رقم " + txtLoanNo.Text + " - " + PaymentDate.Text.ToString();
                dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + BName.ID.Text + "','" + _branch + "','" +
                txtJorSer.Text + "','1','0','" + PaymentInterest.Value + "','" + -PaymentInterest.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + intrestDbDesc + "','0','1','" + JorSer + "')");

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

        private void btnPrintJor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            DataTable dt_ = dal.getDataTabl_1(@"select A.ser_no,A.ACC_NO,A.g_date,A.desc2,
            a.meno,A.loh,A.sanad_no,A.BRANCH_code,A.user_name,A.COST_CENTER,
            A.CAT_CODE ,B.PAYER_NAME,B.payer_l_name,C.COST_name,C.COST_E_NAME,
            D.CAT_NAME,E.BRANCH_name,E.BRANCH_E_NAME
            from daily_transaction as A
            inner join payer2 as B on A.ACC_NO = B.ACC_NO and a.BRANCH_code=B.BRANCH_code
            inner join COST_CENTER  as C on a.COST_CENTER = C.COST_CODE
            inner Join CATEGORY as D on D.CAT_CODE=A.CAT_CODE
            inner join BRANCHS as E on A.BRANCH_code=E.BRANCH_code

            where a.ser_no='" + txtJorSer.Text + "' and A.BRANCH_CODE = 'A1110'");

            DataTable dt_Loan = dal.getDataTabl_1(@"SELECT A.id,A.LoanNo,A.BankId,A.LoanACC,A.LoanDate,A.NumberOfPayments,A.LoanValue,A.PaymentNo,A.PaymentValue
            ,A.StartDate,A.MaturityDate,A.Rate,A.LoanPurpose,A.LoanRefrance,A.Branch_code,A.Jor_ser_no
            ,B.PAYER_NAME,B.payer_l_name,C.Loan_Purpose,C.Loan_Purpose_E
              FROM LoansTbl As A
              inner Join payer2 as B  on A.BankId=B.ACC_NO and A.Branch_code=B.BRANCH_code
              inner join LoanPurpose as C on c.Id=A.LoanPurpose
              where A.LoanNo='" + txtLoanNo.Text + "'");



            RPT.Form1 frm = new RPT.Form1();
            RPT.rpt_DailyEntry rpt = new RPT.rpt_DailyEntry();
            RPT.reportDS ds = new RPT.reportDS();
            ds.Tables["dt_JorPrint"].Merge(dt_);
            ds.Tables["dt_LoandDetials"].Merge(dt_Loan);
            rpt.SetDataSource(ds);
            frm.crystalReportViewer1.ReportSource = rpt;

            // rpt.DataDefinition.FormulaFields["branchCode"].Text = "'" + dt_.Rows[0]["BRANCH_code"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["companyName"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            //  rpt.DataDefinition.FormulaFields["branchName"].Text = "'" +dt_.Rows[0]["BRANCH_name"].ToString()+"'";


            frm.ShowDialog();

            //ds.WriteXmlSchema("schema_rpt.xml");


            Cursor.Current = Cursors.Default;


        }
    }
}