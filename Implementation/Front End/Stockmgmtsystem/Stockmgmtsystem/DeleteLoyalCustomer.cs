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
    public partial class DeleteLoyalCustomer : Form
    {
        public DeleteLoyalCustomer()
        {
            InitializeComponent();
        }

        LoyalCustomer loyalcustomer;

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.ComboNull(CboEmail))
                {
                    throw new Exception("Select Email address");
                }
                loyalcustomer = new LoyalCustomer();
                loyalcustomer.Email = CboEmail.Text;
                loyalcustomer.CustomerId = Convert.ToInt32(CboEmail.SelectedValue);
                bool flag = loyalcustomer.DeleteLoyalCustomer();
                if (flag == true)
                {
                    LoadLoyalCustomerCbo();
                MessageBox.Show("Selected loyal customer is deleted");
                }
                else
                    MessageBox.Show("Email address does not exist");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteLoyalCustomer_Load(object sender, EventArgs e)
        {
            LoadLoyalCustomerCbo();
        }

        private void LoadLoyalCustomerCbo()
        {
            loyalcustomer = new LoyalCustomer();
            CboEmail.DisplayMember = "Email";
            CboEmail.ValueMember = "LoyalCustomerId";
            CboEmail.DataSource = loyalcustomer.GetLoyalCustomer().Tables["LoyalCustomer"];
        }
    }
}
