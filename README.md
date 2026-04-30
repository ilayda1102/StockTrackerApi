Proje amacı: Bu proje, **.NET** kullanılarak geliştirilmiş basit bir hisse senedi takip API’sidir.
Bu projeyi geliştirirken amacım sadece çalışan bir API oluşturmak değil, aynı zamanda okunabilir ve sürdürülebilir bir yapı kurmaktı.
Bu nedenle controller, service ve veri katmanlarını ayırarak daha düzenli bir yapı oluşturmaya dikkat ettim.
Gerçek zamanlı verileri Finnhub API üzerinden çekip veritabanına kaydeden ve fiyat değişimlerini analiz eden bir yapı kurdum. 
Kullanıcılar bu sayede hem anlık verilere ulaşabilir, hem de geçmiş veriler üzerinden değişimleri gözlemleyebilir.
Kod yapısını daha düzenli tutmak için Service Pattern kullanarak dış API ile iletişimi controller’dan ayırdım. 
Bu sayede projenin daha anlaşılır ve geliştirilebilir olmasını hedefledim.

Projede kullanılan API **Finnhub API** sitesinden alınıp, kullanılmıştır.
Kod yapısı Controller, Service, Model ve Data katmanları olarak ayrılmıştır.

Hisse verileri aşağıdaki alanlarla(Veritabanı) saklanmıştır:
  - Symbol
  - CurrentPrice
  - HighPrice
  - LowPrice
  - OpenPrice
  - PreviousClosePrice
  - CreatedAt

Projenin özellikleri:
  - Anlık Hisse Verisi Getirme
  - Hisse Verisini Kaydetme
  - Kayıtlı Verileri Listeleme
  - Fiyat Değişim Analizi


Bu projede **Service Pattern** kullanılmıştır. StockService sınıfı eklenmiş, dış API ile iletişimi controller’dan ayırmak için oluşturulmuştur.  
Bu sayede controller daha sade kalarak kodun daha düzenli olmasını sağlamıştır.

Kurulum için proje indirildikten sonra **VİSUAL Studio** kullanarak ".sln" dosyasını açınız. 
Çalıştırmak için kodlarda yorum satırıyla işaretlenmiş kısımdaki API KEY’i değiştiriniz.
