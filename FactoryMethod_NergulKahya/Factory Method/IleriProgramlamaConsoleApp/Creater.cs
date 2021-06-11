using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriProgramlamaConsoleApp
{
    enum Sekiller
    {
        Kare,
        Dikdortgen,
        Daire
    }
    class Creater
    {
        public Sekil FactoryMethod(Sekiller sekiller)
        {
            Sekil sekil = null;
            switch(sekiller)
            {
                case Sekiller.Kare:
                    sekil = new Kare();
                    break;
                case Sekiller.Dikdortgen:
                    sekil = new Dikdortgen();
                    break;
                case Sekiller.Daire:
                    sekil = new Daire();
                    break;
            }
            return sekil;
        }


    }
}
