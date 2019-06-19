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
    public partial class CreateBill : Form
    {
        public CreateBill()
        {
            InitializeComponent();
            TxtCash.TextChanged += AutoCash;
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

        private bool IsValidNumDec(TextBox textBox)
        {
            decimal parsedValue;
            if (!decimal.TryParse(textBox.Text, out parsedValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ComboNull(CboLiquor))
                {
                    throw new Exception("Select liquor");
                }
                if (!InputHandle(TxtQuantity))
                {
                    throw new Exception("Enter liquor quantity");
                }
                if (!IsValidNumInt(TxtQuantity))
                {
                    throw new Exception("Enter valid quantity");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvBill.Rows.Count == 0)
                {
                    throw new Exception("Liquor is not selected");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CboxApplydiscount_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!ComboNull(CboLoyalcustomer))
                {
                    throw new Exception("Select Customer Email");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AutoCash(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            String cash = tb.Text;
            if (InputHandle(TxtCash) && IsValidNumDec(TxtCash))
            {
                CalculateChange(cash);
            }
        }

        private void CalculateChange(String Text)
        {
            int total = int.Parse(LblTotal.Text);
            int cash = int.Parse(TxtCash.Text);
            int change = total - cash;
            LblChange.Text = change.ToString();
        }
    }
}
