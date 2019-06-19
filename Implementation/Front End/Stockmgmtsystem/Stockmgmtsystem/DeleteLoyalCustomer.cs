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

        private bool ComboNull(ComboBox comboBox)
        {
            if (string.IsNullOrEmpty(comboBox.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ComboNull(CboEmail))
                {
                    throw new Exception("Select Email address");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
