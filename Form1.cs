using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        float sayi1, sayi2,sonuc;   // virgüllü sayılar için float veri türünde sayi degişkenleri oluşturuldu
                                    
        public Form1()
        {
            InitializeComponent();
        }

        private void topla_Click(object sender, EventArgs e)
        {
            sayi1 = float.Parse( sayi1txt.Text);    // textbox'a girilen değer float veri tipine dönüştürüldü
            sayi2 = float.Parse (sayi2txt.Text);

            sonuc = sayi1 + sayi2;  // işlem gerçekleştirildi
            
            sonuçtxt.Text = sonuc.ToString();   // ToString() metodu ile string veri tipine dönüştürüldü
                                                //textbox'a sonuç değeri yazdırıldı.
        }

        private void çıkar_Click(object sender, EventArgs e)
        {
            sayi1 = float.Parse(sayi1txt.Text);
            sayi2 = float.Parse(sayi2txt.Text);

            sonuc = sayi1 - sayi2;

            sonuçtxt.Text = sonuc.ToString();
        }

        private void çarp_Click(object sender, EventArgs e)
        {
            sayi1 = float.Parse(sayi1txt.Text);
            sayi2 = float.Parse(sayi2txt.Text);

            sonuc = sayi1 * sayi2;

            sonuçtxt.Text = sonuc.ToString();
        }

         
        private void böl_Click(object sender, EventArgs e)
        {
            sayi1 = float.Parse(sayi1txt.Text);
            sayi2 = float.Parse(sayi2txt.Text);

            sonuc = sayi1 / sayi2;

            sonuçtxt.Text = sonuc.ToString();

        }
    }
}
