using System;
using System.IO;

public class Program
{
    public const int INF = 30000; // Значення для недосяжних вершин

    public static int[] BellmanFord(int n, int[,] edges)
    {
        int[] dist = new int[n];
        Array.Fill(dist, INF); // Заповнюємо всі відстані INF
        dist[0] = 0; // Відстань від вершини 1 до себе - 0

        // N-1 разів релаксуємо всі ребра
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < edges.GetLength(0); j++)
            {
                int u = edges[j, 0] - 1; // Початок ребра
                int v = edges[j, 1] - 1; // Кінець ребра
                int weight = edges[j, 2]; // Вага ребра

                if (dist[u] != INF && dist[u] + weight < dist[v])
                {
                    dist[v] = dist[u] + weight;
                }
            }
        }

        return dist;
    }

    public static void Main(string[] args)
    {
        string inputPath = "D:\\CROSS_PLATFORM\\Lab3\\input.txt"; 

        // Якщо аргумент передано, використовуємо його як шлях до файлу
        if (args.Length > 0)
        {
            inputPath = args[0];
        }

        // Перевірка на існування файлу
        if (!File.Exists(inputPath))
        {
            Console.WriteLine($"Файл {inputPath} не знайдено. Переконайтеся, що він знаходиться в тій самій директорії.");
            Environment.Exit(1); // Вихід з помилкою
        }

        var input = File.ReadAllLines(inputPath);
        var firstLine = input[0].Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);

        int[,] edges = new int[m, 3];

        for (int i = 0; i < m; i++)
        {
            var edge = input[i + 1].Split();
            edges[i, 0] = int.Parse(edge[0]);
            edges[i, 1] = int.Parse(edge[1]);
            edges[i, 2] = int.Parse(edge[2]);
        }

        var result = BellmanFord(n, edges);
        File.WriteAllText("OUTPUT.TXT", string.Join(" ", result));
    }
}
