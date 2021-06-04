using System;

namespace Refactoring_Ornegi
{
    class Program
    {

        public class Refactoring
        {
            public void EkranaYazdırma()
            {
                KullaniciBilgileri();
            }

            public void KullaniciBilgileri()
            {
                Console.WriteLine("Kullanıcı Adı : CanCilek");
                Console.WriteLine("E-posta : can.cilek@gmail.com");
            }

        }

        static void Main(string[] args)
        {
            Refactoring refactoring_nesne = new Refactoring();
            refactoring_nesne.EkranaYazdırma();
            Console.ReadLine();
        }
    }
}






