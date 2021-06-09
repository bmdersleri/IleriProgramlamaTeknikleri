using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{

    public interface IKayitOlustur
    {
        void kayitOlustur();
    }

    public class MusteriOlustur : IKayitOlustur
    {
        public void kayitOlustur()
        {
            Console.WriteLine("Müşteri");
        }
    }

    public class FirmaOlustur : IKayitOlustur
    {
        public void kayitOlustur()
        {
            Console.WriteLine("Firma");
        }
    }

    public class Kayitlar
    {
        public IKayitOlustur _kayit { get; set; }

        public Kayitlar(IKayitOlustur kayit)
        {
            _kayit = kayit;
        }

        public virtual void kayitYaz()
        {
            _kayit.kayitOlustur();
        }
    }

    public class Musteri: Kayitlar
    {
        public Musteri(IKayitOlustur yaz) : base (yaz) { }

        public override void kayitYaz()
        {
            Console.WriteLine("Müşteri eklendi");
            base.kayitYaz();
        }
    }
    public class Firma : Kayitlar
    {
        public Firma(IKayitOlustur yaz) : base(yaz) { }

        public override void kayitYaz()
        {
            Console.WriteLine("Firma eklendi");
            base.kayitYaz();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kayitlar musteriekle = new Musteri(new MusteriOlustur());
            musteriekle.kayitYaz();

            Kayitlar firmaekle = new Firma(new FirmaOlustur());
            firmaekle.kayitYaz();
            Console.ReadLine();
        }
    }
}
