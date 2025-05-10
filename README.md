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
- Responsive tasarım (mobil uyumlu)

---
 ## 📸 Ekran Görüntüleri
 
### 🔹 Anasayfa

![Homepage](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-10%20233710.png)
![Homepage](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-10%20233723.png)
![Homepage](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-10%20233730.png)
![Homepage](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-10%20233744.png)
![Homepage](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-11%20001134.png))
![Homepage](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-10%20233751.png)
![Homepage](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-10%20233758.png)

---

### 🔹 Rehberler

![Guides](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-10%20233816.png)

---

### 🔹 Rezervasyon Formu

![Booking](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-10%20233803.png)

---

### 🔹 Footer ve İletişim

![Footer](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-10%20233821.png)
![Footer](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-10%20233826.png)

---
### 🛠️ Admin Panel

- `Area` yapısı ile izole edilmiş admin bölgesi
- CRUD işlemleri:
  - Ülkeler 🇹🇷
  - Şehirler 🏙️
  - Rehberler 👨‍💼
  - Paketler 🎒
  - Turlar 🌍
  - Yorumlar 💬
  - Rezervasyonlar 📝
  - Hakkımızda & Footer 🧾
- Dashboard özelliği:
  - Toplam sayılar (ülke, şehir, rezervasyon vb.)
  - Son 5 rezervasyonun listesi
- ViewComponent destekli modüler yapı
- Katmanlı mimari

---
## 🛠️ Admin Paneli
## 📸 Ekran Görüntüleri
### 🔹 Dashboard Sayfası

> Genel istatistik kartları ve son 5 rezervasyon görünümü.

![Dashboard](https://github.com/Sevval-Demir/AcunMedyaTravelProject/blob/main/Screenshot%202025-05-10%20233834.png)

---
### 🔹 Hakkında (About)

![Abouts](Screenshot 2025-05-10 233841.png)

---

### 🔹 Ülke Yönetimi

![Countries](Screenshot 2025-05-10 233900.png)

---

### 🔹 Şehir Yönetimi

![Destinations](Screenshot 2025-05-10 233907.png)

---

### 🔹 Paket Yönetimi

![Packages](Screenshot 2025-05-10 233911.png)

---

### 🔹 Turlar

![Tours](Screenshot 2025-05-10 233923.png)


### 🔹 Yorumlar (Testimonials)

![Testimonials](Screenshot 2025-05-10 233918.png)

---
## 🛠 Kullanılan Teknolojiler

| Teknoloji             | Açıklama                                 |
|----------------------|------------------------------------------|
| ASP.NET Core MVC     | Web uygulama çatısı                      |
| Entity Framework Core| ORM ve Code First veri erişimi          |
| MS SQL Server        | Veritabanı yönetim sistemi               |
| Bootstrap 5          | Responsive UI                            |
| jQuery, Owl Carousel | Dinamik arayüz bileşenleri               |
| Razor View Engine    | .cshtml templating                       |
| ViewComponent        | Component tabanlı bölümler               |
| Areas                | Admin paneli için ayrı yapı              |

---
