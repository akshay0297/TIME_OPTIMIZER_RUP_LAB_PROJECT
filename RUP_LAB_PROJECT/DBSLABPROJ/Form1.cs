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
     
    public partial class Form1 : Form
    {
        MySqlDataAdapter ad;
        DataSet ds;
        DataRow dr;
        DataTable dt;
        
        public Form1()
        {
            InitializeComponent();
        }
        private MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string pass;

        public void connect1()
        {
            server = "localhost";
            database = "yourDatabaseName";
            uid = "root";
            pass = "yourDataPassword";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect1();
            MySqlCommand cm = new MySqlCommand("");
            cm.Connection = connection;
            if (reg.Text != "" && pa.Text != "")
            {
                    cm.CommandText = "select name from user where regno = " + Int32.Parse(reg.Text) + " and password = '" + pa.Text + "'";
                    cm.CommandType = CommandType.Text;
                    ds = new DataSet();
                    ad = new MySqlDataAdapter();
                    ad.SelectCommand = cm;
                    ad.Fill(ds, "sql1");
                    dt = ds.Tables["sql1"];
                    dr = dt.Rows[0];
                   
                if (string.IsNullOrEmpty(dr.ItemArray[0].ToString()))
                {
                    MessageBox.Show("Invalid Registration Number or Password ");
                }
                else
                {
                    MessageBox.Show("Login Successful !");
                    string nm = dr["name"].ToString();
                    int r = Int32.Parse(reg.Text);
                    Form4 f4 = new Form4(nm ,r);
                    this.Hide();
                    f4.Show();
                }
                cm.ExecuteNonQuery();
            }
        }
    }
}
