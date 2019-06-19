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
    public partial class AddLiquor : Form
    {
        public AddLiquor()
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

        private bool ComboNull(ComboBox comboBox)
        {
            if (string.IsNullOrEmpty(comboBox.Text))
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

        private bool IsValidNumDec(TextBox textBox)
        {
            decimal parsedValue;
            if (!decimal.TryParse(textBox.Text, out parsedValue))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputHandle(TxtLiquor))
                {
                    throw new Exception("Enter Liquor name");
                }
                if (!ComboNull(CboCategory))
                {
                    throw new Exception("Select Liquor Category");
                }
                if (!InputHandle(TxtPrice))
                {
                    throw new Exception("Enter Liquor price");
                }
                if (!IsValidNumDec(TxtPrice))
                {
                    throw new Exception("Invalid Liquor price");
                }
                if (!InputHandle(TxtQuantity))
                {
                    throw new Exception("Enter Liquor quantity");
                }
                if (!IsValidNumInt(TxtQuantity))
                {
                    throw new Exception("Invalid Liquor quantity");
                }
                if (!InputHandle(TxtThreshold))
                {
                    throw new Exception("Enter Liquor quantity threshold");
                }
                if (!IsValidNumInt(TxtThreshold))
                {
                    throw new Exception("Invalid liquor quantity threshold");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}