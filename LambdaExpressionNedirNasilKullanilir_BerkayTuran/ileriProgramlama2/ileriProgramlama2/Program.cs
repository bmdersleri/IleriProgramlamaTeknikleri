using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ileriProgramlama2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tumRakamlar = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> tekRakamlar = tumRakamlar.Where(x => x % 2 == 1);
            Console.WriteLine("Tek Rakamlar :");
            foreach (int rakam in tekRakamlar) Console.WriteLine(rakam);

            var sonucListe = Enumerable.Range(0, 10).Where(Rakam => Rakam % 2 == 0);
            Console.WriteLine("Çift Rakamlar :");
            foreach (var Rakam in sonucListe) Console.WriteLine(Rakam);
            Console.ReadKey();
        }
    }
}
