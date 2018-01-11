using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace DBSLABPROJ
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string pass;

        MySqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        DataTable dt;

        public void connect1()
        {
            server = "localhost";
            database = "dbslab";
            uid = "root";
            pass = "akshay";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void showp_CheckedChanged(object sender, EventArgs e)
        {
            if (showp.Checked)
            {
                pbox.UseSystemPasswordChar = false;
                cpbox.UseSystemPasswordChar = false;
            }
            else
            {
                pbox.UseSystemPasswordChar = true;
                cpbox.UseSystemPasswordChar = true;
            }
        }
        private string rname, rpass, rcpass;
        private int rreg;

        private void sub_Click(object sender, EventArgs e)
        {
            rname = nbox.Text;
            rpass = pbox.Text;
            rcpass = cpbox.Text;
            rreg = Int32.Parse(rbox.Text);
            
                connect1();
                MySqlCommand cm = new MySqlCommand("");
                cm.Connection = connection;
                if (rpass == rcpass && rbox.Text != "" && rpass != "" && rname != "")
                {
                    cm.CommandText = "select name , regno from user where name = '" + rname + "' and regno = " + rreg + ";";
                    cm.CommandType = CommandType.Text;
                    ds = new DataSet();
                    da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    da.Fill(ds, "sql2");
                    dt = ds.Tables["sql2"];
                    dr = dt.Rows[0];
                        cm.ExecuteNonQuery();
                    if (string.IsNullOrEmpty(dr.ItemArray[1].ToString()))
                    {
                        MessageBox.Show("Details not found in database ! Redirecting to Login Page. ");
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();
                }
                    else
                    {
                        cm.CommandText = "update user set password = '" + rpass + "' where regno = " + rreg ;
                        cm.CommandType = CommandType.Text;
                        cm.ExecuteNonQuery();
                    MessageBox.Show("Password Changed Successfully ! Redirecting to Login Page. ");
                    Form1 f2 = new Form1();
                    this.Hide();
                    f2.Show();
                }
                }  
               
            
        }
    }
}
