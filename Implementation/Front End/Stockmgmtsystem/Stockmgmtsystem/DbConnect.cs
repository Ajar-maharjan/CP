using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Stockmgmtsystem
{
    class DbConnect
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter da;

        public DbConnect()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=stockmgmtsystem;Integrated Security=True");

        }
        public void manipulate (string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable select(string query)
        {
            ds = new DataSet();
            da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataSet list(string query,string table)
        {
            ds = new DataSet();
            da = new SqlDataAdapter(query, con);
            da.Fill(ds,table);
            return ds;
        }
    }
}
