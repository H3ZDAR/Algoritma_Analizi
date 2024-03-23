using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Başla");
        Console.WriteLine("2. Bir sayı al");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("3. 'faktoriyel' adında bir değişken oluştur ve 1 ile başlat");
        int faktoriyel = 1;

      
        Console.WriteLine("Iteratif Çözüm:");
        for (int i = 1; i <= sayi; i++)						    //1+n+1 +n
        {
            faktoriyel *= i; 									// n+1
        }											            //3n+3
        Console.WriteLine($"Faktöriyel: {faktoriyel}");

        Console.WriteLine("6. Bitir");
    }
}
