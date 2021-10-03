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
    public partial class frm_LoansReports : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_LoansReports()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnReportToal_Click(object sender, EventArgs e)
        {

            DataTable dt = dal.getDataTabl_1(@"select A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.LoanValue,
            SUM(CASE WHEN  cast( B.PaymentDate  as date) <= '" + toDate.Value.ToString("yyyy/MM/dd") + "' THEN  B.PaymentAmount else 0 END) as payment " +
            "from LoansTbl As A " +
            "left join LoanPaymentTbl As B on A.LoanNo = B.LoanNo  and A.PaymentNo = B.PaymentNo " +
            "inner Join(select* from (select*, ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount " +
            "FROM payer2 As P) as t1  where t1.DuplicateCount = 1 ) as C on C.ACC_NO = A.BankId where A.BankId like '" + txtBank.ID.Text+"%' and " +
            "StartDate <= '" + toDate.Value.ToString("yyyy/MM/dd") + "' " +
            "group by A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.LoanValue");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("schema_rpt.xml");
            Loans.rpt_LoansReportTotal rpt = new Loans.rpt_LoansReportTotal();
            rpt.SetDataSource (ds);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";


        }

        private void btnMaturityLoans_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.getDataTabl_1(@"select  A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo,A.PaymentValue,
          SUM(CASE WHEN  cast( B.PaymentDate  as date) <= '" + toDate.Value.ToString("yyyy/MM/dd") + "' THEN  B.PaymentAmount else 0 END) as PaymentAmount " +
          "from LoansTbl As A " +
          "left join LoanPaymentTbl As B on A.LoanNo = B.LoanNo  and A.PaymentNo = B.PaymentNo " +
          "inner Join(select* from (select*, ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount " +
          "FROM payer2 As P) as t1  where t1.DuplicateCount = 1) as C " +
          "on C.ACC_NO = A.BankId where A.BankId like '" + txtBank.ID.Text + "%' and " +
          "A.MaturityDate between '" + fromDate.Value.ToString("yyyy/MM/dd") + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "' " +
          "group by A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo,A.PaymentValue");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("schema_rpt.xml");
            Loans.rpt_LoansMaturity rpt = new Loans.rpt_LoansMaturity();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;

            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";
            string rptTitel = "Due Loans";
            rpt.DataDefinition.FormulaFields["reportTitel"].Text = "'"+rptTitel+"'";

        }

        private void frm_LoansReports_Load(object sender, EventArgs e)
        {

        }

        private void btnNewLoans_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.getDataTabl_1(@"select  A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo,A.PaymentValue,
          SUM(CASE WHEN  cast( B.PaymentDate  as date) <= '" + toDate.Value.ToString("yyyy/MM/dd") + "' THEN  B.PaymentAmount else 0 END) as PaymentAmount " +
         "from LoansTbl As A " +
         "left join LoanPaymentTbl As B on A.LoanNo = B.LoanNo  and A.PaymentNo = B.PaymentNo " +
         "inner Join(select* from (select*, ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount " +
         "FROM payer2 As P) as t1  where t1.DuplicateCount = 1) as C " +
         "on C.ACC_NO = A.BankId where A.BankId like '" + txtBank.ID.Text + "%' and " +
         "A.StartDate between '" + fromDate.Value.ToString("yyyy/MM/dd") + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "' " +
         "group by A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo,A.PaymentValue");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("schema_rpt.xml");
            Loans.rpt_LoansMaturity rpt = new Loans.rpt_LoansMaturity();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;

            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";
            string rptTitel = "New Loans";
            rpt.DataDefinition.FormulaFields["reportTitel"].Text = "'"+rptTitel+"'";
        }

        private void btnPaymentsLoans_Click(object sender, EventArgs e)
        {
            DataTable dt = dal.getDataTabl_1(@"select T.* from  (select  A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo,A.PaymentValue,
          SUM(CASE WHEN  cast( B.PaymentDate  as date) <= '" + toDate.Value.ToString("yyyy/MM/dd") + "' THEN  B.PaymentAmount else 0 END) as PaymentAmount " +
        "from LoansTbl As A " +
        "left join LoanPaymentTbl As B on A.LoanNo = B.LoanNo  and A.PaymentNo = B.PaymentNo " +
        "inner Join(select* from (select*, ROW_NUMBER() OVER(PARTITION BY p.Acc_no ORDER BY p.acc_no) AS DuplicateCount " +
        "FROM payer2 As P) as t1  where t1.DuplicateCount = 1) as C " +
        "on C.ACC_NO = A.BankId " +
        " where  A.BankId like '" + txtBank.ID.Text + "%' and " +
        "B.PaymentDate between '" + fromDate.Value.ToString("yyyy/MM/dd") + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "' " +
        "group by A.BankId,C.PAYER_NAME,C.payer_l_name,A.LoanNo,A.LoanACC,A.StartDate,A.MaturityDate,A.PaymentNo,A.PaymentValue) as T  where PaymentAmount>0");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("schema_rpt.xml");
            Loans.rpt_LoansMaturity rpt = new Loans.rpt_LoansMaturity();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;

            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + fromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + toDate.Value.ToString("yyyy/MM/dd") + "'";
            string rptTitel = "Paid Loans";
            rpt.DataDefinition.FormulaFields["reportTitel"].Text = "'" + rptTitel + "'";

        }
    }
}
