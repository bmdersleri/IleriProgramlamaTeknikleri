using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buyuk_fonksiyonlar
{
    public class Tasit
    {

        public String yakit;// Taşıtın yakıt tipi
        public int hiz; // Taşıtın Maximum hızı 
        public String renk; // Taşıtın rengi
        public String marka; // Taşıtın markası

        // Taşıtın bilgilerini ekrana yazdıran metot
        public void tasitInfo()
        {
            String tasit = "Taşıtın markası: " + marka + " rengi: " + renk + " yakıt tipi: " + yakit + " maximum hızı: " + hiz;

            System.Console.WriteLine(tasit);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Taşıt tipinden otomobil nesnesini oluşturuyoruz
            Tasit otomobil = new Tasit();
            Tasit motor = new Tasit();

            // nesnemize özellik değerlerini giriyoruz
            otomobil.hiz = 220;
            otomobil.yakit = "LPG";
            otomobil.renk = "Siyah";
            otomobil.marka = "Renault";

            // nesnemize özellik değerlerini giriyoruz
            motor.hiz = 200;
            motor.yakit = "Benzin";
            motor.renk = "Metalik Gri";
            motor.marka = "Honda";

            /* Yukarıda dikkat edilmesi gereken bir nokta var. Oluşturduğumuz iki 
           nesnenin örnek değişkenlerine farklı değerler atıyoruz. Yani her nesne 
           oluşturulduğu sınıfın örnek değişkenlerinden bir kopya taşır, kendisini değil. 
           Bu yüzden her nesne örnek değişkenlere farklı değerler verip kullanabilir.
	        */

            // Bilgileri ekrana yazdıracak metodu çağırıyoruz
            otomobil.tasitInfo();
            motor.tasitInfo();
            Console.ReadLine();
        }
    }
}
