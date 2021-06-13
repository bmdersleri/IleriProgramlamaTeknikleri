İçerik: Chain Of Responsibility Örneği

Youtube Kanalımız: BMDersleri

Bağlantı: https://www.youtube.com/channel/UCIdYgV-XFjv9q0IHtzUTtQw

Kısa Bağlantı: https://bit.ly/32k9MnJ

Kodların Uygulandığı Video: https://www.youtube.com/watch?v=GcjQpuJ-N2w

Github Adresimiz: https://github.com/bmdersleri

Sorumluluk zinciri, istekleri bir işleyici zinciri boyunca iletmenizi sağlayan davranışsal bir tasarım modelidir. 
Bir istek aldıktan sonra, her işleyici, isteği işlemeye veya zincirdeki bir sonraki işleyiciye iletmeye karar verir.
İşleyici arabirimi bildirilir ve istekleri işlemek için bir yöntemin imzasını açıklanır.
İstemcinin istek verilerini yönteme nasıl aktaracağına karar verilir. 
En esnek yol, isteği bir nesneye dönüştürmek ve onu argüman olarak işleme yöntemine iletmektir.
Somut işleyicilerde yinelenen ortak metin kodunu ortadan kaldırmak için, işleyici arabiriminden türetilen 
soyut bir temel işleyici sınıfı oluşturmaya değer olabilir. Bu sınıf, zincirdeki sonraki işleyiciye bir başvuru depolamak için bir alana sahip olmalıdır. Sınıfı değişmez kılmayı düşünün. Bununla birlikte, zincirleri çalışma zamanında değiştirmeyi planlıyorsanız, referans alanının değerini değiştirmek için bir ayarlayıcı tanımlamanız gerekir.
Ayrıca, işleme yöntemi için uygun varsayılan davranışı da uygulayabilirsiniz; bu, istek kalmadıkça sonraki nesneye iletilir. Somut işleyiciler, üst yöntemi çağırarak bu davranışı kullanabilecektir.
Tek tek somut işleyici alt sınıfları oluşturulur ve işleme yöntemlerini uygulanır. 

Proje için:
İlk olarak projede arama kriterlerini giriyoruz. Arama kriterleri nesne olmalıdır. 
İstemcinin erişeceği ilk nesne zincirin ilk halkası.
 Bu nesnenin Ara metodu da bizden AramaKriteri nesnesini alacak ve sorumlu nesneye (zincirin sonraki halkasına) doğru aktaracak.
Bu durumda, zincirin tüm halkaları bir üst sınıftan türemelidir. 
Hatta her nesne uygun salon arama işini ayrı bir sunucu ile çalışacağına göre bu üst sınıf ve ara metodu abstract olmalıdır.
Bu sınıfa, ToplantiSalonRezervasyon adını veriyoruz.
 Zincirin her halkası, bir sonraki halkaya erişebileceğine göre, kendi tipinde bir özellik taşıması gerekiyor. 
Bu özelliğe de BirSonrakiSorumlu adını verdik. Nesnenin kendisinden bir sonraki nesneye veriyi aktarmasının en kolay yolu delege kullanmaktır.Çünkü, veri aktarılır aktarılmaz, söz konusu metodun anında tetiklenmesini istiyoruz.
Bu amaçla EventHandler generic delegesinden faydalanılır. Delegenin fırlatacağı metodu da oluşturmamız gerekir. Son olarak, delege ve metodu, ToplantiSalonRezervasyon sınıfının contstuctor’unda eşleştiririz.Bu yapıya göre eklediğimiz method delege çağırmaktadır.  Altındaki metodu da ToplantiSalonRezervasyon sınıfına ekleriz. Artık zincirimizin tüm halkalarını oluşturabiliriz. Burada önemli olan, her halkanın kendi sorumluluğunu bilmesidir. Eğer işlemi yapmaktan sorumlu değilse, ilgili veriyi bir sonraki halkaya fırlatması. Aslında bu halkaların arasında bir hiyerarşi de oluşturuluyor.
 Private static void main ile de sırayla üç halka nesnesi oluşturup, belirlenen sıraya göre birleştirilir. Program çalıştırıldığında zincirin halkasına talepte bulunulur ve çıktı gelir.

Hazırlayan: Cansu Karakuş