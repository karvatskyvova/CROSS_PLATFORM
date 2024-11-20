using System;
using System.IO;

public class Program
{
    public static string[]? rules; 

    public static void Main(string[] args)
    {
        if (!File.Exists("D:\\CROSS_PLATFORM\\Lab2\\input.txt"))
        {
            Console.WriteLine("Помилка: файл INPUT.TXT не знайдено.");
            return;
        }

        string[] input = File.ReadAllLines("D:\\CROSS_PLATFORM\\Lab2\\input.txt");
        rules = input[..6];  

        string[] command = input[6].Split();
        char direction = command[0][0];
        int parameter = int.Parse(command[1]);

        int moves = CalculateMoves(direction, parameter);
        File.WriteAllText("OUTPUT.TXT", moves.ToString());
    }

    public static int CalculateMoves(char direction, int param)
    {
        if (rules == null)
        {
            throw new InvalidOperationException("Правила не завантажені.");
        }

        if (param == 1) return 1;

        int moves = 1;
        string rule = rules["NSWEUD".IndexOf(direction)];

        foreach (char cmd in rule)
        {
            moves += CalculateMoves(cmd, param - 1);
        }
        return moves;
    }
}
