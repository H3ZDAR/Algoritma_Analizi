using System;

namespace RecursiveMaxNumber
{
    class Program
    {
        static int enbuyuk(int[] arr, int n)
        {
            if (n == 1)                                         //1
                return arr[0];                                  //1

            return Math.Max(arr[n - 1], enbuyuk(arr, n - 1));   //n
        }                                                       //n+2     

        static void Main(string[] args)
        {
            int[] myArray = { 10, 5, 20, 15, 30, 40, 10, 60, 75, 1, 35, 24, 98, 14, 41 };
            int result = enbuyuk(myArray, myArray.Length);

            Console.WriteLine($"Dizideki en büyük sayı: {result}");
        }
    }
}
