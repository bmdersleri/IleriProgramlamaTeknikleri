using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriProgramlamaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater();
            Sekil kare = creater.FactoryMethod(Sekiller.Kare);
            Sekil dikdortgen = creater.FactoryMethod(Sekiller.Dikdortgen);
            Sekil daire = creater.FactoryMethod(Sekiller.Daire);
            kare.Draw();
            dikdortgen.Draw();
            daire.Draw();
            Console.Read();

        }
    }
}
