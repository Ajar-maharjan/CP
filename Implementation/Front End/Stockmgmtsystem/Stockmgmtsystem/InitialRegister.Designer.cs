﻿namespace Stockmgmtsystem
{
    partial class InitialRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPin = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Pin";
            // 
            // TxtPin
            // 
            this.TxtPin.Location = new System.Drawing.Point(76, 52);
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.Size = new System.Drawing.Size(140, 20);
            this.TxtPin.TabIndex = 1;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(57, 99);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(178, 23);
            this.BtnRegister.TabIndex = 2;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            // 
            // InitialRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 161);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TxtPin);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "InitialRegister";
            this.Text = "InitialRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPin;
        private System.Windows.Forms.Button BtnRegister;
    }
}