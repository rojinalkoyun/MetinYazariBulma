namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.rtbMetin = new System.Windows.Forms.RichTextBox();
            this.mesajKutusu = new System.Windows.Forms.TextBox();
            this.rtbStackte = new System.Windows.Forms.RichTextBox();
            this.btnHasheAktar = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.btnAgacaAktar = new System.Windows.Forms.Button();
            this.btnStackeOku = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMetinDuzenle = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbStack = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbAgactanHashe = new System.Windows.Forms.RichTextBox();
            this.rtbStacktenAgaca = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kelimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbStack.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(22, 254);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(241, 23);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yukle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // rtbMetin
            // 
            this.rtbMetin.Location = new System.Drawing.Point(22, 78);
            this.rtbMetin.Name = "rtbMetin";
            this.rtbMetin.Size = new System.Drawing.Size(246, 141);
            this.rtbMetin.TabIndex = 1;
            this.rtbMetin.Text = "";
            this.rtbMetin.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // mesajKutusu
            // 
            this.mesajKutusu.Location = new System.Drawing.Point(17, 339);
            this.mesajKutusu.Multiline = true;
            this.mesajKutusu.Name = "mesajKutusu";
            this.mesajKutusu.Size = new System.Drawing.Size(241, 22);
            this.mesajKutusu.TabIndex = 2;
            // 
            // rtbStackte
            // 
            this.rtbStackte.Location = new System.Drawing.Point(21, 55);
            this.rtbStackte.Name = "rtbStackte";
            this.rtbStackte.Size = new System.Drawing.Size(230, 138);
            this.rtbStackte.TabIndex = 24;
            this.rtbStackte.Text = "";
            // 
            // btnHasheAktar
            // 
            this.btnHasheAktar.Location = new System.Drawing.Point(21, 21);
            this.btnHasheAktar.Name = "btnHasheAktar";
            this.btnHasheAktar.Size = new System.Drawing.Size(203, 28);
            this.btnHasheAktar.TabIndex = 19;
            this.btnHasheAktar.Text = "Hashe Aktar";
            this.btnHasheAktar.UseVisualStyleBackColor = true;
            this.btnHasheAktar.Click += new System.EventHandler(this.btnHasheAktar_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Location = new System.Drawing.Point(21, 71);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(177, 23);
            this.btnHeapSort.TabIndex = 20;
            this.btnHeapSort.Text = "HeapSort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.Location = new System.Drawing.Point(152, 254);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(0, 16);
            this.lblDosyaYolu.TabIndex = 16;
            // 
            // btnAgacaAktar
            // 
            this.btnAgacaAktar.Location = new System.Drawing.Point(21, 21);
            this.btnAgacaAktar.Name = "btnAgacaAktar";
            this.btnAgacaAktar.Size = new System.Drawing.Size(230, 29);
            this.btnAgacaAktar.TabIndex = 18;
            this.btnAgacaAktar.Text = "Ağaca Aktar";
            this.btnAgacaAktar.UseVisualStyleBackColor = true;
            this.btnAgacaAktar.Click += new System.EventHandler(this.btnAgacaAktar_Click);
            // 
            // btnStackeOku
            // 
            this.btnStackeOku.Location = new System.Drawing.Point(21, 21);
            this.btnStackeOku.Name = "btnStackeOku";
            this.btnStackeOku.Size = new System.Drawing.Size(233, 28);
            this.btnStackeOku.TabIndex = 17;
            this.btnStackeOku.Text = "Stacke Oku";
            this.btnStackeOku.UseVisualStyleBackColor = true;
            this.btnStackeOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Dosya Yolu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMetinDuzenle);
            this.groupBox1.Controls.Add(this.btnMetinYukle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mesajKutusu);
            this.groupBox1.Controls.Add(this.lblDosyaYolu);
            this.groupBox1.Controls.Add(this.rtbMetin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 419);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosya Islemleri";
            // 
            // btnMetinDuzenle
            // 
            this.btnMetinDuzenle.Location = new System.Drawing.Point(22, 283);
            this.btnMetinDuzenle.Name = "btnMetinDuzenle";
            this.btnMetinDuzenle.Size = new System.Drawing.Size(241, 23);
            this.btnMetinDuzenle.TabIndex = 29;
            this.btnMetinDuzenle.Text = "Metin Düzenle";
            this.btnMetinDuzenle.UseVisualStyleBackColor = true;
            this.btnMetinDuzenle.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbStack
            // 
            this.gbStack.Controls.Add(this.btnStackeOku);
            this.gbStack.Controls.Add(this.rtbStackte);
            this.gbStack.Location = new System.Drawing.Point(314, 12);
            this.gbStack.Name = "gbStack";
            this.gbStack.Size = new System.Drawing.Size(291, 199);
            this.gbStack.TabIndex = 30;
            this.gbStack.TabStop = false;
            this.gbStack.Text = "Stack\'e Aktar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgacaAktar);
            this.groupBox2.Controls.Add(this.rtbStacktenAgaca);
            this.groupBox2.Location = new System.Drawing.Point(314, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 210);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stackten Agaca";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHasheAktar);
            this.groupBox3.Controls.Add(this.rtbAgactanHashe);
            this.groupBox3.Location = new System.Drawing.Point(620, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 193);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agactan Hashe";
            // 
            // rtbAgactanHashe
            // 
            this.rtbAgactanHashe.Location = new System.Drawing.Point(21, 55);
            this.rtbAgactanHashe.Name = "rtbAgactanHashe";
            this.rtbAgactanHashe.Size = new System.Drawing.Size(203, 121);
            this.rtbAgactanHashe.TabIndex = 33;
            this.rtbAgactanHashe.Text = "";
            // 
            // rtbStacktenAgaca
            // 
            this.rtbStacktenAgaca.Location = new System.Drawing.Point(18, 61);
            this.rtbStacktenAgaca.Name = "rtbStacktenAgaca";
            this.rtbStacktenAgaca.Size = new System.Drawing.Size(236, 123);
            this.rtbStacktenAgaca.TabIndex = 34;
            this.rtbStacktenAgaca.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.btnHeapSort);
            this.groupBox5.Location = new System.Drawing.Point(611, 221);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 210);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Heaple Sırala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "En Sık Kullanılan Kelime Getir";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 30);
            this.textBox1.TabIndex = 39;
            // 
            // kelimeBindingSource
            // 
            this.kelimeBindingSource.DataSource = typeof(WindowsFormsApp8.Kelime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Islemler Temsili Olarak Sadece Kelimelerin Orijinal Halleri Üzerinden Yapılmıştır" +
    ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbStack);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbStack.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.RichTextBox rtbMetin;
        private System.Windows.Forms.TextBox mesajKutusu;
        private System.Windows.Forms.RichTextBox rtbStackte;
        private System.Windows.Forms.Button btnHasheAktar;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.Button btnAgacaAktar;
        private System.Windows.Forms.Button btnStackeOku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMetinDuzenle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox gbStack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbAgactanHashe;
        private System.Windows.Forms.RichTextBox rtbStacktenAgaca;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource kelimeBindingSource;
        private System.Windows.Forms.Label label1;
    }
}

