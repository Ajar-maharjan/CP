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

        Liquor liquor;

        private void BtnRestock_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.ComboNull(CboLiquor))
                {
                    throw new Exception("Select Liquor");
                }
                if (!Global.InputHandle(TxtStockquantity))
                {
                    throw new Exception("Enter restock quantity");
                }
                if (!Global.IsValidNumInt(TxtStockquantity))
                {
                    throw new Exception("Invalid restock quantity");
                }
                liquor = new Liquor();
                liquor.LiquorId = Convert.ToInt32(CboLiquor.SelectedValue);
                liquor.LiquorName = CboLiquor.Text;
                liquor.LiquorQuantity = int.Parse(TxtStockquantity.Text);
                bool flag = liquor.RestockLiquor();
                if (flag)
                {
                    MessageBox.Show("Selected liquor restocked");
                }
                else
                    MessageBox.Show("Liquor does not exist");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RestockLiquor_Load(object sender, EventArgs e)
        {
            LoadLiquorCbo();
        }

        private void LoadLiquorCbo()
        {
            liquor = new Liquor();
            CboLiquor.DisplayMember = "LiquorName";
            CboLiquor.ValueMember = "LiquorId";
            CboLiquor.DataSource = liquor.ViewLiquor().Tables["Liquor"];
        }
    }
}
