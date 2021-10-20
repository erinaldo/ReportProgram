using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class Uc_SearchItem : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Uc_SearchItem()
        {
            InitializeComponent();
        }


        private void search_product()
        {
            string strBalance = radiobalance.Checked ? "1" : "2";
            dGV_pro_list.DataSource = dal.getDataTabl_1(@"SELECT item_no,factory_no,descr,Descr_eng,Weight,Group_name,unit,BALANCE
            FROM wh_main_master as A
            inner join wh_Groups as B
            on A.group_code = B.group_code
            where BALANCE <> case when '" + strBalance + "'= 1  then  0 else 1000000000  end and " +
            " descr + Descr_eng + Group_name like '%" + txtsrch_1.Text
            + "%' and descr + Descr_eng + Group_name like  '%" + txtserch_2.Text
            + "%' and descr + Descr_eng + Group_name like '%" + txtSrch_3.Text
            + "%' and descr + Descr_eng + Group_name like '%" + txtserch_4.Text
            + "%' and ( item_no like '" + txtSrch.Text + "%' or factory_no like '" + txtSrch.Text + "%')");
            //, txtSrch.Text, txtsrch_1.Text, txtserch_2.Text, txtSrch_3.Text,txtserch_4.Text, (radiobalance.Checked ? "1" : "2"),dal.db1);
            resizeDG();
        }
        void resizeDG()
        {
            this.dGV_pro_list.Columns[0].Width = 100;
            this.dGV_pro_list.Columns[1].Width = 100;
            this.dGV_pro_list.Columns[2].Width = 300;
            this.dGV_pro_list.Columns[3].Width = 300;
            this.dGV_pro_list.Columns[4].Width = 100;
            this.dGV_pro_list.Columns[5].Width = 300;
        }

        private void txtsrch_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtsrch_1.Text.Trim() != "")
            {
                txtserch_2.Focus();
            }
        }


        private void btnSrch_Click(object sender, EventArgs e)
        {
            search_product();
        }

        private void dGV_pro_list_DoubleClick(object sender, EventArgs e)
        {
                      OnDoubleClick(e);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (ch_SaveSearch.Checked == true)
            {
                this.Visible = false;
            }
            else
            {
               dal.ClearTextBoxes_uc(this);
                this.Visible = false;
            }
        }

        private void txtserch_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtserch_2.Text.Trim() != "")
            {
                txtSrch_3.Focus();
            }
        }

        private void txtSrch_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtSrch_3.Text.Trim() != "")
            {
                txtserch_4.Focus();
            }
        }

        private void txtserch_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && txtserch_4.Text.Trim() != "")
            {
                btnSrch.Focus();
            }
        }

        private void txtSrch_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }

        private void txtserch_2_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }

        private void txtSrch_3_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }

        private void txtserch_4_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }

        private void txtsrch_1_KeyUp(object sender, KeyEventArgs e)
        {
            search_product();
        }
    }
}
