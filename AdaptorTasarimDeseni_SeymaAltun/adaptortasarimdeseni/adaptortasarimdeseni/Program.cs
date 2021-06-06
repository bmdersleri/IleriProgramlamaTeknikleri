using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adaptortasarimdeseni
{
    //Client
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Sonucu");
            float sayi = 8.56f;
            Hesaplama hesap = new HesaplamaToplama();
            //hesap.DegeriHesapla(sayi);
            Hedef adaptor = new Adaptor(hesap);
            var sonuc = adaptor.DegeriHesapla(sayi);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
    //Target interface
    interface Hedef
    {
        int DegeriHesapla(float deger);
    }
    //Adapter class
    class Adaptor : Hedef
    {
        Hesaplama _hesap;
        public Adaptor(Hesaplama hesap)
        {
            this._hesap = hesap;
        }
        public int DegeriHesapla(float deger)
        {
            var dDeger = (int)deger;
            return _hesap.DegeriHesapla(dDeger);

        }
    }
    //Adaptee
    interface Hesaplama
    {
        int DegeriHesapla(int deger);
    }
    class HesaplamaToplama : Hesaplama
    {
        public int DegeriHesapla(int deger)
        {
            return deger + deger;
        }
    }
}


