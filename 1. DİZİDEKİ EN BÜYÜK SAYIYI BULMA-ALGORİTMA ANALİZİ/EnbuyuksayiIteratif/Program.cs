using System;

namespace Iterativenumara
{
    class Program
    {
        static int enbuyuk(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("Dizi boş olamaz.");
            }

            int numara = arr[0];                    //1

            for (int i = 1; i < arr.Length; i++)    // 1  n-1  n
            {
                if (arr[i] > numara)                //n
                {
                    numara = arr[i];                //n
                }
            }

            return numara;                          //1
        }                                           //1+1+n-1+n+n+n+1 = 4n+2    

        static void Main(string[] args)
        {
            int[] myArray = { 12, 25, 2, 15, 36, 42, 10, 60, 3, 1, 53, 42, 102, 1, 81 };
            int result = enbuyuk(myArray);

            Console.WriteLine($"Dizideki en büyük sayı: {result}");
        }
    }
}
