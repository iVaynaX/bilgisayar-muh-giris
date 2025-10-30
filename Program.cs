using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayiyi gir: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ikinci sayiyi gir: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nİşlemi seç:");
        Console.WriteLine("1 - Toplama");
        Console.WriteLine("2 - Çıkarma");
        Console.Write("Seçimin: ");
        int secim = Convert.ToInt32(Console.ReadLine());
        if (secim == 1)
         {
         sonuc = Topla(sayi1, sayi2);
          Console.WriteLine($"\nSonuç: {sayi1} + {sayi2} = {sonuc}");
         }
         else if  (secim == 2)
       {
        sonuc = Cikar(sayi1, sayi2);
        Console.WriteLine($"\nSonuç: {sayi1} - {sayi2} = {sonuc}");
       }
        else if (secim == 3){
        double sonuc = a * b;

        else if (secim==4){
            if (sayi2 == 0)
            {
                Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
                islemYapildi = false; // Hata oldu, işlem yapılmadı
            }
            else
            {
                sonuc = sayi1 / sayi2;
                Console.WriteLine($"\nSonuç: {sayi1} / {sayi2} = {sonuc}");
            }
        }    

        Console.WriteLine("Sonuc: " + sonuc);
        }
    }
}


