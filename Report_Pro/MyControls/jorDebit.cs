using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;

using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class jorDebit : UserControl
    {
        public jorDebit()
        {
            InitializeComponent();
        }
 
                private void UserControl2_Load(object sender, EventArgs e)
        {
          MyControls.Jor_Row r = new MyControls.Jor_Row();
            flowLayoutPanel1.Controls.Add(r);
            r.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();


            r.KeyDown += r_KeyDown;
            ////r.DoubleClick += r_DoubleClick;
            r.KeyUp += r_KeyUP;
            //r.Click += r_Click;
            //r.EnabledChanged += r_TextChanged;

            //flowLayoutPanel1.AutoScroll = false;
            //flowLayoutPanel1.HorizontalScroll.Enabled = false;
            //flowLayoutPanel1.AutoScroll = true;


            //groupPanel1.AutoScroll = false;
            //groupPanel1.VerticalScroll.Enabled = false;
            //groupPanel1.AutoScroll = true;

        }



        public void r_KeyUP(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            base.OnKeyUp(e);
        }



        public void r_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            base.OnKeyDown(e);
        }







        private void c_Load(object sender, EventArgs e)
        {
            gettotDb();
        }
        private void c_click(object sender, EventArgs e)
        {

            //var add = new Jor_Row();
            //flowLayoutPanel1.Controls.Add(add);
            //foreach (Jor_Row ctl in flowLayoutPanel1.Controls)
            //{
            //    ctl.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(ctl) + 1).ToString();
            //}

            
            //gettotDb();
        }

        private void gettotDb()
        {
            double totDb = 0;
            foreach (Jor_Row c in flowLayoutPanel1.Controls)
            {

                totDb += c.txtDebit.Value;
                txtDebitTotal.Value = totDb;

            }
        }

        private void AddTextChangedHandler(Control parent)
        {
           
            foreach (Jor_Row c in flowLayoutPanel1.Controls)
            {
               
                    c.txtDebit.ValueChanged += new EventHandler(c_Load);
                c.Click+= new EventHandler(c_click);
            }
        }

        private void jorDebit_KeyDown(object sender, KeyEventArgs e)
        {


           if (e.KeyCode == Keys.Enter)
            {
              int index = flowLayoutPanel1.Controls.GetChildIndex(ActiveControl);

             foreach (MyControls.Jor_Row JRow  in flowLayoutPanel1.Controls)
              {

                    JRow.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(JRow) + 1).ToString();

                if (flowLayoutPanel1.Controls.Count - 1 == index)
                    {
                        if (JRow.txtDebit.Value == 0 && JRow.txtCredit.Value == 0)
                        {
                            JRow.Dispose();

                        }


                        MyControls.Jor_Row r  = new MyControls.Jor_Row();
                        flowLayoutPanel1.Controls.Add(r);
                        r.ser_.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                        r.txtDebit.Focus();
                        r.KeyDown += r_KeyDown;
                        r.KeyUp += r_KeyUP;
                        //r.Click += r_Click;
                        //r.EnabledChanged += r_TextChanged;
                    }
                    else if (flowLayoutPanel1.Controls.GetChildIndex(JRow) == index + 1)
                    {

                        JRow.txtDebit.Focus();
                    }
                    else { }
                }
            }
        }

        private void jorDebit_KeyUp(object sender, KeyEventArgs e)
        {
            gettotDb();
        }
    }
}
