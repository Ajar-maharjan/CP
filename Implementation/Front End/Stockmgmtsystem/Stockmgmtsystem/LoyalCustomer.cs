using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Stockmgmtsystem
{
    public class LoyalCustomer:DbConnect
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }

        DbConnect db;

        public bool AddLoyalCustomer()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select * from LoyalCustomer where Email = '" + Email + "'";
            dt = db.select(query);
            if (dt.Rows.Count == 0)
            {
                string query2 = "insert into LoyalCustomer values ('" + Email + "',0)";
                manipulate(query2);
                return true;
            }
            else
                return false;
        }

        public bool DeleteLoyalCustomer()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select * from LoyalCustomer where Email = '" + Email + "'";
            dt = db.select(query);
            if (dt.Rows.Count > 0)
            {
                db = new DbConnect();
            string query2 = "delete from LoyalCustomer where LoyalCustomerId = " + CustomerId;
            manipulate(query2);
                return true;
            }
            else
                return false;
        }

        public DataSet GetLoyalCustomer()
        {
            db = new DbConnect();
            DataSet ds;
            string query = ("select * from LoyalCustomer");
            string table = "LoyalCustomer";
            ds = db.list(query, table);
            return ds;
        }

        public DataTable GetCustomerPoints()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select Points from LoyalCustomer where LoyalCustomerid = " + CustomerId;
            dt = db.select(query);
            return dt;
        }
    }
}
