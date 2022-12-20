/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:Proje
**				ÖĞRENCİ ADI............:Sevda Farshidfar
**				ÖĞRENCİ NUMARASI.......:B201210602
**              DERSİN ALINDIĞI GRUP...:1B
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_proje_
{
    class SikilaBilen : Hesapla, IMeyve
    {
        public int vitaminA { get; set; }
        public int vitaminC { get; set; }
        public int agirlik { get; set; }
        public int verim { get; set; }
        public int pureGramaj { get; set; }
        public string isim { get; set; }//interface Implementation

        Random rand = new Random();

        public SikilaBilen()//Constructor
        {
            //meyve SıkılaBilen ise gerekli kısıtlamalar dahilinde agirlik ve verim degeri hesaplanır
            verim = rand.Next(30, 70);
            agirlik = rand.Next(70, 120);
        }
        public override double AvitaminHesapla(int indis)//sıkılabilen meyvelerde yüzdelik A vitamini değerleri hesaplanır 
        {
            if (indis == 0)
            {
                vitaminA = (pureGramaj * 225) / 100;
            }
            else if (indis == 1)
            {
                vitaminA = (pureGramaj * 681) / 100;
            }
            else if (indis == 2)
            {
                vitaminA = (pureGramaj * 3) / 100;
            }
            return vitaminA;
        }

        public override double CvitaminHesapla(int indis)//sıkılabilen meyvelerde yüzdelik B vitamini değerleri hesaplanır
        {
            if (indis == 0)
            {
                vitaminC = (pureGramaj * 45) / 100;
            }
            else if (indis == 1)
            {
                vitaminC = (pureGramaj * 26) / 100;
            }
            else if (indis == 2)
            {
                vitaminC = (pureGramaj * 44) / 100;
            }
            return vitaminC;
        }

        public override void pureHesapla()//verim yüzdesine göre püre/sıvı hali hesaplanır
        {
            pureGramaj = (agirlik * verim) / 100;
        }
    }
}

