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
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmLoan : Form
    {
        CultureInfo cul;
        string _branch = Properties.Settings.Default.BranchAccID;
        Assembly a = Assembly.Load("Report_Pro");

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frmLoan()
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

        private void BSave_Click(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager("Report_Pro.Lang.Langres", a);

            foreach (MyControls.LoanRow r in flowLayoutPanel1.Controls)
                    {

                        if (r.PayValue.Value > 0 && dal.IsDateTime(r.startDate.Text) && dal.IsDateTime(r.maturityDate.Text))
                        {
                            DataTable dt_ = dal.getDataTabl_1(@"select * from LoansTbl where id='" + txtLoanId.Text + "' and PaymentNo='" + r.paySer.Text + "' ");
                            if (dt_.Rows.Count > 0)
                            {
                               
                                dal.Execute_1(@"UPDATE LoansTbl set LoanNo='" + txtLoanNo.Text + "',BankId='" + BName.ID.Text + "',LoanACC='" + txtLoanAcc.ID.Text +
                                    "',NumberOfPayments='" + NoOfPayments.Value + "',LoanValue='" + txtLoanValue.Value + "',PaymentNo='" + r.paySer.Value +
                                    "', PaymentValue='" + r.PayValue.Value + "',StartDate='" + r.startDate.Value.ToString("yyyy-MM-dd") +
                                    "', MaturityDate='" + r.maturityDate.Value.ToString("yyyy-MM-dd") + "', Rate='" + r.intrestRate.Value +
                                    "',LoanPurpose='"+ Convert.ToString(txtLoanPurpose.SelectedValue) + "',LoanRefrance='" + txtLoanRefrance.Text +
                                    "',Branch_code = '"+_branch +"' where  id='" + txtLoanId.Text +"' and PaymentNo='" + r.paySer.Text + "' ");
                        MessageBox.Show(rm.GetString("msgEdit", cul), rm.GetString("msgEdit_H", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                            {
                               
                                dal.Execute_1(@"INSERT INTO LoansTbl(id,LoanNo,BankId,LoanACC,NumberOfPayments,LoanValue,PaymentNo,
                            PaymentValue,StartDate,MaturityDate,Rate,LoanPurpose,LoanRefrance,Branch_code)
                            VALUES(  '" + txtLoanId.Text + "', '" + txtLoanNo.Text + "','" + BName.ID.Text + "','" + txtLoanAcc.ID.Text + "','" + NoOfPayments.Value +
                                    "','" + txtLoanValue.Value + "','" + r.paySer.Value + "','" + r.PayValue.Value + "','" + r.startDate.Value.ToString("yyyy-MM-dd") +
                                    "','" + r.maturityDate.Value.ToString("yyyy-MM-dd") + "','" + r.intrestRate.Value + "','" + Convert.ToString( txtLoanPurpose.SelectedValue)+"', '" + txtLoanRefrance.Text + "','"+_branch+"')");
                        MessageBox.Show(rm.GetString("msgSave", cul), "تعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                    }

                    dal.Execute_1(@"delete from LoansTbl where id='" + txtLoanId.Text + "' and PaymentNo >'" + flowLayoutPanel1.Controls.Count + "' ");


                }

        private void txtLoanNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoanValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void addRows()
        {
            //try
            //{
            if ((NoOfPayments.Value - flowLayoutPanel1.Controls.Count) > 0)
            {
                for (int i = 1; i <= (NoOfPayments.Value - flowLayoutPanel1.Controls.Count); i++)
                {
                    MyControls.LoanRow r = new MyControls.LoanRow();
                    flowLayoutPanel1.Controls.Add(r);
                    r.paySer.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                    r.intrestRate.Value = txtIntrestRate.Value;
                }
            }
            else if ((NoOfPayments.Value - flowLayoutPanel1.Controls.Count) < 0)
            {
                for (int i = 1; i <= (flowLayoutPanel1.Controls.Count - NoOfPayments.Value); i++)

                {
                    flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                }
            }
            //}
            //catch { }

        }

     
        private void NoOfPayments_ValueChanged(object sender, EventArgs e)
        {
            addRows();
        }

        private void frmLoan_Load(object sender, EventArgs e)
        {
            getLoanID();
            addRows();
        }

        private void getLoanID()
        {
            txtLoanId.Text = dal.GetCell_1("select isnull(MAX(id)+1,1) from LoansTbl").ToString();

        }

        private void txtLoanId_TextChanged(object sender, EventArgs e)
        {
            showLoanData(txtLoanId.Text.ParseInt(0));
        }

        private void showLoanData(int id_)
        {

           // string InvNum = lcNo_ + "-" + invNo_;
            DataTable loanData = dal.getDataTabl_1(@"SELECT *  FROM LoansTbl where id='" + id_ + "'");
            if (loanData.Rows.Count > 0)
            {
                txtLoanId.Text = loanData.Rows[0]["Id"].ToString();
                BName.ID.Text= loanData.Rows[0]["BankId"].ToString();
                txtLoanAcc.ID.Text = loanData.Rows[0]["LoanACC"].ToString();
                NoOfPayments.Text = loanData.Rows[0]["NumberOfPayments"].ToString();
                txtLoanNo.Text = loanData.Rows[0]["LoanNo"].ToString();
                txtIntrestRate.Text = loanData.Rows[0]["Rate"].ToString().ToDecimal().ToString();
                txtLoanValue.Text = loanData.Rows[0]["LoanValue"].ToString();
                txtLoanPurpose.SelectedIndex= loanData.Rows[0]["LoanPurpose"].ToString().ParseInt(0);
                txtLoanRefrance.Text= loanData.Rows[0]["LoanRefrance"].ToString(); 
                int i = 0;
                flowLayoutPanel1.Controls.Clear();

                foreach (DataRow r in loanData.Rows)
                {


                    MyControls.LoanRow row = new MyControls.LoanRow();
                    row.paySer.Text = loanData.Rows[i]["PaymentNo"].ToString();
                    row.PayValue.Text = loanData.Rows[i]["PaymentValue"].ToString();
                    row.startDate.Text = loanData.Rows[i]["StartDate"].ToString();
                    row.maturityDate.Text = loanData.Rows[i]["MaturityDate"].ToString();
                    row.intrestRate.Text = loanData.Rows[i]["Rate"].ToString().ToDecimal().ToString();

                    flowLayoutPanel1.Controls.Add(row);
                    i = i + 1;
                }
            }
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            PL.frmLoanSearch frm = new PL.frmLoanSearch();
            frm.ShowDialog();
            txtLoanId.Text = frm.DGV1.CurrentRow.Cells[0].Value.ToString();
            gettot();

        }

        private void btnStatment_Click(object sender, EventArgs e)
        {

        }


        private void getJorSer()
        {

            txtJorSer.Text = "M" + dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) from serial_no where BRANCH_CODE='" + _branch
                     + "' and ACC_YEAR= '" + txtYear.Text + "'").Rows[0][0].ToString().PadLeft(4, '0');

            txtSanadSer.Text = dal.getDataTabl_1(@"select isnull(daily_sn_ser+1,1) from serial_no where BRANCH_CODE='" + _branch
                + "' and ACC_YEAR= '" + txtYear.Text + "' ").Rows[0][0].ToString();//.PadLeft(4, '0');


        }

        private void btnCreateJor_Click(object sender, EventArgs e)
        {
            int JorSer;
            getJorSer();
            gettot();
            if (txtLoanValue.Value <= 0 || txtTotal.Value <= 0 || txtLoanValue.Value != txtTotal.Value)
            {
                MessageBox.Show("تأكد من توازن القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

            string DbDesc = "صرف قرض رقم " + txtLoanNo.Text;
            dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                   , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + BName.ID.Text + "','" + _branch + "','" +
                   txtJorSer.Text + "','1','"+txtLoanValue.Value+"','0','" + txtLoanValue.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                   "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + DbDesc + "','0','1','" + JorSer + "')");


            foreach (MyControls.LoanRow r in flowLayoutPanel1.Controls)
            {

                if (r.PayValue.Value > 0 && dal.IsDateTime(r.startDate.Text) && dal.IsDateTime(r.maturityDate.Text))
                {

                    string crDesc = "صرف الدفعة رقم " + r.paySer.Text + " من القرض";

                    dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                   , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + txtLoanAcc.ID.Text + "','" + _branch + "','" +
                    txtJorSer.Text + "','1','0','" + r.PayValue.Value + "','" + -r.PayValue.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                    "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + crDesc + "','0','1','" + JorSer + "')");

                }

                dal.Execute_1(@"UPDATE serial_no SET daily_sn_ser='" + txtSanadSer.Text + "' , main_daily_ser = '" + JorSer + "' WHERE BRANCH_CODE=  '" + _branch + "' and ACC_YEAR='" + txtYear.Text + "' ");

                dal.Execute_1(@"UPDATE LoansTbl SET Jor_ser_no = '" + txtJorSer + "' WHERE id =  '" + txtLoanId + "' ");


                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        public void gettot()
        {
            double totDb = 0;
          
            foreach (MyControls.LoanRow c in flowLayoutPanel1.Controls)
            {

                totDb += c.PayValue.Value;
                txtTotal.Value = totDb;
               


            }
        }
    }
}
