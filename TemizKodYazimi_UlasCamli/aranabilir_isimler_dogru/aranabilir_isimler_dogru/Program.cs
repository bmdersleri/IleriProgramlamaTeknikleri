using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aranabilir_isimler_dogru
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = 0;
            int ay = 0;
            int hafta = 0;
            long gun = 0;
            long saat = 0;
            long dakika = 0;
            long saniye = 0;
            Console.WriteLine("Yasiniz kac : ");
            yas = Int16.Parse(Console.ReadLine());
            ay = (int)yas * 12;
            hafta = (int)yas * 52;
            gun = (long)yas * 365;
            saat = (long)yas * 365 * 24;
            dakika = (long)yas * 365 * 24 * 60;
            saniye = (long)yas * 365 * 24 * 60 * 60;
            Console.WriteLine(" Yasiniz {0}  olduguna gore :", yas);
            Console.WriteLine("{0} ay", ay);
            Console.WriteLine("{0}  hafta", hafta);
            Console.WriteLine("{0}  gun", gun);
            Console.WriteLine("{0}  saat", saat);
            Console.WriteLine("{0}  dakika", dakika);
            Console.WriteLine("{0}  saniye", saniye);
            Console.WriteLine("yasamissiniz.");
            Console.ReadKey();
        }
    }
}
