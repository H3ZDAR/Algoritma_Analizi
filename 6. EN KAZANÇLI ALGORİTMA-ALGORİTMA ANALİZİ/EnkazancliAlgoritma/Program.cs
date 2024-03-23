using System;

namespace EnkazancliAlgoritma
{
    internal class Program
    {
        // Karatsuba Çarpma Algoritması
        public static long KaratsubaMultiply(long x, long y)
        {
            int size1 = GetNumberSize(x);
            int size2 = GetNumberSize(y);

            // Baz durum: Sayılar tek haneli ise çarpma işlemi yapılır
            if (size1 == 1 || size2 == 1)
                return x * y;

            // Sayıları yarıya bölme
            int n = Math.Max(size1, size2);
            int m = n / 2;

            // Sayıları parçalara ayırma
            long high1 = x / (long)Math.Pow(10, m);
            long low1 = x % (long)Math.Pow(10, m);
            long high2 = y / (long)Math.Pow(10, m);
            long low2 = y % (long)Math.Pow(10, m);

            // Üç farklı alt çarpma işlemi
            long z0 = KaratsubaMultiply(low1, low2);
            long z1 = KaratsubaMultiply((low1 + high1), (low2 + high2));
            long z2 = KaratsubaMultiply(high1, high2);

            // Sonucu birleştirme
            return (z2 * (long)Math.Pow(10, 2 * m)) + ((z1 - z2 - z0) * (long)Math.Pow(10, m)) + z0;
        }

        // Sayının basamak sayısını döndürme
        public static int GetNumberSize(long number)
        {
            return number.ToString().Length;
        }

        static void Main(string[] args)
        {
            long A = 2135;
            long B = 4014;

            long result = KaratsubaMultiply(A, B);
            Console.WriteLine("A * B = " + result);

            Console.ReadLine(); // Programın konsol ekranını kapatmaması için eklenen satır
        }
    }
}
