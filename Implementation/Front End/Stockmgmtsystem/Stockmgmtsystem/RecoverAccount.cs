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
    public partial class RecoverAccount : Form
    {
        public RecoverAccount()
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

        private void BtnRecoverpin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputHandle(TxtRecoverycode))
                {
                    throw new Exception("Enter recoveryCode");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LblreturnLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
