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
            int total_rows = 5; int total_cols = 5; int start = 0;
            int[,] generated_array = GenerateArray(total_rows, total_cols, start);
            PrintArray(generated_array);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static int[,] GenerateArray(int total_rows, int total_cols, int start)
        {
            int value = start;
            int[,] array = new int[total_rows, total_cols];
            for (int r = 0; r != total_rows; r += 1)
            {
                for (int c = 0; c != total_cols; c += 1)
                {
                    array[r, c] = value;
                    value += 1;
                }
                start += 1;
                value = start;
            }
            return array;
        }

        static void PrintArray(int[,] array) {
            int total_rows = array.GetLength(0);
            int total_cols = array.GetLength(1);
            int sum = 0;
            Console.WriteLine();
            for (int row = 0; row != total_rows; row += 1)
            {
                Console.Write("\t");
                for (int col = 0; col != total_cols; col += 1)
                {
                    sum += array[row, col];
                    Console.Write(array[row, col] + " ");
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
