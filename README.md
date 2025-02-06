C# Eğitim Kampı 301 Modülü

// Bu bölümde OOP' ye giriş yapacağız, verimlilik açısından çok katmanlı mimari kullanacağız.
// Çok katmanlı mimari kullandığımızda sınıf yapısını daha iyi pekiştirmiş olacağız.
// Bu projemizde 4 katmandan oluşan bir mimari kullanacağız.
// Çok katmanlı mimari kullanımı kodun sürdürülebilirliğini arttırır, hata yönetimini kolaylaştırır, işlerin daha modüler yapılmasını sağlar böylelikle hem ekip hem de bireysel olarak projenin geliştirilmesi kolaylaşır.
// 1. Katman = EntityLayer : Projeye ait entityler tanımlanacak. Varlıkları (ör: tablolar) barındırır.
// 2. Katman = DataAccessLayer : Proje ile ilgili veritabanı işlemlerini kapsayacak.
// 3. Katman = BusinessLayer : Logic sorgulamaları yapılacak.
// 4. Katman = Presentation / UI Layer (Kullanıcı Arayüzü Katmanı) : Yapılan işlemlerin kullanıcıya gösterilecek olan bölümü kapsayacak.
// Oluşturduğumuz her bir katman sadece kendisine tanımlanan işi yapacak.
// Projeye yeni bir katman eklerken - Class Library (.NET Framework) - seçilir.

// Sınıflar, programlamada 

// Concrete : C#' ta genellikle somut ifadeler (Sınıflar) için kullanılan bir klasör ismidir. 
// Veritabanı işlemlerimizi sql kullanarak değil, c# üzerinde gerçekleştireceğiz.

// Code First : Veritabanı şemalarının oluşturulması gibi işlemlerde sql kullanmadan doğrudan C# kısmında kod ile oluşturulmasıdır. Bu yaklaşımda değerler veritabanına gönderilirken property olarak gönderilmesi gerekir.


// Oluşturduğumuz sınıflar örneğin Category sınıfı sadece kategori tablosuna ait değerleri tutacak. Tabloya ait tüm sütunların karşılığı bu sınıfta duracak.

Class --> Tablo'yu Temsil edecek.
Property --> Column'u temsil edecek.

// Access Modifiers : Erişim belirleyicileridir. Oluşturulan metodların kimler tarafından erişileceği veya erişilemeyeceğinin belirlendiği ve bir kısıtlama uygulanan değerdir. 

4 temel erişim belirleyici (Accsess Modifiers)
------------------------------------------------
public : Her yerden erişilebilir.
private : Sadece bulunduğu sınıftan erişilir, diğer sınıflar tarafından erişilemez.
internal : Sadece bulunduğu katmanda erişim sağlanır.
protected: Bir sınıf ve o sınıfa miras alan yerlerden erişim sağlanır.


// Field - Variable- Property arasındaki farklar: 
// ör: int x şeklindeği bir değişken direkt olarak sınıf içinde tanımlanırsa Field , eğer değişken yapısı sonuna get ve set isimli iki değer alırsa Property, eğer değer direk metot içinde tanımlanırsa Veriable(Değişken) olur. 


SOLID PRENSİPLERİ
-------------------
Single Responsibility: SOLID prensipleri içinde bulunur, tek sorumluluk ilkesidir bağlı bulunduğu alanda sadece tek bir işlem yapmalıdır. Her bir sınıfın yalnızca o sınıfla ilgili olan bir sorumluluğa sahip olması gerektiğini belirtir.

--------------------------------
Referanslar: Uygulamadaki katmanlar birbirini referans edebilecek. Her katman birbiriyle haberleşiyor olacak ama bunun için tüm katmanları görmesine gerek kalmayacak çünkü bir önceki üst katmandan referans almış olacak.
Projeye referans verebilmek için add kısmından Referans seçilir ve hangi katmanın seçileceği belirlenir sonrasında seçilen katman referans olarak ilgili projeye eklenir.

----------------------
Migration : Göç anlamına gelir, ide den SQL'e database oluşturup değer taşıyacağımız (göç ettireceğimiz) bir yaklaşımdır. Visual Studio, sql'de tablonun oluşturulması için köprü görev görür.

------------------------------
Abstract : İçinde interface'leri barındıracak. Soyut anlamına gelir. Somut olmayan, fiziksel olarak var olmayan, ancak düşünsel olarak var olan şeyleri ifade eder.

Interface: Arayüz anlamına gelir. Belirli işlevlerin nasıl olması gerektiğini belirten, ancak bu işlevlerin nasıl gerçekleştirileceğini belirtmeyen yapılar.

---------------------------------------
Tasarım Deseni Nedir : yazılım geliştirmede karşılaşılan yaygın problemleri çözmek için güçlü araçlardır. Bu desenler, yazılımın daha esnek, sürdürülebilir ve okunabilir olmasını sağlar.
Repository Tasarım Deseni: Veri erişim işlemlerinin daha yapılandırılmış ve yönetilebilir olmasını sağlar. Crud işlemlerini (ekleme, silme, güncelleme ve listeleme işlemleri) veya ıd'ye göre getirme işlemlerini merkezileştirir. bu işlemleri her bir entity için tekrar tekrar yazmak yerine ortak bir yapı sunar.
-----------------------------------------
Entity Framework: .NET uygulamalarında veri erişimini ve yönetimini kolaylaştıran bir nesne-ilişkisel eşleme (ORM) frameworküdür. Entity Framework, geliştiricilere veritabanı işlemlerini nesneler üzerinden yapma imkânı sağlar, böylece SQL sorgularını yazma zorunluluğunu ortadan kaldırır.

Database First: Veritabanı şemasını manuel olarak oluşturmak yerine, otomatik olarak oluşturulan modellerle kolayca entegre olabilir ve veri erişimini sağlayabilirsiniz.

------------
Tablonun Id sütununun key değerinin alınabilmesi için modelimize yansıtırken kesinlikle birincil anahtar olarak belirlenmesi gerekir.

Veritabanında yapılan işlemler model üzerinde sağ tıklayıp Update Model From Database aracılığıyla güncellenmeli ve yapılan işlem modele aktarılmalıdır. Veritabaında her bir değişiklik yaptıktan sonra bunu modele yansıtmak zorundayız.

-------------
Proje Analisti : Müşterinin istekleri ve yazılımcı arasında bir köprü görevi görür.


Entity Framework Metotları:
ToList(); = Tüm listeyi döndürür.
SaveChanges(); = yapılan işlemleri veritabanına kaydeder.
MessageBox.Show(""); = Kullanıcıya mesaj gönderir.
Find(...); = belirtilen değere göre o satırın hepsini seçer. Ör: Find(id); id değerinin olduğu tüm sütunu seçer.
Remove(); belirtilen değeri siler.
Entity Frameworkte where şartları, Lambda Expression olarak tanımlanır. verilen şart öylek
