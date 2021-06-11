using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ileri_programlama
{
    public abstract class PDil
    {
        public abstract string Yazdir();
    }
    class Java : PDil
    {
        public override string Yazdir()
        {
            return "Java programlama dili";
        }
    }
     
    class Python : PDil
    {
        public override string Yazdir()
        {
            return "Python programlama dili";
        }
    }
    class Dart : PDil
    {
        public override string Yazdir()
        {
            return "Dart programlama dili";
        }
    }
}
