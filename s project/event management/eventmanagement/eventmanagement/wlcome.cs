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
    public partial class wlcome : Form
    {
        public wlcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Stop();
            login f = new login();
            f.Show();
            this.Hide();
        }

        private void wlcome_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
