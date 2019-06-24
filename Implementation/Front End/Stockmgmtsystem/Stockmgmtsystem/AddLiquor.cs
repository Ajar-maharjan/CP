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
    public partial class AddLiquor : Form
    {
        Liquor liquor;
        LiquorCategory liquorcategory;

        public AddLiquor()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.InputHandle(TxtLiquor))
                {
                    throw new Exception("Enter Liquor name");
                }
                if (!Global.ComboNull(CboCategory))
                {
                    throw new Exception("Select Liquor Category");
                }
                if (!Global.InputHandle(TxtPrice))
                {
                    throw new Exception("Enter Liquor price");
                }
                if (!Global.IsValidNumDec(TxtPrice))
                {
                    throw new Exception("Invalid Liquor price");
                }
                if (!Global.InputHandle(TxtQuantity))
                {
                    throw new Exception("Enter Liquor quantity");
                }
                if (!Global.IsValidNumInt(TxtQuantity))
                {
                    throw new Exception("Invalid Liquor quantity");
                }
                if (!Global.InputHandle(TxtThreshold))
                {
                    throw new Exception("Enter Liquor quantity threshold");
                }
                if (!Global.IsValidNumInt(TxtThreshold))
                {
                    throw new Exception("Invalid liquor quantity threshold");
                }
                liquor = new Liquor();
                liquor.LiquorName = TxtLiquor.Text;
                liquor.CategoryId = Convert.ToInt32(CboCategory.SelectedValue);
                liquor.LiquorPrice = decimal.Parse(TxtPrice.Text);
                liquor.LiquorQuantity = int.Parse(TxtQuantity.Text);
                liquor.ThresholdQuantity = int.Parse(TxtThreshold.Text);
                bool flag = liquor.AddLiquor();
                if (flag == true)
                {
                    MessageBox.Show("Liquor added successfully");
                    Clear();
                }
                else
                    MessageBox.Show("Liquor name already exist");
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

        private void AddLiquor_Load(object sender, EventArgs e)
        {
            LoadCategoryCbo();
        }

        private void LoadCategoryCbo()
        {
            liquorcategory = new LiquorCategory();
            CboCategory.DisplayMember = "CategoryName";
            CboCategory.ValueMember = "CategoryId";
            CboCategory.DataSource = liquorcategory.ViewCategory().Tables["LiquorCategory"];
        }

        private void Clear()
        {
            TxtLiquor.Text = "";
            TxtPrice.Text = "";
            TxtQuantity.Text = "";
            TxtThreshold.Text = "";
        }
    }
}
