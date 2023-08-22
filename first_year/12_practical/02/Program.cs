using System;

// Generar un algoritmo que cargue una matriz de 5 x 5 (con el formato y valores de la imagen que se muestra 
// a continuación mediante un algoritmo automático) y que al final de cada fila muestre la sumatoria de los 
// valores que forman las mismas.


namespace practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_rows = 5;
            int total_cols = 5;
            int start = 0;
            int[,] generated_matrix = GenerateMatrix(total_rows, total_cols, start);
            PrintMatrix(generated_matrix);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[,] GenerateMatrix(int total_rows, int total_cols, int start)
        {
            int value = start;
            int[,] matrix = new int[total_rows, total_cols];
            for (int row = 0; row != total_rows; row += 1)
            {
                for (int col = 0; col != total_cols; col += 1)
                {
                    matrix[row, col] = value;
                    value += 1;
                }
                start += 1;
                value = start;
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix) {
            int total_rows = matrix.GetLength(0);
            int total_cols = matrix.GetLength(1);
            int sum = 0;
            Console.WriteLine();
            for (int row = 0; row != total_rows; row += 1)
            {
                Console.Write("\t");
                for (int col = 0; col != total_cols; col += 1)
                {
                    sum += matrix[row, col];
                    Console.Write(matrix[row, col] + " ");
                    if (col == total_cols - 1) {
                        Console.Write("= " + sum);
                        sum = 0;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
