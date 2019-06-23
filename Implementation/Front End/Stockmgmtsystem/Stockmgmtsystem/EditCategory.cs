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
    public partial class EditCategory : Form
    {
        LiquorCategory liquorcategory;

        public EditCategory()
        {
            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.ComboNull(CboCategory))
                {
                    throw new Exception("Select liquor category");
                }
                liquorcategory = new LiquorCategory();
                liquorcategory.CategoryName = CboCategory.Text;
                liquorcategory.CategoryId = Convert.ToInt32(CboCategory.SelectedValue);
                bool flag = liquorcategory.DeleteCategory();
                if (flag == true)
                {
                    LoadCategoryCbo();
                    MessageBox.Show("Selected liquor category is deleted");
                }
                else
                    MessageBox.Show("Liquor category does not exist");
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
            if (!Global.ComboNull(CboCategory))
                {
                    throw new Exception("Select liquor category");
                }
                if (!Global.InputHandle(TxtCategory))
                {
                    throw new Exception("Enter liquor category");
                }
                liquorcategory = new LiquorCategory();
                liquorcategory.CategoryId = Convert.ToInt32(CboCategory.SelectedValue);
                liquorcategory.CategoryName = TxtCategory.Text;
                bool flag = liquorcategory.UpdateCategory();
                if (flag == true)
                {
                    MessageBox.Show("Selected liquor category is updated");
                    LoadCategoryCbo();
                }
                else
                    MessageBox.Show("Category already exist");
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

        private void EditCategory_Load(object sender, EventArgs e)
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
    }
}
