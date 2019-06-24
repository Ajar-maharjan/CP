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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Pin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Pin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(25, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recovery Code";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Snow;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnSave.Location = new System.Drawing.Point(107, 181);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 34);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtOldpin
            // 
            this.TxtOldpin.BackColor = System.Drawing.Color.Snow;
            this.TxtOldpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOldpin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtOldpin.Location = new System.Drawing.Point(136, 39);
            this.TxtOldpin.Name = "TxtOldpin";
            this.TxtOldpin.Size = new System.Drawing.Size(127, 23);
            this.TxtOldpin.TabIndex = 1;
            // 
            // TxtNewpin
            // 
            this.TxtNewpin.BackColor = System.Drawing.Color.Snow;
            this.TxtNewpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNewpin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtNewpin.Location = new System.Drawing.Point(136, 84);
            this.TxtNewpin.Name = "TxtNewpin";
            this.TxtNewpin.Size = new System.Drawing.Size(127, 23);
            this.TxtNewpin.TabIndex = 2;
            // 
            // TxtRecoverycode
            // 
            this.TxtRecoverycode.BackColor = System.Drawing.Color.Snow;
            this.TxtRecoverycode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecoverycode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtRecoverycode.Location = new System.Drawing.Point(136, 131);
            this.TxtRecoverycode.Name = "TxtRecoverycode";
            this.TxtRecoverycode.Size = new System.Drawing.Size(127, 23);
            this.TxtRecoverycode.TabIndex = 3;
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(297, 238);
            this.Controls.Add(this.TxtRecoverycode);
            this.Controls.Add(this.TxtNewpin);
            this.Controls.Add(this.TxtOldpin);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ChangePin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Pin";
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