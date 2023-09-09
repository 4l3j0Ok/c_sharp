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
            List<int> odd_values = GetSortedOddValues(input, separator);
            List<int> even_values = GetSortedEvenValues(input, separator);
            CountAndPrint(odd_values, even_values);
            SumAndPrint(odd_values, even_values);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static string GetInput(char separator)
        {
            Console.Write($"Ingrese los valores separados por '{separator}': ");
            return Console.ReadLine().Trim();
        }

        static List<int> GetSortedOddValues(string input, char separator)
        {
            List<int> odd = new List<int>();
            foreach (string value in input.Split(separator))
                if (int.Parse(value) % 2 == 0)
                    odd.Add(int.Parse(value));
            odd.Sort();
            return odd;
        }

        static List<int> GetSortedEvenValues(string input, char separator)
        {
            List<int> even = new List<int>();
            foreach (string value in input.Split(separator))
                if (int.Parse(value) % 2 != 0)
                    even.Add(int.Parse(value));
            even.Sort();
            return even;
        }

        static void CountAndPrint(List<int> odd, List<int> even)
        {
            Console.WriteLine($"Total de números pares: {odd.Count()} ({string.Join(" ", odd)})");
            Console.WriteLine($"Total de números impares: {even.Count()} ({string.Join(" ", even)})");
        }

        static void SumAndPrint(List<int> odd, List<int> even)
        {
            int odd_total = 0;
            int even_total = 0;
            foreach (int value in odd)
                odd_total += value;
            foreach (int value in even)
                even_total += value;
            Console.WriteLine($"Total de la suma entre los valores pares: {odd_total}");
            Console.WriteLine($"Total de la suma entre los valores impares: {even_total}");
        }
    }
}
