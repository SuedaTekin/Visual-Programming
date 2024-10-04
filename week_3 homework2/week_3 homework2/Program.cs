using System;

class Program
{
    // Topla_Carp fonksiyon işlemi
    static void Topla_Carp(int a, int b, out int add, out int mult)
    {
        add = a + b;
        mult = a * b;
    }

    static void Main()
    {
        int a = 5;
        int b = 3;
        int topla;
        int carp;

        // Topla_Carp fonksiyonunu çağırma işlemi
        Topla_Carp(a, b, out topla, out carp);

        // Hesaplanan değerleri ekrana yazdırma işlemi
        Console.WriteLine("Toplam: " + topla);
        Console.WriteLine("Çarpım: " + carp);
    }
}

