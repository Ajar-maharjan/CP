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
        public ChangePin()
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputHandle(TxtOldpin))
                {
                    throw new Exception("Enter old pin");
                }
                if (!InputHandle(TxtNewpin))
                {
                    throw new Exception("Enter new pin");
                }
                if (!InputHandle(TxtRecoverycode))
                {
                    throw new Exception("Enter recovery code");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
