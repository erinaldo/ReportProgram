using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
//using System.Linq;
using System.Reflection;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_rpt_Cut_off : Form
    {
        string db1 = Properties.Settings.Default.Database_1;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
      
             

        public frm_rpt_Cut_off()
        {
            InitializeComponent();
         
        }
    
     

   
   

     


           private void btnOption_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

      
    

       
   
        private void buttonX1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                RPT.rpt_Cut_Off rpt = new RPT.rpt_Cut_Off();
                DataSet1 ds = new DataSet1();
                DataTable dt_ = dal.getDataTabl_1(@" select X.* from (SELECT 
                ROW_NUMBER() OVER(PARTITION BY B.branch_name ORDER BY A.G_DATE desc) AS ser
                ,A.Ser_no, A.Branch_code,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_TAKE - D.QTY_ADD) As Qty_Add
                , ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) AS Value
                , sum(D.TAX_OUT-D.TAX_IN) As Vat, A.Transaction_code,
                A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no
		

                FROM    wh_inv_data as A
                INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
                INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
                INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
                INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
                AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
                inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
                inner join wh_main_master As S  on D.ITEM_NO = s.item_no
        

                where D.TRANSACTION_CODE like 'xs%' and D.TRANSACTION_CODE <> 'xsr' and D.TRANSACTION_CODE <> 'xst'
                and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + dTP2.Value.ToString("yyyy-MM-dd") +
                "'  group by   A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME, A.Transaction_code, A.Branch_code," +
                " A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no) as X  where ser <= 5 and Branch_code like '" + UC_Branch.ID.Text + "%' ");

                ds.Tables.Add(dt_);
                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                //rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المبيعات بالفواتير'";
                //rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + Uc_Acc.ID.Text + " - '+'" + Uc_Acc.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + payment_type.Text + "'";
                groupBox1.Visible = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

}

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                RPT.rpt_Cut_Off rpt = new RPT.rpt_Cut_Off();
                DataSet1 ds = new DataSet1();
                DataTable dt_ = dal.getDataTabl_1(@" select X.* from (SELECT 
                ROW_NUMBER() OVER(PARTITION BY B.branch_name ORDER BY A.G_DATE ) AS ser
                ,A.Ser_no, A.Branch_code,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_TAKE - D.QTY_ADD) As Qty_Add
                , ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) AS Value
                , sum(D.TAX_OUT-D.TAX_IN) As Vat, A.Transaction_code,
                A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no
                FROM    wh_inv_data as A
                INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
                INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
                INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
                INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
                AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
                inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
                inner join wh_main_master As S  on D.ITEM_NO = s.item_no
        
                where D.TRANSACTION_CODE like 'xs%' and D.TRANSACTION_CODE <> 'xsr' and D.TRANSACTION_CODE <> 'xst'
                and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + dTP2.Value.ToString("yyyy-MM-dd") +
                "'  group by   A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME, A.Transaction_code, A.Branch_code," +
                " A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no) as X  where ser <= 5 and Branch_code like '" + UC_Branch.ID.Text + "%' ");

                ds.Tables.Add(dt_);
                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                //rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المبيعات بالفواتير'";
                //rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + Uc_Acc.ID.Text + " - '+'" + Uc_Acc.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + payment_type.Text + "'";
                groupBox1.Visible = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

    



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                RPT.rpt_Cut_Off rpt = new RPT.rpt_Cut_Off();
                DataSet1 ds = new DataSet1();
                DataTable dt_ = dal.getDataTabl_1(@" select X.* from (SELECT 
                ROW_NUMBER() OVER(PARTITION BY B.branch_name ORDER BY A.G_DATE ) AS ser
                ,A.Ser_no, A.Branch_code,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_TAKE - D.QTY_ADD) As Qty_Add
                , ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) AS Value
                , sum(D.TAX_OUT-D.TAX_IN) As Vat, A.Transaction_code,
                A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no
                FROM    wh_inv_data as A
                INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
                INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
                INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
                INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
                AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
                inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
                inner join wh_main_master As S  on D.ITEM_NO = s.item_no
        
                where D.TRANSACTION_CODE like 'xp%' and D.TRANSACTION_CODE <> 'xpr' and D.TRANSACTION_CODE <> 'xpt'
                and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + dTP2.Value.ToString("yyyy-MM-dd") +
                "'  group by   A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME, A.Transaction_code, A.Branch_code," +
                " A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no) as X  where ser <= 5 and Branch_code like '" + UC_Branch.ID.Text + "%' ");

                ds.Tables.Add(dt_);
                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                //rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المبيعات بالفواتير'";
                //rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + Uc_Acc.ID.Text + " - '+'" + Uc_Acc.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + payment_type.Text + "'";
                groupBox1.Visible = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;



        }

        private void buttonX4_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                RPT.rpt_Cut_Off rpt = new RPT.rpt_Cut_Off();
                DataSet1 ds = new DataSet1();
                DataTable dt_ = dal.getDataTabl_1(@" select X.* from (SELECT 
                ROW_NUMBER() OVER(PARTITION BY B.branch_name ORDER BY A.G_DATE desc) AS ser
                ,A.Ser_no, A.Branch_code,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_TAKE - D.QTY_ADD) As Qty_Add
                , ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) AS Value
                , sum(D.TAX_OUT-D.TAX_IN) As Vat, A.Transaction_code,
                A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no
		

                FROM    wh_inv_data as A
                INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
                INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
                INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
                INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
                AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
                inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
                inner join wh_main_master As S  on D.ITEM_NO = s.item_no
        

                where D.TRANSACTION_CODE like 'xp%' and D.TRANSACTION_CODE <> 'xpr' and D.TRANSACTION_CODE <> 'xpt'
                and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + dTP2.Value.ToString("yyyy-MM-dd") +
                "'  group by   A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME, A.Transaction_code, A.Branch_code," +
                " A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no) as X  where ser <= 5  and Branch_code like '"+ UC_Branch.ID.Text+"%' ");

                ds.Tables.Add(dt_);
                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                //rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المبيعات بالفواتير'";
                //rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + Uc_Acc.ID.Text + " - '+'" + Uc_Acc.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + payment_type.Text + "'";
                groupBox1.Visible = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }
    }
}

