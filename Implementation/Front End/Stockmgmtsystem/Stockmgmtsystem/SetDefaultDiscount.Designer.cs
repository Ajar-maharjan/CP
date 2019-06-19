namespace Stockmgmtsystem
{
    partial class SetDefaultDiscount
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDiscountper = new System.Windows.Forms.TextBox();
            this.BtnSetdiscount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Discount Percent Per 100 Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount";
            // 
            // TxtDiscountper
            // 
            this.TxtDiscountper.Location = new System.Drawing.Point(157, 58);
            this.TxtDiscountper.Name = "TxtDiscountper";
            this.TxtDiscountper.Size = new System.Drawing.Size(63, 20);
            this.TxtDiscountper.TabIndex = 2;
            // 
            // BtnSetdiscount
            // 
            this.BtnSetdiscount.Location = new System.Drawing.Point(102, 100);
            this.BtnSetdiscount.Name = "BtnSetdiscount";
            this.BtnSetdiscount.Size = new System.Drawing.Size(97, 23);
            this.BtnSetdiscount.TabIndex = 3;
            this.BtnSetdiscount.Text = "Set Discount";
            this.BtnSetdiscount.UseVisualStyleBackColor = true;
            this.BtnSetdiscount.Click += new System.EventHandler(this.BtnSetdiscount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "%";
            // 
            // SetDefaultDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 148);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSetdiscount);
            this.Controls.Add(this.TxtDiscountper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SetDefaultDiscount";
            this.Text = "SetDefaultDiscount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDiscountper;
        private System.Windows.Forms.Button BtnSetdiscount;
        private System.Windows.Forms.Label label3;
    }
}