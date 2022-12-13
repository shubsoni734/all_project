using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace eventmanagement
{
    public partial class schedule : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\event management\eventmanagement\eventmanagement\eventmngmnt.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;

        public schedule()
        {
            InitializeComponent();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homepage h = new homepage();
            this.Hide();
            h.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string d = dateTimePicker1.Value.ToShortDateString();

            string sql = "select * from booking where edate='"+d+"'";
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = sql;
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string d = dateTimePicker1.Value.ToShortDateString();

            string sql = "select * from booking";
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = sql;
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void schedule_Load(object sender, EventArgs e)
        {

        }
    }
}
