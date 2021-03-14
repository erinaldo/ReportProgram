using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing; using System.Linq;
using System.Globalization;

using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

//using Syncfusion.Pdf;
//using Syncfusion.Pdf.Graphics;
//using Syncfusion.Pdf.Parsing;
//using Syncfusion.Pdf.Security;


namespace Report_Pro.PL
{
    public partial class frm_PreformaInvoice : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();
        DataTable dt_P = new DataTable();
        string _branchCode = Properties.Settings.Default.BranchId;
        Assembly a = Assembly.Load("Report_Pro");
        CultureInfo cul;

        public frm_PreformaInvoice()
        {


            InitializeComponent();


            comboBox1.DataSource = Enumerable.Range(1983, DateTime.Now.Year - 1983 + 1).ToList();
            comboBox1.SelectedItem = DateTime.Now.Year;

            foreach (DataGridViewRow row in this.dGV_Item.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                dGV_Item.EnableHeadersVisualStyles = false;
            }

           


            creatDattable();
            resizeDG();




            if (Properties.Settings.Default.lungh == "0")
            {
                cul = new CultureInfo("ar");
            }
            else
            {
                cul = new CultureInfo("en");
            }


            txtCurrency.DataSource = dal.getDataTabl_1("SELECT * FROM " + dal.db1 + ".dbo.Wh_Currency");

            txtCurrency.ValueMember = "Currency_Code";
            if (Properties.Settings.Default.lungh == "ar")
            {
                txtCurrency.DisplayMember = "Currency_Name";
            }
            else
            {
                txtCurrency.DisplayMember = "Currency_Name";

            }
            txtCurrency.SelectedIndex = -1;

            txtRegion.DataSource = dal.getDataTabl_1("SELECT * FROM REGIONS");

            txtRegion.ValueMember = "REGION_code";
            if (Properties.Settings.Default.lungh == "0")
            {
                txtRegion.DisplayMember = "REGION_name";
            }
            else
            {
                txtRegion.DisplayMember = "REGION_E_NAME";

            }
            txtRegion.SelectedIndex = -1;


            txtArivePort.DataSource = dal.getDataTabl_1("SELECT * FROM Cus_Ports");

            txtArivePort.ValueMember = "Port_code";
            if (Properties.Settings.Default.lungh == "0")
            {
                txtArivePort.DisplayMember = "Port_name";
            }
            else
            {
                txtArivePort.DisplayMember = "Port_E_name";

            }
            txtArivePort.SelectedIndex = -1;
        }



        void creatDattable()
        {
            dt.Columns.Add("رقم الصنف");
            dt.Columns.Add(" اسم الصنف");
            dt.Columns.Add(" الوصف");
            dt.Columns.Add(" الوحدة");
            dt.Columns.Add("الوزن");
            dt.Columns.Add(" الكمية");
            dt.Columns.Add("السعر");
            dt.Columns.Add("سعر الطن");
            dt.Columns.Add(" الاجمالي");
            dt.Columns.Add("الخصم");
            dt.Columns.Add("الصافي");
            dt.Columns.Add("نسبة الضريبة");
            dt.Columns.Add("مبلغ الضريبة");
            dt.Columns.Add("اجمالي الوزن");
            dt.Columns.Add("الرصيد");
            dt.Columns.Add("التكلفة");
            dt.Columns.Add("كود القيمة المضافة");
            dGV_Item.DataSource = dt;
        }

        void resizeDG()
        {

            this.dGV_Item.Columns[0].Width = this.txtId.Width;
            this.dGV_Item.Columns[1].Width = this.TxtDesc.Width;
            this.dGV_Item.Columns[2].Width = this.txtNote.Width;
            this.dGV_Item.Columns[3].Width = this.txtUnit.Width;
            this.dGV_Item.Columns[4].Width = this.Weight_.Width;
            this.dGV_Item.Columns[5].Width = this.qty.Width;
            this.dGV_Item.Columns[6].Width = this.TxtPrice.Width;
            this.dGV_Item.Columns[7].Width = this.Price_ton.Width;
            this.dGV_Item.Columns[8].Width = this.txt_subTOt.Width;
            this.dGV_Item.Columns[9].Width = this.TxtDisc.Width;
            this.dGV_Item.Columns[10].Width = this.Txtvalue.Width;

            this.dGV_Item.Columns[11].Width = this.VatRate.Width;
            this.dGV_Item.Columns[12].Width = this.VatValue.Width;
            this.dGV_Item.Columns[13].Width = this.totWeight.Width;
            this.dGV_Item.Columns[14].Width = this.txtBalance.Width;
            this.dGV_Item.Columns[15].Width = this.txtCost.Width;
            this.dGV_Item.Columns[16].Visible = false;


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








       



        private void Currency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCurrency.Text != string.Empty)
            {
                txtAmount.Focus();
            }

        }



        private void AcceptDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && AcceptDays.Text != string.Empty)
            {
                OpenDate.Focus();

            }
        }

        private void Amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtAmount.Text != string.Empty)
            {
                AcceptDays.Focus();

            }
        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void AcceptDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void OpenDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                ExpiryDate.Focus();
            }
        }

        private void ExpiryDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                LShipDate.Focus();
            }
        }




        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            BSave.Enabled = true;
            BEdit.Enabled = false;
        }





        private void buttonX1_Click(object sender, EventArgs e)
        {

            Frm_uploadImage frmUpload = new Frm_uploadImage();
            frmUpload.p_id = this.txtLcNo.Text;
            frmUpload.ShowDialog();
        }

        private void frmLcs_Load(object sender, EventArgs e)
        {
            txtSupplier.txtMainAcc.Text = "234";
            txtSupplier.txtFinal.Text = "1";
            txtLcAcc.txtMainAcc.Text = "125";
            txtLcAcc.txtFinal.Text = "1";

            txtBranch.txtTfinal.Text = "1";
            MyControls.Inv_Row row = new MyControls.Inv_Row();

           


       









        }

      

        //private UsersGrid selectedUser;

        //void user_click(object sender, EventArgs e)
        //{
        //    if (selectedUser != null)
        //        selectedUser.BorderStyle = BorderStyle.None;
        //    selectedUser = (UsersGrid)sender;
        //    selectedUser.BorderStyle = BorderStyle.FixedSingle;
        //}




        private void btnPrintIssueFees_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            RPT.lcOpenDocument rpt = new RPT.lcOpenDocument();
            RPT.Form1 frm = new RPT.Form1();
            rpt.SetDataSource(ds);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            ds.WriteXmlSchema("schema1.xml");
        }










        private void txtSupplier_Load(object sender, EventArgs e)
        {

            DataTable dtSupp = dal.getDataTabl_1("select adress from payer2 where acc_no='" + txtSupplier.ID.Text + "'");
            if (dtSupp.Rows.Count > 0)
            {
                txtAddress.Text = dtSupp.Rows[0]["adress"].ToString();
            }
        }





        private void buttonItem2_Click(object sender, EventArgs e)
        {
            RPT.frm_statment_Rpt frm = new RPT.frm_statment_Rpt();
            frm.UC_Acc1.ID.Text = txtLcAcc.ID.Text;
            frm.ShowDialog();
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            Frm_uploadImage frmUpload = new Frm_uploadImage();
            frmUpload.p_id = this.txtLcNo.Text;
            frmUpload.ShowDialog();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void frm_PreformaInvoice_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void inv_Row4_Load(object sender, EventArgs e)
        {

            //r.paySer.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
            //r.intrestRate.Value = txtIntrestRate.Value;
        }



        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            //MyControls.Inv_Row r = new MyControls.Inv_Row();
            //flowLayoutPanel1.Controls.Add(r);
        }

        private void inv_Row7_Load(object sender, EventArgs e)
        {

        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void txtBranch_Load(object sender, EventArgs e)
        {

        }

        private void BSave_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancl_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }


        private void get_data(string ser_,string branch_,string year_ ,string transaction_)
        {
            dt_P = dal.getDataTabl_1(@"SELECT A.Ser_no,A.Branch_code,A.Transaction_code,A.Cyear,A.G_date,A.ACC_TYPE,A.Acc_no,A.Acc_Branch_code
            ,A.Payment_Type,A.Sales_man_Id,A.User_id,A.LC_NO,A.LC_ACC_NO,A.Perform_invoice,A.Perform_invoice_date
            ,A.Cargo_date,A.Cargo_port,A.Arrival_port,A.cargo_method,A.Cargo_notes1,A.Cargo_notes2,A.Catgo_Media,A.Estihkak_Dayes
            ,A.Lc_Date,A.Paper_Arival_Notes,A.Country,A.Factory,A.LC_EXPIRE_DATE,A.LC_STOPED
            ,B.ITEM_NO,B.QTY_ADD,B.QTY_TAKE,B.total_disc,B.Unit,B.Forign_price,B.Local_Price,B.FORIN_TYPE,B.Currancy_Change_Factor
			,C.PAYER_NAME,C.payer_l_name,C.adress,C.resp_name,C.COSTMER_K_M_NO,C.phone_no,C.E_MAIL,D.branch_name,D.WH_E_NAME,E.descr
            ,E.Descr_eng,E.Weight,F.USER_NAME,H.Currency_Name,K.Payment_name
            FROM wh_inv_data_Ext_Perform As A 
			inner join wh_MATERIAL_TRANSACTION_Ext_Perform As B
            on  A.SER_NO=B.SER_NO and A.Branch_code=B.Branch_code and A.TRANSACTION_CODE=B.TRANSACTION_CODE and A.Cyear=B.Cyear
			inner join payer2 as C on A.Acc_no = C.ACC_NO and A.Acc_Branch_code=C.BRANCH_code
			inner join wh_BRANCHES as D on  A.Branch_code = D.Branch_code
		    inner join wh_main_master as E on E.item_no = B.ITEM_NO
            inner join wh_USERS As F on F.USER_ID=A.User_id
            inner join Wh_Currency as H on H.Currency_Code=B.FORIN_TYPE
			inner join wh_Payment_type as K on K.Payment_type =A.Payment_Type
            where A.Ser_no='" + ser_ + "' and A.Branch_code='" + branch_ + "' and A.Cyear = '" + year_ + "' and A.Transaction_code='"+transaction_+"'");

        }


        private void btn_Srearch_Click(object sender, EventArgs e)
        {
            get_data(txtsearch.Text ,_branchCode,comboBox1.Text.Substring(comboBox1.Text.Length - 2),"PER");
           
            if (dt_P.Rows.Count > 0)
            {
                txtId.Text = dt_P.Rows[0]["Ser_no"].ToString();
                txtDate.Text = dt_P.Rows[0]["G_date"].ToString();
                txtBranch.ID.Text = dt_P.Rows[0]["Branch_code"].ToString();
                txtLcAcc.ID.Text = dt_P.Rows[0]["LC_ACC_NO"].ToString();
                txtSupplier.ID.Text = dt_P.Rows[0]["Acc_no"].ToString();
                txtSuppContact.Text = dt_P.Rows[0]["resp_name"].ToString();
                txtSuppPhone.Text = dt_P.Rows[0]["phone_no"].ToString();
                txtSuppVAT.Text = dt_P.Rows[0]["COSTMER_K_M_NO"].ToString();
                txtAddress.Text = dt_P.Rows[0]["adress"].ToString();
                txtSuppEmail.Text = dt_P.Rows[0]["E_MAIL"].ToString();
                txtRate.Text = dt_P.Rows[0]["Currancy_Change_Factor"].ToString();

                txtCurrency.SelectedValue = dt_P.Rows[0]["FORIN_TYPE"].ToString();
                OpenDate.Text = dt_P.Rows[0]["Lc_Date"].ToString();
                ExpiryDate.Text = dt_P.Rows[0]["LC_EXPIRE_DATE"].ToString();
                LShipDate.Text = dt_P.Rows[0]["Cargo_date"].ToString();
                txtProforma.Text = dt_P.Rows[0]["Perform_invoice"].ToString();
                txtProformaDate.Text = dt_P.Rows[0]["Perform_invoice_date"].ToString();
                txtLcNo.Text = dt_P.Rows[0]["LC_NO"].ToString();


                dt.Clear();
                int i = 0;
                DataRow row = null;
                foreach (DataRow r in dt_P.Rows)
                {

                    row = dt.NewRow();
                    row[0] = dt_P.Rows[i]["ITEM_NO"].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        row[1] = dt_P.Rows[i]["descr"].ToString();
                    }
                    else
                    {
                        row[1] = dt_P.Rows[i]["Descr_eng"].ToString();
                    }
                    //row[2] = dt_P.Rows[i]["DETAILS"].ToString();
                    row[3] = dt_P.Rows[i]["Unit"].ToString();
                    row[4] = dt_P.Rows[i]["Weight"].ToString();
                    row[5] = dt_P.Rows[i]["QTY_ADD"].ToString().ToDecimal().ToString("N2");
                    row[6] = dt_P.Rows[i]["Forign_price"].ToString().ToDecimal().ToString("N3");
                    row[7] = (dt_P.Rows[i]["Forign_price"].ToString().ToDecimal() / dt_P.Rows[i]["Weight"].ToString().ToDecimal() * 1000).ToString("N0");
                    row[8] = (dt_P.Rows[i]["Local_Price"].ToString().ToDecimal() * dt_P.Rows[i]["QTY_ADD"].ToString().ToDecimal()).ToString("N" + dal.digits_);
                    row[9] = 5;
                    row[10] = row[8].ToString().ToDecimal() - row[9].ToString().ToDecimal();
                    //row[11] = dt_P.Rows[i]["TAX_OUT"].ToString().ToDecimal().ToString("N" + dal.digits_); ;
                    //row[12] = dt_P.Rows[i]["TAX_OUT"].ToString().ToDecimal().ToString("N" + dal.digits_); ;

                    row[13] = (dt_P.Rows[i]["QTY_ADD"].ToString().ToDecimal() * dt_P.Rows[i]["Weight"].ToString().ToDecimal()).ToString("n3");
                   // row[12] = dt_P.Rows[i]["BALANCE"].ToString().ToDecimal().ToString("N0");
                    //row[13] = dt_P.Rows[i]["Pice_Total_Cost"].ToString().ToDecimal().ToString("N" + dal.digits_);
                    //row[14] = dt_P.Rows[i]["K_M_TYPE_ITEMS"].ToString();
                    dt.Rows.Add(row);
                    i = i + 1;
                }
                dGV_Item.DataSource = dt;
                resizeDG();
               // total_inv();
                txtsearch.Text = "";
                groupBox1.Visible = false;
                BSave.Enabled = false;
                BEdit.Enabled = true;

            }
        }

        private void labelX17_Click(object sender, EventArgs e)
        {

        }

        private void r_KeyDown(object sender, KeyEventArgs e)
        {
            //MyControls.Inv_Row r = new MyControls.Inv_Row();
            //flowLayoutPanel1.Controls.Add(r);
            //r.ID.Focus();
            //r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            get_data(txtId.Text, txtBranch.ID.Text, comboBox1.Text.Substring(comboBox1.Text.Length - 2), "PER");

            ds.Tables.Add(dt_P);
            ds.WriteXmlSchema("schema_rpt.xml");
            RPT.Form1 frm = new RPT.Form1();
            RPT.rpt_Preform_Print rpt_P = new RPT.rpt_Preform_Print();
            rpt_P.SetDataSource(ds);
            ////rpt_P.SetDataSource(dal.getDataTabl("get_invDetails", txt_InvNu.Text, txt_transaction_code.Text, txt_InvDate.Value.Year.ToString()));
            frm.crystalReportViewer1.ReportSource = rpt_P;
            frm.ShowDialog();
            //ToWord toWord = new ToWord(Math.Abs(Math.Round(dt_P.Rows[0][1].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
            //rpt_P.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";


        }

        private void Price_ton_KeyUp(object sender, KeyEventArgs e)
        {

           


            if (Weight_.Text.ToDecimal() > 0)
            {
                TxtPrice.Text = ((Price_ton.Text.ToDecimal() * Weight_.Text.ToDecimal()) / 1000).ToString("n3");
            }
            clculat_amount();
        }




        void clculat_amount()
        {
            //    try
            //    {
                txt_subTOt.Text = (qty.Text.ToDecimal() * TxtPrice.Text.ToDecimal()).ToString("N" + dal.digits_);
                Txtvalue.Text =(txt_subTOt.Text.ToDecimal()-TxtDisc.Text.ToDecimal()).ToString("N" + dal.digits_);
                VatValue.Text = (Txtvalue.Text.ToDecimal() * VatRate.Text.ToDecimal()).ToString("N" + dal.digits_);

            //}
            //catch
            //{
            //    return;
            //}
        }

        void clculat_Peaces()
        {
            try
            {
                qty.Text = (Convert.ToDecimal(totWeight.Text) / Convert.ToDecimal(Weight_.Text)).ToString();
                //Txtvalue.Text = (txt_subTOt.Text.ToDecimal() - TxtDisc.Text.ToDecimal()).ToString("N" + dal.digits_);
                //VatValue.Text = (Convert.ToDecimal(Txtvalue.Text) * Convert.ToDecimal(VatRate.Text)).ToString("N" + dal.digits_);
                //totWeight.Text = (Convert.ToDecimal(qty.Text) * Convert.ToDecimal(Weight_.Text)).ToString("N3");

            }
            catch
            {
                return;
            }
        }

        private void txt_Code_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Code.Text != "")
            {

                get_ItemData(txt_Code.Text);

            }
        }

        private void get_ItemData(string item_No)
        {
            DataTable dt = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,Weight,unit,
                BALANCE,local_cost,K.KM_RATIO,K.KM_Code
                FROM wh_main_master as A 
                inner join wh_Groups As B on A.group_code = B.group_code 
                left join KM_MATERIAL_CODE As K on  ISNULL(NULLIF(a.KM_CODE, ''), 1) = K.KM_CODE
                 where item_no = '" + item_No + "' or factory_no = '" + item_No + "'");
            if (dt.Rows.Count > 0)
            {
                txt_Code.Text = dt.Rows[0][0].ToString();
                if (Properties.Settings.Default.lungh == "0")
                {
                    TxtDesc.Text = dt.Rows[0][2].ToString();
                }
                else
                {
                    TxtDesc.Text = dt.Rows[0][3].ToString();
                }
                Weight_.Text = dt.Rows[0][4].ToString().ToDecimal().ToString("N3");
                txtUnit.Text = dt.Rows[0][5].ToString();
                txtBalance.Text = dt.Rows[0][6].ToString().ToDecimal().ToString("N1");
                txtCost.Text = dt.Rows[0][7].ToString().ToDecimal().ToString("N3");
                VatRate.Text = dt.Rows[0][8].ToString().ToDecimal().ToString("N2");
                KM_TYPE_ITEMS.Text = dt.Rows[0][9].ToString();

                txtNote.Focus();


            }
            else
            {
                btn_braws.PerformClick();
            }
        }

        private void TxtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (Weight_.Text.ToDecimal() > 0)
            {
                Price_ton.Text = ((TxtPrice.Text.ToDecimal() / Weight_.Text.ToDecimal()) * 1000).ToString("n0");
            }
            clculat_amount();
        }

        private void qty_KeyUp(object sender, KeyEventArgs e)
        {
            clculat_amount();
            totWeight.Text = (qty.Text.ToDecimal() * Weight_.Text.ToDecimal()).ToString("N3");

        }

        private void totWeight_KeyUp(object sender, KeyEventArgs e)
        {
            clculat_Peaces();
            clculat_amount();
        }

        private void AddInvDetails()
        {
            for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            {
                if (dGV_Item.Rows[i].Cells[0].Value != null && dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() > 0)
                //&& dGV_Item.Rows[i].Cells[6].Value.ToString().ToDecimal() > 0)
                {
                    dal.Execute_1(@" INSERT INTO wh_MATERIAL_TRANSACTION_Ext_Perform
                    (SER_NO,Branch_code,TRANSACTION_CODE,Cyear,SANAD_NO,ITEM_NO,QTY_ADD,QTY_TAKE
                    ,total_disc,DISC_R,DISC_R2,DISC_R3,G_DATE,Unit,Forign_price,Local_Price,FORIN_TYPE
                    ,USER_ID,main_counter,balance,Currancy_Change_Factor,Backege,GAMAREK,Notes) 
                    values( '" + txtId.Text + "', '" + txtBranch.ID.Text + "', '" + Doc_Type.Text + "', '" + txtDate.Value.ToString("yy") +
                    "' ,'0','" + dGV_Item.Rows[i].Cells[0].Value.ToString() + "' ,'" + dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() + "','0','" + 
                   
                    ((dGV_Item.Rows[i].Cells[9].Value.ToString().ToDecimal() / dGV_Item.Rows[i].Cells[8].Value.ToString().ToDecimal()) + disc_Rate.Text.ToDecimal()) * 100 +
                    "' ,'" + (dGV_Item.Rows[i].Cells[9].Value.ToString().ToDecimal() / dGV_Item.Rows[i].Cells[8].Value.ToString().ToDecimal()) * 100 + "' ,'0','" + (disc_Rate.Text.ToDecimal()) * 100 +
                    "', '" + txtDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dGV_Item.Rows[i].Cells[3].Value.ToString() +
                    "' ,'" + dGV_Item.Rows[i].Cells[6].Value.ToString().ToDecimal() + "' ,'" + dGV_Item.Rows[i].Cells[6].Value.ToString().ToDecimal() + "','"+Convert.ToString(txtCurrency.SelectedValue)+"', '" + 
                    userID.Text + "','" + dGV_Item.Rows[i].Index + "', '" + dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() + "', '" + txtRate.Text +

                    "','1','0','" + dGV_Item.Rows[i].Cells[2].Value.ToString() + "')");

                }
            }
        }
    }
}
