using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Stockmgmtsystem
{
    class LiquorCategory : DbConnect
    {
        public string CategoryName { get; set; }

        public bool AddCategory()
        {
            return false;
        }

        public bool DeleteCategory()
        {
            return false;
        }

        public bool UpdateCategory()
        {
            return false;
        }

        public DataSet ViewCategory()
        {
            DataSet ds = new DataSet();
            return ds;
        }

    }
}
