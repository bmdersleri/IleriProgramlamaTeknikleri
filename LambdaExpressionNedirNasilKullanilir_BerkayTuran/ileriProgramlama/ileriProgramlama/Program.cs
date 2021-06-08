﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ileriProgramlama
{
    class Program
    {
        delegate int Tamsayiislevi(int sayi1, int sayi2);
        static void Main(string[] args)
        {
            Tamsayiislevi tsiTopla = (x, y) => x + y;
            Tamsayiislevi tsiCikar = (x, y) => x - y;
            Console.WriteLine(tsiTopla(5, 2));
            Console.WriteLine(tsiCikar(5, 2));
            Console.ReadKey();
        }
    }
}