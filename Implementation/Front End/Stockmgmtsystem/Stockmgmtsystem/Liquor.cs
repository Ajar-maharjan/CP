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
        public string LiquorName { get; set; }
        public string CategoryId { get; set; }
        public decimal LiquorPrice { get; set; }
        public int LiquorQuantity { get; set; }
        public int ThresholdQuantity { get; set; }

        public bool AddLiquor()
        {
            return false;
        }

        public bool DeleteLiquor()
        {
            return false;
        }

        public bool UpdateLiquor()
        {
            return false;
        }

        public DataSet ViewLiquor()
        {
            DataSet ds = new DataSet();
            return ds;
        }

        public void NotifyStockStatus()
        {

        }

        public DataSet CreateReport()
        {
            DataSet ds = new DataSet();
            return ds;
        }

        public DataSet SearchLiquor()
        {
            DataSet ds = new DataSet();
            return ds;
        }

        public DataSet FilterLiquorCategory()
        {
            DataSet ds = new DataSet();
            return ds;
        }

    }
}
