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
    public partial class InitialRegister : Form
    {
        public InitialRegister()
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
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputHandle(TxtPin))
                {
                    throw new Exception("Enter pin");
                }
                if (!InputHandle(TxtRepin))
                {
                    throw new Exception("Enter Re-enter pin");
                }
                if (TxtPin.Text != TxtRepin.Text)
                {
                    throw new Exception("Re-enter pin is inccorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
