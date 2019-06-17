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
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // BtnAddcat
            // 
            this.BtnAddcat.Location = new System.Drawing.Point(81, 90);
            this.BtnAddcat.Name = "BtnAddcat";
            this.BtnAddcat.Size = new System.Drawing.Size(85, 23);
            this.BtnAddcat.TabIndex = 1;
            this.BtnAddcat.Text = "Add";
            this.BtnAddcat.UseVisualStyleBackColor = true;
            // 
            // TxtCategory
            // 
            this.TxtCategory.Location = new System.Drawing.Point(95, 33);
            this.TxtCategory.Name = "TxtCategory";
            this.TxtCategory.Size = new System.Drawing.Size(133, 20);
            this.TxtCategory.TabIndex = 2;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 142);
            this.Controls.Add(this.TxtCategory);
            this.Controls.Add(this.BtnAddcat);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddcat;
        private System.Windows.Forms.TextBox TxtCategory;
    }
}