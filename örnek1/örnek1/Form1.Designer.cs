namespace örnek1
{
    partial class Form1
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
            this.rbTamBilet = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOgretmen = new System.Windows.Forms.RadioButton();
            this.rbOgrenci = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.btnGecisyap = new System.Windows.Forms.Button();
            this.lblKalan = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTamBilet
            // 
            this.rbTamBilet.AutoSize = true;
            this.rbTamBilet.Location = new System.Drawing.Point(23, 28);
            this.rbTamBilet.Name = "rbTamBilet";
            this.rbTamBilet.Size = new System.Drawing.Size(194, 26);
            this.rbTamBilet.TabIndex = 0;
            this.rbTamBilet.TabStop = true;
            this.rbTamBilet.Text = "Tam Bilet (20TL)";
            this.rbTamBilet.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.rbOgrenci);
            this.groupBox1.Controls.Add(this.rbOgretmen);
            this.groupBox1.Controls.Add(this.rbTamBilet);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(300, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ücret Seçenekleri";
            // 
            // rbOgretmen
            // 
            this.rbOgretmen.AutoSize = true;
            this.rbOgretmen.Location = new System.Drawing.Point(23, 60);
            this.rbOgretmen.Name = "rbOgretmen";
            this.rbOgretmen.Size = new System.Drawing.Size(198, 26);
            this.rbOgretmen.TabIndex = 1;
            this.rbOgretmen.TabStop = true;
            this.rbOgretmen.Text = "Öğretmen (14,32)";
            this.rbOgretmen.UseVisualStyleBackColor = true;
            // 
            // rbOgrenci
            // 
            this.rbOgrenci.AutoSize = true;
            this.rbOgrenci.Location = new System.Drawing.Point(23, 92);
            this.rbOgrenci.Name = "rbOgrenci";
            this.rbOgrenci.Size = new System.Drawing.Size(175, 26);
            this.rbOgrenci.TabIndex = 2;
            this.rbOgrenci.TabStop = true;
            this.rbOgrenci.Text = "Öğrenci  (9,76)";
            this.rbOgrenci.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bakiye Giriniz:";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBakiye.Location = new System.Drawing.Point(172, 46);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(100, 35);
            this.txtBakiye.TabIndex = 3;
            // 
            // btnGecisyap
            // 
            this.btnGecisyap.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGecisyap.ForeColor = System.Drawing.Color.Black;
            this.btnGecisyap.Location = new System.Drawing.Point(56, 97);
            this.btnGecisyap.Name = "btnGecisyap";
            this.btnGecisyap.Size = new System.Drawing.Size(216, 39);
            this.btnGecisyap.TabIndex = 4;
            this.btnGecisyap.Text = "Geçiş Yap";
            this.btnGecisyap.UseVisualStyleBackColor = true;
            this.btnGecisyap.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.BackColor = System.Drawing.Color.Maroon;
            this.lblKalan.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalan.ForeColor = System.Drawing.Color.White;
            this.lblKalan.Location = new System.Drawing.Point(12, 173);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(125, 22);
            this.lblKalan.TabIndex = 5;
            this.lblKalan.Text = "Kalan Bakiye:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(564, 236);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.btnGecisyap);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTamBilet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOgrenci;
        private System.Windows.Forms.RadioButton rbOgretmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Button btnGecisyap;
        private System.Windows.Forms.Label lblKalan;
    }
}

