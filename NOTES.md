# C# Eğitim Kampı 301 Modülü

## 🔹 OOP ve Çok Katmanlı Mimari

- OOP'ye giriş yaparak, **çok katmanlı mimari** kullanacağız.
- Bu yapı, **sınıf yapısını pekiştirmemizi**, kodun **sürdürülebilirliğini** artırmamızı ve hata yönetimini kolaylaştırmamızı sağlar.
- Kullanılacak **4 katman**:
  1. **EntityLayer**: Varlıkları (tablolar) barındırır.
  2. **DataAccessLayer**: Veritabanı işlemlerini kapsar.
  3. **BusinessLayer**: İş mantığı (logic) sorgulamaları yapılır.
  4. **Presentation/UI Layer**: Kullanıcıya gösterilecek işlemleri kapsar.
- **Her katman yalnızca kendisine tanımlanan işi yapacaktır.**

---

## 🛠 **Concrete ve Code First Yaklaşımı**

- **Concrete**: C#'ta genellikle somut ifadeler (sınıflar) için kullanılan bir klasör ismidir.
- **Code First**: SQL kullanmadan, doğrudan C# kodlarıyla veritabanı şemaları oluşturma yöntemidir.
- Örnek kullanım:
  - **Class**: Bir tabloyu temsil eder.
  - **Property**: Bir sütunu temsil eder.

---

## 🔐 **Erişim Belirleyicileri (Access Modifiers)**

| Belirleyici  | Açıklama |
|-------------|----------|
| `public` | Her yerden erişilebilir. |
| `private` | Sadece bulunduğu sınıftan erişilebilir. |
| `internal` | Sadece bulunduğu katmandan erişilebilir. |
| `protected` | Sınıf ve türetilen sınıflardan erişilebilir. |

---

## 🎯 **Field - Variable - Property Arasındaki Farklar**

- **Field**: Sınıf içinde tanımlanan değişken.
- **Property**: `get` ve `set` metodlarını içeren yapı.
- **Variable**: Bir metod içinde tanımlanan değişken.

---

## 🔍 **SOLID Prensipleri**

- **S**ingle Responsibility: Bir sınıfın yalnızca **tek bir sorumluluğu** olmalıdır.

---

## 🔗 **Katmanlar Arası Referanslama**

- Katmanlar, birbirine doğrudan bağımlı olmadan iletişim kurabilmelidir.
- **Referans ekleme** işlemi: `Add > Reference` üzerinden yapılır.

---

## 🔄 **Migration (Veri Taşıma)**

- **IDE'den SQL'e veri taşıma** yöntemidir.
- **Visual Studio**, SQL'de tabloların oluşturulması için **köprü görevi** görür.

---

## 🏗 **Abstract ve Interface Kullanımı**

- **Abstract**: Soyut sınıfları içerir.
- **Interface**: Arayüzler belirli işlevlerin nasıl olması gerektiğini tanımlar.

---

## 🏛 **Tasarım Desenleri (Design Patterns)**

- **Repository Tasarım Deseni**: CRUD işlemlerini merkezi hale getirir.
- **Amaç**: Kod tekrarını önleyerek, **daha modüler ve yönetilebilir bir yapı** oluşturmak.

---

## 🗄 **Entity Framework ve ORM Kullanımı**

- **Entity Framework**, SQL sorgularını doğrudan yazmadan veri yönetimini sağlar.
- **Code First vs. Database First:**
  - **Code First**: Tabloları kod üzerinden oluşturur.
  - **Database First**: Önceden oluşturulmuş veritabanı şemasını kullanır.

---

## 🔑 **Veritabanı İşlemleri**

- **Id sütunu** birincil anahtar olarak tanımlanmalıdır.
- Veritabanı değişiklikleri **`Update Model From Database`** ile güncellenmelidir.

---

## 👥 **Proje Analisti Kimdir?**

- Müşteri ile yazılımcılar arasında **köprü** görevi görür.

---

## 🏆 **Entity Framework Metotları**

| Metot | Açıklama |
|------|----------|
| `ToList()` | Tüm listeyi döndürür. |
| `SaveChanges()` | Veritabanına yapılan değişiklikleri kaydeder. |
| `MessageBox.Show()` | Kullanıcıya mesaj gönderir. |
| `Find(id)` | Verilen ID’ye sahip veriyi getirir. |
| `Remove()` | Veriyi siler. |

---

## 🏷 **LINQ Sorguları**

- `Where(x => x.Id == id).ToList();` kullanımı ile veritabanında filtreleme yapılabilir.

---

## ⌨ **Kullanışlı Kısayollar**

| İşlem | Kısayol |
|------|----------|
| **Toolbox Açma** | `Ctrl + Alt + X` |

---

## 📌 **Önemli Not**

`Average()` metodunun sonucunu `GetValueOrDefault()` ile işleyerek, eğer değer `null` ise `0.0` olarak döndürmek mümkündür:

```csharp
var ortalama = db.Students.Average(x => x.Grade).GetValueOrDefault().ToString("F2");
```

Bu sayede yalnızca **virgülden sonra iki basamak** gösterilir.

---

📌 **Bu notlar, C# Eğitim Kampı kapsamında alınmıştır.** 🎯

