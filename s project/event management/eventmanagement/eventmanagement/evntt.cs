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
    public partial class evntt : Form
    {
        public evntt()
        {
            InitializeComponent();
        }

        private void evntt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addevent a = new addevent();
            this.Hide();
            a.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            addevent a = new addevent();
            this.Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateevent u = new updateevent();
            this.Hide();
            u.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            updateevent u = new updateevent();
            this.Hide();
            u.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewevent v = new viewevent();
            this.Hide();
            v.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            viewevent v = new viewevent();
            this.Hide();
            v.Show();
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
    }
}
