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
    public partial class viewcustomer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\event management\eventmanagement\eventmanagement\eventmngmnt.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;

        public viewcustomer()
        {
            InitializeComponent();
        }

        private void viewcustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventmngmntDataSet3.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.eventmngmntDataSet3.customer);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from customer";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Customer Id";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Customer Name";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Mobile Number";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "E-Mail ";
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].HeaderText = "Address";
            dataGridView1.Columns[4].Width = 250;
            dataGridView1.Columns[5].HeaderText = "City";
            dataGridView1.Columns[5].Width = 100;
             
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

        private void hOMEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            homepage h = new homepage();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.Show();
            this.Hide();
        }
    }
}
