namespace Stockmgmtsystem
{
    partial class Login
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
            this.LblForgotpin = new System.Windows.Forms.LinkLabel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Pin";
            // 
            // TxtPin
            // 
            this.TxtPin.Location = new System.Drawing.Point(87, 41);
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.Size = new System.Drawing.Size(137, 20);
            this.TxtPin.TabIndex = 1;
            // 
            // LblForgotpin
            // 
            this.LblForgotpin.AutoSize = true;
            this.LblForgotpin.Location = new System.Drawing.Point(44, 79);
            this.LblForgotpin.Name = "LblForgotpin";
            this.LblForgotpin.Size = new System.Drawing.Size(61, 13);
            this.LblForgotpin.TabIndex = 2;
            this.LblForgotpin.TabStop = true;
            this.LblForgotpin.Text = "Forgot Pin?";
            this.LblForgotpin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblForgotpin_LinkClicked);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(78, 118);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(122, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 176);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblForgotpin);
            this.Controls.Add(this.TxtPin);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPin;
        private System.Windows.Forms.LinkLabel LblForgotpin;
        private System.Windows.Forms.Button BtnLogin;
    }
}

