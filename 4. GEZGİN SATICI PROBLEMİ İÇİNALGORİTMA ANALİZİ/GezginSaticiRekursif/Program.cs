using System;

class TravelingSalesmanProblem
{
    static int[,] graph = {
        {0, 10, 15, 20},
        {10, 0, 35, 25},
        {15, 35, 0, 30},
        {20, 25, 30, 0}
    };
    static int numCities = 4;

    static int[] visited = new int[numCities];
    static int[] minPath = new int[numCities + 1];
    static int minCost = int.MaxValue;

    static void TSP(int currentCity, int cost, int depth)
    {
        visited[currentCity] = 1;                                                                            // 1

        minPath[depth] = currentCity;                                                                       //1

        if (depth == numCities - 1)                                                                         // n-1
        {
            if (graph[currentCity, 0] != 0 && cost + graph[currentCity, 0] < minCost)    // 1
            {
                minCost = cost + graph[currentCity, 0];                                                    // n+1
                minPath[numCities] = 0;                                                                    // 1
                Array.Copy(minPath, 0, minPath, 0, numCities + 1);                                         // n
            }
        }
        else // O(n) 
        {
            for (int i = 0; i < numCities; i++)                                                          // 2n+1
            {
                if (visited[i] == 0 && graph[currentCity, i] != 0)                                       // 1
                {
                    TSP(i, cost + graph[currentCity, i], depth + 1);                                   // (n-1)!
                }
            }
        }

        visited[currentCity] = 0;                                                                       // 1
    }
                                                                                                     //Sonuc= n * (n-1)!


    static void Main(string[] args)
    {
        TSP(0, 0, 0);

        Console.WriteLine("Minimum Path:");
        for (int i = 0; i <= numCities; i++)
        {
            Console.Write(minPath[i] + " -> ");
        }
        Console.WriteLine("\nMinimum Cost: " + minCost);
    }
}
