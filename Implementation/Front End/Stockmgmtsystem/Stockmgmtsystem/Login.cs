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
        User user;
        RecoverAccount recoveraccount;

        public Login()
        {
            InitializeComponent();
        }
        
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.InputHandle(TxtPin))
                {
                    throw new Exception("Please enter pin");
                }
                user = new User();
                user.Pin = TxtPin.Text;
                bool flag = user.Login();
                if (flag == true)
                {
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Invalid Pin code");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LblForgotpin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recoveraccount = new RecoverAccount();
            this.Hide();
            recoveraccount.ShowDialog();
        }
    }
}
