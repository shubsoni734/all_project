using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace eventmanagement
{
    class db
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\event management\eventmanagement\eventmanagement\eventmngmnt.mdf;Integrated Security=True;User Instance=True");
        public DataSet invoice_pat(int billid)
        {
            SqlCommand com = new SqlCommand("select * from booking where bid=@billno", con);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@billno", billid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet customerinfo(string e)
        {
            SqlCommand com = new SqlCommand("select * from customer where cname=@ename", con);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@ename", e);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
