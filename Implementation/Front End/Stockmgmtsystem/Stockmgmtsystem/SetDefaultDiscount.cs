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
    public partial class SetDefaultDiscount : Form
    {
        public SetDefaultDiscount()
        {
            InitializeComponent();
        }

        Bill bill;

        private void BtnSetdiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.InputHandle(TxtDiscountper))
                {
                    throw new Exception("Enter Discount percent");
                }
                if (!Global.IsValidNumInt(TxtDiscountper))
                {
                    throw new Exception("Invalid Discount percent");
                }
                bill = new Bill();
                bill.DefaultDiscount = int.Parse(TxtDiscountper.Text);
                bill.SetDefaultDiscount();
                MessageBox.Show("Default discount changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
