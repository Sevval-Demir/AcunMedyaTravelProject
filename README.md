# 🌍 AcunMedya Travel Project

ASP.NET Core MVC ile geliştirilmiş olan **AcunMedya Travel**, bir turizm ajansı için hazırlanmış tam donanımlı bir web projesidir. Ziyaretçiler, turlar ve destinasyonlar hakkında bilgi alabilirken, admin panelinden içerikler dinamik olarak yönetilebilmektedir.

Bu proje, .NET ekosistemindeki önemli yapıların bir arada nasıl kullanılacağını ve katmanlı mimarinin nasıl kurulacağını açıkça göstermektedir.

---

## 🎯 Proje Hedefi

Turizm sektörü için dinamik, yönetilebilir ve kullanıcı dostu bir rezervasyon platformu oluşturmak. Bu platform hem son kullanıcıya hitap ederken hem de yöneticilere kolay bir kontrol paneli sunar.

---

### 👤 Ziyaretçi Paneli

- Anasayfa üzerinden:
  - Rehberler, destinasyonlar, paketler, bloglar
  - Dinamik slider alanı
- Rezervasyon formu ile kayıt oluşturma
- Footer’da sosyal medya, iletişim bilgileri ve özet menüler
- Responsive tasarım (Mobil uyumlu)

### 🛠️ Admin Panel

- `Area` yapısı ile ayrı admin yönetimi
- CRUD işlemleri:
  - Ülkeler 🇹🇷
  - Şehirler 🏙️
  - Rehberler 👨‍💼
  - Paketler 🎒
  - Turlar 🌍
  - Yorumlar 💬
  - Rezervasyonlar 📝
  - Hakkımızda & Footer içeriği 🧾
- Dashboard: Toplam veriler ve son 5 rezervasyon
- ViewComponent yapısıyla parçalanmış görsel katman

---

## 🛠 Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|----------|----------|
| ASP.NET Core MVC | Web uygulama çatısı |
| Entity Framework Core | ORM ve Code First veri erişimi |
| MS SQL Server | Veritabanı yönetim sistemi |
| Bootstrap 5 | Responsive UI |
| jQuery & Owl Carousel | Dinamik bileşenler |
| Razor View Engine | .cshtml templating |
| ViewComponent | Component tabanlı yapı |
| Areas | Admin bölgesi izolasyonu |

---


