using System;
using static chainOfResponsibility.Program.ToplantiSalonRezervasyon;

namespace chainOfResponsibility
{
    class Program
    {

        public class AramaKriteri
        {
            public string Ulke { get; set; }
            public string Sehir { get; set; }
            public int KatilimciSayisi { get; set; }
            public DateTime TalepTarihi { get; set; }
        }
        public abstract class ToplantiSalonRezervasyon
        {
            //Zincirin bir üst halkası
            public ToplantiSalonRezervasyon BirSonrakiSorumlu { get; set; }

            //kriteri yakalayıcı
            private EventHandler<AramaKriteri> aramaKriteriHandler;
            //kriter yakalandığında çalışacak metot
            protected abstract void ara(object sender, AramaKriteri kriter);
            public ToplantiSalonRezervasyon()
            {
                //ara metodunu delege'ye aktar:
                aramaKriteriHandler += ara;
            }
            public void UygunSalonlariAra(AramaKriteri kriter)
            {
                aramaKriteriHandler(this, kriter);
            }


            //1. Halka
            public class AlmanyaRezervasyon : ToplantiSalonRezervasyon
            {
                protected override void ara(object sender, AramaKriteri kriter)
                {
                    if (kriter.Ulke == "Almanya")
                    {
                        Console.WriteLine("Almanya için uygun salonlar aranıyor");
                    }
                    else
                    {
                        //birsonrakiSorumlu boş değilse
                        BirSonrakiSorumlu?.UygunSalonlariAra(kriter);
                    }
                }
            }
            //2. Halka
            public class BelcikaRezervasyon : ToplantiSalonRezervasyon
            {
                protected override void ara(object sender, AramaKriteri kriter)
                {
                    if (kriter.Ulke == "Belçika")
                    {
                        Console.WriteLine("Belçika için uygun salonlar aranıyor");
                    }
                    else
                    {
                        BirSonrakiSorumlu?.UygunSalonlariAra(kriter);
                    }
                }
            }
            //3. Halka
            public class TurkiyeRezervasyon : ToplantiSalonRezervasyon
            {
                protected override void ara(object sender, AramaKriteri kriter)
                {
                    if (kriter.Ulke == "Türkiye")
                    {
                        Console.WriteLine("Türkiye için uygun salonlar aranıyor");
                    }
                }
            }
        }
        private static void Main(string[] args)
        {
            AlmanyaRezervasyon almanyaRezervasyon = new AlmanyaRezervasyon();
            BelcikaRezervasyon belcikaRezervasyon = new BelcikaRezervasyon();
            TurkiyeRezervasyon turkiyeRezervasyon = new TurkiyeRezervasyon();

            almanyaRezervasyon.BirSonrakiSorumlu = belcikaRezervasyon;
            belcikaRezervasyon.BirSonrakiSorumlu = turkiyeRezervasyon;

            almanyaRezervasyon.UygunSalonlariAra(new AramaKriteri { KatilimciSayisi = 15, Ulke = "Türkiye" });
            Console.ReadLine();

        }



    }
}
}
