using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stateDesignPatternOrnegi
{
    class Program
    {

        //interface Konsolumuzu tanımladık.
      
        public interface IKonsol
        {
            void KareBas();
            void UcgenBas();
            void YuvarlakBas();
            void XBas();

        }








        //Konsolda Defans Durumunda Tuşların Görevleri

        public class Defans : IKonsol
        {
            public void KareBas()
            {
                Console.WriteLine("pres yapılıyor..");
            }

            public void UcgenBas()
            {
                Console.WriteLine("Kaleci Açılıyor..");
            }

            public void XBas()
            {
                Console.WriteLine("Markaj uygulanıyor..");
            }

            public void YuvarlakBas()
            {
                Console.WriteLine("Kayarak Müdahale");
            }
        }







        //Konsolda Hücum Durumunda Tuşların Görevleri
        public class Hucum : IKonsol
        {
            public void KareBas()
            {
                Console.WriteLine("Şut çekiliyor");
            }

            public void UcgenBas()
            {
                Console.WriteLine("Arapas Atılıyor..");
            }

            public void XBas()
            {
                Console.WriteLine("Pas Veriliyor..");
            }

            public void YuvarlakBas()
            {
                Console.WriteLine("Orta Açılıyor..");
            }
        }






        //oyun sınıfı tanımlama 
        //konsola ilk olarak Hucum Durumunu atama
        //ve tuşların konsoldaki işlevlerini çağırma 
        public class Oyun
        {
            private IKonsol konsol;
            public Oyun()
            {
                Console.WriteLine("Oyun Başladı...");
                konsol = new Hucum();
            }
            public void Ucgen()
            {
                konsol.UcgenBas();
            }
            public void Kare()
            {
                konsol.KareBas();
            }
            public void Yuvarlak()
            {
                konsol.YuvarlakBas();
            }
            public void X()
            {
                konsol.XBas();
            }







            // State değişme durumları
            public void Topukap()
            {
                Console.WriteLine("Top Kapıldı Hucuma çıkılıyor..");
                konsol = new Hucum();
            }

            public void Topukaptır()
            {
                Console.WriteLine("Top Kaptırıldı defansa koşşş..");
                konsol = new Defans();
            }

        }





        //Ana main  sınıfı ve oyunu başlatma

        static void Main(string[] args)
        {

            Oyun oyun = new Oyun();

            oyun.X();
            oyun.Ucgen();
            oyun.Kare();

            oyun.Topukaptır();

            oyun.X();
            oyun.Ucgen();
            oyun.Kare();

            oyun.Topukap();


            Console.ReadLine();
        }
    }
}
