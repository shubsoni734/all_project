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
    public partial class addcustomer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\event management\eventmanagement\eventmanagement\eventmngmnt.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        int i;
        public addcustomer()
        {
            InitializeComponent();
        }
        public void clear_data()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
            comboBox1.Text = "";
            textBox2.Focus();
        }

        private void addcustomer_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if ( textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || richTextBox1.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Please fill all the details");
                    textBox2.Focus();
                }
                else
                {
                    string sql = "insert into customer(cname,phone,email,address,city) values(@cname,@phone,@email,@address,@city)";
                    com = new SqlCommand(sql, con);
                    com.CommandType = CommandType.Text;
                    com.CommandText = sql;
                    //com.Parameters.AddWithValue("@custid", i);
                    com.Parameters.AddWithValue("@cname", textBox2.Text);
                    com.Parameters.AddWithValue("@phone", textBox3.Text);
                    com.Parameters.AddWithValue("@email", textBox4.Text);
                    com.Parameters.AddWithValue("@address", richTextBox1.Text);
                    com.Parameters.AddWithValue("@city", comboBox1.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("customer registered successfully");
                    //textBox1.Text = (++i).ToString();
                    clear_data();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("error in registration");
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
            clear_data();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.Show();
            this.Hide();
        }
    }
}
