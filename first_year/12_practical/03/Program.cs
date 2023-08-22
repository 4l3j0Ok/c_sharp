using System;

// Elaborar un programa que lea o recorra una matriz, que ya debe estar cargadas con valores, y que imprima 
// por pantalla poniendo las filas como columnas y las columnas como filas (lo que se conoce como matriz 
// transpuesta)


namespace practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                { 2, 5, 6, 7, 8 },
                { 8, 6, 3, 2, 1 },
                { 7, 4, 6, 1, 5 }
            };
            Console.WriteLine("Matrix original:");
            PrintMatrix(matrix);
            int[,] transposed_matrix = TransposeMatrix(matrix);
            Console.WriteLine("Matrix transpuesta:");
            PrintMatrix(transposed_matrix);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[,] TransposeMatrix(int[,] old_matrix) {
            int rows = old_matrix.GetLength(0);
            int cols = old_matrix.GetLength(1);
            int[,] new_matrix = new int[cols, rows];
            for (int row = 0; row != rows; row += 1) {
                for (int col = 0; col != cols; col += 1) {
                    new_matrix[col, row] = old_matrix[row, col];
                }
            }
            return new_matrix;
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
    }
}
