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
    class Kati : Hesapla,IMeyve
    {
        public int vitaminA { get; set; }
        public int vitaminC { get; set; }
        public int agirlik { get; set; }
        public int verim { get; set; }
        public int pureGramaj { get; set; }
        public string isim { get; set; }//interface Implementation

        Random rand = new Random();
        public Kati()//Constructor
        {
            //meyve kati ise gerekli kısıtlamalar dahilinde agirlik ve verim degeri hesaplanır
            verim = rand.Next(80, 95);
            agirlik = rand.Next(70, 120);
        }
        public override double AvitaminHesapla(int indis)//fotoğraf indisine göre hesaplama yapılır
        {
            if (indis == 3)
            {
                vitaminA = (pureGramaj * 54) / 100;
            }
            else if (indis == 4)
            {
                vitaminA = (pureGramaj * 25) / 100;
            }
            else if (indis == 5)
            {
                vitaminA = (pureGramaj * 12) / 100;
            }
            return vitaminA;
        }

        public override double CvitaminHesapla(int indis)//fotoğraf indisine göre hesaplama yapılır
        {
            if (indis == 3)
            {
                vitaminC = (pureGramaj * 5) / 100;
            }
            else if (indis == 4)
            {
                vitaminC = (pureGramaj * 5) / 100;
            }
            else if (indis == 5)
            {
                vitaminC = (pureGramaj * 60) / 100;
            }
            return vitaminC;
        }

        public override void pureHesapla()//olusturulan verim oranına göre püre ve ya sıvı değeri hesaplanır
        {
            pureGramaj = (agirlik * verim) / 100;
        }
    }
}
