using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Stockmgmtsystem
{
    class LoyalCustomer:DbConnect
    {
        public string Email { get; set; }

        public bool AddLoyalCustomer()
        {
            return false;
        }

        public bool DeleteLoyalCustomer()
        {
            return false;
        }
    }
}
