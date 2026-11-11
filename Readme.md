# PetroTakip
Akaryakıt istasyonu takip uygulaması (C# WinForms + SQL Server).

## Kurulum
1. SSMS'te `PetroTakip.sql` dosyasını açıp çalıştır.
2. `Projem/VeriTabani.cs` içindeki `Server=` değerini kendi SQL Server adınla değiştir.

// VERİTABANI BAĞLANTISI
public static string Baglanti =
    @"Server=Buraya-Kendi-Sunucunuzun-Adı;Database=PetroTakip;Integrated Security=True;TrustServerCertificate=True;";

    
3. Projeyi Visual Studio'da açıp çalıştır.
