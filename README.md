Proje amacı:Proje, .NET kullanılarak geliştirilmiş basit bir hisse senedi takip API’sidir.
Kullanıcıların anlık hisse verilerini çekmesini, veritabanına kaydetmesini ve fiyat değişimlerini gözlemlemesine yardımcı olur.

Projede kullanılan API **Finnhub API** sitesinden alınıp, kullanılmıştır.
Kod yapısı Controller, Service, Model ve Data katmanları olarak ayrılmıştır.

Veritabanı kısmı:Hisse verileri aşağıdaki alanlarla saklanmıştır:
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


Bu projede **Service Pattern** kullanılmıştır.StockService sınıfı eklenmiş, dış API ile iletişimi controller’dan ayırmak için oluşturulmuştur.  
Bu sayede controller daha sade kalarak kodun daha düzenli olmasını sağlamıştır.

Kurulum için proje indirildikten sonra **VİSUAL STUDİO** kullanarak ".sln" dosyasını açınız. 
Çalıştırmak için kodlarda yorum satırıyla işaretlenmiş kısımdaki API KEY’i değiştiriniz.
 
