using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public interface Oyuncular
    {
        string Oyuncu();
    }

    public interface Takim
    {
        string TakimRengi ();
    }

    public interface FutbolFactory
    {
        Takim OlusturTakim();
        Oyuncular OlusturOyuncu();
    }


    public class AlmanyaLigiFactory : FutbolFactory
    {
        public Takim OlusturTakim()
        {
            return new BayerMunih();
        }

        public Oyuncular OlusturOyuncu()
        {
            return new A_LigOyuncusu();
        }
    }

    public class IngiltereLigiFactory : FutbolFactory
    {
        public Takim OlusturTakim()
        {
            return new Liverpool();
        }

        public Oyuncular OlusturOyuncu()
        {
            return new I_LigOyuncusu();
        }
    }

    public class ItalyaLigiFactory : FutbolFactory
    {
        public Takim OlusturTakim()
        {
            return new Juventus();
        }

        public Oyuncular OlusturOyuncu()
        {
            return new It_LigiOyuncusu();
        }
    }

    public class BayerMunih : Takim
    {
        public string TakimRengi()
        {
            return "Takım Rengi: Kırmızı ve Beyaz";
        }
    }

    public class Juventus : Takim
    {
        public string TakimRengi()
        {
            return "Takım Rengi: Siyah ve Beyaz";
        }
    }

    public class Liverpool : Takim
    {
        public string TakimRengi()
        {
            return "Takım Rengi: Kırmızı ve Beyaz";
        }
    }

    public class A_LigOyuncusu : Oyuncular
    { 
        public string Oyuncu()
        {
            return "Oyuncu: Thomas Müller";
        }
    }

    public class I_LigOyuncusu : Oyuncular
    {
        public string Oyuncu()
        {
            return "Oyuncu: Ozan Kabak";
        }
    }

    public class It_LigiOyuncusu : Oyuncular
    {
        public string Oyuncu()
        {
            return "Oyuncu: Cristiano Ronaldo";
        }
    }


public class Futbol
{
    private readonly Takim _takim;
    private readonly Oyuncular _oyuncu;
        public Futbol(FutbolFactory factory)
    {
            _oyuncu = factory.OlusturOyuncu();
            _takim = factory.OlusturTakim();
    }

    public string FutbolTakimRengi()
    {
        return _takim.TakimRengi();
    }
    public string FutbolOyuncu()
    {
        return _oyuncu.Oyuncu();
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            FutbolFactory almanya = new AlmanyaLigiFactory();
            FutbolFactory ingiltere = new IngiltereLigiFactory();
            FutbolFactory italya = new ItalyaLigiFactory();
            Futbol futbol = new Futbol(ingiltere);
            Console.WriteLine(futbol.FutbolTakimRengi());
            Console.WriteLine(futbol.FutbolOyuncu());
            Console.ReadLine();
        }
    }
}
