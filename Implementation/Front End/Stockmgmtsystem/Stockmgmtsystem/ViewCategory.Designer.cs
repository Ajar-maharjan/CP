namespace Stockmgmtsystem
{
    partial class ViewCategory
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
            this.DgvCategory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCategory
            // 
            this.DgvCategory.AllowUserToAddRows = false;
            this.DgvCategory.AllowUserToDeleteRows = false;
            this.DgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCategory.Location = new System.Drawing.Point(0, 0);
            this.DgvCategory.Name = "DgvCategory";
            this.DgvCategory.ReadOnly = true;
            this.DgvCategory.Size = new System.Drawing.Size(340, 450);
            this.DgvCategory.TabIndex = 0;
            // 
            // ViewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.DgvCategory);
            this.MaximizeBox = false;
            this.Name = "ViewCategory";
            this.Text = "ViewCategory";
            this.Load += new System.EventHandler(this.ViewCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCategory;
    }
}