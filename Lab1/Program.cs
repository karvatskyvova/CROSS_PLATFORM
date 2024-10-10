using System;
using System.IO;

namespace Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Читання вхідних даних з INPUT.TXT
            string[] input = File.ReadAllLines("Lab1\\INPUT.TXT");
            int N = int.Parse(input[0].Split()[0]);
            int K = int.Parse(input[0].Split()[1]);

            // Підрахунок кількості рядків у максимальному ненадмірному наборі
            long maxStrings = (long)Math.Pow(K, N);

            // Кількість можливих ненадмірних наборів - за умовою, це 1
            long maxSets = 1;

            // Запис результату у файл OUTPUT.TXT
            File.WriteAllLines("Lab1\\OUTPUT.TXT", new string[] { maxStrings.ToString(), maxSets.ToString() });
        }
    }
}
