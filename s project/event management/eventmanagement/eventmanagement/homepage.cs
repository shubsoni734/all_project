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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer c = new customer();
           
            c.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            customer c = new customer();
           
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            evntt ev = new evntt();
            ev.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bookevent b = new bookevent();
           
            b.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            bookevent b = new bookevent();
           
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            schedule s = new schedule();
           
            s.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            schedule s = new schedule();
           
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            evntt ev = new evntt();
            ev.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
