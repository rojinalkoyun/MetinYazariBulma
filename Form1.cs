using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string dosya, metin;
        public bool dosyaOku = false;
        private void btnMetinYukle_Click(object sender, EventArgs e)
        {
            // Dosyayı getirme ve dosyadan eleman silme ekleme sonrası kayıt işlemlerinde kullandığım kaynak.
            //https://www.youtube.com/watch?v=ntCr_x1YAtg
            openFileDialog1.Filter = "Metin Dosyası| *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosya = openFileDialog1.FileName;
                var fileStream = openFileDialog1.OpenFile();
                rtbMetin.LoadFile(dosya, RichTextBoxStreamType.PlainText);
                mesajKutusu.Text = dosya;
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    metin = reader.ReadToEnd();
                    dosyaOku = true;
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool stackeTasi = false;
        public int cumleSayac = 0;
        Stack Kelimeler=new Stack();
        Stack CumleStack = new Stack();
        private void btnStackOku_Click(object sender, EventArgs e)
        {
            //Metindeki cümleleri doğru şekilde ayırması için kullandığım kaynak.
            //https://docs.microsoft.com/tr-tr/dotnet/api/system.text.regularexpressions.regex.split?view=net-6.0
            int cumleSayac =0, kelimeSayac=0, toplamkelimeSayisi = 0;
            string[] cumleler = Regex.Split(metin, @"(?<=[\.!\?])\s+");
            for (int i = 0; i < cumleler.Length; i++)
            {
                cumleSayac++;
                //https://www.codegrepper.com/code-examples/csharp/select+from+list+where+not+in+other+list+c%23
                char[] punctuation = cumleler[i].Where(Char.IsPunctuation).Distinct().ToArray();
                var words = cumleler[i].Split().Select(x => x.Trim(punctuation));
                string[] wordss = (words.ToArray());
                kelimeSayac = wordss.Length;
                toplamkelimeSayisi += kelimeSayac;
                KelimeyiStaceTasi(Kelimeler, wordss, Onislem(wordss), cumleSayac);
                rtbStackte.Text += (i + 1) + ". cümledeki kelime sayısı: " + kelimeSayac + "\r\n";
                CumleStack.Push(cumleler[i]);

            }
            rtbStackte.Text += "Toplam Kelime Sayısı: " + toplamkelimeSayisi + "\r\n" +
                "Toplam Cümle Sayısı : " + CumleStack.Size
                + "\r\n" + "Ortalama Kelime Sayısı: " + toplamkelimeSayisi / CumleStack.Size;
            stackeTasi = true;
        }
        public void KelimeyiStaceTasi(Stack KelimelerStack, string[] kelimeler, string[] kelimelerOnislemli, int cumleNum)
        {
            bool kelimeVar = false;
            Node temp;
            for (int i = 0; i < kelimeler.Length; i++)
            {
                kelimeVar = false;
                temp = KelimelerStack.top;
                Kelime kelime = new Kelime();
                Kelime arananKelime = new Kelime();
                while (temp != null)
                {
                    arananKelime = (Kelime)temp.data;
                    if (kelimeler[i] == arananKelime.önIslemliKelime)
                    {
                        arananKelime.kullanımSıklığı++;
                        kelimeVar = true;
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                if (!kelimeVar)
                {

                    kelime.orjinalBicim = kelimeler[i];
                    kelime.kullanımSıklığı = 1;
                    kelime.kacıncıKelime = Array.IndexOf(kelimeler, kelimeler[i]) + 1;
                    kelime.önIslemliKelime = kelimelerOnislemli[i];
                    kelime.kacıncıCümle = cumleNum;
                    KelimelerStack.Push(kelime);

                }
            }
        }
        public string[] Onislem(string[] wordss)
        {
            //https://docs.microsoft.com/tr-tr/dotnet/csharp/how-to/parse-strings-using-split
            for (int i = 0; i < wordss.Length; i++)
            {
                if (wordss[i].Split(new char[] { '\'', ' ' }).Length == 2)
                    wordss[i] = wordss[i].Split(new char[] { '\'', ' ' }).First();
            }
            return wordss;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        Heap heap= new Heap();
        private void btnAgacaAktar_Click(object sender, EventArgs e)
        {
            if (stackeTasi)
            {
                while (!Kelimeler.IsEmpty())
                {
                    Kelime kelime = (Kelime)Kelimeler.Pop();
                    heap.Insert(kelime);
                }
            }
            else
            {
                MessageBox.Show("Önce kelimeler stack yapısına aktarılmalı");
            }
            rtbStacktenAgaca.Text=heap.DisplayHeap();
        }
        HashMap hash = new HashMap(30);
        private void btnHasheAktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < heap.currentSize; i++)
            {
                hash.insert(heap.heapArray[i].kelime.kacıncıKelime, heap.heapArray[i].kelime);
            }
            rtbAgactanHashe.Text=hash.print();
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            
            Kelime[] maxKelimeler = new Kelime[3];
            for (int j = 0; j < 3; j++)
            {
                maxKelimeler[j] = heap.heapArray[j].kelime;
            }
            textBox1.Text = heap.Sort(maxKelimeler).First().önIslemliKelime;
        }

        private void dgMaxlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dosyayı getirme ve dosyadan eleman silme ekleme sonrası kayıt işlemlerinde kullandığım kaynak.
            //https://www.youtube.com/watch?v=ntCr_x1YAtg
            saveFileDialog1.Filter = "Metin Dosyası| *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosya = saveFileDialog1.FileName;
                rtbMetin.SaveFile(dosya, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
