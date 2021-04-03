using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_DailyEntry : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_DailyEntry()
        {
            InitializeComponent();
        }

        private void frm_DailyEntry_Load(object sender, EventArgs e)
        {
            getAccBrnchData(Properties.Settings.Default.BranchAccID);
            txtUserID.Text = Program.userID;
            getJorSer(txtBranchCode.Text);
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void getAccBrnchData(string BranchCode)
        {
            DataTable dtBranch = dal.getDataTabl_1(@"select BRANCH_code,BRANCH_name,BRANCH_E_NAME from BRANCHS where BRANCH_code = '" +BranchCode+"'");
            if (dtBranch.Rows.Count > 0)
            {
                txtBranchCode.Text = dtBranch.Rows[0]["BRANCH_code"].ToString();
                if (Properties.Settings.Default.lungh == "0")
                {
                    txtBranchName.Text = dtBranch.Rows[0]["BRANCH_name"].ToString();
                }
                else
                {
                    txtBranchName.Text = dtBranch.Rows[0]["BRANCH_E_NAME"].ToString();
                }
            }
        }

        private void btn_ChoseCompamy_Click(object sender, EventArgs e)
        {
            PL.frm_ChoseAccBranch frm = new frm_ChoseAccBranch();
            frm.ShowDialog();
            getAccBrnchData(frm.AccBranchCode);
            getJorSer(txtBranchCode.Text);
        }


        private void getJorSer(string Branch_)
        {

            DataTable dtSer = dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) as Jor_ser,isnull(daily_sn_ser+1,1) as Main_ser from serial_no where BRANCH_CODE='" + Branch_
                     + "' and ACC_YEAR= '" + txtCyear.Text + "'");

            if (dtSer.Rows.Count > 0)
            {
                txtSerNo.Text = "M" + dtSer.Rows[0]["Jor_ser"].ToString();
                Main_serNo.Text =  dtSer.Rows[0]["Main_ser"].ToString();
            }

            //this.txtSerNo.Text = "M" + dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) from serial_no where BRANCH_CODE='" + txtBranchCode.Text
            //         + "' and ACC_YEAR= '" + txtCyear.Text + "'").Rows[0][0].ToString().PadLeft(4, '0');

            //this.Main_serNo.Text = dal.getDataTabl_1(@"select isnull(daily_sn_ser+1,1) from serial_no where BRANCH_CODE='" + Branch_.ID.Text
            //     + "' and ACC_YEAR= '" + txtAcc_year.Text + "' ").Rows[0][0].ToString();//.PadLeft(4, '0');


        }
    }
}
