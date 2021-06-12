
using System;
using System.Collections.Generic;

namespace CompositePattern
{

    /// Askerlerin rütbeleri

    enum Rank
    {
        General,
        Albay,
        Yarbay,
        Binbasi,
        Yuzbasi,
        Tegmen
    }

    /// Component sınıfı

    abstract class Soldier
    {

        protected string _name;
        protected Rank _rank;

        public Soldier(string name, Rank rank)
        {
            _name = name;
            _rank = rank;
        }

        public abstract void AddSoldier(Soldier soldier);
        public abstract void RemoveSoldier(Soldier soldier);
        public abstract void ExecuteOrder(); // Hem Leaf hemde Composite tipi için uygulanacak olan fonksiyon

    }


    /// Leaf class


    class PrimitiveSoldier : Soldier
    {

        public PrimitiveSoldier(string name, Rank rank) : base(name, rank)
        {
        }

        // Bu fonksiyonun Leaf için anlamı yoktur.
        public override void AddSoldier(Soldier soldier)
        {
            throw new NotImplementedException();
        }

        // Bu fonksiyonun Leaf için anlamı yoktur.
        public override void RemoveSoldier(Soldier soldier)
        {
            throw new NotImplementedException();
        }
        public override void ExecuteOrder()
        {
            Console.WriteLine(String.Format("{0} {1}", _rank, _name));
        }

    }

    /// Composite Class

    class CompositeSoldier : Soldier
    {
        // Composite tip kendi içerisinde birden fazla Component tipi içerebilir. Bu tipleri bir koleksiyon içerisinde tutabilir.
        private List<Soldier> _soldiers = new List<Soldier>();

        public CompositeSoldier(string name, Rank rank) : base(name, rank)
        {
        }

        // Composite tipin altına bir Component eklemek için kullanılır
        public override void AddSoldier(Soldier soldier)
        {
            _soldiers.Add(soldier);
        }

        // Composite tipin altındaki koleksiyon içerisinden bir Component tipinin çıkartmak için kullanılır
        public override void RemoveSoldier(Soldier soldier)
        {
            _soldiers.Remove(soldier);
        }

        // Önemli nokta. Composite tip içerisindeki bu operasyon, Composite tipe bağlı tüm Component'ler için gerçekleştirilir.
        public override void ExecuteOrder()
        {
            Console.WriteLine(String.Format("{0} {1}", _rank, _name));

            foreach (Soldier soldier in _soldiers)
            {
                soldier.ExecuteOrder();
            }

        }
    }

    class Program
    {

        public static void Main(string[] args)
        {

            // Root oluşturulur.   
            CompositeSoldier generalCagatay = new CompositeSoldier("Çağatay", Rank.General);


            // root altına Leaf tipten nesne örnekleri eklenir.
            generalCagatay.AddSoldier(new PrimitiveSoldier("Koray", Rank.Albay));
            generalCagatay.AddSoldier(new PrimitiveSoldier("Tarık", Rank.Albay));


            // Composite tipler oluşturulur.
            CompositeSoldier AlbayYunus = new CompositeSoldier("Yunus", Rank.Albay);
            CompositeSoldier YarbayZafer = new CompositeSoldier("Zafer", Rank.Yarbay);


            // Composite tipe bağlı primitive tipler oluşturulur.
            YarbayZafer.AddSoldier(new PrimitiveSoldier("Tekin", Rank.Yuzbasi));
            AlbayYunus.AddSoldier(YarbayZafer);
            AlbayYunus.AddSoldier(new PrimitiveSoldier("Mustafa", Rank.Yarbay));

            // Root' un altına Composite nesne örneği eklenir.
            generalCagatay.AddSoldier(AlbayYunus);

            generalCagatay.AddSoldier(new PrimitiveSoldier("Zekeriya", Rank.Albay));


            // root için ExecuteOrder operasyonu uygulanır. Buna göre root altındaki tüm nesneler için bu operasyon uygulanır
            generalCagatay.ExecuteOrder();


            Console.ReadLine();

        }

    }

}