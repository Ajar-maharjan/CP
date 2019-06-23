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
    public partial class ViewCategory : Form
    {
        LiquorCategory liquorcategory;

        public ViewCategory()
        {
            InitializeComponent();
        }

        private void ViewCategory_Load(object sender, EventArgs e)
        {
            liquorcategory = new LiquorCategory();
            DgvCategory.DataMember = "LiquorCategory";
            DgvCategory.DataSource = liquorcategory.ViewCategory().Tables["LiquorCategory"];
            DgvCategory.Columns[0].Visible = false;
        }
    }
}
