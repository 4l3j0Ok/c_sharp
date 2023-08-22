using System;

// Elabore un programa que cargue una matriz de 6 x 6 con números aleatorios entre 2 y 8. Imprima la misma 
// por pantalla. Al mismo tiempo que la imprime debe almacenar en un matrix de 6 posiciones los valores de 
// la diagonal de dicha matriz (diagonal de izquierda a derecha y de arriba hacia abajo) y luego se debe 
// imprimir dicho matrix.


namespace practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_rows = 6;
            int total_cols = 6;
            int start = 2;
            int limit = 9;
            int[,] random_matrix = GetRandommatrix(total_rows, total_cols, start, limit);
            int[] diagonal_values = GetDiagonalMatrixValues(random_matrix);
            Console.WriteLine("Matriz generada con valores aleatorios:");
            PrintMatrix(random_matrix);
            Console.WriteLine("Array generada con los valores de la diagonal:");
            PrintArray(diagonal_values);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[,] GetRandommatrix(int total_rows, int total_cols, int start, int limit)
        {
            int[,] matrix = new int[total_rows, total_cols];
            for (int row = 0; row != total_rows; row += 1)
            {
                for (int col = 0; col != total_cols; col += 1)
                {
                    matrix[row, col] = new Random().Next(start, limit);
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int total_rows = matrix.GetLength(0);
            int total_cols = matrix.GetLength(1);
            Console.WriteLine();
            for (int row = 0; row != total_rows; row += 1)
            {
                Console.Write("\t");
                for (int col = 0; col != total_cols; col += 1)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[] GetDiagonalMatrixValues(int[,] matrix)
        {
            int total_rows = matrix.GetLength(0);
            int total_cols = matrix.GetLength(1);
            int[] array = new int[total_cols];
            int index = 0;
            for (int row = 0; row != total_rows; row += 1)
            {
                array[index] = matrix[row, index];
                index += 1;
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            int array_length = array.GetLength(0);
            Console.WriteLine();
            Console.Write("\t");
            for (int index = 0; index != array_length; index += 1) {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
