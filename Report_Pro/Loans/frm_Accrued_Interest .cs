using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.Loans
{
    public partial class frm_Accrued_Interest : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Accrued_Interest()
        {
            InitializeComponent();
        }

        private void btnAccruedIntrrest_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;

            DataTable dt_ = dal.getDataTabl_1(@"SELECT A.id,A.LoanNo,A.BankId,A.LoanACC,A.LoanDate,A.NumberOfPayments,A.LoanValue,A.PaymentNo,A.PaymentValue
            ,A.StartDate,A.MaturityDate,A.Rate,A.LoanPurpose,A.LoanRefrance,A.Branch_code,A.Jor_ser_no
            ,B.PAYER_NAME,B.payer_l_name,C.Loan_Purpose,C.Loan_Purpose_E
			,SUM(CASE WHEN  cast( D.PaymentDate  as date) <= '"+toDate.Value.ToString("yyyy-MM-dd")+"' THEN  D.PaymentAmount else 0 END) as payment "+
            ",SUM(CASE WHEN  cast( D.PaymentDate  as date) <= '"+toDate.Value.ToString("yyyy-MM-dd")+"' THEN  D.PayMentInterest else 0 END) as PayMentInterest "+
            ",D.PaymentDate "+
            "FROM LoansTbl As A "+
            "inner Join payer2 as B  on A.BankId=B.ACC_NO and A.Branch_code=B.BRANCH_code "+
            "left join LoanPurpose as C on c.Id=A.LoanPurpose "+
            "left join LoanPaymentTbl As D on A.LoanNo = D.LoanNo  and A.PaymentNo = D.PaymentNo "+
            "where  A.BankId like '"+txtBank.ID.Text+ "%' and A.StartDate <='"+ toDate.Value.ToString("yyyy-MM-dd") + "' " +
            "group by A.id,A.LoanNo,A.BankId,A.LoanACC,A.LoanDate,A.NumberOfPayments,A.LoanValue,A.PaymentNo,A.PaymentValue "+
            ",A.StartDate,A.MaturityDate,A.Rate,A.LoanPurpose,A.LoanRefrance,A.Branch_code,A.Jor_ser_no "+
            ",B.PAYER_NAME,B.payer_l_name,C.Loan_Purpose,C.Loan_Purpose_E ,D.PaymentDate");



            //RPT.Form1 frm = new RPT.Form1();
            //RPT.rpt_DailyEntry rpt = new RPT.rpt_DailyEntry();
            //rpt.SetDataSource(dt_);
            RPT.reportDS ds = new RPT.reportDS();
            ds.Tables["dt_LoandDetials"].Merge(dt_);
            Loans.rpt_Accrued_Interest rpt = new Loans.rpt_Accrued_Interest();
            rpt.SetDataSource(dt_);

            crystalReportViewer1.ReportSource = rpt;
            rpt.SetParameterValue("accrued_Date",toDate.Value.ToString("yyyy-MM-dd"));

            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Bank_Name"].Text = "'" + txtBank.Desc.Text + "'";
            //rpt.DataDefinition.FormulaFields["companyName"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            //rpt.DataDefinition.FormulaFields["branchName"].Text = "'" + dt_.Rows[0]["BRANCH_name"].ToString() + "'";




            //ds.WriteXmlSchema("schema_rpt.xml");




        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
    }
}
