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
        User user;
        Login login;

        public InitialRegister()
        {
            InitializeComponent();
        }
        
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.InputHandle(TxtPin))
                {
                    throw new Exception("Enter pin");
                }
                if (!Global.InputHandle(TxtRepin))
                {
                    throw new Exception("Enter Re-enter pin");
                }
                if (TxtPin.Text != TxtRepin.Text)
                {
                    throw new Exception("Re-enter pin is inccorrect");
                }
                user = new User();
                user.Pin = TxtPin.Text;
                string recovery = user.Register();
                MessageBox.Show("User registered."+ Environment.NewLine 
                    + "Your Recovery code is " + recovery + Environment.NewLine 
                    + "(Code is copied in clipboard)");
                Clipboard.SetText(recovery);
                this.Hide();
                login = new Login();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
