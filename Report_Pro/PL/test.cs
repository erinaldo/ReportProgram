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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowCount = 10;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                MyControls.JorRow r = new MyControls.JorRow();

     

                this.dataGridView1.Controls.Add(r);
             
            }
        }
    }
}
