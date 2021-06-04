using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //metod çağırma
        static void Main(string[] args)
        {
            Istemci i = new Adaptör();
            i.Siparis();
            Console.ReadKey();

        }
    }
    class Istemci
    {
        public virtual void Siparis()
        {
            int biftek = 75;
            int hindi = 65;
            int tavuk = 55;
            Console.WriteLine("Biftegin firinda pisme süresi = " + biftek);
            Console.WriteLine("Hindinin firinda pisme süresi = " + hindi);
            Console.WriteLine("Tavugun firinda pisme süresi = " + tavuk);

        }
    }
    class Servis
    {
        //Servis sınıfında olması istenilen bütün özellikler eklidir.
        public void Biftek()
        {
            Console.WriteLine("Biftek için \n Firinda Pisirilme Suresi = 30dk \n"
                + " Kalori Degeri = 75cal \n Protein Degeri = 7.45 \n Pisirme Suresi = 45dk\n\n");
        }
        public void Hindi()
        {
            Console.WriteLine("Hindi için \n Firinda Pisirilme Suresi = 25dk \n"
                + " Kalori Degeri = 65cal \n Protein Degeri = 9.45 \n Pisirme Suresi = 60dk\n\n");
        }
        public void Tavuk()
        {
            Console.WriteLine("Tavuk için \n Firinda Pisirilme Suresi = 15dk \n"
                + " Kalori Degeri = 50cal \n Protein Degeri = 6.45 \n Pisirme Suresi = 20dk\n\n");
        }
    }
    class Adaptör : Istemci
    {
        public Servis Adapte = new Servis();
        public override void Siparis()
        {
            //Serviste olan metodlar çağrılır.
            Adapte.Biftek();
            Adapte.Hindi();
            Adapte.Tavuk();
        }
    }
}





