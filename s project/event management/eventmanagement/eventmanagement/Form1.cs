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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db d = new db();
            DataSet ds= d.invoice_pat(bookevent.b);
            List<bookinginfo> _l = new List<bookinginfo>();
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                _l.Add(new bookinginfo
                {
                    bid=Convert.ToInt16(dr[0]),
                    edate=dr[1].ToString(),
                    etype=dr[2].ToString(),
                    venue=dr[3].ToString(),
                    noofguest=dr[4].ToString(),
                    theme=dr[5].ToString(),
                    gst=dr[6].ToString(),
                    subtotal=dr[7].ToString(),
                    baseprice=dr[8].ToString(),
                    extracharge=dr[9].ToString(),
                    cname=dr[10].ToString(),
                    grandtotal=dr[11].ToString()
                });
            }
            DataSet ds1 = new DataSet();
            ds1 = d.customerinfo(bookevent.c);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                invoice1.SetDataSource(_l);
                invoice1.SetParameterValue("pcity", dr[5]);
                invoice1.SetParameterValue("pmobile", dr[2]);
                invoice1.SetParameterValue("pem", dr[3]);
                crystalReportViewer1.ReportSource = invoice1;
            }
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
