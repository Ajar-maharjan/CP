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
    public partial class RestockLiquor : Form
    {
        public RestockLiquor()
        {
            InitializeComponent();
        }

        private bool InputHandle(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
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

        private bool IsValidNumInt(TextBox textBox)
        {
            int parsedValue;
            if (!int.TryParse(textBox.Text, out parsedValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnRestock_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ComboNull(CboLiquor))
                {
                    throw new Exception("Select Liquor");
                }
                if (!InputHandle(TxtStockquantity))
                {
                    throw new Exception("Enter restock quantity");
                }
                if (!IsValidNumInt(TxtStockquantity))
                {
                    throw new Exception("Invalid restock quantity");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
