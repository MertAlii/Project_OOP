# Project_OOP
<img width="1279" height="553" alt="Ekran görüntüsü 2025-07-29 191633" src="https://github.com/user-attachments/assets/c5b2e024-6e8b-4ba2-88e2-2648cb0ef89b" />
<img width="1279" height="509" alt="Ekran görüntüsü 2025-07-29 191643" src="https://github.com/user-attachments/assets/aed52fb9-a43a-4564-8378-8d89f3131b3d" />
<img width="1279" height="508" alt="Ekran görüntüsü 2025-07-29 191651" src="https://github.com/user-attachments/assets/182e79a4-0945-4ed6-ba2f-1ea03327f1ec" />
<img width="1279" height="506" alt="Ekran görüntüsü 2025-07-29 191656" src="https://github.com/user-attachments/assets/667f22d5-224e-4268-b531-dd956342e299" />

## Hakkında

Bu proje, Murat Yücedağ'ın Udemy'deki **C# İLE OOP TEMELLERİ: ADIM ADIM KATMANLI MİMARİ** isimli kursunu takip ederek geliştirdiğim bir uygulamadır. Temel olarak ASP.NET Core MVC ve Entity Framework Core kullanarak müşteri ve ürün yönetimi işlemlerini (ekle, listele, güncelle, sil) gerçekleştirmeyi amaçlıyor. Kodlar ve mimari tamamen kursun anlatımına uygun şekilde, adım adım ilerleyerek yazılmıştır. Kendi öğrenme sürecimde hem pratik yapmak hem de OOP ve katmanlı mimariyi daha iyi kavramak için bu projeyi oluşturdum.

## Proje Hakkında

Project_OOP, ASP.NET Core MVC ve Entity Framework Core kullanılarak geliştirilmiş, temel müşteri ve ürün yönetimi sağlayan bir web uygulamasıdır. Kullanıcılar ürün ve müşteri ekleyebilir, listeleyebilir, güncelleyebilir ve silebilirler. Proje, temel CRUD (Create, Read, Update, Delete) işlemlerini örneklemek amacıyla hazırlanmıştır.

## Kullanılan Teknolojiler

- .NET 8.0
- ASP.NET Core MVC
- Entity Framework Core 9
- SQL Server
- Bootstrap

## Kurulum ve Çalıştırma

1. **Gereksinimler:**
   - .NET 8 SDK
   - SQL Server (veya uyumlu bir veritabanı)
2. **Veritabanı Ayarları:**
   - `Project_OOP/Project_OOP/ProjeContext/Context.cs` dosyasında bağlantı dizesini kendi veritabanı sunucunuza göre güncelleyin.
3. **Migration ve Veritabanı Oluşturma:**
   - Terminalde proje dizinine gelin:
     ```
     cd Project_OOP/Project_OOP
     dotnet ef database update
     ```
4. **Projeyi Başlatma:**
   ```
   dotnet run
   ```
   veya Visual Studio ile F5 tuşuna basarak çalıştırabilirsiniz.

## Ana Özellikler

- Müşteri Yönetimi: Müşteri ekleme, listeleme, güncelleme ve silme.
- Ürün Yönetimi: Ürün ekleme, listeleme, güncelleme ve silme.
- Kategori Modeli: (Şu an sadece entity olarak mevcut, arayüzde kullanılmıyor.)
- Örnek Sayfalar: DefaultController ile örnek ViewBag, ViewData ve temel C# fonksiyonlarının kullanımı.

## Veri Modelleri

### Customer
```csharp
public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerSurname { get; set; }
    public string CustomerCity { get; set; }
}
```

### Product
```csharp
public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductStock { get; set; }
}
```

### Category
```csharp
public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
```

## Sayfa Akışı

- Ana Sayfa: Menüden Ürünler, Müşteriler ve Deneme sayfalarına geçiş.
- Ürünler: Ürün listesi, yeni ürün ekleme, silme ve güncelleme işlemleri.
- Müşteriler: Müşteri listesi, yeni müşteri ekleme, silme ve güncelleme işlemleri.
