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
        MultiplyMatricesRecursive(matrix1, matrix2, result, n, 0, 0, 0);
    }

    static void MultiplyMatricesRecursive(int[,] matrix1, int[,] matrix2, int[,] result, int n, int row, int col, int idx)
    {
        if (idx >= n)                                                                       //n
            return;                                                                         //1                                                   

        if (col >= n)                                                                       //n                
        {
            col = 0;                                                                        //1                             
            row++;                                                                          //1
        }

        if (row >= n)                                                                       //n
            return;                                                                         //1

        int sum = 0;
        for (int i = 0; i < n; i++)                                                         //1+n-1+n =2n
        {
            sum += matrix1[row, i] * matrix2[i, col];                                       //n * n = n^2
        }

        result[row, col] = sum;                                                             //1

        MultiplyMatricesRecursive(matrix1, matrix2, result, n, row, col + 1, idx + 1);      // 1
    }                                                                                       //5n + n^2 + 6

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
