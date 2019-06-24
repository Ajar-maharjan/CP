namespace Stockmgmtsystem
{
    partial class AddLoyalCustomer
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
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnAddcust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Loyal Customer Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.Snow;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtEmail.Location = new System.Drawing.Point(40, 57);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(217, 23);
            this.TxtEmail.TabIndex = 1;
            // 
            // BtnAddcust
            // 
            this.BtnAddcust.BackColor = System.Drawing.Color.Snow;
            this.BtnAddcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddcust.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnAddcust.Location = new System.Drawing.Point(110, 110);
            this.BtnAddcust.Name = "BtnAddcust";
            this.BtnAddcust.Size = new System.Drawing.Size(69, 32);
            this.BtnAddcust.TabIndex = 2;
            this.BtnAddcust.Text = "Add";
            this.BtnAddcust.UseVisualStyleBackColor = false;
            this.BtnAddcust.Click += new System.EventHandler(this.BtnAddcust_Click);
            // 
            // AddLoyalCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(293, 168);
            this.Controls.Add(this.BtnAddcust);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddLoyalCustomer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Loyal Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnAddcust;
    }
}