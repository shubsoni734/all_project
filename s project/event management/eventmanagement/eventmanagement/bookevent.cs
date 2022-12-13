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
    public partial class bookevent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\event management\eventmanagement\eventmanagement\eventmngmnt.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        int i;
        public static int b;
        public static string c;
        public bookevent()
        {
            InitializeComponent();
        }
       
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homepage h = new homepage();
            this.Hide();
            h.Show();
        }

        private void bookevent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventmngmntDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.eventmngmntDataSet1.customer);
            // TODO: This line of code loads data into the 'eventmngmntDataSet6.evnt' table. You can move, or remove it, as needed.
            this.evntTableAdapter.Fill(this.eventmngmntDataSet6.evnt);
            string sql = "select count(bid) from booking";
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
                    txtbid.Text = i.ToString();
                }
                dr.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }

            SqlDataAdapter da = new SqlDataAdapter("select evnttype from evnt", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cbevnttype.Items.Add(dr[0].ToString());
            }

            SqlDataAdapter da1 = new SqlDataAdapter("select cname from customer", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                cbcname.Items.Add(dr[0].ToString());
            }
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnoguest_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbevnttype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbevnttype_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            com = new SqlCommand("select price from evnt where evnttype= '"+cbevnttype.Text+"'", con);
            SqlDataReader dr;
            dr = com.ExecuteReader();
            if (dr.Read())
            {

                txtbasecharge.Text = dr.GetValue(0).ToString();
            }
            dr.Dispose();
        }

        private void chkballon_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtextracharge_Click(object sender, EventArgs e)
        {
            long i=0;
        if (chkballon.Checked == true)
        { i += Convert.ToInt64(label8.Text);
        
        }
        if (chkflower.Checked == true)
        { i += Convert.ToInt64(label10.Text);
        
        }
        if (chklighting.Checked == true)
        { i += Convert.ToInt64(label9.Text);
        
        }
        if (chkdjfloor.Checked == true)
        { i += Convert.ToInt64(label11.Text);
        
        }
        if (chkanchor.Checked == true)
        { i += Convert.ToInt64(label12.Text);
               }
        if (chkphotography.Checked == true)
        { i += Convert.ToInt64(label13.Text);
        
        }
        if (chkled.Checked == true)
        { i += Convert.ToInt64(label14.Text);
        
        }
        if (chkdj.Checked == true)
        { i += Convert.ToInt64(label15.Text);
        
        }
        if (chktent.Checked == true)
        { i += Convert.ToInt64(label16.Text);
        
        }
            txtextracharge.Text = i.ToString();
            double u=(Convert.ToDouble(txtbasecharge.Text))+(Convert.ToDouble(txtextracharge.Text));
            txtsubtotal.Text = u.ToString();
            double g = (u * 18) / 100;
            txtgst.Text = g.ToString();
            txttotal.Text= (u + g).ToString();
        }

        private void txtsubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtbid.Text == "" || cbevnttype.Text == "" || cbcname.Text == "" || richTextBox1.Text == "" || txttheme.Text == "" )               {
                    MessageBox.Show("Please fill all the details");
                   
                }
                else
                {
                    string sql = "insert into booking values(@bid,@edate,@etype,@venue,@noofguest,@theme,@gst,@subtotal,@baseprice,@extracharge,@cname,@grandtotal)";
                    com = new SqlCommand(sql, con);
                    com.CommandType = CommandType.Text;
                    com.CommandText = sql;
                    com.Parameters.AddWithValue("@bid", i);
                    com.Parameters.AddWithValue("@edate",dateTimePicker1.Value.Date.ToShortDateString());
                    com.Parameters.AddWithValue("@etype", cbevnttype.Text);
                    
                    com.Parameters.AddWithValue("@venue", richTextBox1.Text);
                    com.Parameters.AddWithValue("@noofguest", numericUpDown1.Value);
                    com.Parameters.AddWithValue("@theme", txttheme.Text);
                    com.Parameters.AddWithValue("@gst", txtgst.Text); 
                    com.Parameters.AddWithValue("@subtotal",txtsubtotal.Text);
                    com.Parameters.AddWithValue("@baseprice",txtbasecharge.Text);
                    com.Parameters.AddWithValue("@extracharge",txtextracharge.Text );
                    com.Parameters.AddWithValue("@cname",cbcname.Text );
                    com.Parameters.AddWithValue("@grandtotal",txttotal.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Bill Added Successfully");
                    b = Convert.ToInt16(txtbid.Text);
                        c=cbcname.Text;
                        Form1 f = new Form1();
                        f.Show();
                        this.Hide();
                    

                }
            }
            catch (Exception)
            {
                MessageBox.Show("error in registration");
            }
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string d = dateTimePicker1.Value.ToShortDateString();

            string sql = "select bid from booking where edate='" + d + "'";
            com = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = com.ExecuteReader();
            if (dr.HasRows)
            {

                MessageBox.Show("date has already booked");
                txtbid.Enabled = false;
                txtbasecharge.Enabled = false;
                txtextracharge.Enabled = false;
                txtgst.Enabled = false;
                txtsubtotal.Enabled = false;
                txttheme.Enabled = false;
                txttotal.Enabled = false;
                cbcname.Enabled = false;
                cbcname.Enabled = false;
                richTextBox1.Enabled = false;
                numericUpDown1.Enabled = false;
            }
            else
            {
                txtbid.Enabled = true;
                txtbasecharge.Enabled = true;
                txtextracharge.Enabled = true;
                txtgst.Enabled = true;
                txtsubtotal.Enabled = true;
                txttheme.Enabled = true;
                txttotal.Enabled = true;
                cbcname.Enabled = true;
                cbcname.Enabled = true;
                richTextBox1.Enabled = true;
                numericUpDown1.Enabled = true;
            }
            dr.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        
    }
}
