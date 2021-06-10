using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isimlendirme_dogru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gunluk Kol Antremani Saatinizi Girin");
            int antreman1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Gunluk Ayak Antremani Saatinizi Girin");
            int antreman2 = int.Parse(Console.ReadLine());

            if (antreman1 > antreman2)
            {
                Console.WriteLine("Kol Antremanini bugun daha cok yapmissiniz");
            }
            else
            {
                Console.WriteLine("Ayak Antremanini bugun daha cok yapmissin");
            }
            Console.ReadKey();
        }
    }
}
