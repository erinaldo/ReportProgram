﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Linq;
using System.Reflection;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
namespace Report_Pro.RPT
{
    public partial class frm_Inventory_Report : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string R, F, C, P, S, Z, X;
        double T1, T2;

        public frm_Inventory_Report()
        {
            InitializeComponent();
            dTP2.Value = DateTime.Today;

            //category.DataSource = dal.getDataTabl_1(@"SELECT * FROM wh_Category");
            //category.DisplayMember = "Category_name";
            //category.ValueMember = "Category_code";
            //category.SelectedIndex = -1;

            cmb_DimCategory.DataSource = dal.getDataTabl_1(@"select * FROM Wh_Unit_dim");
            cmb_DimCategory.DisplayMember = "Wh_Unit_dim";
            cmb_DimCategory.ValueMember = "Wh_Unit_dim";
            cmb_DimCategory.SelectedIndex = -1;

        }

        private void choises()
        {
            if (chR.Checked == true) { R = "R"; } else { R = "Y"; }
            if (chF.Checked == true) { F = "F"; } else { F = "Y"; }
            if (chC.Checked == true) { C = "C"; } else { C = "Y"; }
            if (chS.Checked == true) { S = "S"; } else { S = "Y"; }
            if (chP.Checked == true) { P = "P"; } else { P = "Y"; }
            if (chZ.Checked == true) { Z = "Z"; } else { Z = "Y"; }
            if (chX.Checked == true) { X = "X"; } else { X = "Y"; }
            Cursor.Current = Cursors.WaitCursor;
            // double T1, T2;
            if (thick_1.Text == "")
            { T1 = 0; }
            else { T1 = Convert.ToDouble(thick_1.Text); }
            if (thick_2.Text == "" || thick_2.Value == 0)
            { T2 = 10000; }
            else { T2 = Convert.ToDouble(thick_2.Text); }
        }



        private DataTable dt_report()
        {
            choises();

            string rpt_str = @"SELECT A.item_no,A.descr,a.Descr_eng,A.group_code,G.Group_name,a.Category,A.Weight,a.UnitDepth,a.local_cost,t2.COST_PRICE,
                a.Dim_category, round(sum(D.QTY_ADD - D.QTY_TAKE), 2) as balance, sum(D.QTY_ADD - D.QTY_TAKE) * a.local_cost as cost
                FROM wh_material_transaction As D
                inner join wh_main_master As A on A.item_no = D.ITEM_NO
                inner join wh_Groups As G on g.group_code = a.group_code
                inner join(select ITEM_NO, COST_PRICE from(select*, ROW_NUMBER() OVER(PARTITION BY item_no ORDER BY G_DATE DESC) AS DuplicateCount
                FROM wh_MATERIAL_TRANSACTION  where cast(G_DATE as date) <= '" +
                dTP2.Value.ToString("yyyy/MM/dd") + "') as t1 where DuplicateCount = 1) as t2 on t2.ITEM_NO = a.item_no " +
                "where cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy") + "' " +
                "and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "')  and   D.branch_code like " +
                " (CASE WHEN '" + Branch.ID.Text + "' !=''  then  '" + Branch.ID.Text + "' else  '" + Branch.ID.Text + "%' end) and A.group_code like '" + Group.ID.Text +
                "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "' and D.TRANSACTION_CODE like '" + Uc_Transaction.ID.Text + "%'  " +
                "group by A.item_no, A.descr, a.Descr_eng, A.group_code, G.Group_name, a.Category, A.Weight, a.UnitDepth, a.local_cost, a.Dim_category, t2.COST_PRICE order by A.item_no";

            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(rpt_str);
            return dt1;
        }


        private void btnReport_Click(object sender, EventArgs e)
        { 
            Cursor.Current = Cursors.WaitCursor;
            choises();


            RPT.rpt_inventory_byBranch rpt = new RPT.rpt_inventory_byBranch();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

            //dt1 = dal.getDataTabl("get_inventory_", dTP2.Value.Date, Convert.ToString(category.SelectedValue), dal.db1);
            dt1 = dal.getDataTabl_1(@"SELECT d.Branch_code,B.branch_name,A.item_no,A.descr,a.Descr_eng,A.group_code,G.Group_name,a.Category,A.Weight,a.UnitDepth,a.local_cost,t2.COST_PRICE,
            a.Dim_category, round(sum(D.QTY_ADD - D.QTY_TAKE), 2) as balance, sum(D.QTY_ADD - D.QTY_TAKE) * a.local_cost as cost
            FROM wh_material_transaction As D 
            inner join wh_BRANCHES as B on B.branch_code = D.Branch_code
            inner join wh_main_master As A on A.item_no = D.ITEM_NO 
            inner join wh_Groups As G on g.group_code = a.group_code 
            inner join(select ITEM_NO, COST_PRICE from(select *, ROW_NUMBER() OVER(PARTITION BY item_no ORDER BY G_DATE DESC) AS DuplicateCount 
            FROM wh_MATERIAL_TRANSACTION  where cast(G_DATE as date) <= '" + 
            dTP2.Value.ToString("yyyy/MM/dd") + "') as t1 where DuplicateCount = 1) as t2 on t2.ITEM_NO = a.item_no " +
            "where cast(D.G_date as date) <= '"+ dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '"+ dTP2.Value.ToString("yy") + "' " +
            "and A.Category in('"+R+"','"+ F + "','" + C + "','" + P +"','" + S +"','" + Z+"')  and   D.branch_code like " +
            " (CASE WHEN '" + Branch.ID.Text + "' !=''  then  '" + Branch.ID.Text + "%' else  '" + Branch.ID.Text + "%' end) and A.group_code like '"+Group.ID.Text+
            "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "'  group by A.item_no, A.descr, a.Descr_eng, A.group_code, G.Group_name, a.Category, A.Weight, a.UnitDepth, a.local_cost, a.Dim_category, t2.COST_PRICE,d.Branch_code,B.branch_name order by A.item_no");

            ds.Tables.Add(dt1);
            ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            Cursor.Current = Cursors.Default;
            groupPanel1.Visible = false;

        }

        private void labelX5_Click(object sender, EventArgs e)
        {
                   }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
           
            DataSet ds = new DataSet();

            ds.Tables.Add(dt_report());
          
            RPT.rpt_InventoryList rpt = new RPT.rpt_InventoryList();
            ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            Cursor.Current = Cursors.Default;
            groupPanel1.Visible = false;


          
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            {
                Cursor.Current = Cursors.WaitCursor;
                choises();
                

                RPT.rpt_inventory rpt = new RPT.rpt_inventory();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();

                //dt1 = dal.getDataTabl("get_inventory_", dTP2.Value.Date, Convert.ToString(category.SelectedValue), dal.db1);
                dt1 = dal.getDataTabl_1(@"SELECT A.item_no,A.descr,a.Descr_eng,A.group_code,G.Group_name,a.Category,A.Weight,a.UnitDepth,a.local_cost,t2.COST_PRICE,
                a.Dim_category, round(sum(D.QTY_ADD - D.QTY_TAKE), 2) as balance, sum(D.QTY_ADD - D.QTY_TAKE) * a.local_cost as cost
                FROM wh_material_transaction As D 
                inner join wh_main_master As A on A.item_no = D.ITEM_NO 
                inner join wh_Groups As G on g.group_code = a.group_code 
                inner join(select ITEM_NO, COST_PRICE from(select *, ROW_NUMBER() OVER(PARTITION BY item_no ORDER BY G_DATE DESC) AS DuplicateCount 
                FROM wh_MATERIAL_TRANSACTION  where cast(G_DATE as date) <= '" +
                dTP2.Value.ToString("yyyy/MM/dd") + "') as t1 where DuplicateCount = 1) as t2 on t2.ITEM_NO = a.item_no " +
                "where cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy") + "' " +
                "and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "')  and   D.branch_code like " +
                " (CASE WHEN '" + Branch.ID.Text + "' !=''  then  '" + Branch.ID.Text + "' else  '" + Branch.ID.Text + "%' end) and A.group_code like '" + Group.ID.Text +
                "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "'  group by A.item_no, A.descr, a.Descr_eng, A.group_code, G.Group_name, a.Category, A.Weight, a.UnitDepth, a.local_cost, a.Dim_category, t2.COST_PRICE order by A.item_no");

                ds.Tables.Add(dt1);
                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                Cursor.Current = Cursors.Default;
                groupPanel1.Visible = false;

            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
           
            Cursor.Current = Cursors.WaitCursor;
            choises();


            RPT.rpt_inventory_Item_byBranch rpt = new RPT.rpt_inventory_Item_byBranch();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

            //dt1 = dal.getDataTabl("get_inventory_", dTP2.Value.Date, Convert.ToString(category.SelectedValue), dal.db1);
            dt1 = dal.getDataTabl_1(@"SELECT d.Branch_code,B.branch_name,A.item_no,A.descr,a.Descr_eng,A.group_code,G.Group_name,a.Category,A.Weight,a.UnitDepth,a.local_cost,t2.COST_PRICE,
            a.Dim_category, round(sum(D.QTY_ADD - D.QTY_TAKE), 2) as balance, sum(D.QTY_ADD - D.QTY_TAKE) * a.local_cost as cost
            FROM wh_material_transaction As D 
            inner join wh_BRANCHES as B on B.branch_code = D.Branch_code
            inner join wh_main_master As A on A.item_no = D.ITEM_NO 
            inner join wh_Groups As G on g.group_code = a.group_code 
            inner join(select ITEM_NO, COST_PRICE from(select *, ROW_NUMBER() OVER(PARTITION BY item_no ORDER BY G_DATE DESC) AS DuplicateCount 
            FROM wh_MATERIAL_TRANSACTION  where cast(G_DATE as date) <= '" +
            dTP2.Value.ToString("yyyy/MM/dd") + "') as t1 where DuplicateCount = 1) as t2 on t2.ITEM_NO = a.item_no " +
            "where cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy") + "' " +
            "and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "')  and   D.branch_code like " +
            " (CASE WHEN '" + Branch.ID.Text + "' !=''  then  '" + Branch.ID.Text + "%' else  '" + Branch.ID.Text + "%' end) and A.group_code like '" + Group.ID.Text +
            "%' and  A.item_no = '" + Item.ID.Text + "' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "'  group by A.item_no, A.descr, a.Descr_eng, A.group_code, G.Group_name, a.Category, A.Weight, a.UnitDepth, a.local_cost, a.Dim_category, t2.COST_PRICE,d.Branch_code,B.branch_name order by A.item_no");

            ds.Tables.Add(dt1);
            ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            Cursor.Current = Cursors.Default;

            rpt.DataDefinition.FormulaFields["Date_"].Text = "'" + dTP2.Value.ToString("dd/MM/yyyy") + "'";

            groupPanel1.Visible = false;


        }

        private void Item_Click(object sender, EventArgs e)
        {
            try
            {
                PL.frm_search_items frm = new PL.frm_search_items();
                frm.ShowDialog();
                Item.ID.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
               
            }
            catch { }
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            choises();


           RPT.rpt_inventory_Mstore_Branchs rpt = new RPT.rpt_inventory_Mstore_Branchs();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

            //dt1 = dal.getDataTabl("get_inventory_", dTP2.Value.Date, Convert.ToString(category.SelectedValue), dal.db1);
            dt1 = dal.getDataTabl_1(@"SELECT A.item_no,A.descr,a.Descr_eng,A.group_code,G.Group_name,
            sum (case when D.branch_code like'A21%' then D.QTY_ADD - D.QTY_TAKE  else 0 end)  as B_balance, 
			sum( case when D.branch_code like'A21%' then  (D.QTY_ADD - D.QTY_TAKE) * a.local_cost else 0 end) as B_cost,
            sum(case when D.branch_code like'A21%' then  (D.QTY_ADD - D.QTY_TAKE)*A.Weight else 0 end) as B_Weight_ ,
		    sum (case when D.branch_code='A1112' then D.QTY_ADD - D.QTY_TAKE  else 0 end)  as M_balance, 
			sum( case when D.branch_code='A1112' then  (D.QTY_ADD - D.QTY_TAKE) * a.local_cost else 0 end) as M_cost,
            sum(case when D.branch_code='A1112' then  (D.QTY_ADD - D.QTY_TAKE)*A.Weight else 0 end) as M_Weight_ ,
            sum (case when D.branch_code='A1112' or D.branch_code like 'A21%' then D.QTY_ADD - D.QTY_TAKE  else 0 end)  as balance, 
			sum( case when D.branch_code='A1112' or D.branch_code like 'A21%' then  (D.QTY_ADD - D.QTY_TAKE) * a.local_cost else 0 end) as cost,
            sum(case when D.branch_code='A1112' or D.branch_code like 'A21%' then  (D.QTY_ADD - D.QTY_TAKE)*A.Weight else 0 end) as Weight_ 
			
            FROM wh_material_transaction As D 
            inner join wh_BRANCHES as B on B.branch_code = D.Branch_code
            inner join wh_main_master As A on A.item_no = D.ITEM_NO 
            inner join wh_Groups As G on g.group_code = a.group_code 

             where cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '"+ dTP2.Value.ToString("yy") + "' " +
            "and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "') " +
            "and A.group_code like '" + Group.ID.Text +
            "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "'  group by A.item_no, A.descr, a.Descr_eng, A.group_code, G.Group_name order by A.item_no");

            ds.Tables.Add(dt1);
            ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            Cursor.Current = Cursors.Default;
            groupPanel1.Visible = false;



        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            choises();


            RPT.rpt_inventory_Mstore_Branchs_G rpt = new RPT.rpt_inventory_Mstore_Branchs_G();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

            //dt1 = dal.getDataTabl("get_inventory_", dTP2.Value.Date, Convert.ToString(category.SelectedValue), dal.db1);
            dt1 = dal.getDataTabl_1(@"SELECT A.group_code,G.Group_name,
            sum (case when D.branch_code like'A21%' then D.QTY_ADD - D.QTY_TAKE  else 0 end)  as B_balance, 
			sum( case when D.branch_code like'A21%' then  (D.QTY_ADD - D.QTY_TAKE) * a.local_cost else 0 end) as B_cost,
            sum(case when D.branch_code like'A21%' then  (D.QTY_ADD - D.QTY_TAKE)*A.Weight else 0 end) as B_Weight_ ,
		    sum (case when D.branch_code='A1112' then D.QTY_ADD - D.QTY_TAKE  else 0 end)  as M_balance, 
			sum( case when D.branch_code='A1112' then  (D.QTY_ADD - D.QTY_TAKE) * a.local_cost else 0 end) as M_cost,
            sum(case when D.branch_code='A1112' then  (D.QTY_ADD - D.QTY_TAKE)*A.Weight else 0 end) as M_Weight_ ,
            sum (case when D.branch_code='A1112' or D.branch_code like 'A21%' then D.QTY_ADD - D.QTY_TAKE  else 0 end)  as balance, 
			sum( case when D.branch_code='A1112' or D.branch_code like 'A21%' then  (D.QTY_ADD - D.QTY_TAKE) * a.local_cost else 0 end) as cost,
            sum(case when D.branch_code='A1112' or D.branch_code like 'A21%' then  (D.QTY_ADD - D.QTY_TAKE)*A.Weight else 0 end) as Weight_ 
			
            FROM wh_material_transaction As D 
            inner join wh_BRANCHES as B on B.branch_code = D.Branch_code
            inner join wh_main_master As A on A.item_no = D.ITEM_NO 
            inner join wh_Groups As G on g.group_code = a.group_code 

             where cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy") + "' " +
            "and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "') " +
            "and A.group_code like '" + Group.ID.Text +
            "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "'  group by  A.group_code, G.Group_name order by A.group_code");

            ds.Tables.Add(dt1);
            ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            Cursor.Current = Cursors.Default;
            groupPanel1.Visible = false;
        }

       
    }
}   
