İçerik: C dilinde yazılmış branchless kod örnekleri

Youtube Kanalımız: BMDersleri

Bağlantı: https://www.youtube.com/channel/UCIdYgV-XFjv9q0IHtzUTtQw

Kısa Bağlantı: https://bit.ly/32k9MnJ

Github Adresimiz: https://github.com/bmdersleri

Hazırlayan: Hayri Yiğit

Yazılım geliştiriken koşullu ifadeleri her zaman kullanırız. Ancak bu koşullu ifadeler program çalıştırıldığında çalışma akışını böler (branch -dal- oluşur). Modern işlemciler hangi talimatı çalıştıracaklarını tahmin ederler ve bu iyi bir optimizasyon yöntemidir ancak eğer tahmin yanlış olacak olursa yeniden tahmin yapılır ta ki doğru tahmin yapılana kadar.

Bu tahmin işlemi akışta gecikmelere  ve performans kaybına neden olabilir. Branchless programlama, programdaki bu branch'leri (dal) azaltan bir programlama teknigidir.
