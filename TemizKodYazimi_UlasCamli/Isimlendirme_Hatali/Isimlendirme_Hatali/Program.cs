using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isimlendirme_Hatali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gunluk Antreman1 Saatinizi Girin");
            int antreman1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Gunluk Antreman2 Saatinizi Girin");
            int antreman2 = int.Parse(Console.ReadLine());

            if (antreman1 > antreman2)
            {
                Console.WriteLine("Antreman1'i bugun daha cok yapmissiniz");
            }
            else
            {
                Console.WriteLine("Antreman2'i bugun daha cok yapmissin");
            }
            Console.ReadKey();
        }
    }
}
