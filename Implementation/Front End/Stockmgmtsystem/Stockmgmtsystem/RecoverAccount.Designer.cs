namespace Stockmgmtsystem
{
    partial class RecoverAccount
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
            this.TxtRecoverycode = new System.Windows.Forms.TextBox();
            this.BtnRecoverpin = new System.Windows.Forms.Button();
            this.LblreturnLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Recovery Code";
            // 
            // TxtRecoverycode
            // 
            this.TxtRecoverycode.BackColor = System.Drawing.Color.Snow;
            this.TxtRecoverycode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecoverycode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtRecoverycode.Location = new System.Drawing.Point(191, 29);
            this.TxtRecoverycode.Name = "TxtRecoverycode";
            this.TxtRecoverycode.Size = new System.Drawing.Size(132, 23);
            this.TxtRecoverycode.TabIndex = 1;
            // 
            // BtnRecoverpin
            // 
            this.BtnRecoverpin.BackColor = System.Drawing.Color.Snow;
            this.BtnRecoverpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecoverpin.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnRecoverpin.Location = new System.Drawing.Point(124, 94);
            this.BtnRecoverpin.Name = "BtnRecoverpin";
            this.BtnRecoverpin.Size = new System.Drawing.Size(108, 27);
            this.BtnRecoverpin.TabIndex = 2;
            this.BtnRecoverpin.Text = "Recover Pin";
            this.BtnRecoverpin.UseVisualStyleBackColor = false;
            this.BtnRecoverpin.Click += new System.EventHandler(this.BtnRecoverpin_Click);
            // 
            // LblreturnLogin
            // 
            this.LblreturnLogin.AutoSize = true;
            this.LblreturnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblreturnLogin.LinkColor = System.Drawing.Color.DarkRed;
            this.LblreturnLogin.Location = new System.Drawing.Point(84, 61);
            this.LblreturnLogin.Name = "LblreturnLogin";
            this.LblreturnLogin.Size = new System.Drawing.Size(101, 17);
            this.LblreturnLogin.TabIndex = 3;
            this.LblreturnLogin.TabStop = true;
            this.LblreturnLogin.Text = "Return to login";
            this.LblreturnLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblreturnLogin_LinkClicked);
            // 
            // RecoverAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(364, 143);
            this.Controls.Add(this.LblreturnLogin);
            this.Controls.Add(this.BtnRecoverpin);
            this.Controls.Add(this.TxtRecoverycode);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RecoverAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recover Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRecoverycode;
        private System.Windows.Forms.Button BtnRecoverpin;
        private System.Windows.Forms.LinkLabel LblreturnLogin;
    }
}