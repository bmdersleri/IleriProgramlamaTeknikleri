using System;
using System.Collections.Generic;

namespace MerveYldrm
{
    class Program
    {
        //Öncelikle Subject’imize(yani hedefimize) bir çok tipin abone olabilmesini sağlayacak Observer arayüzünü geliştirelim.
        abstract public class Observer
        {
            public abstract void Update();
        }
      

        //--
        //1
        //Şimdi  takip edecek sınıflarımızı oluşturalım.
        public class AnneObserver : Observer
        {
            public override void Update()
            {
                Console.WriteLine("Öğrencinin kaçtığından annesinin haberi oldu.");
            }
        }
        public class BabaObserver : Observer
        {
            public override void Update()
            {
                Console.WriteLine("Öğrencinin kaçtığından babasının haberi oldu.");
            }
        }
        //Şimdide Subject’imizi yani takip edilecek nesnemizi inşa edelim.
        public class Ogrenci
        {
            public string Adi { get; set; }
            public string SoyAdi { get; set; }
            public string Memleket { get; set; }
            public int Sinif { get; set; }
            bool dersiAstiMi;

          
            //set bloğuna dikkat edersek eğer set edilen değer true ise
            //Notify metodu tetiklenmekte ve tüm abonelere haber gönderilmektedir.
            public bool DersiAstiMi
            {
                get { return dersiAstiMi; }
                set
                {
                    if (value == true)
                    {
                        Notify();
                        dersiAstiMi = value;
                    }
                    else
                        dersiAstiMi = value;
                }
            }
            //Subject nesnesi kendisine abone olan gözlemcileri bu koleksiyonda tutacaktır. List için kütüphanelerimize System.Collections.Generic; eklememiz gerekmektedir.
            List<Observer> Gozlemciler;
            public Ogrenci()
            {
                this.Gozlemciler = new List<Observer>();
            }
            //Gözlemci ekle
            public void AboneEkle(Observer observer)
            {
                Gozlemciler.Add(observer);
            }
            //Gözlemci çıkar
            public void AboneCikar(Observer observer)
            {
                Gozlemciler.Remove(observer);
            }
            //Herhangi bir güncelleme olursa ilgili gözlemcilere haber verecek metodumuzdur.
            public void Notify()
            {
                Gozlemciler.ForEach(g =>
                {
                    g.Update();
                });
            }

            static void Main(string[] args)
            {
                //yeni bir öğrenci nesnesi oluşturuyoruz.
                Ogrenci o = new Ogrenci();
                //haber bekleyenleri ekliyoruz
                o.AboneEkle(new BabaObserver());
                o.AboneEkle(new AnneObserver());
                // nesnenin özelliklerini veriyoruz
                o.Adi = "Merve";
                o.SoyAdi = "Yıldırım";
                o.Memleket = "Samsun";
                o.Sinif = 4;
                //derste oluş olmadıgını giriyoruz.
                o.DersiAstiMi = true; //burada öğrenci derse gelmedi yani anne ve babaya bilgi verilecek.
                Console.ReadKey(true);
            }
        }
    }
}
