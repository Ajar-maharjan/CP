﻿using System;
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
    public partial class SetDefaultDiscount : Form
    {
        public SetDefaultDiscount()
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

        private bool IsValidNumInt(TextBox textBox)
        {
            int parsedValue;
            if (!int.TryParse(textBox.Text, out parsedValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnSetdiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputHandle(TxtDiscountper))
                {
                    throw new Exception("Enter Discount percent");
                }
                if (!IsValidNumInt(TxtDiscountper))
                {
                    throw new Exception("Invalid Discount percent");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
