# Borsa-Projesi-Final
Final sınavı için oluşturulan borsa projesi (Database kullanılmadı)

#### Proje İsterleri
- UserStory-5 (Alıcı bir fiyat belirleyebilecek eğer istediği fiyattan satan kişi olmaz ise işlem gerçekleşmeyecek. İşlem ancak alıcının verdiği fiyattan ürün satan bir kişi olana kadar bekleyecek.) 
- UserStory-6 (Kullanıcı seçtiği tarih aralığında yaptığı alış ve/veya satışlara ilişkin bir rapor oluşturabilecek (Oluşturulan rapor [.csv yada .xlsx yada .dat yada.pdf] uzantılı bir formatta dönüştürülecek.) 
-	UserStory-7 (Alıcı sisteme sadece TL değil farklı para tiplerinden de yükleme yapabilecek. Yüklenen bu tutar adminin onay verdiği tarihteki döviz kuru üzerinden Tl’ye çevrilerek sisteme aktarılacak.) (.Json/.Xml/vb bir yerden veri seçilebilir.) En az 3 para birimi sistem tarafından kabul edilsin (Örnek sterlin, İsviçre frank, Euro).
-	UserStory-8 (Muhasebe_kullanıcısı aracılık ücreti yüzde 1 olsun ve bu tutar alıcıdan tahsil edilsin.)

##### ->
UserStory-5 için satın alma ekranına filtreleme özelliği konuldu (Veritabanı ile yapılmadığı için pasif bir ekran oldu.) ve istenilen şekilde alış emri vermek için form oluşturuldu. Alış emirleri kullanıcı girişinden görünebilecek ve emir işlemi yapılabilecektir. UserStory-6 için kullanıcı formuna işlemler kısmı yapıldı kullanıcının aldığı veya sattığı ürünleri excele aktarabilecek. UserStory-7 için admin formuna anlık döviz kuru panosu eklendi. Sistem 5 tane döviz bulunmakta.  Para onayı kısmından hem tl hem döviz yüklemesi görünebilecek. UserStory-8 için ürün al kısmında alınan ürün için komisyon ücreti kesildi komisyon hem admin hem de kullanıcı formlarında görünebiliyor.

