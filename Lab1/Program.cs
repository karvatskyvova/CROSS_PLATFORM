using System;
using System.IO;
using System.Linq;

namespace Lab1
{
    public class Program
    {
        public static int Main(string[] args)
        {
            // Перевірка на наявність аргументів
            if (args.Length == 0)
            {
                Console.WriteLine("Помилка: Ви не вказали жодного файлу.");
                return 1; // Код 1 вказує на помилку
            }

            try
            {
                int sum = 0;

                foreach (var filePath in args)
                {
                    // Перевірка, чи існує файл
                    if (!File.Exists(filePath))
                    {
                        Console.WriteLine($"Помилка: Файл '{filePath}' не знайдено.");
                        continue; // Переходить до наступного файлу, не зупиняючи програму
                    }

                    // Читання вмісту файлу
                    var lines = File.ReadAllLines(filePath);

                    // Перевірка на порожній файл
                    if (lines.Length == 0)
                    {
                        Console.WriteLine($"Попередження: Файл '{filePath}' порожній.");
                        continue;
                    }

                    foreach (var line in lines)
                    {
                        // Перевірка на коректність даних (лише цілі числа)
                        if (int.TryParse(line, out int number))
                        {
                            sum += number;
                        }
                        else
                        {
                            Console.WriteLine($"Попередження: '{line}' у файлі '{filePath}' не є цілим числом.");
                        }
                    }
                }

                // Виведення результату
                Console.WriteLine($"Загальна сума: {sum}");
                return 0; // Код 0 вказує на успішне виконання
            }
            catch (Exception ex)
            {
                // Загальна обробка непередбачених винятків
                Console.WriteLine($"Непередбачена помилка: {ex.Message}");
                return -1; // Код -1 вказує на критичну помилку
            }
        }
    }
}
