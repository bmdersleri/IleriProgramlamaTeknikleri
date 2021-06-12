using System;
using System.Collections.Generic;



namespace CompositeDesignPattern
{
    public interface Komponent
    {
        void FiyatGoster();
    }

    public class Yaprak : Komponent
    {
        public int Fiyat { get; set; }
        public string Ad { get; set; }
        public Yaprak(string ad, int Fiyat)
        {
            this.Fiyat = Fiyat;
            this.Ad = ad;
        }

        public void FiyatGoster()
        {
            Console.WriteLine(Ad + " : " + Fiyat);
        }
    }

    public class Kompozit : Komponent
    {
        public string Ad { get; set; }
        List<Komponent> komponentler = new List<Komponent>();
        public Kompozit(string ad)
        {
            this.Ad = ad;
        }
        public void KomponentEkle(Komponent komponent)
        {
            komponentler.Add(komponent);
        }

        public void FiyatGoster()
        {
            Console.WriteLine(Ad);
            foreach (var item in komponentler)
            {
                item.FiyatGoster();
            }
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            //Yaprak Nesneleri Oluşturma
            Komponent hardDisk = new Yaprak("Hard Disk", 2000);
            Komponent ram = new Yaprak("RAM", 3000);
            Komponent cpu = new Yaprak("CPU", 2000);
            Komponent fare = new Yaprak("Fare", 2000);
            Komponent klavye = new Yaprak("Klavye", 2000);

            // Kompozit-Bileşik nesneler oluşturma
            Kompozit anakart = new Kompozit("Çevre Birimleri");
            Kompozit kabin = new Kompozit("Kabin");
            Kompozit CevreBirimleri = new Kompozit("Çevre Birimleri");
            Kompozit bilgisayar = new Kompozit("Bilgisayar");

            //Ağaç yapısı oluşturma
            //Ana karta CPU ve RAM ekleme
            anakart.KomponentEkle(cpu);
            anakart.KomponentEkle(ram);

            //Kabine ana kart ve sabit disk ekleme
            kabin.KomponentEkle(anakart);
            kabin.KomponentEkle(hardDisk);

            // Çevre birimlerinde fare ve klavye ekleme
            CevreBirimleri.KomponentEkle(fare);
            CevreBirimleri.KomponentEkle(klavye);

            //Bilgisayara Kabine ve çevre birimlerini ekleme
            bilgisayar.KomponentEkle(kabin);
            bilgisayar.KomponentEkle(CevreBirimleri);

            //Bilgisayarın Fiyatını Görüntülemek İçin
            bilgisayar.FiyatGoster();
            Console.WriteLine();

            // Klavye Fiyatını görüntülemek için
            klavye.FiyatGoster();
            Console.WriteLine();

            // Kabin Fiyatını görüntülemek için
            kabin.FiyatGoster();
            Console.Read();
        }
    }

}