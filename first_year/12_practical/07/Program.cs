using System;
using System.IO;


// 7 - Desarrollar un programa que simule que se arrojan 5 dados, 5 veces, sobre la mesa y se toma nota de los 
//   valores de cada dado (la cara que queda para arriba). Los valores deben ser cargados en un array 
//   bidimensional siendo cada fila la que representa cada una de las 5 tiradas o tiros.
//   Luego de estar cargado, el programa deberá recorrer el array e indicar cuantas veces salió cada cara del 
//   dado en total de todos los tiros.


namespace practical_7
{
    class Program
    {
        /////////////////////////////////////////////// WRITER ////////////////////////////////////////////////////////
        static string file_name = "practical_7_output.txt";
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
            int rolls = 5;
            int dices = 5;
            int faces = 6;
            int[,] results = StartGame(rolls, dices, faces);
            ShowResults(results);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            writer.Close();
        }

        static int[,] StartGame(int rolls, int dices, int faces)
        {
            int[,] results = new int[rolls, dices];
            faces = faces + 1;
            Random rndm = new Random();
            for (int i = 0; i != rolls; i++)
            {
                WriteLine($"Presione una tecla para la jugada numero {i + 1}");
                Console.ReadKey();
                for (int j = 0; j != dices; j++)
                {
                    results[i, j] = rndm.Next(1, faces);
                }
            }
            WriteLine();
            return results;
        }

        static void ShowResults(int[,] results)
        {
            int[,] occurrences = new int[results.GetLength(0) + 1, 2];
            for (int i = 0; i != results.GetLength(0); i++)
            {
                Write($"Tiro {i + 1}: ");
                for (int j = 0; j != results.GetLength(1); j++)
                {
                    Write($"{results[i, j]} ");
                    occurrences[results[i, j] - 1, 0] = results[i, j];
                    occurrences[results[i, j] - 1, 1] = occurrences[results[i, j] - 1, 1] + 1;
                }
                WriteLine("\n");
            }
            for (int i = 0; i != occurrences.GetLength(0); i++)
            {
                WriteLine($"{occurrences[i, 0]} = {occurrences[i, 1]} veces");
            }
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
