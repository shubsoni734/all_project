using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eventmanagement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (txtuser.Text == "madpark" && txtpass.Text == "priyanshi")
            {
                this.Hide();
                homepage f = new homepage();
                f.Show();
            }
            else if (txtuser.Text == " " || txtpass.Text == " ")
            {
                MessageBox.Show("please fill all the details");
            }
            else
            {
                MessageBox.Show("incorrect username or password");
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox4_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
