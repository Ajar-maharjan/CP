namespace Stockmgmtsystem
{
    partial class RestockLiquor
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
            this.TxtStockquantity = new System.Windows.Forms.TextBox();
            this.CboLiquor = new System.Windows.Forms.ComboBox();
            this.BtnRestock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liquor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Liquor stock quantity";
            // 
            // TxtStockquantity
            // 
            this.TxtStockquantity.BackColor = System.Drawing.Color.Snow;
            this.TxtStockquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockquantity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtStockquantity.Location = new System.Drawing.Point(206, 80);
            this.TxtStockquantity.Name = "TxtStockquantity";
            this.TxtStockquantity.Size = new System.Drawing.Size(90, 23);
            this.TxtStockquantity.TabIndex = 2;
            // 
            // CboLiquor
            // 
            this.CboLiquor.BackColor = System.Drawing.Color.Snow;
            this.CboLiquor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboLiquor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CboLiquor.FormattingEnabled = true;
            this.CboLiquor.Location = new System.Drawing.Point(84, 36);
            this.CboLiquor.Name = "CboLiquor";
            this.CboLiquor.Size = new System.Drawing.Size(212, 24);
            this.CboLiquor.TabIndex = 1;
            // 
            // BtnRestock
            // 
            this.BtnRestock.BackColor = System.Drawing.Color.Snow;
            this.BtnRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestock.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnRestock.Location = new System.Drawing.Point(113, 131);
            this.BtnRestock.Name = "BtnRestock";
            this.BtnRestock.Size = new System.Drawing.Size(99, 28);
            this.BtnRestock.TabIndex = 3;
            this.BtnRestock.Text = "Restock";
            this.BtnRestock.UseVisualStyleBackColor = false;
            this.BtnRestock.Click += new System.EventHandler(this.BtnRestock_Click);
            // 
            // RestockLiquor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(340, 181);
            this.Controls.Add(this.BtnRestock);
            this.Controls.Add(this.CboLiquor);
            this.Controls.Add(this.TxtStockquantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RestockLiquor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restock Liquor";
            this.Load += new System.EventHandler(this.RestockLiquor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtStockquantity;
        private System.Windows.Forms.ComboBox CboLiquor;
        private System.Windows.Forms.Button BtnRestock;
    }
}