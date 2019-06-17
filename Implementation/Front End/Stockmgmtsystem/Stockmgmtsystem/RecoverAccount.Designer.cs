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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Recovery Code";
            // 
            // TxtRecoverycode
            // 
            this.TxtRecoverycode.Location = new System.Drawing.Point(171, 29);
            this.TxtRecoverycode.Name = "TxtRecoverycode";
            this.TxtRecoverycode.Size = new System.Drawing.Size(132, 20);
            this.TxtRecoverycode.TabIndex = 1;
            // 
            // BtnRecoverpin
            // 
            this.BtnRecoverpin.Location = new System.Drawing.Point(128, 72);
            this.BtnRecoverpin.Name = "BtnRecoverpin";
            this.BtnRecoverpin.Size = new System.Drawing.Size(108, 23);
            this.BtnRecoverpin.TabIndex = 2;
            this.BtnRecoverpin.Text = "Recover Pin";
            this.BtnRecoverpin.UseVisualStyleBackColor = true;
            // 
            // RecoverAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 127);
            this.Controls.Add(this.BtnRecoverpin);
            this.Controls.Add(this.TxtRecoverycode);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RecoverAccount";
            this.Text = "RecoverAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRecoverycode;
        private System.Windows.Forms.Button BtnRecoverpin;
    }
}