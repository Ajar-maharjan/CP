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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputHandle(TxtLiquor))
                {
                    throw new Exception("Enter Liquor");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewLiquor_Load(object sender, EventArgs e)
        {

        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
