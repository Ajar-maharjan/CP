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
    public partial class EditLiquor : Form
    {
        public EditLiquor()
        {
            InitializeComponent();
        }

        Liquor liquor;
        LiquorCategory liquorcategory;

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.ComboNull(CboLiquor))
                {
                    throw new Exception("Select liquor");
                }
                liquor = new Liquor();
                liquor.LiquorName = CboLiquor.Text;
                liquor.LiquorId = Convert.ToInt32(CboLiquor.SelectedValue);
                bool flag = liquor.DeleteLiquor();
                if (flag)
                {
                    LoadLiquorCbo();
                    LoadLiquor();
                    MessageBox.Show("Selected liquor is deleted");
                }
                else
                    MessageBox.Show("Liquor does not exist");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool liquorflag = false;
                if (!Global.ComboNull(CboLiquor))
                {
                    throw new Exception("Select liquor");
                }
                if (!Global.InputHandle(TxtLiquor))
                {
                    liquorflag = true;
                }
                if (!Global.ComboNull(CboCategory))
                {
                    throw new Exception("Select liquor Category");
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
                if (liquorflag)
                    liquor.LiquorName = CboLiquor.Text;
                else
                    liquor.LiquorName = TxtLiquor.Text;
                liquor.LiquorId = Convert.ToInt32(CboLiquor.SelectedValue);
                liquor.CategoryId = Convert.ToInt32(CboCategory.SelectedValue);
                liquor.LiquorPrice = Decimal.Parse(TxtPrice.Text);
                liquor.LiquorQuantity = int.Parse(TxtQuantity.Text);
                liquor.ThresholdQuantity = int.Parse(TxtThreshold.Text);
                bool flag = liquor.UpdateLiquor(liquorflag);
                if (flag)
                {
                    MessageBox.Show("Selected liquor is updated");
                    LoadLiquor();
                    LoadLiquorCbo();
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

        private void EditLiquor_Load(object sender, EventArgs e)
        {
            LoadLiquor();
            LoadLiquorCbo();
        }

        private void LoadLiquorCbo()
        {
            liquor = new Liquor();
            CboLiquor.DisplayMember = "LiquorName";
            CboLiquor.ValueMember = "LiquorId";
            CboLiquor.DataSource = liquor.ViewLiquor().Tables["Liquor"];
            liquorcategory = new LiquorCategory();
            CboCategory.DisplayMember = "CategoryName";
            CboCategory.ValueMember = "CategoryId";
            CboCategory.DataSource = liquorcategory.ViewCategory().Tables["LiquorCategory"];
            
        }

        private void LoadCbo()
        {
            liquorcategory = new LiquorCategory();
            CboCategory.DisplayMember = "CategoryName";
            CboCategory.ValueMember = "CategoryId";
            CboCategory.DataSource = liquorcategory.ViewCategory().Tables["LiquorCategory"];

        }

        private void CboLiquor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLiquor();
        }

        private void LoadLiquor()
        {
            liquor = new Liquor();
            liquor.LiquorId = Convert.ToInt32(CboLiquor.SelectedValue);
            if (liquor.GetLiquor().Rows.Count > 0)
            {
                LoadCbo();
                CboCategory.DisplayMember = liquor.GetLiquor().Rows[0][1].ToString();
                TxtPrice.Text = liquor.GetLiquor().Rows[0][2].ToString();
                TxtQuantity.Text = liquor.GetLiquor().Rows[0][3].ToString();
                TxtThreshold.Text = liquor.GetLiquor().Rows[0][4].ToString();
            }
        }
    }
}
