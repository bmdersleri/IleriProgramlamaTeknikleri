using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoratortasarimdeseni
{
    class Program
    {
        //Test Ortamı
        class Client
        {
            static void Uygula(IComponent c)
            {
                Console.WriteLine(c.Operation());
            }
            static void Main()
            {
                Console.WriteLine("Decorator Pattern\n");
                Console.WriteLine("Normal Siparişiniz Hesaplanıyor...");

                IComponent component = new Component();
                Uygula(component);
                Uygula(new DecoratorA(component));
                Uygula(new DecoratorB(component));
            }
        }
        interface IComponent
        {
            //Component interface,tüm decoratorler burada implement etmek zorundadır.
            double Operation();
        }
        class Component : IComponent
        {
            //Decorator isleminin yapilacagi sinif

            public double paket = 353.53;
            public double kiyafet = 88.34;
            public double binek = 58.87;
            public double silah = 88.34;

            public double Operation()
            {
                double toplam = paket + kiyafet + binek + silah;
                return toplam;
            }
        }
        //Decorator sinifi.abstrack tanimlamak zorunlu
        //Önsiparisin hesaplanacagi kisim

        class DecoratorA : IComponent
        {
            private IComponent component;
 
            public DecoratorA(IComponent c)
            {
                component = c;
            }

            public double Operation()
            {
                Component nesne1 = new Component();

                Console.WriteLine("Önsiparişinizin toplam fiyatı hesaplanıyor...");
                double onsiparis = (nesne1.Operation()) - (nesne1.Operation() * 0.15);
                return onsiparis;
            }
        }
        //Decorator sinifi.abstrack tanimlamak zorunlu
        //Premium indiriminin yapılacagi kısım
        class DecoratorB : IComponent
        {
            private IComponent component;
 
            public DecoratorB(IComponent c)
            {
                component = c;
            }

            public double Operation()
            {
                Component nesne1 = new Component();

                Console.WriteLine("Önsiparişinizin toplam fiyatı hesaplanıyor...");
                double premiumSiparis = (nesne1.Operation()) - (nesne1.Operation() * 0.15) - (nesne1.Operation() * 0.12);
                Console.WriteLine("Siparise ön ek indirim ekleniyor...");
                return premiumSiparis;
            }
        }
    }
}
