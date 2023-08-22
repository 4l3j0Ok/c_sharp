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
            int total_rows = 4; int total_cols = 4; int start = 1; int limit = 7;
            int[,] random_matrix = GetRandomMatrix(total_rows, total_cols, start, limit);
            PrintAndSumMatrix(random_matrix);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[,] GetRandomMatrix(int total_rows, int total_cols, int start, int limit)
        {
            int[,] matrix = new int[total_rows, total_cols];
            for (int row = 0; row != total_rows; row += 1) {
                for (int col = 0; col != total_cols; col += 1) {
                    matrix[row, col] = new Random().Next(start, limit);
                }
            }
            return matrix;
        }

        static void PrintAndSumMatrix(int[,] matrix) {
            int total_rows = matrix.GetLength(0);
            int total_cols = matrix.GetLength(1);
            int sum = 0;
            Console.WriteLine("La matriz generada es la siguiente:\n");
            for (int row = 0; row != total_rows; row += 1) {
                Console.Write("\t");
                for (int col = 0; col != total_cols; col += 1) {
                    sum += matrix[row, col];
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nEl total de la suma entre todos los números de la matriz es: " + sum + "\n");
        }
    }
}
