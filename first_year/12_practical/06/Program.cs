using System;
using System.Diagnostics;


// 5 - Desarrolle un programa que:
//   a. Utilice dos arrays unidimensionales de 5 posiciones.
//   b. Los arrays deberán ser cargados con valores random de entre 1 y 9.
//   c. Luego deberá tomar cada valor del array1 e ir multiplicando por cada uno de los del array2 de la 
//   siguiente forma: 7 x 7 x 9 x 3 x 8 x 9 = 95256


namespace practical_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ammount = 5;
            string[,] matrix = CreateUserMatrix(ammount);
            PrintMatrix(matrix);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static string[,] CreateUserMatrix(int ammount)
        {
            string[,] matrix = new string[ammount, 3];
            for (int row = 0; row != ammount; row++) {
                Console.Write("Ingrese el nombre: ");
                matrix[row, 0] = Console.ReadLine();
                Console.Write("Ingrese el apellido: ");
                matrix[row, 1] = Console.ReadLine();
                Console.Write("Ingrese la edad: ");
                matrix[row, 2] = Console.ReadLine();
            }
            Console.WriteLine();
            return matrix;
        }

        static void PrintMatrix(string[,] matrix)
        {
            int total_rows = matrix.GetLength(0);
            int half;
            if (total_rows % 2 == 0) half = (total_rows + 1) / 2;
            else half = total_rows / 2;
            // Imprimo todo hasta la mitad, omitiendo el último índice.
            for (int row = total_rows -2; row >= half; row--)
            {
                Console.WriteLine($"{matrix[row, 1]}, {matrix[row, 0]} {matrix[row, 2]}");
            }
            // Imprimo el último índice.
            Console.WriteLine($"{matrix[total_rows - 1, 1]}, {matrix[total_rows - 1, 0]} {matrix[total_rows - 1, 2]}");
            // Imprimo desde la mitad hasta el índice 0.
            for (int row = half - 1; row >= 0; row--)
            {
                Console.WriteLine($"{matrix[row, 1]}, {matrix[row, 0]} {matrix[row, 2]}");
            }
            Console.WriteLine();
        }
    }
}
