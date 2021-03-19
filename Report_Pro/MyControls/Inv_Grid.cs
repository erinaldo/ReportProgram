﻿using System;
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
    public partial class Inv_Grid : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Inv_Grid()
        {
            InitializeComponent();


        }

        private void Inv_Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (MyControls.Inv_Row inv_r in flowLayoutPanel1.Controls)
                {
                    inv_r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(inv_r) + 1).ToString();

                    if (inv_r.txt_Code.Text == string.Empty)
                    {
                        inv_r.Dispose();

                    }


                }
                MyControls.Inv_Row r = new MyControls.Inv_Row();
                flowLayoutPanel1.Controls.Add(r);
                r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                r.VatAccRate.Text = txtAccVat_Rate.Text;
                r.txt_Code.Focus();
                r.KeyDown += r_KeyDown;
                r.KeyUp += r_KeyUP;
                r.Enter += r_Enter;

                //r.DoubleClick += r_DoubleClick;
                // OnKeyDown(e);


            }
        }

        private void r_Enter(object sender, EventArgs e)
        {
            base.OnEnter(e);
        }

        private void validateRow()
        {

        }

        private void Inv_Grid_Load(object sender, EventArgs e)
        {
            MyControls.Inv_Row r = new MyControls.Inv_Row();
            flowLayoutPanel1.Controls.Add(r);
            r.Ser.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();


            r.KeyDown += r_KeyDown;
            r.DoubleClick += r_DoubleClick;
            r.KeyUp += r_KeyUP;

            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.AutoScroll = true;


            groupPanel2.AutoScroll = false;
            groupPanel2.VerticalScroll.Enabled = false;
            groupPanel2.AutoScroll = true;



        }

        public void r_KeyUP(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            base.OnKeyUp(e);
        }

        public void r_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            base.OnKeyDown(e);
        }

        private void r_DoubleClick(object sender, EventArgs e)
        {

            base.OnDoubleClick(e);
        }

        private void flowLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
            PL.frm_search_items frm = new PL.frm_search_items();
            frm.ShowDialog();
        }

        private void labelX7_Click(object sender, EventArgs e)
        {

        }

        private void Acc_Vat_Rate_TextChanged(object sender, EventArgs e)
        {
            foreach (MyControls.Inv_Row r in flowLayoutPanel1.Controls)
            {

                r.VatValue.Text = ((r.VatRate.Text.ToDecimal() <= r.VatAccRate.Text.ToDecimal() ? r.VatRate.Text : r.VatAccRate.Text).ToDecimal() * r.Txtvalue.Text.ToDecimal()).ToString("N" + dal.digits_);

            }
        }

        private void total_inv()
        {

            totalQty.Text =
               (from MyControls.Inv_Row row in flowLayoutPanel1.Controls
                where row.qty.Text != string.Empty
                select Convert.ToDouble(row.qty.Text)).Sum().ToString("n0");

           txt_SubTot.Text =
             (from MyControls.Inv_Row row in flowLayoutPanel1.Controls
              where row.txt_subTOt.Text != string.Empty
              select Convert.ToDouble(row.txt_subTOt.Text)).Sum().ToString("n0");

            txt_TotDisc.Text =
            (from MyControls.Inv_Row row in flowLayoutPanel1.Controls
             where row.TxtDisc.Text != string.Empty
             select Convert.ToDouble(row.TxtDisc.Text)).Sum().ToString("n0");

            txtNetTotal.Text =
             (from MyControls.Inv_Row row in flowLayoutPanel1.Controls
              where row.Txtvalue.Text != string.Empty
              select Convert.ToDouble(row.Txtvalue.Text)).Sum().ToString("n0");

            totalWeight.Text =
              (from MyControls.Inv_Row row in flowLayoutPanel1.Controls
               where row.totWeight.Text != string.Empty
               select Convert.ToDouble(row.totWeight.Text)).Sum().ToString("n0");


            //for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            //{
            //    if (dGV_Item.Rows[i].Cells[0].Value != null && dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() > 0
            //       && dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() > 0)
            //    {
            //        if (dGV_Item.Rows[i].Cells[9].Value.ToString().ToDecimal() > Cust_Vat_Rate.Text.ToDecimal())
            //        {
            //            dGV_Item.Rows[i].Cells[10].Value = Math.Round((dGV_Item.Rows[i].Cells[8].Value.ToString().ToDecimal() * Cust_Vat_Rate.Text.ToDecimal()), 3);
            //        }
            //        else
            //        {
            //            dGV_Item.Rows[i].Cells[10].Value = Math.Round((dGV_Item.Rows[i].Cells[8].Value.ToString().ToDecimal() * dGV_Item.Rows[i].Cells[9].Value.ToString().ToDecimal()), 3);
            //        }
            //    }
            //}
            //Net_Vat.Text =
            //    (from DataGridViewRow row in dGV_Item.Rows
            //     where row.Cells[10].FormattedValue.ToString() != string.Empty
            //     select Convert.ToDouble(row.Cells[10].FormattedValue)).Sum().ToString("N" + dal.digits_);

            //NetValue.Text = (txtNetTotal.Text.ToDecimal() + Net_Vat.Text.ToDecimal()).ToString("N" + dal.digits_);


        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            total_inv();
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            total_inv();
        }

        private void Inv_Grid_KeyUp(object sender, KeyEventArgs e)
        {
            total_inv();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls[0].Dispose();
        }

        private void Inv_Grid_Enter(object sender, EventArgs e)
        {
            

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
