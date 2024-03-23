using System;

class MatrixMultiplication
{
    static void Main()
    {
        Console.WriteLine("Matris Boyutunu Girin (n x n):");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] matrix1 = new int[n, n];
        int[,] matrix2 = new int[n, n];
        int[,] result = new int[n, n];

        Console.WriteLine("İlk Matrisin Elemanlarını Girin:");
        InputMatrix(matrix1);

        Console.WriteLine("İkinci Matrisin Elemanlarını Girin:");
        InputMatrix(matrix2);

        MultiplyMatrices(matrix1, matrix2, result);

        Console.WriteLine("Matris Çarpımı:");
        PrintMatrix(result);
    }

    static void InputMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = Convert.ToInt32(values[j]);
            }
        }
    }

    static void MultiplyMatrices(int[,] matrix1, int[,] matrix2, int[,] result)
    {
        int n = matrix1.GetLength(0);
        for (int i = 0; i < n; i++)                                                 // 1 + n + 1 + n = 2n + 2
        {
            for (int j = 0; j < n; j++)                                             // 1 + n + 1 + n = 2n + 2
            {
                for (int k = 0; k < n; k++)                                         // 1 + n + 1 + n = 2n + 2
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];                  // 1 
                }                                                                   //(2n+2)^3+1
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
