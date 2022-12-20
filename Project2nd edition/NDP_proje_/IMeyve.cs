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
    interface IMeyve//interface 
    {
        int vitaminA { get; set; }
        int vitaminC { get; set; }
        int agirlik { get; set; }
        int verim { get; set; }
        int pureGramaj { get; set; }
        string isim { get; set; }
    }
}
