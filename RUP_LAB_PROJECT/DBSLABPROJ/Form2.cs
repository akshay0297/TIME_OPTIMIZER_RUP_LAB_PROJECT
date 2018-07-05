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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pass.UseSystemPasswordChar = true;
            cpass.UseSystemPasswordChar = true;
        }
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string passw;

        public void connect1()
        {
            server = "localhost";
            database = "yourDatabaseName";
            uid = "root";
            pass = "yourPassword";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + passw + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            noteL.ForeColor = Color.FromArgb(A, R, G, B);
        }
        private string sname, spass, scpass ,semail, sbranch, ssection;

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                pass.UseSystemPasswordChar = false;
                cpass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
                cpass.UseSystemPasswordChar = true;
            }
        }

        private int sregno;
        private void submit_Click(object sender, EventArgs e)
        {
           
            sname = name.Text;
            spass = pass.Text;
            scpass = cpass.Text;
            semail = email.Text;
            sbranch = branch.Text;
            ssection = section.Text;
            sregno = Int32.Parse(regno.Text);
            if (sname == "" || spass == "" || scpass == "" || semail == "" || sbranch == "" || ssection == "")
            {
                MessageBox.Show("Please Fill all the details ");
            }
            else
            {
                if (stud.Checked)
                {
                    if (showpass.Checked)
                    {
                        pass.UseSystemPasswordChar = false;
                        cpass.UseSystemPasswordChar = false;
                    }
                    else
                    {
                        pass.UseSystemPasswordChar = true;
                        cpass.UseSystemPasswordChar = true;
                    }
                    connect1();
                    MySqlCommand cm = new MySqlCommand("");
                    cm.Connection = connection;
                    if (spass == scpass && regno.Text != "")
                    {
                        cm.CommandText = "insert into user values('" + sname + "'," +
                    sregno + " , '" + spass +"' , '" + semail+ "', '"+sbranch+"' ,'" + ssection +"')" ;
                    }
                    cm.CommandType = CommandType.Text;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Thank You For Registering ! Redirecting To Login Page !");
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                if (fac.Checked)
                {
                    if (showpass.Checked)
                    {
                        pass.UseSystemPasswordChar = false;
                        cpass.UseSystemPasswordChar = false;
                    }
                    else
                    {
                        pass.UseSystemPasswordChar = true;
                        cpass.UseSystemPasswordChar = true;
                    }
                    connect1();
                    MySqlCommand cm = new MySqlCommand("");
                    cm.Connection = connection;
                    if (spass == scpass && regno.Text != "")
                    {
                        cm.CommandText = "insert into user(name , regno , password , email) values('" + sname + "'," +
                    sregno + " , '" + spass + "' , '" + semail + "')";
                    }
                    cm.CommandType = CommandType.Text;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Thank You For Registering ! Redirecting To Login Page !");
                    this.Hide();
                    Form1 f2 = new Form1();
                    f2.Show();
                }
            }
        }

       
    }

    
}
