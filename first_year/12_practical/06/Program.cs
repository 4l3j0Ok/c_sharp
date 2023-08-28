using System;
using System.Diagnostics;


// Desarrollar un programa que utilice un array bidimensional que permita cargar Nombre, Apellido y Edad de 
// 5 personas (y en ese orden). Luego de que el mismo es cargado con la ayuda o interacción del usuario, el 
// programa deberá recorrer el array e imprimir por consola el contenido de este respetando el formato que 
// se muestra en la siguiente imagen ejemplo de ejecución


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
            matrix = OrderMatrixByAge(matrix);
            return matrix;
        }

        static string[,] OrderMatrixByAge(string[,] matrix)
        {
            int total_rows = matrix.GetLength(0);
            int total_cols = matrix.GetLength(1);
            string[,] new_matrix = new string[total_rows, total_cols];
            List<int> order = new List<int>();
            for (int row = 0; row != total_rows; row++)
            {
                // Si el valor del indice actual es mayor al valor del indice anterior
                // hago sobre la lista order un .Add, sino un hago un .Insert cuando corresponda.
                if (order.Count == 0 || int.Parse(matrix[row, 2]) > int.Parse(matrix[order[order.Count - 1], 2]))
                    order.Add(row);
                else
                {
                    for (int insert_index = 0; insert_index < order.Count(); insert_index++)
                    {
                        if (int.Parse(matrix[row, 2]) < int.Parse(matrix[order[insert_index], 2]))
                        {
                            order.Insert(insert_index, row);
                            break;
                        }
                    }
                }
            }
            // Creo la nueva matriz en base al la lista order que contiene los indices en orden de menor a mayor.
            for (int row = 0; row != total_rows; row++)
            {
                new_matrix[row, 0] = matrix[order[row], 0];
                new_matrix[row, 1] = matrix[order[row], 1];
                new_matrix[row, 2] = matrix[order[row], 2];
            }
            return new_matrix;
        }

        static void PrintMatrix(string[,] matrix)
        {
            int total_rows = matrix.GetLength(0);
            for (int row = 0; row != total_rows; row++)
                Console.WriteLine(
                    $"{matrix[row, 1]}, {matrix[row, 0]} {matrix[row, 2]}"
                );
            Console.WriteLine();
        }
    }
}
