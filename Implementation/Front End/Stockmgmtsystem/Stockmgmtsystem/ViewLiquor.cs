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
    public partial class ViewLiquor : Form
    {
        public ViewLiquor()
        {
            InitializeComponent();
        }

        Liquor liquor;
        LiquorCategory liquorcategory;

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                bool category = true;
                if (!Global.InputHandle(TxtLiquor))
                {
                    throw new Exception("Enter Liquor");
                }
                if (!Global.ComboNull(CboCategory))
                {
                    category= false;
                }
                liquor = new Liquor();
                if (!category)                 
                    SearchLiquor();
                else
                    SearchLiquorCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewLiquor_Load(object sender, EventArgs e)
        {
            LoadLiquor();
            LoadCategoryCbo();
            CboCategory.SelectedIndex = -1;
            DgvLiquor.Columns[0].Visible = false;
        }

        private void LoadLiquor()
        {
            liquor = new Liquor();
            DgvLiquor.DataSource = liquor.ViewLiquor().Tables["Liquor"];
        }

        private void LoadCategoryCbo()
        {
            liquorcategory = new LiquorCategory();
            CboCategory.DisplayMember = "CategoryName";
            CboCategory.ValueMember = "CategoryId";
            CboCategory.DataSource = liquorcategory.ViewCategory().Tables["LiquorCategory"];
            
        }

        private void SearchLiquor()
        {
            liquor = new Liquor();
            DgvLiquor.DataSource = liquor.SearchLiquor(TxtLiquor.Text).Tables["Liquor"];
        }

        private void SearchLiquorCategory()
        {
            liquor = new Liquor();
            DgvLiquor.DataSource = liquor.SearchLiquorCategory(TxtLiquor.Text, 
                Convert.ToInt32(CboCategory.SelectedValue)).Tables["Liquor"];
            
        }

        private void FilterLiquorCategory()
        {
            liquor = new Liquor();
            liquor.CategoryId = Convert.ToInt32(CboCategory.SelectedValue);
            DgvLiquor.DataSource = liquor.FilterLiquorCategory().Tables["Liquor"];
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCategory.SelectedIndex != -1)
                    FilterLiquorCategory();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LoadLiquor();
            CboCategory.SelectedIndex = -1;
            TxtLiquor.Text = null;
        }
    }
}
