using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;

using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class Jor_Row : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Jor_Row()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            OnClick(e);
        }

        private void txtDebit_ValueChanged(object sender, EventArgs e)
        {
            OnLoad(e);
        }

        private void txtDebit_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (txtDebit.Value != 0)
                {
                   txtCredit.Value = 0;
                    txtCredit.Focus();
                }
                else
                {
                    txtCredit.Focus();
                }

            }


            
        }

        private void txtAccNo_TextChanged(object sender, EventArgs e)
        {
            get_desc();
        }


     



        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select PAYER_NAME,payer_l_name from payer2 where ACC_NO= '" + txtAccNo.Text + "' and  BRANCH_code like '" + branchID.Text + "'+'%' and t_final like '1' ");
                if (dt_.Rows.Count > 0)
                {
                    if (dt_.Rows.Count > 0)
                    {
                        if (Properties.Settings.Default.lungh == "0")
                        {
                            txtAccDesc.Text = dt_.Rows[0]["PAYER_NAME"].ToString();
                        }
                        else
                        {
                            txtAccDesc.Text = dt_.Rows[0]["payer_l_name"].ToString();
                        }
                    }
                }
                else
                {

                    txtAccDesc.Text = "";
                    txtAccNo.Focus();

                }
                }
    catch { }
        }

        private void txtAccNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtAccNo.Text!= string.Empty && e.KeyCode==Keys.Enter)
            {
              txtDescription.Focus();
            }
        }

        private void txtAccDesc_Click(object sender, EventArgs e)
        {

        }

        private void Jor_Row_Load(object sender, EventArgs e)
        {
            branchID.Text = Properties.Settings.Default.BranchAccID;
        }

        private void txtBalance_Click(object sender, EventArgs e)
        {

        }

        private void txtDebit_Leave(object sender, EventArgs e)
        {
            if (txtDebit.Value != 0)
            {
               txtCredit.Value = 0;

            }
        }

        private void txtCredit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txtCredit.Value != 0)
                {
                   txtDebit.Value = 0;
                   txtAccNo.Focus();
                }

                else
                {
                    txtAccNo.Focus();
                }

            }
        }

        private void txtCredit_Leave(object sender, EventArgs e)
        {
            if (txtCredit.Value!= 0)
            {
                txtDebit.Value=0;

            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtDescription.Text.Trim()!= string.Empty)
            {
                txtCatID.Focus();

            }
        }

        private void txtCatID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCatID.Text.Trim() != string.Empty)
                {
                    txtCostID.Focus();
                }
                else
                {
                    txtCatID.Text = "1";
                    txtCostID.Focus();

                }
            }
        }

        private void txtCostID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCostID.Text.Trim() != string.Empty)
                {
                    txtCostID.Text = "1";
                }

                if (txtAccNo.Text.StartsWith("238"))
                {
                    txtDocument.Focus();
                }
                else
                {
                    OnKeyDown(e);

                }
            }


        }

        private void txtDebit_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void txtCredit_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void txtDocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDocDate.Focus();
            }
        }

        private void txtDocDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtVatNo.Focus();
            }
        }

        private void txtVatNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAcc_2.Focus();
            }
        }

        private void txtAcc_2_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }
    }

}
