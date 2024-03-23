using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ondalık sayıyı girin:");
        int ondalikSayi = int.Parse(Console.ReadLine());

        string ikiliSayi = "";					    // 1
        while (ondalikSayi > 0)				        // n
        {
            int kalan = ondalikSayi % 2;			// 1
            ikiliSayi = kalan + ikiliSayi;			// 1
            ondalikSayi /= 2;					    // 1
        }							                //n+4

        Console.WriteLine("İkili sayı: " + ikiliSayi);
    }
}