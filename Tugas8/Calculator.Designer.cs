namespace Tugas8
{
    partial class Calculator
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
            this.ProsesNilai = new System.Windows.Forms.Button();
            this.NilaiA = new System.Windows.Forms.TextBox();
            this.NilaiB = new System.Windows.Forms.TextBox();
            this.OperasiPilihan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nilai B";
            // 
            // ProsesNilai
            // 
            this.ProsesNilai.AccessibleName = "ProsesNilai";
            this.ProsesNilai.Location = new System.Drawing.Point(176, 226);
            this.ProsesNilai.Name = "ProsesNilai";
            this.ProsesNilai.Size = new System.Drawing.Size(94, 29);
            this.ProsesNilai.TabIndex = 1;
            this.ProsesNilai.Text = "Proses";
            this.ProsesNilai.UseVisualStyleBackColor = true;
            this.ProsesNilai.Click += new System.EventHandler(this.ProsesNilai_Click);
            // 
            // NilaiA
            // 
            this.NilaiA.AccessibleName = "NilaiA";
            this.NilaiA.Location = new System.Drawing.Point(112, 91);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(158, 27);
            this.NilaiA.TabIndex = 2;
            // 
            // NilaiB
            // 
            this.NilaiB.AccessibleName = "NilaiB";
            this.NilaiB.Location = new System.Drawing.Point(112, 148);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(158, 27);
            this.NilaiB.TabIndex = 2;
            // 
            // OperasiPilihan
            // 
            this.OperasiPilihan.AutoCompleteCustomSource.AddRange(new string[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.OperasiPilihan.FormattingEnabled = true;
            this.OperasiPilihan.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.OperasiPilihan.Location = new System.Drawing.Point(112, 33);
            this.OperasiPilihan.Name = "OperasiPilihan";
            this.OperasiPilihan.Size = new System.Drawing.Size(158, 28);
            this.OperasiPilihan.TabIndex = 3;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 298);
            this.Controls.Add(this.OperasiPilihan);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.ProsesNilai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button ProsesNilai;
        private TextBox NilaiA;
        private TextBox NilaiB;
        private ComboBox OperasiPilihan;
    }
}