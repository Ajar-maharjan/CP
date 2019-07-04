using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Stockmgmtsystem
{
    public class LiquorCategory : DbConnect
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        DbConnect db;

        public bool AddCategory()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select * from LiquorCategory where CategoryName = '" + CategoryName +"'";
            dt = db.select(query);
            if (dt.Rows.Count == 0)
            {
                string query2 = "insert into LiquorCategory values ('" + CategoryName + "')";
                manipulate(query2);
                return true;
            }
            else
                return false;
        }

        public DataSet ViewCategory()
        {
            db = new DbConnect();
            DataSet ds;
            string query = ("select * from LiquorCategory");
            string table = "liquorCategory";
            ds = db.list(query,table);
            return ds;
        }

        public bool DeleteCategory()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select * from LiquorCategory where CategoryName = '" + CategoryName + "'";
            dt = db.select(query);
            if (dt.Rows.Count > 0)
            {
                string query2 = "delete from LiquorCategory where CategoryId = " + CategoryId;
                manipulate(query2);
                return true;
            }
            else
                return false;
        }

        public bool UpdateCategory()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select * from Liquorcategory where CategoryName = '" + CategoryName + "'";
            dt = db.select(query);
            if (dt.Rows.Count == 0)
            {
                string query2 = "update LiquorCategory set CategoryName = '" + CategoryName + "'" +
                           "where categoryId = " + CategoryId;
                manipulate(query2);
                return true;
            }
            else
                return false;
        }

    }
}
