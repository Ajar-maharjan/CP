namespace Stockmgmtsystem
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultDiscountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createStockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.BtnDellcust = new System.Windows.Forms.Button();
            this.BtnAddlcust = new System.Windows.Forms.Button();
            this.BtnCreatebill = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEditcategory = new System.Windows.Forms.Button();
            this.BtnViewcategory = new System.Windows.Forms.Button();
            this.BtnAddcategory = new System.Windows.Forms.Button();
            this.Liquor = new System.Windows.Forms.TabPage();
            this.BtnRestock = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEditlqiquor = new System.Windows.Forms.Button();
            this.BtnViewliquor = new System.Windows.Forms.Button();
            this.btnAddliquor = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Tab.SuspendLayout();
            this.Main.SuspendLayout();
            this.Category.SuspendLayout();
            this.Liquor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDefaultDiscountToolStripMenuItem,
            this.createStockReportToolStripMenuItem,
            this.changePinToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.myAccountToolStripMenuItem.Text = "My Account";
            // 
            // setDefaultDiscountToolStripMenuItem
            // 
            this.setDefaultDiscountToolStripMenuItem.Name = "setDefaultDiscountToolStripMenuItem";
            this.setDefaultDiscountToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.setDefaultDiscountToolStripMenuItem.Text = "Set Default Discount";
            this.setDefaultDiscountToolStripMenuItem.Click += new System.EventHandler(this.setDefaultDiscountToolStripMenuItem_Click);
            // 
            // createStockReportToolStripMenuItem
            // 
            this.createStockReportToolStripMenuItem.Name = "createStockReportToolStripMenuItem";
            this.createStockReportToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.createStockReportToolStripMenuItem.Text = "Create Stock Report";
            this.createStockReportToolStripMenuItem.Click += new System.EventHandler(this.createStockReportToolStripMenuItem_Click);
            // 
            // changePinToolStripMenuItem
            // 
            this.changePinToolStripMenuItem.Name = "changePinToolStripMenuItem";
            this.changePinToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.changePinToolStripMenuItem.Text = "Change Pin";
            this.changePinToolStripMenuItem.Click += new System.EventHandler(this.changePinToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Main);
            this.Tab.Controls.Add(this.Category);
            this.Tab.Controls.Add(this.Liquor);
            this.Tab.Location = new System.Drawing.Point(0, 27);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(465, 310);
            this.Tab.TabIndex = 1;
            this.Tab.Tag = "";
            // 
            // Main
            // 
            this.Main.Controls.Add(this.BtnDellcust);
            this.Main.Controls.Add(this.BtnAddlcust);
            this.Main.Controls.Add(this.BtnCreatebill);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(457, 284);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // BtnDellcust
            // 
            this.BtnDellcust.Location = new System.Drawing.Point(246, 166);
            this.BtnDellcust.Name = "BtnDellcust";
            this.BtnDellcust.Size = new System.Drawing.Size(150, 23);
            this.BtnDellcust.TabIndex = 2;
            this.BtnDellcust.Text = "Delete Loyal Customer";
            this.BtnDellcust.UseVisualStyleBackColor = true;
            this.BtnDellcust.Click += new System.EventHandler(this.BtnDellcust_Click);
            // 
            // BtnAddlcust
            // 
            this.BtnAddlcust.Location = new System.Drawing.Point(58, 166);
            this.BtnAddlcust.Name = "BtnAddlcust";
            this.BtnAddlcust.Size = new System.Drawing.Size(150, 23);
            this.BtnAddlcust.TabIndex = 1;
            this.BtnAddlcust.Text = "Add Loyal Customer";
            this.BtnAddlcust.UseVisualStyleBackColor = true;
            this.BtnAddlcust.Click += new System.EventHandler(this.BtnAddlcust_Click);
            // 
            // BtnCreatebill
            // 
            this.BtnCreatebill.Location = new System.Drawing.Point(170, 55);
            this.BtnCreatebill.Name = "BtnCreatebill";
            this.BtnCreatebill.Size = new System.Drawing.Size(111, 58);
            this.BtnCreatebill.TabIndex = 0;
            this.BtnCreatebill.Text = "Create Bill";
            this.BtnCreatebill.UseVisualStyleBackColor = true;
            this.BtnCreatebill.Click += new System.EventHandler(this.BtnCreatebill_Click);
            // 
            // Category
            // 
            this.Category.Controls.Add(this.label2);
            this.Category.Controls.Add(this.BtnEditcategory);
            this.Category.Controls.Add(this.BtnViewcategory);
            this.Category.Controls.Add(this.BtnAddcategory);
            this.Category.Location = new System.Drawing.Point(4, 22);
            this.Category.Name = "Category";
            this.Category.Padding = new System.Windows.Forms.Padding(3);
            this.Category.Size = new System.Drawing.Size(457, 284);
            this.Category.TabIndex = 1;
            this.Category.Text = "Category";
            this.Category.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liquor Category";
            // 
            // BtnEditcategory
            // 
            this.BtnEditcategory.Location = new System.Drawing.Point(144, 175);
            this.BtnEditcategory.Name = "BtnEditcategory";
            this.BtnEditcategory.Size = new System.Drawing.Size(153, 23);
            this.BtnEditcategory.TabIndex = 2;
            this.BtnEditcategory.Text = "Edit Category";
            this.BtnEditcategory.UseVisualStyleBackColor = true;
            this.BtnEditcategory.Click += new System.EventHandler(this.BtnEditcategory_Click);
            // 
            // BtnViewcategory
            // 
            this.BtnViewcategory.Location = new System.Drawing.Point(144, 125);
            this.BtnViewcategory.Name = "BtnViewcategory";
            this.BtnViewcategory.Size = new System.Drawing.Size(153, 23);
            this.BtnViewcategory.TabIndex = 1;
            this.BtnViewcategory.Text = "View Category";
            this.BtnViewcategory.UseVisualStyleBackColor = true;
            this.BtnViewcategory.Click += new System.EventHandler(this.BtnViewcategory_Click);
            // 
            // BtnAddcategory
            // 
            this.BtnAddcategory.Location = new System.Drawing.Point(144, 76);
            this.BtnAddcategory.Name = "BtnAddcategory";
            this.BtnAddcategory.Size = new System.Drawing.Size(153, 23);
            this.BtnAddcategory.TabIndex = 0;
            this.BtnAddcategory.Text = "Add Category";
            this.BtnAddcategory.UseVisualStyleBackColor = true;
            this.BtnAddcategory.Click += new System.EventHandler(this.BtnAddcategory_Click);
            // 
            // Liquor
            // 
            this.Liquor.Controls.Add(this.BtnRestock);
            this.Liquor.Controls.Add(this.label4);
            this.Liquor.Controls.Add(this.textBox1);
            this.Liquor.Controls.Add(this.label1);
            this.Liquor.Controls.Add(this.BtnEditlqiquor);
            this.Liquor.Controls.Add(this.BtnViewliquor);
            this.Liquor.Controls.Add(this.btnAddliquor);
            this.Liquor.Location = new System.Drawing.Point(4, 22);
            this.Liquor.Name = "Liquor";
            this.Liquor.Padding = new System.Windows.Forms.Padding(3);
            this.Liquor.Size = new System.Drawing.Size(457, 284);
            this.Liquor.TabIndex = 2;
            this.Liquor.Text = "Liquor";
            this.Liquor.UseVisualStyleBackColor = true;
            // 
            // BtnRestock
            // 
            this.BtnRestock.Location = new System.Drawing.Point(40, 115);
            this.BtnRestock.Name = "BtnRestock";
            this.BtnRestock.Size = new System.Drawing.Size(153, 22);
            this.BtnRestock.TabIndex = 10;
            this.BtnRestock.Text = "Restock Liquor";
            this.BtnRestock.UseVisualStyleBackColor = true;
            this.BtnRestock.Click += new System.EventHandler(this.BtnRestock_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock Status";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(232, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(224, 257);
            this.textBox1.TabIndex = 8;
            this.textBox1.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Liquor";
            // 
            // BtnEditlqiquor
            // 
            this.BtnEditlqiquor.Location = new System.Drawing.Point(40, 210);
            this.BtnEditlqiquor.Name = "BtnEditlqiquor";
            this.BtnEditlqiquor.Size = new System.Drawing.Size(153, 23);
            this.BtnEditlqiquor.TabIndex = 5;
            this.BtnEditlqiquor.Text = "Edit Liquor";
            this.BtnEditlqiquor.UseVisualStyleBackColor = true;
            this.BtnEditlqiquor.Click += new System.EventHandler(this.BtnEditlqiquor_Click);
            // 
            // BtnViewliquor
            // 
            this.BtnViewliquor.Location = new System.Drawing.Point(40, 160);
            this.BtnViewliquor.Name = "BtnViewliquor";
            this.BtnViewliquor.Size = new System.Drawing.Size(153, 23);
            this.BtnViewliquor.TabIndex = 4;
            this.BtnViewliquor.Text = "View Liquor";
            this.BtnViewliquor.UseVisualStyleBackColor = true;
            this.BtnViewliquor.Click += new System.EventHandler(this.BtnViewliquor_Click);
            // 
            // btnAddliquor
            // 
            this.btnAddliquor.Location = new System.Drawing.Point(40, 73);
            this.btnAddliquor.Name = "btnAddliquor";
            this.btnAddliquor.Size = new System.Drawing.Size(153, 23);
            this.btnAddliquor.TabIndex = 3;
            this.btnAddliquor.Text = "Add Liquor";
            this.btnAddliquor.UseVisualStyleBackColor = true;
            this.btnAddliquor.Click += new System.EventHandler(this.btnAddliquor_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(367, 343);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(86, 23);
            this.BtnLogout.TabIndex = 2;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 391);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Category.ResumeLayout(false);
            this.Category.PerformLayout();
            this.Liquor.ResumeLayout(false);
            this.Liquor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultDiscountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createStockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.Button BtnDellcust;
        private System.Windows.Forms.Button BtnAddlcust;
        private System.Windows.Forms.Button BtnCreatebill;
        private System.Windows.Forms.TabPage Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEditcategory;
        private System.Windows.Forms.Button BtnViewcategory;
        private System.Windows.Forms.Button BtnAddcategory;
        private System.Windows.Forms.TabPage Liquor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEditlqiquor;
        private System.Windows.Forms.Button BtnViewliquor;
        private System.Windows.Forms.Button btnAddliquor;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnRestock;
    }
}