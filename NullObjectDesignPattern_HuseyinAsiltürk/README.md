# Beni Oku
|   |   |
| ------ | ------ |
| Konu Anlatım Videosu = | https://youtu.be/2lAZiKzjwtE |
| BMDersleri  =  | https://www.youtube.com/bmdersleri |
| Github Adresimiz =  | https://github.com/bmdersleri | 
| Hazırlayan =  | Hüseyin ASİLTÜRK | 
 
 
## _Null Object Design Pattern_



 > Bu pattern'in amacı uygulama içeresinde null objeler return etmek yerine ilgili tipin yerine geçen ve expected value'nun null objesi olarak kabul edilen tipini geriye döndürmektir diğer bir değişle null yerine daha tutarlı nesneler döndürmektir. Bu nesne asıl return edilmesi gereken nesnenin null değeri olarak kabul edilirken onunla aynı özelliklere sahip değildir, çok daha az bilgi içermektedir. NULL Object Pattern , sürekli olarak null kontrolü yaparak hem server-side hemde client-side için boilerplate code yazmaya engel olmak amacıyla ortaya çıkmış bir pattern dir.

> Platform yada dil fark etmeksizin geliştirme yaparken sürekli olarak null reference exception aldığımız durumlar olmuştur bu durumdan kurtulmak adına obj null mı değil mi diye bir sürü if/else kontrolleri yaparız. Bu pattern'i kullanarak biraz sonraki örnekte yapacağımız gibi boilerplate code'lar yazmaktan nasıl kurtulabiliriz bunu inceleyeceğiz

![UML](https://www.cs.oberlin.edu/~jwalker/nullObjPattern/structure.png)

 # Client
>İstemci soyut sınıfın bir uygulamasını alır ve kullanır.

 # Abstract Object
>Sınıf içerisinde uygulanması gereken farklı işlemleri tanımlayan soyut bir sınıf.

# Real Objet
>İstenilen işlemleri gerçekleştiren Abstract Object’in gerçek bir nesnesidir.

# Null Object
>İstemciye boş olmayan nesne sağlamak için soyut sınıftan türetilen hiçbir şey yapmayan nesnedir.


| Avantajları | Dezavantajları |
| ------ | ------ |
| Gerçek ve boş nesnelerden sınıf hiyerarşisi tanımlamaktadır. |Null nesnesi iyi tanımlanmadığı zaman istemci tarafından yönetilemeyeceği için sorunlara neden olabilir.|
| Nesnenin bir şey yapması beklenmediğinde boş nesneler gerçek nesnelerin yerine kullanılabilir. | Her yeni absract object sınıfı için yeni bir null objest sınıfı gerekir. |
| İstemci kodu daha basittir. | Nesne boş ise yapması gereken işlemler var ise bunlar tanımlanamayabilir. |
| İf else yapısı gibi koşullu karmaşıklıklardan arındırır. |  | 



 
## Örnek (_Null Object Design Pattern_  KULLANMADAN)

```sh
public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int NumberOfChildren { get; set; }
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
}
```
 
- Örneğimizi 2 şekilde ele alalım. İlk olarak geriye null değer return ederek çoğunlukla nasıl geliştirme yapıyoruz o case'i ele alalım, sonrasında ise NULL Object Pattern kullanarak nasıl geliştirebiliriz onu inceleyelim.
- İlk olarak Customer adında bir nesnemiz var ve repository kullanarak geriye bu nesneyi return edelim. 
- Nesnenin değişkenlerini ve Customer(Müşterinin Adını ve Soyadını birleştiren bir fonksiyonumuz var)



```sh
public class CustomerService
    {
        public Customer GetCustomerByFirstName(string firstName)
        {
            return _customerRepository.List(c => c.FirstName == firstName).FirstOrDefault();
        }
    }
```
 
- Service katmanında generic bir repository yapımız varmış gibi varsayalım ve repository üzerinden GetCustomerByFirstName adında bir metot tanımlayalım. 



```sh
var customerService = new CustomerService();
var customer = customerService.GetCustomerByFirstName("AsilTürk");
Console.WriteLine("FullName : " + customer.GetFullName() + "\nNumber Of Childreen:" + customer.NumberOfChildren);
```
 
-  Yukarıdaki kod bloğunda göründüğü gibi customer'ın null geldiği durumda exception thrown 'system.nullreferenceexception' hatasını çoktan almış oluruz. Çünkü memory'de değeri assing edilmemiş bir yere erişmeye çalışıyoruz. Peki çözüm olarak ne yapabiliriz ilk akla gelen bir sonraki sayfadaki gibi bir kontrol olacaktır. 


# İf ile Çözüm

```sh
var customerService = new CustomerService();
var customer = customerService.GetCustomerByFirstName("AsilTürk");
if (customer != null)
{
    Console.WriteLine("FullName : " + customer.GetFullName() + "\nNumber Of Childreen:" + customer.NumberOfChildren);
}
else
{
    Console.WriteLine("Name : Customer Not Found !" + "\nNumber Of Childreen: 0");
}
```
 
-  Yukarıdaki gibi bir çözüme gittiğimizde customer objesini get ettiğimiz bir sürü yer olduğunu düşünün ve her yerde sürekli olarak null kontrolü yapıp sonrasında console'a değerleri yazıyor oluruz. Aslında bu şu deme değil;"null kontrolü yapma arkadaş !" kesinlikle bu değil tabiki de ihtiyaç duyulan yerlerde bu kontrol yapılmalı. Fakat diyelim ki boş olduğunda bir işleme gerek duymuyoruz ve bu projemizde her yerde yapmaktansa bir yerde yapmak bizim işimizi görecektir.

## Örnek (_Null Object Design Pattern_  Kullanarak)

```sh
 public abstract class AbstractCustomer
{
    public abstract int Id { get; set; }
    public abstract string FirstName { get; set; }
    public abstract string LastName { get; set; }
    public abstract int NumberOfChildren { get; set; }
    public abstract string GetFullName();
}
```
 
-  Hadi şimdi NULL Object Pattern uygulayarak nasıl bir çözüm getirirdik ona bakalım. İlk olarak AbstractCustomer adında base sınıfımızı oluşturalım.



```sh
public class Customer : AbstractCustomer
{
    public override string FirstName { get; set; }
    public override string LastName { get; set; }
    public override int NumberOfChildren { get; set; }
    public override int Id { get; set; }
 
    public override string GetFullName()
    {
        return FirstName + " " + LastName;
    }
}
```
 
- Sonrasında Customer objesini bu sınıftan türetelim.


```sh
public class NullCustomer : AbstractCustomer
{
    public override string FirstName { get; set; }
    public override string LastName { get; set; }
    public override int NumberOfChildren { get; set; }
    public override int Id { get; set; }
 
    public override string GetFullName()
    {
        return "Customer Not Found !";
    }
}
```
 
- Şimdi ise bu pattern'in getirdiği çözüm olarak geriye null value dönmeyip asıl return edilmek istenen sınıf yerine onun null olduğunu belirten bir sınıf geriye dönelim. Bu sınıfa da #NullCustomer adını verelim.



```sh
public class CustomerService
{
    public AbstractCustomer GetCustomerByFirstName(string firstName)
    {
        return _customerRepository.Where(c => c.FirstName == firstName).FirstOrDefault().GetValue();
    }
}
public static class CustomerExtensions
{
    public static AbstractCustomer GetValue(this AbstractCustomer customer)
    {
        return customer == null ? new NullCustomer() : customer;
    }
}
```
 
- Yukarıdaki kod bloğunda görüldüğü üzre repository null değer dönmek yerine yeni bir NullCustomer sınıfı return edecektir.

```sh
public class CustomerService
{
    public AbstractCustomer GetCustomerByFirstName(string firstName)
    {
        return _customerRepository.Where(c => c.FirstName == firstName).FirstOrDefault().GetValue();
    }
}
public static class CustomerExtensions
{
    public static AbstractCustomer GetValue(this AbstractCustomer customer)
    {
        return customer == null ? new NullCustomer() : customer;
    }
}
```
 
- Yukarıdaki kod bloğunda görüldüğü üzre repository null değer dönmek yerine yeni bir NullCustomer sınıfı return edecektir.

```sh
var customerService = new CustomerService();
var customer = customerService.GetCustomerByFirstName("tosuner");
Console.WriteLine("FullName : " + customer.GetFullName() + "\nNumber Of Childreen:" + customer.NumberOfChildren);
```
 
- Son adım olarak da cient tarafında yazılacak kod ise yazımızın ilk başında yazdığımız kod bloğu ile aynı.

 # Sunuç
 
- Null reference kontrollerinden kurtulduk,
- Duplicate kod oranını azalttık,
- Memory de değeri olmayan bir alana erişmek yerine null value görevi gören bir nesneye eriştik,
- Dahası client tarafı için daha temiz ve kolay anlaşılır bir kod bıraktık,

 
 
