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
    public partial class AddCategory : Form
    {
        LiquorCategory liquorcategory;

        public AddCategory()
        {
            InitializeComponent();
        }

        private void BtnAddcat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.InputHandle(TxtCategory))
                {
                    throw new Exception("Please enter liquor category");
                }
                liquorcategory = new LiquorCategory();
                liquorcategory.CategoryName = TxtCategory.Text;
                bool flag = liquorcategory.AddCategory();
                if (flag == true)
                    MessageBox.Show("Category added");
                else
                    MessageBox.Show("Category already exist");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
