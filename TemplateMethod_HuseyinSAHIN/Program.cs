using System;

namespace TemplateMethod_HuseyinSAHIN
{
    class Program
    {
        //Main metodu içerisine OyunRaporlari türünden bir değişken tanımlıyoruz.
        static void Main(string[] args)
        {
            OyunRaporlari rapor = null;
            //Oluşturduğumuz sınıflardan nesne tanımlama ve metot çağırma işlemleri.(XML için)
            rapor = new XmlRaporlari();
            rapor.ozetYaz();
            Console.WriteLine();
            //Oluşturduğumuz sınıflardan nesne tanımlama ve metot çağırma işlemleri.(Text için.)
            rapor = new TextRaporlari();
            rapor.ozetYaz();
            Console.WriteLine();
            //Oluşturduğumuz sınıflardan nesne tanımlama ve metot çağırma işlemleri.(Konsol için)
            rapor = new KonsolRaporlari();
            rapor.ozetYaz();
        }
    }
    //Oyunraporlari soyut sınıfımız içerisine somut sınıfları kullanma işlemi.
    abstract class OyunRaporlari
    {
        //Sonuc getirme metodumuz.
        public void sonucGetir()
        {
            Console.WriteLine("Oyuncuların istatistikleri toplanıyor");
        }
        //Sonuc ayrıştırma metodumuz.
        public void sonucAyristir()
        {
            Console.WriteLine("İstatistikler ayrıştırılıyor");
        }
        //Sonuç yazmak için kullanacağımız soyut metodumuz.
        public abstract void sonucYaz();

        //Template metodumuz. (Kendi içerisinde 3 metodu çağırır.)
        public void ozetYaz()
        {
            sonucGetir();
            sonucAyristir();
            sonucYaz();
        }
    }
    //Bilgileri XML dosyasına yazdırmak için kullanacağımız sınıf.
    class XmlRaporlari : OyunRaporlari
    {
        public override void sonucYaz()
        {
            Console.WriteLine("İstatistikler XML dosyasına yazılıyor.");
        }
    }
    //Bilgileri Text dosyasına yazdırmak için kullanacağımız sınıf.
    class TextRaporlari : OyunRaporlari
    {
        public override void sonucYaz()
        {
            Console.WriteLine("İstatistikler TEXT dosyasına yazdırılıyor.");
        }
    }
    //Bilgileri Konsol dosyasına yazdırmak için kullanacağımız sınıf.
    class KonsolRaporlari : OyunRaporlari
    {
        public override void sonucYaz()
        {
            Console.WriteLine("İstatistikler CONSOLE ekranına basılıyor.");
        }
    }
}
