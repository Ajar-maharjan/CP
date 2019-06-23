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
    public partial class ChangePin : Form
    {
        User user;

        public ChangePin()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Global.InputHandle(TxtOldpin))
                {
                    throw new Exception("Enter old pin");
                }
                if (!Global.InputHandle(TxtNewpin))
                {
                    throw new Exception("Enter new pin");
                }
                if (!Global.InputHandle(TxtRecoverycode))
                {
                    throw new Exception("Enter recovery code");
                }
                user = new User();
                user.OldPin = TxtOldpin.Text;
                user.Pin = TxtNewpin.Text;
                user.RecoveryCode = TxtRecoverycode.Text;
                bool flag = user.ChangePin();
                if (flag == true)
                    MessageBox.Show("Pin Changed");
                else
                    MessageBox.Show("Invalid pin or recovery code");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
