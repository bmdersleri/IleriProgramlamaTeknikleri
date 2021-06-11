
using System;

namespace Proxy_Örnek_2
{
    class Program
    {
      
        abstract class Hesaplamaislemi
        {
            public abstract int Hesaplama();

        }
        class Hesaplamayönetici : Hesaplamaislemi
        {
            public override int Hesaplama()
            {
                int sonuc = 1;
                for (int i = 1; i < 7; i++)
                {
                    sonuc += sonuc;

                }
                return sonuc;
            }
        }
        class HesaplamaProxy : Hesaplamaislemi
        {
            private Hesaplamayönetici hesapyönet;
            private int cachedval = 0;
            public override int Hesaplama()
            {
                if(hesapyönet==null)
                {
                    hesapyönet = new Hesaplamayönetici();
                    cachedval = hesapyönet.Hesaplama();

                }
                return cachedval;
            }
        }
        static void Main(string[] args)
        {
            Hesaplamaislemi hesaplamaislemi = new HesaplamaProxy();
            Console.WriteLine(hesaplamaislemi.Hesaplama());
            Console.WriteLine(hesaplamaislemi.Hesaplama());

            Console.ReadLine();
        }
    }
    
}
