using System;
using System.Collections.Generic;

using System.Text;
//
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Globalization;

namespace Report_Pro.DAL
{
    class DataAccesslayer1
    {
        SqlConnection sqlconn1;
       public SqlConnection sqlconn_1;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public string db1 = Properties.Settings.Default.Database_1;
        public string db = Properties.Settings.Default.Database;



        public DataAccesslayer1()
        {

            string mode = Properties.Settings.Default.Mode;

            if (mode == "sql")
            {
                sqlconn_1 = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Convert.ToString(Properties.Settings.Default.Database_1) + " ;integrated security=false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + ";timeout=60");
                sqlconn1 = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Convert.ToString(Properties.Settings.Default.Database) + " ;integrated security=false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + "");
                
            }
            else
            {
                sqlconn_1 = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Properties.Settings.Default.Database_1 + " ;integrated security=true");
                sqlconn1 = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Properties.Settings.Default.Database + " ;integrated security=true");
            }
        }



        public void open()
        {
            if (sqlconn1.State != ConnectionState.Open)
            {
                sqlconn1.Open();
            }
        }


        public void open_1()
        {
            if (sqlconn_1.State != ConnectionState.Open)
            {

                sqlconn_1.Open();
            }
        }





        public void close()
        {
            if (sqlconn1.State == ConnectionState.Open)
            {
                sqlconn1.Close();
            }
        }


        public void close_1()
        {
            if (sqlconn_1.State == ConnectionState.Open)
            {
                sqlconn_1.Close();
            }
        }



        public  DataTable getDataTabl(string stored_procedure, params object[] param)
        {
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.CommandType = CommandType.StoredProcedure;
            sqlcmd1.CommandText = stored_procedure;
            sqlcmd1.Connection = sqlconn1;
            sqlcmd1.CommandTimeout = 30;
            if (param != null)
            {
                for (int i = 0; i <= param.Length - 1; i++)
                {
                    sqlcmd1.Parameters.AddWithValue("@" + i, param[i]);
                }
            }
            SqlDataAdapter da1 = new SqlDataAdapter(sqlcmd1);
            DataTable dt1 = new DataTable();
                da1.Fill(dt1);
            return dt1;
        }


        public  DataTable getDataTabl_1(string sp)
        {

       
            close_1();
            SqlCommand cmd = new SqlCommand();
            open_1();
            cmd.CommandText = sp;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1000;
            cmd.Connection = sqlconn_1;
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            return dt1;

            //sqlconn1.Close();
        }


        public int effectRows(string sp)
        {


            close_1();
            SqlCommand cmd = new SqlCommand();
            open_1();
            cmd.CommandText = sp;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1000;
            cmd.Connection = sqlconn_1;
            int rows_count = Convert.ToInt32(cmd.ExecuteNonQuery());
            //SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            //DataTable dt1 = new DataTable();
            //da1.Fill(dt1);
            //return dt1;
            return rows_count;

            //sqlconn1.Close();
        }


        public object GetCell_1(string sp)
        {

            try
            {
                close_1();
                SqlCommand cmd = new SqlCommand();
                open_1();
                cmd.CommandText = sp;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlconn_1;
                
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }



        public object GetCell(string stored_procedure, params object[] param)
        {

            try
            {
                SqlCommand sqlcmd1 = new SqlCommand();
                sqlcmd1.CommandType = CommandType.StoredProcedure;
                sqlcmd1.CommandText = stored_procedure;
                sqlcmd1.Connection = sqlconn1;
                if (param != null)
                {
                    for (int i = 0; i <= param.Length - 1; i++)
                    {
                        sqlcmd1.Parameters.AddWithValue("@" + i, param[i]);
                    }
                }

                return sqlcmd1.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }


       
        public DataRow getDataRow(string stored_procedure, params object[] param)
        {
           
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.CommandType = CommandType.StoredProcedure;
            sqlcmd1.CommandText = stored_procedure;
            sqlcmd1.Connection = sqlconn1;
            if (param != null)
            {
                for (int i = 0; i <= param.Length - 1; i++)
                {
                    sqlcmd1.Parameters.AddWithValue("@" + i, param[i]);
                }
            }
            SqlDataAdapter da1 = new SqlDataAdapter(sqlcmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            DataRow dr = dt1.Rows[0];
            return dr;
           
        }









        public void Execute(string sp, params object[] obj)
        {
            if (sqlconn1.State == ConnectionState.Open)
            {
                sqlconn1.Close();
            }
            SqlCommand cmd = new SqlCommand();
            
            sqlconn1.Open();
            cmd = new SqlCommand(sp, sqlconn1);
            cmd.CommandType = CommandType.StoredProcedure;
            int i = 0;
            for (i = 0; i <= obj.Length - 1; i++)
            {
                cmd.Parameters.AddWithValue("@" + i, obj[i]);
            }

            cmd.ExecuteNonQuery();
           

        }

        public void Execute_1(string sp)
        {


            open_1();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sp;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlconn_1;
            cmd.ExecuteNonQuery();
            sqlconn_1.Close();
            
        }


        public void Execute_1_test(string sp)
        {
           
            close_1();

            SqlCommand cmd = new SqlCommand();
            open_1();
            cmd.CommandText = sp;
            cmd.CommandType = CommandType.Text;
           
        }


            public void Execute_test(string sp, params object[] obj)
        {
            if (sqlconn1.State == ConnectionState.Open)
            {
                sqlconn1.Close();
            }
            SqlCommand cmd = new SqlCommand();

            sqlconn1.Open();
            cmd = new SqlCommand(sp, sqlconn1);
            cmd.CommandType = CommandType.StoredProcedure;
            int i = 0;
            for (i = 0; i <= obj.Length - 1; i++)
            {
                cmd.Parameters.AddWithValue("@" + i, obj[i]);
            }
        }

        public bool IsDateTime(string text)
        {
            DateTime dateTime;
            bool isDateTime = false;

            // Check for empty string.
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            isDateTime = DateTime.TryParse(text, out dateTime);

            return isDateTime;
        }


        internal object selectdata(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        public  int digits_ = Properties.Settings.Default.digitNo_;

      
       public string languh_ = Properties.Settings.Default.lungh ;

        //public  int R = 255;
        //public  int G = 255;
        //public  int B = 255;
        //public  int FS = 10;



      


       public CultureInfo cul;
        // Assembly a = Assembly.Load("Report_Pro");
       public ResourceManager rm = new ResourceManager("Report_Pro.Lang.Langres", Assembly.Load("Report_Pro"));


        public void ClearTextBoxes(Form frm)
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

            func(frm.Controls);
        }





    }




}
