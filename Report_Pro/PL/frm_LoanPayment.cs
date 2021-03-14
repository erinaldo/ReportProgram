using DevExpress.Utils.Filtering.Internal;
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

namespace Report_Pro.PL
{
    public partial class frm_LoanPayment : Form
    {
        CultureInfo cul;
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
            PL.frmLoanSearch frm = new PL.frmLoanSearch();
            frm.ShowDialog();
            txtLoanNo.Text = frm.DGV1.CurrentRow.Cells[2].Value.ToString();
            txtPaymentNo.Text = frm.DGV1.CurrentRow.Cells[3].Value.ToString();

            getLoanData();
           
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
            ResourceManager rm = new ResourceManager("Report_Pro.Lang.Langres", a);


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
                    MessageBox.Show(rm.GetString("msgEdit", cul), rm.GetString("msgEdit_H", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    dal.Execute_1(@"INSERT INTO LoanPaymentTbl(LoanNo,PaymentNo,PaymentAmount,PayMentInterest,PaymentDate)
                     VALUES ('" + txtLoanNo.Text + "','" + txtPaymentNo.Value + "','" + PaymentAmount.Value + "','" + PaymentInterest.Value +
                        "','" + PaymentDate.Value.ToString("yyyy/MM/dd") + "')");
                    MessageBox.Show(rm.GetString("msgSave", cul), "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                getBalance();
            }
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            PL.frmLoanPaymentSearch frm = new PL.frmLoanPaymentSearch();
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
    }
}