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
    public partial class updatecustomer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\event management\eventmanagement\eventmanagement\eventmngmnt.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;

        public updatecustomer()
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
            com.CommandText = "Select * from customer";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
             }
        public void clear_data()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
            comboBox1.Text = "";

        }

        private void updatecustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventmngmntDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.eventmngmntDataSet1.customer);
            display();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i=Convert.ToInt16(textBox1.Text);
        string sql = "delete from customer where custid=" + i ;
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();
            MessageBox.Show("DATA DELETED SUCCESSFULLY");
            clear_data();
            //customerBindingSource.MoveNext();
            display();

        }
        catch (Exception)
        {
         MessageBox.Show("ERROR IN DELETING DATA");
       }
        //SqlDataAdapter da1 = new SqlDataAdapter("select city from customer", con);
        //DataSet ds1 = new DataSet();
        //da1.Fill(ds1);
        //foreach (DataRow dr in ds1.Tables[0].Rows)
        //{
        //    comboBox1.Items.Add(dr[5].ToString());
        //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = r.Cells[0].Value.ToString();
                textBox2.Text = r.Cells[1].Value.ToString();
                textBox3.Text = r.Cells[2].Value.ToString();
                textBox4.Text = r.Cells[3].Value.ToString();
                richTextBox1.Text = r.Cells[4].Value.ToString();
                comboBox1.Text = r.Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "update customer set cname=@cname,phone=@phone,email=@email,address=@address,city=@city where custid=" + Convert.ToInt16(textBox1.Text);
            com = new SqlCommand(sql,con);
            com.CommandType = CommandType.Text;
            com.CommandText = sql;
           //com.Parameters.AddWithValue("@custid", Convert.ToInt16(textBox1.Text));
                com.Parameters.AddWithValue("@cname", textBox2.Text);
                    com.Parameters.AddWithValue("@phone", textBox3.Text);
                    com.Parameters.AddWithValue("@email", textBox4.Text);
                    com.Parameters.AddWithValue("@address", richTextBox1.Text);
                    com.Parameters.AddWithValue("@city", comboBox1.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("customer updated successfully");
                    display();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            }

    }
}
