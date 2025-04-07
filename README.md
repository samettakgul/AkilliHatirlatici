# Akıllı Hatırlatıcı Mobil Uygulaması

Akıllı Hatırlatıcı, günlük görevlerinizi zamanında tamamlamanızı sağlamak amacıyla geliştirilmiş, kullanıcı dostu bir mobil uygulamadır. Xamarin.Forms ile geliştirilmiş ve veriler Supabase üzerinden yönetilmektedir.

---

## ✨ Özellikler

- Hatırlatma ekleme (Başlık, açıklama, tarih ve saat)
- Hatırlatma listesi görüntüleme
- Hatırlatma silme ve düzenleme
- Supabase ile bulut veri senkronizasyonu
- Kullanıcı dostu arayüz tasarımı

---

## 📄 Kullanılan Teknolojiler

- Xamarin.Forms (.NET Standard)
- C# Programlama Dili
- Supabase (PostgreSQL + Realtime)
- XAML (UI tasarım dili)

---

## ⚡ Kurulum

1. Bu depoyu klonlayın:
   ```
   https://github.com/samettakgul/AkilliHatirlatici
   ```

2. Visual Studio 2022 ile projeyi açın.

3. Gerekli NuGet paketlerini yükleyin:
   - Supabase
   - Postgrest
   - Newtonsoft.Json

4. SupabaseService.cs içinde kendi Supabase URL ve Anon Key'inizi girin:
   ```csharp
   client = new Supabase.Client(
       "(https://dvrmquvlklcifypsvoqr.supabase.co)",
       "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImR2cm1xdXZsa2xjaWZ5cHN2b3FyIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDM3ODk0MzksImV4cCI6MjA1OTM2NTQzOX0._ZunGYDtrsBu8ztPdmGUG3evInQUhV4NI_lsO7dNi-c",
       new Supabase.SupabaseOptions { AutoConnectRealtime = true });
   ```

5. Emülatör ya da fiziksel cihaz seçerek uygulamayı çalıştırın (F5).

---
## 👤 Geliştirici

- **Ad Soyad**: Samet AKGÜL
- **Eğitim**: Ayancık Meslek Yüksek Okulu/İnternet ve Ağ Teknolojileri 2
- **E-posta**: sametakgul154@gmail.com

---

## 🎉 Teşekkürler

Bu projeyi destekleyen herkese teşekkür ederiz!

---

© 2025 Akıllı Hatırlatıcı. Tüm hakları saklıdır.

