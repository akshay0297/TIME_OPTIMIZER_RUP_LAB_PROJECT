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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
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
        private int r;
        private string uname;
        public Form6(int nu, string na)
        {
            InitializeComponent();
            this.r = nu;
            this.uname = na;
        }
        SpeechSynthesizer ss;
        private void Form6_Load(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
            nm.Text = "Welcome " + uname.ToUpper() + " Your Events !";
           
            connect1();
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = connection;
            cm.CommandText = "select eventId Event_ID , ename Event_Name , edate Event_Date , etime Event_Time from event where regno = " + r;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            int no_of_events = dt.Select().Length;
            ss.SpeakAsync("You Created "+no_of_events.ToString() + " events Till now");

            dgv.DataSource = dt;
           

        }
    }
}
