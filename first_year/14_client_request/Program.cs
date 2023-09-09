using System;
using System.Collections.Generic;
using System.Linq;


namespace client_request
{
    class Program
    {
        static void Main(string[] args)
        {
            char separator = ';';
            string input = GetInput(separator);
            List<int> numbers = ParseNumbers(input, separator);
            List<int> odd_values = numbers.Where(n => n % 2 == 0).ToList();
            List<int> even_values = numbers.Where(n => n % 2 != 0).ToList();
            PrintCount("pares", odd_values);
            PrintCount("impares", even_values);
            PrintSum(odd_values, even_values);
        }

        static string GetInput(char separator)
        {
            Console.Write($"Ingrese los valores separados por '{separator}': ");
            return Console.ReadLine().Trim();
        }

        static List<int> ParseNumbers(string input, char separator)
        {
            List<int> list = new List<int>();
            foreach (string value in input.Split(separator))
                list.Add(int.Parse(value));
            list.Sort();
            return list;
        }

        static void PrintCount(string type, List<int> values)
        {
            Console.WriteLine($"Total de números {type}: {values.Count()} ({string.Join(" ", values)})");
        }

        static void PrintSum(List<int> odd, List<int> even)
        {
            Console.WriteLine($"Total de la suma entre los valores pares: {odd.Sum()}");
            Console.WriteLine($"Total de la suma entre los valores impares: {even.Sum()}");
        }
    }
}
