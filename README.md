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
