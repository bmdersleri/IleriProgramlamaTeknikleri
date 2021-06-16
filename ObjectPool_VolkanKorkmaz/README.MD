# Object Pool (Nesne havuzu) Deseni
Object Pool Örnek Kodları
| | |
|-----|-----|
| Konu Anlatım Videosu | https://youtu.be/ul6WaGugA1s |
| BMDersleri   | https://www.youtube.com/bmdersleri |
| Github Adresimiz   | https://github.com/bmdersleri | 
| Hazırlayan   | Volkan KORKMAZ | 


Object Pool Tasarım Deseni,tekrarlı kullanılan nesnelerin üretim ve imha süreçlerinde meydana gelen maliyetlerin minimize edilmesi için üretilen nesnenin bir kaynakta/alanda/havuzda tutulması üzerine geliştirilmiş bir tasarım desenidir.

Object Pool, dağıtık sistemlerde veya yazılımlarda geliştirici tarafından yönetilmesi zor olan nesnelerde kullanılabilecek bir tasarım desenidir. Creational(Yaratıcı, nesnelerin oluşturulmasına yönelik) desenler içerisinde yer almaktadır. İstenilen nesnelerin sürekli olarak üretilmesi yerine, başlangıçta bir havuz oluşturulur ve bu havuz nesneler ile doldurulur. 

Projelerimizde sınıfların oluşturulması veya bellekten gereksiz yer ayırma(allocation) durumlarında performans sorunları ortaya çıkabilmektedir.Bu tür performans sorunlarını çözmek için sınıfların yeniden oluşturulmasını engellemek bir çözüm olabilir.Bunun için de Object Pool kullanılır.Ayrıca, .NET Framework SQL Connection üzerinde Object Pool kullanılmaktadır.
