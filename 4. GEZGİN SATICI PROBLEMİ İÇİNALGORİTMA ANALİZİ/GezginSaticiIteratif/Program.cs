using System;

class GezginSaticiIteratif
{
    static int[,] distanceMatrix = {
        {0, 10, 15, 20},
        {10, 0, 35, 25},
        {15, 35, 0, 30},
        {20, 25, 30, 0}
    };

    static int cities = 4;
    static int[] visited;

    // Fonksiyon, verilen yolu ziyaret etmiş mi kontrol eder
    static bool AllVisited()
    {
        for (int i = 0; i < cities; i++)
        {
            if (visited[i] == 0)
                return false;
        }
        return true;
    }

    // Hesaplanmış yolları kontrol eder
    static int ComputePath(int[] path)
    {
        int pathDistance = 0;
        for (int i = 0; i < cities - 1; i++)
        {
            pathDistance += distanceMatrix[path[i], path[i + 1]];
        }
        pathDistance += distanceMatrix[path[cities - 1], path[0]]; // Geri dönüş yolunu ekler
        return pathDistance;
    }

    // Ana işlev
    public static void Main()
    {
        visited = new int[cities];
        int[] path = new int[cities];
        int minPath = int.MaxValue;

        for (int i = 0; i < cities; i++)
        {
            path[0] = i; // Başlangıç noktası
            visited[i] = 1; // Ziyaret edildi olarak işaretle
            int currentPath = TSP(path, 1); // Minimum yol bul
            visited[i] = 0; // Ziyaret işaretini geri al
            minPath = Math.Min(minPath, currentPath);
        }

        Console.WriteLine("Minimum Path Weight: " + minPath);
    }

    // Geri izleme algoritması
    static int TSP(int[] path, int level)
    {
        if (level == cities && AllVisited())                              // n
        {
            return ComputePath(path);                                      // n
        }

        int minPath = int.MaxValue;                                        // 1

        for (int i = 0; i < cities; i++)                                   // n
        {
            if (visited[i] == 0) // 1
            {
                visited[i] = 1; // 1
                path[level] = i; // 1
                minPath = Math.Min(minPath, TSP(path, level + 1));         // n!
                visited[i] = 0;                                            // 1
            }
        }

        return minPath;                                                     // 1
    }                                                                       //Sonuç= O(n!)
}
