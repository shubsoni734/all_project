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
    public partial class addevent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\event management\eventmanagement\eventmanagement\eventmngmnt.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        int i;
        public addevent()
        {
            InitializeComponent();
        }

        private void addevent_Load(object sender, EventArgs e)
        {
             string sql = "select count(evntid) from evnt";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                com = new SqlCommand(sql, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    i = Convert.ToInt16(dr.GetValue(0)) + 1;
                    textBox1.Text = i.ToString();
                }
                dr.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {try
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") 
            {
                MessageBox.Show("Please fill all the details");

                textBox2.Focus();
            }
             else
                {
                    string sql = "insert into evnt(evnttype,price) values(@evnttype,@price)";
                    com = new SqlCommand(sql, con);
                    com.CommandType = CommandType.Text;
                    com.CommandText = sql;
                    //com.Parameters.AddWithValue("@evntid", i);
                    com.Parameters.AddWithValue("@evnttype", textBox2.Text);
                    com.Parameters.AddWithValue("@price", textBox3.Text);
                    
                    com.ExecuteNonQuery();
                    MessageBox.Show("event added successfully");
                    textBox1.Text = (++i).ToString();
                    textBox2.Clear();
                    textBox3.Clear();
                    
                    textBox2.Focus();
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error in registration..");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            evntt et = new evntt();
            et.Show();
            this.Hide();
        }
    }
}
