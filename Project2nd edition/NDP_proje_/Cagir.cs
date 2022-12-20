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
    static class Cagir
    {
        public static IMeyve IslemCagir(int indis)//IMeyve tipinde nesne döndüren fonksiyon
        {
            SikilaBilen sikilaBilen = new SikilaBilen();
            if (indis == 0)//meyve indisi kontrol edilir
            {
                Portakal portakal = new Portakal();
                portakal.pureHesapla();
                portakal.AvitaminHesapla(indis);
                portakal.CvitaminHesapla(indis);
                return portakal;
            }
            else if (indis == 1)//meyve indisi kontrol edilir
            {
                Mandalina mandalina = new Mandalina();
                mandalina.pureHesapla();
                mandalina.AvitaminHesapla(indis);
                mandalina.CvitaminHesapla(indis);
                return mandalina;
            }
            else if (indis == 2)//meyve indisi kontrol edilir
            {
                Greyfurt greyfurt = new Greyfurt();
                greyfurt.pureHesapla();
                greyfurt.AvitaminHesapla(indis);
                greyfurt.CvitaminHesapla(indis);
                return greyfurt;
            }
            else if (indis == 3)//meyve indisi kontrol edilir
            {
                Elma elma = new Elma();
                elma.pureHesapla();
                elma.AvitaminHesapla(indis);
                elma.CvitaminHesapla(indis);
                return elma;
            }
            else if (indis == 4)//meyve indisi kontrol edilir
            {
                Armut armut = new Armut();
                armut.pureHesapla();
                armut.AvitaminHesapla(indis);
                armut.CvitaminHesapla(indis);
                return armut;
            }
            else//meyve indisi kontrol edilir
            {
                Cilek cilek = new Cilek();
                cilek.pureHesapla();
                cilek.AvitaminHesapla(indis);
                cilek.CvitaminHesapla(indis);
                return cilek;
            }
        }
    }
}
