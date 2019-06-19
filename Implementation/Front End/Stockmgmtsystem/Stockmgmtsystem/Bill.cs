using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockmgmtsystem
{
    class Bill: DbConnect
    {
        public int DefaultDiscount { get; set; }
        public string LiquorId { get; set; }
        public string LoyalCustomerId { get; set; }
        public int Points { get; set; }
        
        public bool CreateBill()
        {
            return false;
        }

        private decimal DiscountCalc()
        {
            return 1;
        }

        public bool SetDefaultDiscount()
        {
            return false;
        }

        public void SelectLoyalCustomer()
        {

        }

        private void AutoUpdateLiquorStock()
        {

        }

        private void AutoLoyalCustomerPoint()
        {

        }

    }
}
