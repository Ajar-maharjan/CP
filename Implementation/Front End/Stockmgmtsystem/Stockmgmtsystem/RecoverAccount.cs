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
        Login login;
        User user;

        public RecoverAccount()
        {
            InitializeComponent();
        }

        private void BtnRecoverpin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.InputHandle(TxtRecoverycode))
                {
                    throw new Exception("Enter recoveryCode");
                }
                user = new User();
                user.RecoveryCode = TxtRecoverycode.Text;
                bool flag = user.ForgotPin();
                if (flag == true)
                    MessageBox.Show("Your pin is " + user.Pin);
                else
                    MessageBox.Show("Invalid recovery code");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LblreturnLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login = new Login();
            this.Close();
            login.Show();
        }
    }
}
