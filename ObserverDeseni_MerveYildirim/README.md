 
## _Observer (Gözlemci) Deseni_



 > Observer pattern davranışsal Kalıplar	içerisinde yer alır.Gözlemci deseni , bir nesne kümesi arasındaki one-to-many ilişkiyi tanımlar. Bir nesnenin durumu değiştiğinde, bütün bağımlılarına bildirilir.  
 > Bir nesnenin durumunun değişmesi ile o nesneye bağlı diğer nesnelerin bu değişimi bilmesini istiyorsak, böyle durumlarda bu tasarım desenini kullanabiliriz.


> Bir haber sitesini ele alalım. Bu sitedeki haberler ekonomi, spor, siyaset, magazin ve buna benzer haberler olsun. Tüm haberlerin başlangıçta ana merkeze düştüğünü, sonrasında ilgili birimlere yönlendirildiğini düşünelim. Dolayısıyla spor, siyaset, ekonomi ,magazin vb. her haber içeriği için editörler farklı olacaktır. Çünkü her editör kendi alanıyla ilgili kısımdan sorumlu olmalıdır.İşte tam bu noktada, ana merkeze düşen haberin türüne göre, editöre otomatik olarak bildirim gönderildiğini düşünelim. Bu sayede editörün sistemi sürekli kontrol etmesine, merkeze düşen yeni haberin kendisini ilgilendirip ilgilendirmediğine bakmasına gerek kalmayacaktır. Bu tasarım şablonu aslında tam olarak bu işlemi yapıyor. Sistem, editöre diyor ki “sen beni takip etme zahmetine girme, ben seni ilgilendiren bir haber olduğunda tarafına bildirim göndereceğim”. Bu şekilde gerçekleşiyor.


 
![UML](https://www.gencayyildiz.com/blog/wp-content/uploads/2016/04/C-Observer-Design-PatternObserver-Tasar%C4%B1m-Deseni.png)

 # UML
>Öncelikle iki tane interface sınıfına ihtiyacımız vardır. Bunlar ise Subject ve Observer’dır. 
Subject interface sınıfı durumu değişecek nesneyi temsil ederken, Observer türünden olan nesneler ise Subject türündeki nesneyi gözlemleyecek ve bir bir değişiklik olduğu zaman uyarılacaktır. 
Yani burada Subject etkileyen nesneyi, Observer ise etkilenen nesneleri temsil edmektedir. 

>Subject sınıfında gözlemcileri bir liste olarak tutan List yapısı mevcuttur. State olarak isimlendirilen int değişken ise, gireceğimiz sayıyı temsil ediyor ve private olduğu için getter-setter metotlarıyla erişebiliyoruz. attach() ile yeni gözlemci ekleyebiliyoruz ve son olarak notifyAllObservers() metodu ile de tüm gözlemcilere herhangi bir değişiklik durumunda bildirim gönderiyoruz.

  


 
## Örnek |_Observer (Gözlemci) Deseni_ |

- Örneğimiz aşağıdaki gibi olsun;

>Elimizde bir Öğrenci nesnesi olsun. Bu Öğrenciyi takip eden; Anne, Baba ve Öğretmen nesneleri olsun. Okul, Öğrenci dersi astığı zaman onu takip eden Annesine, Babasına ve Öğretmenine direkt olarak bu durumu haber veriyor olsun.

- İşte bu yukarıda gördüğünüz örnek olay tam tamına Observer tasarım desenine uygun bir örnektir. 
- Observer Design Pattern yapısınıda Öğrencinin dersi asdığı anda diğer abonelere haber veren Okul’a benzetebiliriz. Yani bir sistemdir diyebiliriz.



# Kodlama
- - - - 
-  Öncelikle Subject’imize(yani hedefimize) bir çok tipin abone olabilmesini sağlayacak Observer arayüzünü geliştirelim.
- Observer arayüzünü ben abstract class olarak beliyorum. Siz isterseniz interface olarak çalışabilirsiniz. Observer sınıfından kalıtım alan her abone sınıfa Update metodu uygulanacaktır. Haliyle Subject’imizde ilgili alan değiştiğinde abonelerimizdeki Update metodu tetiklenmiş olacaktır.

```sh
abstract public class Observer
{
    public abstract void Update();
}
```

- - - - 

-  Öncelikle Subject’imize(yani hedefimize) bir çok tipin abone olabilmesini sağlayacak Observer arayüzünü geliştirelim.
- Observer arayüzünü ben abstract class olarak beliyorum. Siz isterseniz interface olarak çalışabilirsiniz. Observer sınıfından kalıtım alan her abone sınıfa Update metodu uygulanacaktır. Haliyle Subject’imizde ilgili alan değiştiğinde abonelerimizdeki Update metodu tetiklenmiş olacaktır.

```sh
  public class AnneObserver : Observer
        {
            public override void Update()
            {
                Console.WriteLine("Öğrencinin kaçtığından annesinin haberi oldu.");
            }
        }
        public class BabaObserver : Observer
        {
            public override void Update()
            {
                Console.WriteLine("Öğrencinin kaçtığından babasının haberi oldu.");
            }
        }
```
- - - - 
- Şimdi Concrete nesnelerimizi başka bir deyişle takip edecek sınıflarımızı oluşturalım.
- Burada konuyu anlamak amacımız olduğu için sadece ekrana bildirinin mesajını yazıyoruz. İstersek buradaki işlemlere birden fazla iş yükü de tanımlaya biliriz.



```sh
  public class AnneObserver : Observer
        {
            public override void Update()
            {
                Console.WriteLine("Öğrencinin kaçtığından annesinin haberi oldu.");
            }
        }
        public class BabaObserver : Observer
        {
            public override void Update()
            {
                Console.WriteLine("Öğrencinin kaçtığından babasının haberi oldu.");
            }
        }
```

- - - - 

- Şimdide Subject’imizi yani takip edilecek nesnemizi inşa edelim.  
- - Takip edilecek nesnemizin özelliklerini belirliyoruz.
- - Biz burada örneğimize uygun olacak şekilde öğrenci bilgilerinden bazılarını girdik.
- - Tek fark dersiAstiMi adında yer alan bool tipindeki değişkendir.
- - Bu değişken ile; Bildirimleri tetikleme işlemlerini görüyoruz. Bir sonraki sayfadaki açıklamalar ile bunu daha iyi kavrayacağımızı düşünüyorum.


```sh
   public class Ogrenci
        {
            public string Adi { get; set; }
            public string SoyAdi { get; set; }
            public string Memleket { get; set; }
            public int Sinif { get; set; }
            bool dersiAstiMi;
            .
            .
            .
            .
```
----

- set bloğuna dikkat edersek eğer set edilen değer true ise
- Notify metodu tetiklenmekte ve tüm abonelere haber gönderilmektedir.


```sh
            .
            .
            .
            .
                   
            public bool DersiAstiMi
            {
                get { return dersiAstiMi; }
                set
                {
                    if (value == true)
                    {
                        Notify();
                        dersiAstiMi = value;
                    }
                    else
                        dersiAstiMi = value;
                }
            }
                        .
            .
            .
            .
```
----

- Abone ekle ve çıkar fonksiyonları ise bu koleksiyona eleman ekleme ve çıkarma işlemleri gerçekleştirir.



```sh
            .
            .
            .
            .
                   
            List<Observer> Gozlemciler;
            public Ogrenci()
            {
                this.Gozlemciler = new List<Observer>();
            }
            //Gözlemci ekle
            public void AboneEkle(Observer observer)
            {
                Gozlemciler.Add(observer);
            }
            //Gözlemci çıkar
            public void AboneCikar(Observer observer)
            {
                Gozlemciler.Remove(observer);
            }
                        .
            .
            .
            .
               
```




----

-  Programın main kısmına geçerek sonunda test işlemlerine geçelim.
-  Öncelikle nesnemizi tanımlıyoruz.
-  Observer’larımızı abone ekle yapımız ile liste ekliyoruz.
-  Öğrencinin bilgilerini girdikten sonra desti astımı durumunu true yani derse gelmedi şeklinde belirliyoruz ki bildirim işlemleri başarıyla gerçekleşecek mi bir bakalım.
-  Gelin şimdi diğer sayfada ekran çıktımıza bir göz atalım


```sh
            .
            .
            .
            .
                   
           
            static void Main(string[] args)
            {
                //yeni bir öğrenci nesnesi oluşturuyoruz.
                Ogrenci o = new Ogrenci();
                //haber bekleyenleri ekliyoruz
                o.AboneEkle(new BabaObserver());
                o.AboneEkle(new AnneObserver());
                // nesnenin özelliklerini veriyoruz
                o.Adi = "Merve";
                o.SoyAdi = "YLD";
                o.Memleket = "Samsun";
                o.Sinif = 4;
                //derste oluş olmadıgını giriyoruz.
                o.DersiAstiMi = true; //burada öğrenci derse gelmedi yani anne ve babaya bilgi verilecek.
                Console.ReadKey(true);
            }
        } 
               
```
----
# Ekran Çıktımız
![UML](https://lh3.googleusercontent.com/OCzglY9TIJw3ZCXHD05hZIDvOcToqcC0ZC8U8sYtc56J3-148hc-YSoJjmUNZybbRfZCqZ_n4-AwuJx0Fucp=w1920-h969-rw)

- Aşağıda da gördüğünüz gibi bildirimler ekrana düştü ve yapımız sorunsuz bir biçimde çalıştı.

- Yapıyı kavradığımızı düşünüyorum ve sonuç kısmına geçerek konuyu bağlayalım.





 

 # Sunuç
 
- Özetle observer design pattern, içinde bildirim olan her sistemde ekstrem durumlar olmadığı sürece kullanılabilir. Amaç, otomatik bildirim gönderimi ile gözlemcilerin sistemi sürekli takip etme gereksinimini ortadan kaldırıp, bu sorumluluğu üstlenen yapıyı oluşturmaktır.

- Bir nesnenin birden çok nesneyi otomatik olarak etkilemesini istiyorsak bu tasarım desenini kullanabiliriz.

- Bu yapı öyle göründüğü kadar zor bir yapı değildir. 

- Observer tasarım deseni one-to-many prensibini uyguladığı için tek bir tane Subject olmalı, birden çok ise Observer sınıfı olmalıdır.



 
 
