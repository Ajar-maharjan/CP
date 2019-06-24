using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockmgmtsystem
{
    class Bill: DbConnect
    {

        public int DefaultDiscount { get; set; }
        public int LiquorId { get; set; }
        public int LoyalCustomerId { get; set; }
        public int Points { get; set; }
        public decimal Total { get; set; }
        public int Quantity { get; set; }

        DbConnect db;

        public DataTable CreateBill()
        {
            db = new DbConnect();
            string query = "insert into Bill values (" + Total + ",null)";
            manipulate(query);
            DataTable dt;
            string query2 = "select top 1 BillId from Bill order by BillId desc";
            dt = db.select(query2);
            return dt;
        }

        public void SetDefaultDiscount()
        {
            db = new DbConnect();
            string query = "update discount set discount ="+DefaultDiscount;
            manipulate(query);
        }

        public void AutoUpdateLiquorStock(int billid)
        {
            db = new DbConnect();
            string query = "insert into LiquorBill values ("+ billid +","+ LiquorId 
                            +", "+ Quantity + ")";
            manipulate(query);
            string query2 = "update LiquorQuantity set Quantity = Quantity -" + Quantity
                        + "where LiquorId = '"+ LiquorId +"'";
            manipulate(query2);
        }

        public void AutoLoyalCustomerPoint()
        {
            db = new DbConnect();
            string query = "update LoyalCustomer set Points = Points + 14 " +
                          "where LoyalCustomerId = '" + LoyalCustomerId + "'";
            manipulate(query);
        }

        public void ReduceloyalCustomerPoints()
        {
            db = new DbConnect();
            string query = "update LoyalCustomer set Points = Points -100 " +
                          "where LoyalCustomerId = '" + LoyalCustomerId + "'";
            manipulate(query);
        }

        public int GetDiscount()
        {
            db = new DbConnect();
            DataTable dt;
            string query = "select discount from discount";
            dt = db.select(query);
            int discount = int.Parse(dt.Rows[0][0].ToString());
            return discount;
        }
    }
}
