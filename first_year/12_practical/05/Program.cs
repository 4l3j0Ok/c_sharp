using System;
using System.Diagnostics;


// 5 - Desarrolle un programa que:
//   a. Utilice dos arrays unidimensionales de 5 posiciones.
//   b. Los arrays deberán ser cargados con valores random de entre 1 y 9.
//   c. Luego deberá tomar cada valor del array1 e ir multiplicando por cada uno de los del array2 de la 
//   siguiente forma: 7 x 7 x 9 x 3 x 8 x 9 = 95256


namespace practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const bool DEBUG = false;
            int array_length = 6;
            int rndm_start = 1;
            int rndm_limit = 10;
            int[] array_1 = GenerateRandomArray(array_length, rndm_start, rndm_limit);
            int[] array_2 = GenerateRandomArray(array_length, rndm_start, rndm_limit);
            int[] results = LMultiply(array_1, array_2, DEBUG);
            Console.WriteLine("Array 1:");
            PrintArray(array_1);
            Console.WriteLine("Array 2:");
            PrintArray(array_2);
            Console.WriteLine("Resultante:");
            PrintArray(results);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[] GenerateRandomArray(int array_length, int rndm_start, int rndm_limit)
        {
            int[] array = new int[array_length];
            for (int index = 0; index != array_length; index += 1)
            {
                array[index] = new Random().Next(rndm_start, rndm_limit);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            int array_length = array.GetLength(0);
            Console.WriteLine();
            Console.Write("\t");
            for (int index = 0; index != array_length; index += 1)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static int[] LMultiply(int[] array_1, int[] array_2, bool debug = false) {
            int pos = 0;
            int[] results = new int[array_1.Length];
            for (int i = 0; i != array_1.Length; i += 1) {
                if (debug) Console.Write($"{array_1[i]} X {array_2[i]}");
                results[i] = array_1[i] * array_2[i];
                if (i != array_1.Length - 1) pos = i + 1;
                else pos = 0;
                while (true) {
                    if (pos == i) break;
                    if (debug) Console.Write($" X {array_2[pos]}");
                    results[i] *= array_2[pos];
                    if (pos == (array_2.Length - 1)) {
                        pos = 0;
                        continue;
                    }
                    pos++;
                }
                if (debug) Console.Write($" = {results[i]}");
                if (debug) Console.WriteLine();
            }
            if(debug) Console.WriteLine();
            return results;
        }
    }
}
