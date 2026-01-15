# Kütüphane Yönetim Sistemi (N-Katmanlı Mimari)

Bu proje, **N-Tier Architecture (N-Katmanlı Mimari)** prensipleri kullanılarak geliştirilmiş profesyonel bir kütüphane yönetim sistemidir. C# WinForms arayüzü ve MySQL veritabanı entegrasyonu ile modüler ve sürdürülebilir bir yapı sunar.

Mimari Katmanlar
  Proje, kod tekrarını önlemek ve bakımı kolaylaştırmak için üç temel katmana ayrılmıştır:
  Business (Service): İş kurallarının ve veri doğrulamaların (Validation) yapıldığı katman (Örn: `KitapService.cs`).
  Data Access (DAL): SQL sorgularının ve veritabanı işlemlerinin yönetildiği katman (Örn: `KitapDAL.cs`).
  Domain (Entities):Veritabanı tablolarının nesne karşılıklarının bulunduğu katman.

Temel Özellikler
  CRUD İşlemleri: Kitap ve Üye ekleme, silme, güncelleme ve listeleme.
  Veri Doğrulama: Boş alan kontrolü ve hatalı veri girişi engelleme işlemleri Service katmanında yapılır.
  MySQL Entegrasyonu: Veriler ilişkisel veritabanında güvenli bir şekilde saklanır.

Kullanılan Teknolojiler
  Dil: C# (.NET Framework / .NET 8)
  Veritabanı: MySQL
  Mimari: N-Tier Architecture
