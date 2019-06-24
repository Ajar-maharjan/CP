namespace Stockmgmtsystem
{
    partial class CreateBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBill));
            this.CboLoyalcustomer = new System.Windows.Forms.ComboBox();
            this.ChkApplydiscount = new System.Windows.Forms.CheckBox();
            this.CboLiquor = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvBill = new System.Windows.Forms.DataGridView();
            this.LiquorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LiquorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtCash = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblChange = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDiscount = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PrintBill = new System.Drawing.Printing.PrintDocument();
            this.BillPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // CboLoyalcustomer
            // 
            this.CboLoyalcustomer.BackColor = System.Drawing.Color.Snow;
            this.CboLoyalcustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboLoyalcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboLoyalcustomer.FormattingEnabled = true;
            this.CboLoyalcustomer.Location = new System.Drawing.Point(199, 23);
            this.CboLoyalcustomer.Name = "CboLoyalcustomer";
            this.CboLoyalcustomer.Size = new System.Drawing.Size(201, 24);
            this.CboLoyalcustomer.TabIndex = 0;
            this.CboLoyalcustomer.SelectedIndexChanged += new System.EventHandler(this.CboLoyalcustomer_SelectedIndexChanged);
            // 
            // ChkApplydiscount
            // 
            this.ChkApplydiscount.AutoSize = true;
            this.ChkApplydiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkApplydiscount.ForeColor = System.Drawing.Color.IndianRed;
            this.ChkApplydiscount.Location = new System.Drawing.Point(383, 550);
            this.ChkApplydiscount.Name = "ChkApplydiscount";
            this.ChkApplydiscount.Size = new System.Drawing.Size(121, 21);
            this.ChkApplydiscount.TabIndex = 5;
            this.ChkApplydiscount.Text = "Apply Discount";
            this.ChkApplydiscount.UseVisualStyleBackColor = true;
            this.ChkApplydiscount.CheckedChanged += new System.EventHandler(this.ChkApplydiscount_CheckedChanged);
            // 
            // CboLiquor
            // 
            this.CboLiquor.BackColor = System.Drawing.Color.Snow;
            this.CboLiquor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboLiquor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboLiquor.FormattingEnabled = true;
            this.CboLiquor.Location = new System.Drawing.Point(127, 125);
            this.CboLiquor.Name = "CboLiquor";
            this.CboLiquor.Size = new System.Drawing.Size(192, 24);
            this.CboLiquor.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvBill);
            this.panel1.Location = new System.Drawing.Point(12, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 228);
            this.panel1.TabIndex = 3;
            // 
            // DgvBill
            // 
            this.DgvBill.AllowUserToAddRows = false;
            this.DgvBill.AllowUserToDeleteRows = false;
            this.DgvBill.AllowUserToResizeColumns = false;
            this.DgvBill.AllowUserToResizeRows = false;
            this.DgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBill.BackgroundColor = System.Drawing.Color.SeaShell;
            this.DgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LiquorId,
            this.LiquorName,
            this.Quantity,
            this.Price});
            this.DgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvBill.Location = new System.Drawing.Point(0, 0);
            this.DgvBill.Name = "DgvBill";
            this.DgvBill.ReadOnly = true;
            this.DgvBill.Size = new System.Drawing.Size(492, 228);
            this.DgvBill.TabIndex = 19;
            // 
            // LiquorId
            // 
            this.LiquorId.HeaderText = "Column1";
            this.LiquorId.Name = "LiquorId";
            this.LiquorId.ReadOnly = true;
            this.LiquorId.Visible = false;
            // 
            // LiquorName
            // 
            this.LiquorName.HeaderText = "Liquor Name";
            this.LiquorName.Name = "LiquorName";
            this.LiquorName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.BackColor = System.Drawing.Color.Snow;
            this.TxtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantity.Location = new System.Drawing.Point(127, 167);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(60, 23);
            this.TxtQuantity.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Snow;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnAdd.Location = new System.Drawing.Point(350, 160);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(96, 30);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add Liquor";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtCash
            // 
            this.TxtCash.BackColor = System.Drawing.Color.Snow;
            this.TxtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCash.Location = new System.Drawing.Point(437, 467);
            this.TxtCash.Name = "TxtCash";
            this.TxtCash.Size = new System.Drawing.Size(45, 23);
            this.TxtCash.TabIndex = 4;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.Snow;
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnCreate.Location = new System.Drawing.Point(418, 588);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(86, 33);
            this.BtnCreate.TabIndex = 7;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Snow;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnClose.Location = new System.Drawing.Point(19, 588);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(88, 33);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Loyal Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Points :";
            // 
            // LblPoints
            // 
            this.LblPoints.AutoSize = true;
            this.LblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoints.ForeColor = System.Drawing.Color.IndianRed;
            this.LblPoints.Location = new System.Drawing.Point(91, 56);
            this.LblPoints.Name = "LblPoints";
            this.LblPoints.Size = new System.Drawing.Size(16, 17);
            this.LblPoints.TabIndex = 12;
            this.LblPoints.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(30, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select Liquor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(55, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(383, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total :";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.IndianRed;
            this.LblTotal.Location = new System.Drawing.Point(437, 442);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(40, 17);
            this.LblTotal.TabIndex = 16;
            this.LblTotal.Text = "0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(383, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cash :";
            // 
            // LblChange
            // 
            this.LblChange.AutoSize = true;
            this.LblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChange.ForeColor = System.Drawing.Color.IndianRed;
            this.LblChange.Location = new System.Drawing.Point(437, 524);
            this.LblChange.Name = "LblChange";
            this.LblChange.Size = new System.Drawing.Size(40, 17);
            this.LblChange.TabIndex = 18;
            this.LblChange.Text = "0000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(366, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Change :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(360, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Discount :";
            // 
            // LblDiscount
            // 
            this.LblDiscount.AutoSize = true;
            this.LblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiscount.ForeColor = System.Drawing.Color.IndianRed;
            this.LblDiscount.Location = new System.Drawing.Point(437, 499);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(40, 17);
            this.LblDiscount.TabIndex = 21;
            this.LblDiscount.Text = "0000";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Snow;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnClear.Location = new System.Drawing.Point(127, 588);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(88, 33);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Snow;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.IndianRed;
            this.btnPrint.Location = new System.Drawing.Point(312, 588);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 33);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Stockmgmtsystem.Properties.Resources._3;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Location = new System.Drawing.Point(423, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(59, 66);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // PrintBill
            // 
            this.PrintBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintBill_PrintPage);
            // 
            // BillPrintPreview
            // 
            this.BillPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.BillPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.BillPrintPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.BillPrintPreview.Document = this.PrintBill;
            this.BillPrintPreview.Enabled = true;
            this.BillPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("BillPrintPreview.Icon")));
            this.BillPrintPreview.Name = "BillPrintPreview";
            this.BillPrintPreview.Visible = false;
            // 
            // CreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(517, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LblDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblChange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtCash);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CboLiquor);
            this.Controls.Add(this.ChkApplydiscount);
            this.Controls.Add(this.CboLoyalcustomer);
            this.MinimizeBox = false;
            this.Name = "CreateBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Bill";
            this.Load += new System.EventHandler(this.CreateBill_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboLoyalcustomer;
        private System.Windows.Forms.CheckBox ChkApplydiscount;
        private System.Windows.Forms.ComboBox CboLiquor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvBill;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtCash;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiquorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LiquorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Drawing.Printing.PrintDocument PrintBill;
        private System.Windows.Forms.PrintPreviewDialog BillPrintPreview;
    }
}