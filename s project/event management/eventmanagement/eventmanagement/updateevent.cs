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
    public partial class updateevent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\event management\eventmanagement\eventmanagement\eventmngmnt.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;

        public updateevent()
        {
            InitializeComponent();
        }
        public void display()
        {
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
            con.Close();
        }
        public void clear_data()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }  

        private void updateevent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventmngmntDataSet2.evnt' table. You can move, or remove it, as needed.
            this.evntTableAdapter.Fill(this.eventmngmntDataSet2.evnt);
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
            //    textBox1.Text = r.Cells[0].Value.ToString();
            //    textBox3.Text = r.Cells[1].Value.ToString();
            //    textBox2.Text = r.Cells[2].Value.ToString();
            // }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "update evnt set evnttype=@evnttype,price=@price where evntid=" + Convert.ToInt16(textBox1.Text);
            com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            com.CommandText = sql;
            //com.Parameters.AddWithValue("@evntid", Convert.ToInt16(textBox1.Text));
            com.Parameters.AddWithValue("@evnttype", textBox3.Text);
            com.Parameters.AddWithValue("@price", textBox2.Text);
                       com.ExecuteNonQuery();
            MessageBox.Show("event updated successfully");
            display();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = r.Cells[0].Value.ToString();
                textBox3.Text = r.Cells[1].Value.ToString();
                textBox2.Text = r.Cells[2].Value.ToString();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            evntt et = new evntt();
            et.Show();
            this.Hide();
        }
    }
}
