using System.Collections.Generic;
using System;

namespace FlyWeight
{
    enum SoldierType
    {
        Private,
        Sergeant
    }

    abstract class Asker
    {
        #region Intrinsic Fields


        protected string BirimAdi;
        protected string Silahlar;
        protected string Saglik;

        #endregion

        #region Extrinsic Fields

        protected int X;
        protected int Y;

        #endregion

        public abstract void MoveTo(int x, int y);
    }

    // Concrete FlyWeight
    class Private
        : Asker
    {
        public Private()
        {
            // Intrinsict değerler set edilir
            BirimAdi = "SWAT";
            Silahlar = "Machine Gun";
            Saglik = "Good";
        }
        public override void MoveTo(int x, int y)
        {
            // Extrinsic değerler set edilir ve bir işlem gerçekleştirilir
            X = x;
            Y = y;
            Console.WriteLine("Er ({0}:{1}) noktasına hareket etti", X, Y);
        }
    }

    // Concrete FlyWeight
    class Sergeant
        : Asker
    {
        public Sergeant()
        {
            BirimAdi = "SWAT";
            Silahlar = "Sword";
            Saglik = "Good";
        }
        public override void MoveTo(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Çavuş ({0}:{1}) noktasına hareket etti", X, Y);
        }
    }

    // FlyWeight Factory
    class SoldierFactory
    {
        // Depolama alanı(Havuz).
        // Uygulama ortamında tekrar edecek olan FlyWeight nesne örnekleri depolama alanında basit birer Key ile ifade edilir
        private Dictionary<SoldierType, Asker> _askerler;

        public SoldierFactory()
        {
            _askerler = new Dictionary<SoldierType, Asker>();
        }

        public Asker GetSoldier(SoldierType sType)
        {
            Asker asker = null;

            // Eğer depolama alanında, parametre olarak gelen Key ile eşleşen bir FlyWeight nesnesi var ise onu çek
            if (_askerler.ContainsKey(sType))
                asker = _askerler[sType];
            else
            {
                // Yoksa Key tipine bakarak uygun FlyWeight nesne örneğini oluştur ve depolama alanına(havuz) ekle
                if (sType == SoldierType.Private)
                    asker = new Private();
                else if (sType == SoldierType.Sergeant)
                    asker = new Sergeant();
                _askerler.Add(sType, asker);
            }

            // Elde edilen FlyWeight nesnesini geri döndür
            return asker;
        }
    }

    class Program
    {
        public static void Main()
        {
            // İstemci için örnek bir FlyWeight nesne örneği dizisi oluşturulur
            SoldierType[] soldiers = { SoldierType.Private, SoldierType.Private, SoldierType.Sergeant, SoldierType.Private, SoldierType.Sergeant };

            // FlyWeight Factory nesnesi örneklernir
            SoldierFactory factory = new SoldierFactory();

            // Extrinsic değerler set edilir
            int lokasyonX = 10;
            int lokasyonY = 10;

            foreach (SoldierType soldier in soldiers)
            {
                lokasyonX += 10;
                lokasyonY += 5;
                // O anki Soldier tipi için MoveTo operasyonu çağırılmadan önce fabrika nesnesinden tedarik edilir
                Asker sld = factory.GetSoldier(soldier);
                // FlyWeight nesnesi üzerinden talep edilen operasyon çağrısı gerçekleştirilir
                sld.MoveTo(lokasyonX, lokasyonY);
            }
        }
    }
}

