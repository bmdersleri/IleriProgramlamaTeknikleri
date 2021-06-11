using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aranabilir__isimler_hatali
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            int a = 0;
            int h = 0;
            long g = 0;
            long s = 0;
            long d = 0;
            long sa = 0;
            Console.WriteLine("n Yasiniz kac : ");
            y = Int16.Parse(Console.ReadLine());
            a = (int)y * 12;
            h = (int)y * 52;
            g = (long)y * 365;
            s = (long)y * 365 * 24;
            d = (long)y * 365 * 24 * 60;
            sa = (long)y * 365 * 24 * 60 * 60;
            Console.WriteLine(" Yasiniz {0}  olduguna gore :", y);
            Console.WriteLine("{0} ay", a);
            Console.WriteLine("{0}  hafta", h);
            Console.WriteLine("{0}  gun", g);
            Console.WriteLine("{0}  saat", s);
            Console.WriteLine("{0}  dakika", d);
            Console.WriteLine("{0}  saniye", sa);
            Console.WriteLine(" yasamissiniz.");
            Console.ReadKey();
        }
    }
}
