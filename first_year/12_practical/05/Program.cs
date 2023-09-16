using System;
using System.IO;
using System.Diagnostics;


// 5 - Desarrolle un programa que:
//   a. Utilice dos arrays unidimensionales de 5 posiciones.
//   b. Los arrays deberán ser cargados con valores random de entre 1 y 9.
//   c. Luego deberá tomar cada valor del array1 e ir multiplicando por cada uno de los del array2 de la 
//   siguiente forma: 7 x 7 x 9 x 3 x 8 x 9 = 95256


// 8 - A los programas de los ejercicios 5 y 8 deberán incorporarle que además de imprimir por consola imprima 
//   también en un archivo de texto plano (.txt) agregando al principio la fecha y hora exacta en que se ejecuta 
//   el programa y que sea ese archivo un histórico de ejecuciones (una deba de la otra con su respectiva fecha 
//   y hora).

namespace practical_5
{
    class Program
    {
        /////////////////////////////////////////////// WRITER ////////////////////////////////////////////////////////
        static string file_name = "practical_5_output.txt";
        // Combino el path del escritorio y el nombre del archivo. Obtengo la ruta del escritorio con Environment.
        static string file_path = Path.Combine(
            path1: Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            path2: file_name
        );
        static StreamWriter writer = File.AppendText(file_path);
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            writer.WriteLine($"\n{DateTime.Now.ToString()}\n");
            int array_length = 6;
            int rndm_start = 1;
            int rndm_limit = 10;
            int[] array_1 = GenerateRandomArray(array_length, rndm_start, rndm_limit);
            int[] array_2 = GenerateRandomArray(array_length, rndm_start, rndm_limit);
            int[] results = LMultiply(array_1, array_2);
            WriteLine("Array 1:");
            PrintArray(array_1);
            WriteLine("Array 2:");
            PrintArray(array_2);
            WriteLine("Resultante:");
            PrintArray(results);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            writer.Close();
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
            WriteLine();
            Write("\t");
            for (int index = 0; index != array_length; index += 1)
            {
                Write(array[index] + " ");
            }
            WriteLine();
            WriteLine();
        }

        static int[] LMultiply(int[] array_1, int[] array_2) {
            int pos = 0;
            int[] results = new int[array_1.Length];
            for (int i = 0; i != array_1.Length; i += 1) {
                results[i] = array_1[i] * array_2[i];
                if (i != array_1.Length - 1) pos = i + 1;
                else pos = 0;
                while (true) {
                    if (pos == i) break;
                    results[i] *= array_2[pos];
                    if (pos == (array_2.Length - 1)) {
                        pos = 0;
                        continue;
                    }
                    pos++;
                }
            }
            return results;
        }

        static void Write(string text = "")
        {
            Console.Write(text);
            writer.Write(text);
        }

        static void WriteLine(string text = "")
        {
            Console.WriteLine(text);
            writer.WriteLine(text);
        }
    }
}
