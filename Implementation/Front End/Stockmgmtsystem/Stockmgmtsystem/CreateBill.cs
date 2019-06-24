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
            ChkApplydiscount.Checked = false;
        }

        Bill bill;
        Liquor liquor;
        LoyalCustomer loyalcustomer;
        int count = 0;
        bool dis = false;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.ComboNull(CboLiquor))
                {
                    throw new Exception("Select liquor");
                }
                if (!Global.InputHandle(TxtQuantity))
                {
                    throw new Exception("Enter liquor quantity");
                }
                if (!Global.IsValidNumInt(TxtQuantity))
                {
                    throw new Exception("Enter valid quantity");
                }
                liquor = new Liquor();
                liquor.LiquorId = Convert.ToInt32(CboLiquor.SelectedValue);
                Decimal price = Convert.ToDecimal(liquor.GetLiquorPrice().Rows[0][0]);
                int quant = Convert.ToInt32(liquor.GetLiquorPrice().Rows[0][1]);
                int quantity = int.Parse(TxtQuantity.Text);
                if (quantity > quant)
                {
                    throw new Exception("Not enough liquor in stock");
                }
                if (quantity == 0)
                {
                    throw new Exception("Invalid quantity");
                }
                for (int row = 0; row < DgvBill.Rows.Count; row++)
                {
                    for (int col = 0; col < DgvBill.Columns.Count; col++)
                    {
                        if (DgvBill.Rows[row].Cells[col].Value != null &&
                            DgvBill.Rows[row].Cells[col].Value.Equals(CboLiquor.Text.Trim()))
                        {
                            throw new Exception("Cannot enter same liquor twice");
                        }
                    }
                }
                decimal total = price * quantity;
                this.DgvBill.Rows.Add(liquor.LiquorId,CboLiquor.Text, quantity, total);
                decimal result = 0;
                foreach (DataGridViewRow row in DgvBill.Rows)
                {
                    result += Convert.ToDecimal(row.Cells["Price"].Value);
                }
                LblTotal.Text = result.ToString();
                ClearLiquor();
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
                if(Convert.ToDecimal(LblChange.Text) < 0 || LblChange.Text == "0000")
                {
                    throw new Exception("Not enough cash for complete transaction");
                }
                if (DgvBill.Rows.Count == 0)
                {
                    throw new Exception("Liquor is not selected");
                }
                bill = new Bill();
                int cust = (Convert.ToInt32(CboLoyalcustomer.SelectedValue));
                if (cust != 0)
                    bill.LoyalCustomerId = cust;
                else
                    bill.LoyalCustomerId = 0;
                bill.Total = decimal.Parse(LblTotal.Text);
                int billid = Convert.ToInt32(bill.CreateBill().Rows[0][0]);
                foreach (DataGridViewRow row in DgvBill.Rows)
                {
                    bill.LiquorId = Convert.ToInt32(row.Cells[0].Value);
                    bill.Quantity = Convert.ToInt32(row.Cells[2].Value);
                    bill.AutoUpdateLiquorStock(billid);
                }
                if (dis)
                {
                    bill.ReduceloyalCustomerPoints();
                }
                if (Global.ComboNull(CboLoyalcustomer))
                {
                    bill.AutoLoyalCustomerPoint();
                }
                MessageBox.Show("Bill created");
                Clear();
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

        private void AutoCash(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            String cash = tb.Text;
            if (Global.InputHandle(TxtCash) && Global.IsValidNumDec(TxtCash))
            {
                CalculateChange(cash);
            }
        }

        private void CalculateChange(String Text)
        {
            Decimal total = Decimal.Parse(LblTotal.Text);
            Decimal cash = Decimal.Parse(TxtCash.Text);
            Decimal change = cash - (total);
            LblChange.Text = change.ToString();
        }

        private void CreateBill_Load(object sender, EventArgs e)
        {
            LoadCustomerCbo();
            LoadLiquorCbo();
            CboLoyalcustomer.SelectedIndex = -1;
            CboLiquor.SelectedIndex = -1;
            LblPoints.Text = "0";
        }

        private void LoadCustomerCbo()
        {
            loyalcustomer = new LoyalCustomer();
            CboLoyalcustomer.DisplayMember = "Email";
            CboLoyalcustomer.ValueMember = "LoyalCustomerId";
            CboLoyalcustomer.DataSource = loyalcustomer.GetLoyalCustomer().Tables["LoyalCustomer"];
        }

        private void LoadLiquorCbo()
        {
            liquor = new Liquor();
            CboLiquor.DisplayMember = "LiquorName";
            CboLiquor.ValueMember = "LiquorId";
            CboLiquor.DataSource = liquor.ViewLiquor().Tables["Liquor"];
        }

        private void CboLoyalcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboLoyalcustomer.SelectedIndex != -1)
            {
                loyalcustomer = new LoyalCustomer();
                loyalcustomer.CustomerId = Convert.ToInt32(CboLoyalcustomer.SelectedValue);
                string points = loyalcustomer.GetCustomerPoints().Rows[0][0].ToString();
                LblPoints.Text = points;
            }
        }

        private bool AllowCheck()
        {
            if (int.Parse(LblPoints.Text) >= 100)
                return true;
            else
                return false;
        }

        private decimal DiscountCalc(decimal total)
        {
            bill = new Bill();
            int dec = bill.GetDiscount();
            decimal net = (Convert.ToDecimal(dec) / 100) * total;
            return net;
        }

        private void Clear()
        {
            DgvBill.Rows.Clear();
            DgvBill.Refresh();
            CboLoyalcustomer.SelectedIndex = -1;
            CboLiquor.SelectedIndex = -1;
            LblPoints.Text = "0";
            LblTotal.Text = "0000";
            LblDiscount.Text = "0000";
            LblChange.Text = "0000";
            TxtCash.Text = "";
            TxtQuantity.Text = "";
            ChkApplydiscount.Checked = false;
        }

        private void ClearLiquor()
        {
            CboLiquor.SelectedIndex = -1;
            TxtQuantity.Text = "";
        }

        private void ChkApplydiscount_CheckedChanged(object sender, EventArgs e)
        {

            if (ChkApplydiscount.Checked == true)
            {
                bool flag = AllowCheck();
                if (!Global.ComboNull(CboLoyalcustomer))
                {
                    ChkApplydiscount.Checked = false;
                }
                if (!flag)
                {
                    ChkApplydiscount.Checked = false;
                }
                else
                {
                    if (Convert.ToDecimal(LblTotal.Text)> 1 && count == 0)
                    {
                        decimal discount = DiscountCalc(decimal.Parse(LblTotal.Text));
                        LblDiscount.Text = discount.ToString();
                        decimal total = Convert.ToDecimal(LblTotal.Text) - Convert.ToDecimal(LblDiscount.Text);
                        LblTotal.Text = total.ToString();
                        dis = true;
                        count = count + 1;
                    }
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        Bitmap bmp;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics bill = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width-15, this.Size.Height-315, bill);
            Graphics img = Graphics.FromImage(bmp);
            img.CopyFromScreen(this.Location.X+7, this.Location.Y+220, 0, 0, this.Size);
            BillPrintPreview.ShowDialog();
        }

        private void PrintBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }
    }

}
