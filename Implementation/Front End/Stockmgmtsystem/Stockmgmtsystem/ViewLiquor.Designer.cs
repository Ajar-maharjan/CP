namespace Stockmgmtsystem
{
    partial class ViewLiquor
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
            this.TxtLiquor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvLiquor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.CboCategory = new System.Windows.Forms.ComboBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLiquor)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtLiquor
            // 
            this.TxtLiquor.BackColor = System.Drawing.Color.Snow;
            this.TxtLiquor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLiquor.Location = new System.Drawing.Point(210, 32);
            this.TxtLiquor.Name = "TxtLiquor";
            this.TxtLiquor.Size = new System.Drawing.Size(178, 23);
            this.TxtLiquor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvLiquor);
            this.panel1.Location = new System.Drawing.Point(1, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 452);
            this.panel1.TabIndex = 1;
            // 
            // DgvLiquor
            // 
            this.DgvLiquor.AllowUserToAddRows = false;
            this.DgvLiquor.AllowUserToDeleteRows = false;
            this.DgvLiquor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLiquor.BackgroundColor = System.Drawing.Color.Linen;
            this.DgvLiquor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLiquor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLiquor.Location = new System.Drawing.Point(0, 0);
            this.DgvLiquor.Name = "DgvLiquor";
            this.DgvLiquor.ReadOnly = true;
            this.DgvLiquor.Size = new System.Drawing.Size(689, 452);
            this.DgvLiquor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By Liquor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(75, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By Category";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Snow;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnSearch.Location = new System.Drawing.Point(413, 29);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(81, 29);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CboCategory
            // 
            this.CboCategory.BackColor = System.Drawing.Color.Snow;
            this.CboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCategory.FormattingEnabled = true;
            this.CboCategory.Location = new System.Drawing.Point(210, 67);
            this.CboCategory.Name = "CboCategory";
            this.CboCategory.Size = new System.Drawing.Size(178, 24);
            this.CboCategory.TabIndex = 2;
            this.CboCategory.SelectedIndexChanged += new System.EventHandler(this.CboCategory_SelectedIndexChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Snow;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnClear.Location = new System.Drawing.Point(413, 64);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(81, 29);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ViewLiquor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(690, 553);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.CboCategory);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtLiquor);
            this.MaximizeBox = false;
            this.Name = "ViewLiquor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Liquor";
            this.Load += new System.EventHandler(this.ViewLiquor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLiquor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLiquor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvLiquor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ComboBox CboCategory;
        private System.Windows.Forms.Button BtnClear;
    }
}