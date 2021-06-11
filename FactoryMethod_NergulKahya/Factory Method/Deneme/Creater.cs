using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    enum PDiller
    {
        Java,
        Python,
        Dart

    }
    class Creater
    {
        public PDil FactoryMethod(PDiller pDiller)
        {
            PDil pDil = null;
            switch (pDiller)
            {
                case PDiller.Java:
                    pDil = new Java();
                    break;
                case PDiller.Python:
                    pDil = new Python();
                    break;
                case PDiller.Dart:
                    pDil = new Dart();
                    break;
            }
            return pDil;
        }

    }
}
