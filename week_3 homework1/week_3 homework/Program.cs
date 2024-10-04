using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Kullanıcı bilgilerini tutan sınıf işlemi
    class Kullanici
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public int Yas
        {
            get
            {
                DateTime now = DateTime.Now;
                int yas = now.Year - DogumTarihi.Year;
                if (now < DogumTarihi.AddYears(yas)) yas--;
                return yas;
            }
        }
    }

    static void Main()
    {
        // Kullanıcı bilgilerini içeren liste işlemi
        List<Kullanici> kullanicilar = new List<Kullanici>
        {
            new Kullanici { Ad = "SENA", Soyad = "YANLIŞ", DogumTarihi = new DateTime(1956, 5, 12) },
            new Kullanici { Ad = "Ayşe", Soyad = "ÖZYILMAZ", DogumTarihi = new DateTime(1973, 3, 22) },
            new Kullanici { Ad = "Mehmet", Soyad = "GÜÇLÜ", DogumTarihi = new DateTime(2000, 7, 5) },
            new Kullanici { Ad = "Fatma", Soyad = "ÇELİKER", DogumTarihi = new DateTime(1995, 11, 15) },
            new Kullanici { Ad = "Ali", Soyad = "ÖZTÜRK", DogumTarihi = new DateTime(1988, 1, 30) },
            new Kullanici { Ad = "Zeynep", Soyad = "AYNEN", DogumTarihi = new DateTime(1992, 4, 10) },
            new Kullanici { Ad = "Murat", Soyad = "TABAKA", DogumTarihi = new DateTime(1980, 9, 25) },
            new Kullanici { Ad = "Selin", Soyad = "YANLIŞ", DogumTarihi = new DateTime(1965, 2, 18) },
            new Kullanici { Ad = "Emre", Soyad = "KEMAL", DogumTarihi = new DateTime(2002, 6, 3) },
            new Kullanici { Ad = "Hale", Soyad = "BULUN", DogumTarihi = new DateTime(1983, 12, 7) }
        };

        // Kullanıcıları yaşlarına göre küçükten büyüğe sıralama işlemi
        var siraliKullanicilar = kullanicilar.OrderBy(k => k.Yas).ToList();

        // Sıralanmış kullanıcı bilgilerini ekrana yazdırma işlemi
        foreach (var kullanici in siraliKullanicilar)
        {
            Console.WriteLine($"Ad: {kullanici.Ad}, Soyad: {kullanici.Soyad}, Yaş: {kullanici.Yas}");
        }
    }
}
