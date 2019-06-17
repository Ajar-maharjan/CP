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
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Loyal Customer Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(35, 57);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(217, 20);
            this.TxtEmail.TabIndex = 1;
            // 
            // BtnAddcust
            // 
            this.BtnAddcust.Location = new System.Drawing.Point(107, 110);
            this.BtnAddcust.Name = "BtnAddcust";
            this.BtnAddcust.Size = new System.Drawing.Size(75, 23);
            this.BtnAddcust.TabIndex = 2;
            this.BtnAddcust.Text = "Add";
            this.BtnAddcust.UseVisualStyleBackColor = true;
            // 
            // AddLoyalCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 168);
            this.Controls.Add(this.BtnAddcust);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddLoyalCustomer";
            this.Text = "AddLoyalCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnAddcust;
    }
}