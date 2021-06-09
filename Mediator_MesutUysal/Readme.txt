Sunumdaki örnekte mediator desing pattern hakkında açıklayıcı bir örnek sunulmuştur.

ilk önce 2 sınıf arasında ( çiftçi,halci) ilişki kurulmuştur. 

ilk olarak bir enum oluşturuldu

bu enum içerisinden satılan sebzeler tanımlandı. daha sonra üretici sınıfı abstract class olarak
tanımlandı. üreticinin adı,satığı fiyatı ve ürün tanımlandı. 

Bunlar getter larını alarak modellenme sağlandı.

Aynı işlem halci sınıfı için de yapıldı. Aracı sınıfı ise java da çoklu miras olmadığı için coklu miras alabilmek için interface
ler tanımlanarak tanımı yapıldı. 

Aracı sınıfı üreticiEkle halciEkle, üreticiden alma ve hale satma işlemlerini gerçekleştirdi.

Sonraki işlemlerde ise domatesüreticisi ve domateshalcisi adı altında 2 sınıf koda eklendi bu sınıflar sırasıyla üretici ve halci 
sınıflarından (extends) kalıtım aldı.

 Yani o sınıfın tüm özelliklerine erişebilmek adına bu yapıldı.

Bu işlemlerin ardından örnek bir kabzimal classı oluşturuldu.

 Bu class içinde üretici ve halci listeleri tanımlandı. yeni bir üretici veya halci oluşturulmak istendiğinde 
otomatikmen  bu listelere eklenebilecekti.

15. sayfadaki kodda ise bir karşılaştırma işlemi ile karşı karşıyayız.enuygun üreticiyi bulmak
için önce ilk değeri null atıyoruz.

 Daha sonra tek tek tüm üreticileri for döngüsü ile karşılaştırıyoruz.bu işlemin yapılması için 
öncelikle üreticinin sattığı ürün ile halcinin almak istediği ürün aynı olmak durumundadır.

 Bu işlemin ardından en uygun üretici eger 1 tane ise mecbur alıyoruz. Ya da en uygun üreticinin fiyatı verdiğimiz fiyattan büyükse ya null değeri ya da daha güzel fiyat olacktır.
Bu durumda elimizdeki üretici en uygun üretici olmuş olacaktır. Aynı işlemi kopyalayıp halci için yapabiliriz burada sadece <0 yerine >0 işlemi yapılmalıdır.

Main fonksiyonuna gelince ise 1 tane kabzimal ürettik. Örnek olarak da üretici listesine 2 tane çiftçi bahadır(4) ,yusuf(3) şeklinde. Yanındaki sayılar ise çiftçilerin mallarını satmak
istedikleri değer olmaktadır.

2 tane de halci eklendi. HalciAhmet(5) ve HalciMehmet(7) adı altında. Bu sayılar ise halcilerin malları almak istedikleri fiyatlardır. 

üreticiBahadır.ürünSat adı altında bir fonksiyon çalıştırldığında bunun anlamı bahadır ürününü satmak isetediğinden kime satar sorusunun cevabını sormaktadır aslında.
Burada üretici malını HalciMehmet e satacaktır. Çünkü mehmet ürüne 7 lira verirken ahmet ise 5 lira vermetedir. 

Böylece 2 sınıf arasındaki bu kamaşıklığı mediator ile nasıl çözebileceğimizi anlayabileceğimiz güzel bir örnek oldu. Bir sonraki video  ve anlatımlar için bmDersleri kanalıan üye 
olmayı unutmayalım :)
