﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_rpt_salary : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_rpt_salary()
        {
            InitializeComponent();
        }

        private void الفرع_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            RPT.rpt_salary rpt = new RPT.rpt_salary();
                      
           DataTable dt_rpt=dal.getDataTabl_1(@"SELECT MONTH(D.g_date) as month
        ,isnull(D.CAT_CODE, 0) as cat_code,c.CAT_NAME,D.BRANCH_code,B.BRANCH_name
        ,SUM(CASE WHEN  D.ACC_NO in ('32101', '32201', '3420101')  THEN D.meno - D.loh  ELSE 0 END) AS B_Salary
        , SUM(CASE WHEN  D.ACC_NO in ('32102', '32202', '3420102')  THEN D.meno - D.loh  ELSE 0 END) AS OverTime
        , SUM(CASE WHEN  D.ACC_NO in ('32103', '32203', '3420103')  THEN D.meno - D.loh  ELSE 0 END) AS bounse
        , SUM(CASE WHEN  D.ACC_NO in ('32104', '32204', '3420110')  THEN D.meno - D.loh  ELSE 0 END) AS iasha
        , SUM(CASE WHEN  D.ACC_NO in ('32105', '32205', '3420104')  THEN D.meno - D.loh  ELSE 0 END) AS transport
        , SUM(CASE WHEN  D.ACC_NO in ('32106', '32206', '3420107')  THEN D.meno - D.loh  ELSE 0 END) AS sakan
        , SUM(CASE WHEN  D.ACC_NO in ('32169', '32269', '3420136')  THEN D.meno - D.loh  ELSE 0 END) AS schoolFess
        , SUM(CASE WHEN  D.ACC_NO in ('2339')  THEN D.meno - D.loh  ELSE 0 END) AS T_bank
        , SUM(CASE WHEN  D.ACC_NO like '127021%' and loh between 1 and 2000 THEN D.loh  ELSE 0 END) AS loans
        FROM daily_transaction as D
        left join CATEGORY as C on c.CAT_CODE = D.CAT_CODE
        inner join BRANCHS as B on B.BRANCH_code = D.BRANCH_code
        where CAST(D.g_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd")+ "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
        "' and D.CAT_CODE like '"+Catogry.ID.Text+ "%' and D.BRANCH_code like '" + AccBranch.ID.Text +
        "%' and D.ACC_NO like '" + Acc.ID.Text +"%' group by MONTH(D.g_date),isnull(D.CAT_CODE, 0),c.CAT_NAME,d.BRANCH_code,B.BRANCH_name " +
        "order by MONTH(D.g_date),cat_code");
        ds.Tables.Add(dt_rpt);
        ds.WriteXmlSchema("schema1.xml");
        rpt.SetDataSource(ds);
        crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + AccBranch.Desc.Text+ "'";
            
            groupPanel1.Visible = false;


        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            RPT.rpt_salary rpt = new RPT.rpt_salary();

            DataTable dt_rpt = dal.getDataTabl_1(@"SELECT MONTH(D.g_date) as month
        ,isnull(D.CAT_CODE, 0) as cat_code,c.CAT_NAME,D.BRANCH_code,B.BRANCH_name
        ,SUM(CASE WHEN  D.ACC_NO in ('3201', '32201', '3420101')  THEN D.meno - D.loh  ELSE 0 END) AS B_Salary
        , SUM(CASE WHEN  D.ACC_NO in ('3202', '32202', '3420102')  THEN D.meno - D.loh  ELSE 0 END) AS OverTime
        , SUM(CASE WHEN  D.ACC_NO in ('3203', '32203', '3420103')  THEN D.meno - D.loh  ELSE 0 END) AS bounse
        , SUM(CASE WHEN  D.ACC_NO in ('3204', '32204', '3420110')  THEN D.meno - D.loh  ELSE 0 END) AS iasha
        , SUM(CASE WHEN  D.ACC_NO in ('3205', '32205', '3420104')  THEN D.meno - D.loh  ELSE 0 END) AS transport
        , SUM(CASE WHEN  D.ACC_NO in ('3206', '32206', '3420107')  THEN D.meno - D.loh  ELSE 0 END) AS sakan
       , SUM(CASE WHEN  D.ACC_NO in ('3269', '32269', '3420136')  THEN D.meno - D.loh  ELSE 0 END) AS schoolFess
        , SUM(CASE WHEN  D.ACC_NO in ('2339')  THEN D.meno - D.loh  ELSE 0 END) AS T_bank
        , SUM(CASE WHEN  D.ACC_NO like '127021%' and loh between 1 and 2000 THEN D.loh  ELSE 0 END) AS loans
        FROM daily_transaction as D
        left join CATEGORY as C on c.CAT_CODE = D.CAT_CODE
        inner join BRANCHS as B on B.BRANCH_code = D.BRANCH_code
        where CAST(D.g_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
         "' and D.CAT_CODE like '" + Catogry.ID.Text + "%' and D.BRANCH_code like '" + AccBranch.ID.Text +
         "%' and D.ACC_NO like '" + Acc.ID.Text + "%' group by MONTH(D.g_date),isnull(D.CAT_CODE, 0),c.CAT_NAME,d.BRANCH_code,B.BRANCH_name " +
         "order by MONTH(D.g_date),cat_code");
            ds.Tables.Add(dt_rpt);
            ds.WriteXmlSchema("schema1.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + AccBranch.Desc.Text + "'";

            groupPanel1.Visible = false;

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            RPT.rpt_salary rpt = new RPT.rpt_salary();

            DataTable dt_rpt = dal.getDataTabl_1(@"SELECT MONTH(D.g_date) as month
        ,isnull(D.CAT_CODE, 0) as cat_code,c.CAT_NAME,D.BRANCH_code,B.BRANCH_name
        ,SUM(CASE WHEN  D.ACC_NO in ('310101', '320101')  THEN D.meno - D.loh  ELSE 0 END) AS B_Salary
        , SUM(CASE WHEN  D.ACC_NO in ('310102', '320102')  THEN D.meno - D.loh  ELSE 0 END) AS OverTime
        , SUM(CASE WHEN  D.ACC_NO in ('310103', '320103')  THEN D.meno - D.loh  ELSE 0 END) AS bounse
        , SUM(CASE WHEN  D.ACC_NO in ( '320108')  THEN D.meno - D.loh  ELSE 0 END) AS iasha
        , SUM(CASE WHEN  D.ACC_NO in ('310104', '320104')  THEN D.meno - D.loh  ELSE 0 END) AS transport
        , SUM(CASE WHEN  D.ACC_NO in ('310105', '320105')  THEN D.meno - D.loh  ELSE 0 END) AS sakan
       , SUM(CASE WHEN  D.ACC_NO in ('310540')  THEN D.meno - D.loh  ELSE 0 END) AS schoolFess
       , SUM(CASE WHEN  D.ACC_NO in ('230310')  THEN D.meno - D.loh  ELSE 0 END) AS T_bank
        , SUM(CASE WHEN  D.ACC_NO like '120501%' and loh between 1 and 2000 THEN D.loh  ELSE 0 END) AS loans
        FROM daily_transaction as D
        left join CATEGORY as C on c.CAT_CODE = D.CAT_CODE
        inner join BRANCHS as B on B.BRANCH_code = D.BRANCH_code
        where CAST(D.g_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
         "' and D.CAT_CODE like '" + Catogry.ID.Text + "%' and D.BRANCH_code like '" + AccBranch.ID.Text +
         "%' and D.ACC_NO like '" + Acc.ID.Text + "%' group by MONTH(D.g_date),isnull(D.CAT_CODE, 0),c.CAT_NAME,d.BRANCH_code,B.BRANCH_name " +
         "order by MONTH(D.g_date),cat_code");
            ds.Tables.Add(dt_rpt);
            ds.WriteXmlSchema("schema1.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + AccBranch.Desc.Text + "'";

            groupPanel1.Visible = false;
        }
    }
}
