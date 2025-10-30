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

        Console.WriteLine("Sonuc: " + sonuc);
        }
    }
}

