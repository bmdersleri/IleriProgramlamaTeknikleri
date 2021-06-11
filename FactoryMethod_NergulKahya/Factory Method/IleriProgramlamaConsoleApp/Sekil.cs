using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriProgramlamaConsoleApp
{
    abstract class Sekil
    {
        public abstract void Draw();
    }

    class Kare : Sekil
    {
        public override void Draw()
        {
            Console.Write("Karenin bir kenarını giriniz = ");
            int a = Convert.ToInt32(Console.ReadLine());
            int alan = a * a;
            int cevre = 4 * a;
            Console.WriteLine("Karenin Alanı = " + alan + "\n" + "Karenin Çevresi = " + cevre);
        }

    }
    class Dikdortgen : Sekil
    {
        public override void Draw()
        {
            Console.Write("Dikdortgenin uzun kenarını giriniz = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dikdortgenin kısa kenarını giriniz = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double alan = a * b;
            double cevre = 2 * (a + b);
            Console.WriteLine("Dikdortgenin Alanı = " + alan + "\n" + "Dikdortgenin Çevresi = " + cevre);
        }
    }
    class Daire : Sekil
    {
        public override void Draw()
        {
            Console.Write("Dairenin yarıçapını giriniz = ");
            double r = Convert.ToDouble(Console.ReadLine());
            double alan = 3.14 * r * r;
            double cevre = 2 * 3.14 * r;
            Console.WriteLine("Dairenin Alanı = " + alan + "\n" + "Dairenin Çevresi = " + cevre);
        }
    }
}
