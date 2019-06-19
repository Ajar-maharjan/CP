namespace Stockmgmtsystem
{
    partial class ChangePin
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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtOldpin = new System.Windows.Forms.TextBox();
            this.TxtNewpin = new System.Windows.Forms.TextBox();
            this.TxtRecoverycode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Pin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Pin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recovery Code";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(107, 181);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtOldpin
            // 
            this.TxtOldpin.Location = new System.Drawing.Point(136, 39);
            this.TxtOldpin.Name = "TxtOldpin";
            this.TxtOldpin.Size = new System.Drawing.Size(117, 20);
            this.TxtOldpin.TabIndex = 4;
            // 
            // TxtNewpin
            // 
            this.TxtNewpin.Location = new System.Drawing.Point(136, 84);
            this.TxtNewpin.Name = "TxtNewpin";
            this.TxtNewpin.Size = new System.Drawing.Size(117, 20);
            this.TxtNewpin.TabIndex = 5;
            // 
            // TxtRecoverycode
            // 
            this.TxtRecoverycode.Location = new System.Drawing.Point(136, 131);
            this.TxtRecoverycode.Name = "TxtRecoverycode";
            this.TxtRecoverycode.Size = new System.Drawing.Size(117, 20);
            this.TxtRecoverycode.TabIndex = 6;
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 227);
            this.Controls.Add(this.TxtRecoverycode);
            this.Controls.Add(this.TxtNewpin);
            this.Controls.Add(this.TxtOldpin);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ChangePin";
            this.Text = "ChangePin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtOldpin;
        private System.Windows.Forms.TextBox TxtNewpin;
        private System.Windows.Forms.TextBox TxtRecoverycode;
    }
}