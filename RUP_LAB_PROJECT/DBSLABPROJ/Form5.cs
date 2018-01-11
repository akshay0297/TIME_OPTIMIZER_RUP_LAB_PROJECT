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
using System.Speech.Synthesis;
using System.Speech;


namespace DBSLABPROJ
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            ed.Format = DateTimePickerFormat.Custom;
            ed.CustomFormat = "yyyy-MM-dd";
        }
        private int r;
        private string uname;
        public Form5(int nu , string na)
        {
            InitializeComponent();
            this.uname = na;
            this.r = nu;
            ed.Format = DateTimePickerFormat.Custom;
            ed.CustomFormat = "yyyy-MM-dd";
        }
        SpeechSynthesizer ss;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string passw;
        
        public void connect1()
        {
            server = "localhost";
            database = "dbslab";
            uid = "root";
            passw = "akshay";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + passw + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void create_Click(object sender, EventArgs e)
        {
            connect1();

            MySqlCommand cm = new MySqlCommand("");
            cm.Connection = connection;
            DateTime d;
            cm.CommandText = "select count(*) from (select name,regno from user where regno = " + Int32.Parse(rb.Text) + ") as dum";
            int result = int.Parse(cm.ExecuteScalar().ToString());
            if (r == int.Parse(rb.Text))
            {
                if (rb.Text != "" && en.Text != "" && ed.Text != "" && et.Text != "")
                {
                    Console.Write("\n date : " + ed.Text);
                    d = Convert.ToDateTime(ed.Text);
                    cm.CommandText = "insert into event(regno , ename , edate , etime) values (" + Int32.Parse(rb.Text) + " , '" + en.Text + " ' ,  '" + ed.Text + "' , '" + et.Text + "' )";
                }
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                ss = new SpeechSynthesizer();
                // ss.Dispose();
                ss.SpeakAsync(" 1 event Created ");
                MessageBox.Show("Ok ! Redirecting To Login Page");
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Registration Number ! Retry ");
            }
        }   
        private void Form5_Load(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
        }

        private void showevent_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6( r , uname);
            this.Hide();
            f6.Show();

        }
    }
}
