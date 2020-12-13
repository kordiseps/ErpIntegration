namespace ErpIntegration.Tester
{
    partial class FormLogoGoPlusCariEkle
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
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_taxNumber = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari kod";
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(152, 33);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(100, 26);
            this.textBox_code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ünvan";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(152, 65);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(100, 26);
            this.textBox_title.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vergi No";
            // 
            // textBox_taxNumber
            // 
            this.textBox_taxNumber.Location = new System.Drawing.Point(152, 97);
            this.textBox_taxNumber.Name = "textBox_taxNumber";
            this.textBox_taxNumber.Size = new System.Drawing.Size(100, 26);
            this.textBox_taxNumber.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(37, 156);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(215, 57);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Kaydet";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // FormLogoGoPlusCariEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 250);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_taxNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.label1);
            this.Name = "FormLogoGoPlusCariEkle";
            this.Text = "FormLogoGoPlusCariEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_taxNumber;
        private System.Windows.Forms.Button button_add;
    }
}