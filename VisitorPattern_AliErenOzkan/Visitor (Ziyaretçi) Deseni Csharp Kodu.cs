    //tablet isimli soyut sınıf oluşturuyoruz.
    public abstract class Tablet
    {
        public string Model { get; set; }
        public string Marka { get; set; }

        public Tablet(string model, string marka)
        {
            Model = model;
            Marka = marka;
        }

        public abstract void Accept(IVisitor visitor);
    }
    //IPad isimli somut sınıf oluşturuyoruz.
    public class IPad:Tablet
    {
        public IPad(string model, string marka)
            : base(model, marka)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    //GalaxyTab isimli somut sınıf oluşturuyoruz.
    public class GalaxyTab:Tablet
    {
        public GalaxyTab(string model, string marka)
            : base(model, marka)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    //Ziyaretçiyi temsil eden bir arayüz oluşturuyoruz.
    public interface IVisitor
    {
        void Visit(Tablet tablet);
    }
    //WifiVisitor isimli zomut Ziyaretçiyi oluşturuyoruz.
    public class WifiVisitor:IVisitor
    {
        public void Visit(Tablet tablet)
        {
            if (tablet is IPad)
                Console.WriteLine("Ipad minide wifi acık");
            else if (tablet is GalaxyTab)
                Console.WriteLine("GalaxyTabde wifi yok");
            else
                Console.WriteLine("Bu nesne bir tablet değildir");
        }
    }
    
    public class ThreeGVisitor:IVisitor
    {
        public void Visit(Tablet tablet)
        {
            if (tablet is IPad)
                Console.WriteLine("Ipad minide 3G yok");
            else if (tablet is GalaxyTab)
                Console.WriteLine("GalaxyTabde 3G var");
            else
                Console.WriteLine("Bu nesne bir tablet değildir");
        }
    }
    
    static void Main(string[] args)
    {
        IPad iPad = new IPad("Ipad mini", "Apple");
        GalaxyTab galaxyTab = new GalaxyTab("Galaxy Tab", "Samsung");

        iPad.Accept(new WifiVisitor());
        galaxyTab.Accept(new WifiVisitor());

        iPad.Accept(new ThreeGVisitor());
        galaxyTab.Accept(new ThreeGVisitor());

        Console.ReadLine();

    }