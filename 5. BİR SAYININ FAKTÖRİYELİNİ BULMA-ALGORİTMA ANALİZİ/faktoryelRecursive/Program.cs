using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Başla");
        Console.WriteLine("2. Bir sayı al");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("3. 'faktoriyelRecursive' adında bir değişken oluştur ve metodu çağır");

        
        Console.WriteLine("Recursive Çözüm:");
        int faktoriyelRecursive = FaktoriyelRecursive(sayi);
        Console.WriteLine($"Faktöriyel: {faktoriyelRecursive}");

        Console.WriteLine("6. Bitir");
    }

    
    static int FaktoriyelRecursive(int n)
    {
        if (n <= 0) 											    //  n
            return 1; 										        // 1
        else
            return n * FaktoriyelRecursive(n - 1); 					// n-1
    }													            // 2n
}
