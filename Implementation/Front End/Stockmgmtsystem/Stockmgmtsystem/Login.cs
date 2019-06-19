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
    public partial class Login : Form
    {
        public Login()
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
        
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputHandle(TxtPin))
                {
                    throw new Exception("Please enter pin");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LblForgotpin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoverAccount recoveraccount = new RecoverAccount();
            this.Hide();
            recoveraccount.Show();
        }
    }
}
