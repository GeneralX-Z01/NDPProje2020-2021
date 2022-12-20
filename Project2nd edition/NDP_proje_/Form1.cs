using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_proje_
{
    public partial class Form1 : Form
    {
        int resim_index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        int A = 0, C = 0, Pure = 0, Atoplam = 0, Ctoplam = 0, PureToplam = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            resim_index = rand.Next(0, 6);//rastgele resim indexi oluşturulur
            pictureBox1.Image = imageList1.Images[resim_index];
            if (resim_index < 3)//resim indexe göre sıkacak belirlenir
            {
                narenciye_button1.Enabled = true;
                kati_button1.Enabled = false;
            }
            else
            {
                kati_button1.Enabled = true;
                narenciye_button1.Enabled = false;
            }
            var nesne = Cagir.IslemCagir(resim_index);
            isim_label1.Text = "Meyve Adı: " + nesne.isim;
            agirlik_label2.Text = "Ağirlik: " + Convert.ToString(nesne.agirlik) + " gr";
            pure_agirlik_label3.Text = "Sıvı/Püre ağırlığı: " + Convert.ToString(nesne.pureGramaj) + " gr";
            vitaminA_label4.Text = "Vitamin A: " + Convert.ToString(nesne.vitaminA) + " iu";
            vitaminC_label5.Text = "Vitamin C: " + Convert.ToString(nesne.vitaminC) + " mg";
            A = nesne.vitaminA;
            C = nesne.vitaminC;
            Pure = nesne.pureGramaj;
        }

        int zaman = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman_label.Text = "00:" + Convert.ToString(59 - zaman);
            if ((60 - zaman) < 10)
            {
                zaman_label.Text = "00:0" + Convert.ToString(59 - zaman);
            }
            if ((60 - zaman) == 0)
            {
                timer1.Stop();
                islem_panel1.Enabled = false;
            }
            zaman++;
        }
        
        private void basla_button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            islem_panel1.Visible = true;
            panel1.Visible = true;
            basla_button1.Visible = false;
        }

        private void narenciye_button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int yeni_index = rand.Next(0, 6);
            while (yeni_index == resim_index)
            {
                yeni_index = rand.Next(0, 6);
            }
            pictureBox1.Image = imageList1.Images[yeni_index];
            if (yeni_index < 3)
            {
                narenciye_button1.Enabled = true;
                kati_button1.Enabled = false;
            }
            else
            {
                kati_button1.Enabled = true;
                narenciye_button1.Enabled = false;
            }
            Atoplam = A + Atoplam;
            Ctoplam = C + Ctoplam;
            PureToplam = Pure + PureToplam;
            toplamA_label6.Text = Convert.ToString(Atoplam+" iu");
            toplamC_label7.Text = Convert.ToString(Ctoplam+" mg");
            toplamPure_label8.Text = Convert.ToString(PureToplam+" gr");
            var nesne = Cagir.IslemCagir(yeni_index);
            isim_label1.Text = "Meyve Adı: " +nesne.isim;
            agirlik_label2.Text = "Ağirlik: "+Convert.ToString(nesne.agirlik)+" gr";
            pure_agirlik_label3.Text = "Sıvı/Püre ağırlığı: "+ Convert.ToString(nesne.pureGramaj)+" gr";
            vitaminA_label4.Text = "Vitamin A: "+Convert.ToString(nesne.vitaminA)+" iu";
            vitaminC_label5.Text = "Vitamin C: "+Convert.ToString(nesne.vitaminC)+" mg";
            A = nesne.vitaminA;
            C = nesne.vitaminC;
            Pure = nesne.pureGramaj;
            resim_index = yeni_index;
        }
        private void kati_button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int yeni_index = rand.Next(0, 6);
            while (yeni_index == resim_index)
            {
                yeni_index = rand.Next(0, 6);
            }
            pictureBox1.Image = imageList1.Images[yeni_index];
            if (yeni_index < 3)
            {
                narenciye_button1.Enabled = true;
                kati_button1.Enabled = false;
            }
            else
            {
                kati_button1.Enabled = true;
                narenciye_button1.Enabled = false;
            }
            Atoplam = A + Atoplam;
            Ctoplam = C + Ctoplam;
            PureToplam = Pure + PureToplam;
            toplamA_label6.Text = Convert.ToString(Atoplam+" iu");
            toplamC_label7.Text = Convert.ToString(Ctoplam+" mg");
            toplamPure_label8.Text = Convert.ToString(PureToplam+" gr");
            var nesne = Cagir.IslemCagir(yeni_index);
            isim_label1.Text = "Meyve Adı: " + nesne.isim;
            agirlik_label2.Text = "Ağirlik: " + Convert.ToString(nesne.agirlik) + " gr";
            pure_agirlik_label3.Text = "Sıvı/Püre ağırlığı: " + Convert.ToString(nesne.pureGramaj) + " gr";
            vitaminA_label4.Text = "Vitamin A: " + Convert.ToString(nesne.vitaminA) + " iu";
            vitaminC_label5.Text = "Vitamin C: " + Convert.ToString(nesne.vitaminC) + " mg";
            A = nesne.vitaminA;
            C = nesne.vitaminC;
            Pure = nesne.pureGramaj;
            resim_index = yeni_index;
        }
    }
}
