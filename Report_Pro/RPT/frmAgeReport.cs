﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frmAgeReport : Form
    {

        string btn_name;
        string M_than="0";
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        



        public frmAgeReport()
        {
            InitializeComponent();
            
           

        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (rAll.Checked == true)
            { M_than = "0"; }
            else if (rM_30.Checked == true)
            { M_than = "30"; }
            else if (rM_60.Checked == true)
            { M_than = "60"; }
            else if (rM_90.Checked == true)
            { M_than = "90"; }
            else if (rM_120.Checked == true)
            { M_than = "120"; }
            else if (rM_150.Checked == true)
            { M_than = "150"; }
            else if (rM_180.Checked == true)
            { M_than = "180"; }


            RPT.AgeReport rpt = new RPT.AgeReport();
            rpt.SetDataSource(dal.getDataTabl("AgeReport_",FromDate.Value.Date,ToDate.Value.Date,Uc_Acc.ID.Text,Uc_Cost.ID.Text,Uc_Catogry.ID.Text,Uc_Branch.ID.Text,dal.db1));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["M_"].Text = "'"+M_than+"'";
            rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            rpt.DataDefinition.FormulaFields["Date_"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = " '" + Uc_Acc.Desc.Text + "'";
            groupPanel1.Visible = false;
            this.Cursor = Cursors.Default;
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }


       
       

        private void Branch_name_MultilineChanged(object sender, EventArgs e)
        {
           
        }

        

       

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }



     
      

      


      

        private void frm_statment_Rpt_Load(object sender, EventArgs e)
        {
            FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            ToDate.Value = DateTime.Today;
        }

      
        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgeReport_Load(object sender, EventArgs e)
        {

        }

        private void buttonX5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (rAll.Checked == true)
            { M_than = "0"; }
            else if (rM_30.Checked == true)
            { M_than = "30"; }
            else if (rM_60.Checked == true)
            { M_than = "60"; }
            else if (rM_90.Checked == true)
            { M_than = "90"; }
            else if (rM_120.Checked == true)
            { M_than = "120"; }
            else if (rM_150.Checked == true)
            { M_than = "150"; }
            else if (rM_180.Checked == true)
            { M_than = "180"; }


            RPT.Supp_AgeReport rpt = new RPT.Supp_AgeReport();
            rpt.SetDataSource(dal.getDataTabl_1(@"select A.*,p.PAYER_NAME from ( select acc_no
		,SUM(CASE WHEN cast(g_date as date) <= '"+ToDate.Value.ToString("yyyy/MM/dd")+"' THEN loh - meno ELSE 0 END) AS Ending_balance "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=0 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=30  THEN loh    ELSE 0 END) AS '1-30' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=31 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=60  THEN loh    ELSE 0 END) AS '31-60' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=61 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=90  THEN loh    ELSE 0 END) AS '61-90' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=91 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=120  THEN loh    ELSE 0 END) AS '91-120' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=121 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=150  THEN loh    ELSE 0 END) AS '121-250' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=151 and DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')<=180  THEN loh    ELSE 0 END) AS '151-180' "+
		",SUM(CASE WHEN  DATEDIFF(Day,CAST(g_date as date ),'"+ToDate.Value.ToString("yyyy/MM/dd")+"')>=181  THEN loh    ELSE 0 END) AS more180 "+
	    " from daily_transaction  where ACC_NO like '"+Uc_Acc.ID.Text+"%'	 group by ACC_NO  ) as A  "+
	    "inner join ( select * from ( select   acc_no ,PAYER_NAME "+
        ",ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS DuplicateCount "+
        "from payer2 ) as B where b.DuplicateCount =1) as P on P.ACC_NO =a.ACC_NO order by A.ACC_NO"));
            //, FromDate.Value.Date, ToDate.Value.Date, Uc_Acc.ID.Text, Uc_Cost.ID.Text, Uc_Catogry.ID.Text, Uc_Branch.ID.Text, dal.db1));



            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["M_"].Text = "'" + M_than + "'";
            rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            rpt.DataDefinition.FormulaFields["Date_"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = " '" + Uc_Acc.Desc.Text + "'";
            groupPanel1.Visible = false;
            this.Cursor = Cursors.Default;


        }
    }
       
}
