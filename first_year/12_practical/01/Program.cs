using System;

// 1 - Desarrollar un algoritmo que cargue una matriz de 4 x 4 con valores enteros aleatorios(random)
// comprendidos entre 1 y 6.Luego de cargadas la misma, el programa debe hacer lo siguiente:
// a - Imprimir la matriz en consola.
//  b - Recorrerla posición a posición, ir sumando el valor de cada celda y luego de terminar de
// recorrerla imprimir en consola, y debajo de la matriz ya impresa, el resultado de esa suma de
// todos los valores

namespace practical_1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int total_rows = 4;
            int total_cols = 4;
            int start = 1;
            int limit = 7;
            int[,] random_array = GetRandomArray(total_rows, total_cols, start, limit);
            PrintAndSumArray(random_array);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[,] GetRandomArray(int total_rows, int total_cols, int start, int limit)
        {
            int[,] array = new int[total_rows, total_cols];
            for (int row = 0; row != total_rows; row += 1) {
                for (int col = 0; col != total_cols; col += 1) {
                    array[row, col] = new Random().Next(start, limit);
                }
            }
            return array;
        }

        static void PrintAndSumArray(int[,] array) {
            int total_rows = array.GetLength(0);
            int total_cols = array.GetLength(1);
            int sum = 0;
            Console.WriteLine("La matriz generada es la siguiente:\n");
            for (int row = 0; row != total_rows; row += 1) {
                Console.Write("\t");
                for (int col = 0; col != total_cols; col += 1) {
                    sum += array[row, col];
                    Console.Write(array[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nEl total de la suma entre todos los números de la matriz es: " + sum + "\n");
        }
    }
}
