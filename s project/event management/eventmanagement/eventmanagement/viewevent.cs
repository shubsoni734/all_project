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
    public partial class viewevent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\event management\eventmanagement\eventmanagement\eventmngmnt.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        public viewevent()
        {
            InitializeComponent();
        }

        private void viewevent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventmngmntDataSet4.evnt' table. You can move, or remove it, as needed.
            this.evntTableAdapter.Fill(this.eventmngmntDataSet4.evnt);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from evnt";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Event Id";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Event Type";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "Base Price";
            dataGridView1.Columns[2].Width = 120;

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
             homepage h = new homepage();
            this.Hide();
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            evntt et = new evntt();
            et.Show();
            this.Hide();
        }
    }
}
