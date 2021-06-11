using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    abstract class PDil
    {
        public abstract string Yadir();


    }
    class Java : PDil
    {
        public override string Yadir()
        {
            return "java dilidir.";
        }
    }
    class Python : PDil
    {
        public override string Yadir()
        {
            return "Python dilidir.";
        }
    }
    class Dart : PDil
    {
        public override string Yadir()
        {
            return "dart dilidir.";
        }
    }
}
