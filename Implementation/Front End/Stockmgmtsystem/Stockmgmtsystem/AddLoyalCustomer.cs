using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockmgmtsystem
{
    public partial class AddLoyalCustomer : Form
    {
        public AddLoyalCustomer()
        {
            InitializeComponent();
        }

        LoyalCustomer loyalcustomer;

        private void BtnAddcust_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.InputHandle(TxtEmail))
                {
                    throw new Exception("Enter Email address");
                }
                if (!Global.IsValidEmail(TxtEmail.ToString()))
                {
                    throw new Exception("Invalid Email address");
                }
                loyalcustomer = new LoyalCustomer();
                loyalcustomer.Email = TxtEmail.Text;
                bool flag = loyalcustomer.AddLoyalCustomer();
                if (flag == true)
                    MessageBox.Show("Loyal Customer added");
                else
                    MessageBox.Show("Email address already exist");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
