using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Stockmgmtsystem
{
    class Liquor: DbConnect
    {
        public int LiquorId { get; set; }
        public string LiquorName { get; set; }
        public int CategoryId { get; set; }
        public decimal LiquorPrice { get; set; }
        public int LiquorQuantity { get; set; }
        public int ThresholdQuantity { get; set; }

        DbConnect db;

        public bool AddLiquor()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select * from Liquor where LiquorName = '" + LiquorName + "'";
            dt = db.select(query);
            if (dt.Rows.Count == 0)
            {
                string query2 = "insert into Liquor values ('" + LiquorName + "'," +
                            "" + LiquorPrice + "," + CategoryId + ")";
                string query3 = "insert into LiquorQuantity (LiquorId,Quantity,Threshold) " +
                            "select Liquor.LiquorId ,"+ LiquorQuantity + "," +
                            "" + ThresholdQuantity + " from Liquor where " +
                            "Liquor.LiquorName ='" + LiquorName+"'";
                manipulate(query2);
                manipulate(query3);
                return true;
            }
            else
                return false;
        }

        public bool DeleteLiquor()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select * from Liquor where LiquorName = '" + LiquorName + "'";
            dt = db.select(query);
            if (dt.Rows.Count > 0)
            {
                string query2 = "delete from LiquorQuantity where LiquorId= " + LiquorId;
                string query3 = "delete from Liquor where LiquorId = " + LiquorId;
                manipulate(query2);
                manipulate(query3);
                return true;
            }
            else
                return false;
        }

        public bool UpdateLiquor(bool flag)
        {
            db = new DbConnect();
            DataTable dt;
            int count = 0;
            if (!flag)
            {
                string query = "select * from Liquor where liquorName = '" + LiquorName + "'";
                dt = db.select(query);
                count = dt.Rows.Count;
            }
            if (count == 0)
            {
                string query2 = "update Liquor set LiquorName = '" + LiquorName +"', LiquorPrice =" + LiquorPrice + "," +
                            "CategoryId =" + CategoryId + " where LiquorId =" + LiquorId ;
                string query3 = "update LiquorQuantity set Quantity = '" + LiquorQuantity + "', " +
                            "Threshold =" + ThresholdQuantity + " where LiquorId =" + LiquorId;
                manipulate(query2);
                manipulate(query3);
                return true;
            }
            else
                return false;
        }

        public bool RestockLiquor()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select * from Liquor where liquorName = '" + LiquorName + "'";
            dt = db.select(query);
            if (dt.Rows.Count > 0)
            {
                string query2 = "update LiquorQuantity set Quantity = Quantity + " +
                            "" + LiquorQuantity +" where LiquorId =" + LiquorId;
                manipulate(query2);
                return true;
            }
            else
                return false;
        }

        public DataSet ViewLiquor()
        {
            db = new DbConnect();
            DataSet ds;
            string query = "select L.LiquorId,L.LiquorName,C.CategoryName,L.LiquorPrice,Q.Quantity,Q.Threshold " +
                        "from Liquor L inner join LiquorQuantity Q on L.LiquorId = Q.LiquorId " +
                        "inner join LiquorCategory C on C.CategoryId = L.CategoryId";
            string table = "Liquor";
            ds = db.list(query, table);
            return ds;
        }
        
        public DataTable GetLiquor()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select L.LiquorName,C.CategoryName,L.LiquorPrice,Q.Quantity,Q.Threshold " +
                        "from Liquor L inner join LiquorQuantity Q on L.LiquorId = Q.LiquorId " +
                        "inner join LiquorCategory C on C.CategoryId = L.CategoryId " +
                        "where L.LiquorId = " + LiquorId;
            dt = db.select(query);
            return dt;
        }

        public DataTable GetLiquorPrice()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select L.LiquorPrice, Q.Quantity from Liquor L inner join LiquorQuantity Q on L.LiquorId = Q.LiquorId where L.LiquorId = " + LiquorId;
            dt = db.select(query);
            return dt;
        }

        public DataSet NotifyStockStatus()
        {
            db = new DbConnect();
            DataSet ds;
            string query = " select L.LiquorName as Stock_below_threshold from Liquor " +
                       "L inner join LiquorQuantity Q on L.LiquorId = Q.LiquorId " +
                       "where Q.Quantity < Q.threshold";
            string table = "Liquor";
            ds = db.list(query, table);
            return ds;
        }

        public DataSet CreateReport()
        {
            db = new DbConnect();
            DataSet ds;
            string query = " select L.LiquorName , Sum(B.Quantity) as Total_bought_Liquor " +
                        "from LiquorBill B  inner join Liquor L on L.LiquorId = B.LiquorId " +
                        "group by L.LiquorName";
            string table = "Liquor";
            ds = db.list(query, table);
            return ds;
        }

        public DataSet SearchLiquor(string liquorname)
        {
            db = new DbConnect();
            DataSet ds;
            string query = "select L.LiquorId,L.LiquorName,C.CategoryName,L.LiquorPrice,Q.Quantity,Q.Threshold " +
                        "from Liquor L inner join LiquorQuantity Q on L.LiquorId = Q.LiquorId " +
                        "inner join LiquorCategory C on C.CategoryId = L.CategoryId " +
                        "where L.LiquorName Like '%"+ liquorname +"%'";
            string table = "Liquor";
            ds = db.list(query, table);
            return ds;
        }

        public DataSet FilterLiquorCategory()
        {
            db = new DbConnect();
            DataSet ds;
            string query = "select L.LiquorId,L.LiquorName,C.CategoryName,L.LiquorPrice,Q.Quantity,Q.Threshold " +
                        "from Liquor L inner join LiquorQuantity Q on L.LiquorId = Q.LiquorId " +
                        "inner join LiquorCategory C on C.CategoryId = L.CategoryId " +
                        "where C.CategoryId = "+CategoryId;
            string table = "Liquor";
            ds = db.list(query, table);
            return ds;
        }

        public DataSet SearchLiquorCategory(string liquorname,int categoryid)
        {
            db = new DbConnect();
            DataSet ds;
            string query = "select L.LiquorId,L.LiquorName,C.CategoryName,L.LiquorPrice,Q.Quantity,Q.Threshold " +
                        "from Liquor L inner join LiquorQuantity Q on L.LiquorId = Q.LiquorId " +
                        "inner join LiquorCategory C on C.CategoryId = L.CategoryId " +
                        "where C.CategoryId = " + categoryid + "and L.LiquorName Like '%" + liquorname + "%'";
            string table = "Liquor";
            ds = db.list(query, table);
            return ds;
        }
    }
}
