namespace Stockmgmtsystem
{
    partial class AddCategory
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
            this.BtnAddcat = new System.Windows.Forms.Button();
            this.TxtCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // BtnAddcat
            // 
            this.BtnAddcat.BackColor = System.Drawing.Color.Snow;
            this.BtnAddcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddcat.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnAddcat.Location = new System.Drawing.Point(81, 83);
            this.BtnAddcat.Name = "BtnAddcat";
            this.BtnAddcat.Size = new System.Drawing.Size(95, 30);
            this.BtnAddcat.TabIndex = 1;
            this.BtnAddcat.Text = "Add";
            this.BtnAddcat.UseVisualStyleBackColor = false;
            this.BtnAddcat.Click += new System.EventHandler(this.BtnAddcat_Click);
            // 
            // TxtCategory
            // 
            this.TxtCategory.BackColor = System.Drawing.Color.Snow;
            this.TxtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtCategory.Location = new System.Drawing.Point(95, 33);
            this.TxtCategory.Name = "TxtCategory";
            this.TxtCategory.Size = new System.Drawing.Size(133, 23);
            this.TxtCategory.TabIndex = 2;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(264, 142);
            this.Controls.Add(this.TxtCategory);
            this.Controls.Add(this.BtnAddcat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddCategory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Liquor Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddcat;
        private System.Windows.Forms.TextBox TxtCategory;
    }
}