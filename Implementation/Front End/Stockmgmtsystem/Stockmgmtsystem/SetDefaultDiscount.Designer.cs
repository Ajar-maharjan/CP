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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Discount Percent Per 100 Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(61, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount";
            // 
            // TxtDiscountper
            // 
            this.TxtDiscountper.BackColor = System.Drawing.Color.Snow;
            this.TxtDiscountper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiscountper.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDiscountper.Location = new System.Drawing.Point(130, 58);
            this.TxtDiscountper.Name = "TxtDiscountper";
            this.TxtDiscountper.Size = new System.Drawing.Size(47, 23);
            this.TxtDiscountper.TabIndex = 2;
            // 
            // BtnSetdiscount
            // 
            this.BtnSetdiscount.BackColor = System.Drawing.Color.Snow;
            this.BtnSetdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetdiscount.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnSetdiscount.Location = new System.Drawing.Point(97, 99);
            this.BtnSetdiscount.Name = "BtnSetdiscount";
            this.BtnSetdiscount.Size = new System.Drawing.Size(97, 36);
            this.BtnSetdiscount.TabIndex = 3;
            this.BtnSetdiscount.Text = "Set Discount";
            this.BtnSetdiscount.UseVisualStyleBackColor = false;
            this.BtnSetdiscount.Click += new System.EventHandler(this.BtnSetdiscount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(183, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "%";
            // 
            // SetDefaultDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(299, 156);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSetdiscount);
            this.Controls.Add(this.TxtDiscountper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SetDefaultDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Default Discount";
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