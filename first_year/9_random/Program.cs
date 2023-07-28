using System;

namespace random {
    class Program
    {
        static void Main(string[] args)
        {
            first_exercise();
            Console.ReadKey();
        }
        static void first_exercise()
        {
            int arr_rows = 6, arr_columns = 4;
            int[,] cardboard = create_cardboard(arr_rows, arr_columns);
            start_game(cardboard, arr_rows, arr_columns);
        }

        private static void start_game(int[,] cardboard, int arr_rows, int arr_columns) {
            int max_attempts = 3;
            int raffled;
            string str_raffled;
            print_cardboard(cardboard, arr_rows, arr_columns);
            Console.WriteLine("Presiona una tecla para sortear un número: ");
            Console.ReadKey();
            for (int attempt = max_attempts; attempt > 0; attempt -= 1)
            {
                raffled = new Random().Next(0, 100);
                if (raffled >= 10) str_raffled = raffled.ToString();
                else str_raffled = "0" + raffled.ToString();
                Console.WriteLine("\n\tEl número sorteado fue: " + str_raffled + "\n");
                for (int row = 0; row != arr_rows; row += 1)
                {
                    for (int column = 0; column != arr_columns; column += 1)
                    {
                        if (raffled == cardboard[row, column])
                        {
                            Console.WriteLine("\tEl número {0} está en su cartón.", str_raffled);
                            Console.WriteLine("\n\t¡¡¡¡¡¡ACABAS DE GANAR!!!!!!");
                            return;
                        }
                    }
                }
                Console.WriteLine("\tEl número {0} no se encuentra en su cartón.", str_raffled);
                Console.WriteLine("\nTe quedan {0} intentos.\n", attempt - 1);
                if (attempt != 1)
                {
                    Console.WriteLine("Presiona una tecla para sortear otro número...");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Se te acabaron los intentos ):\nMás suerte la próxima.");
        }

        private static void print_cardboard(int[,] cardboard, int arr_rows, int arr_columns)
        {
            Console.WriteLine("Tu cartón es el siguiente: ");
            for (int row = 0; row != arr_rows; row += 1)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("- ", (arr_columns * 3) - 1)));
                for (int column = 0; column != arr_columns; column += 1)
                {
                    Console.Write("|");
                    if (cardboard[row, column] >= 10) Console.Write(" " + cardboard[row, column] + " ");
                    else Console.Write(" 0" + cardboard[row, column] + " ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("- ", (arr_columns * 3) - 1)));
        }

        private static int[,] create_cardboard(int arr_rows, int arr_columns) {
            int[,] cardboard = new int[arr_rows, arr_columns];
            int cardboard_value;
            int[] all_values = new int[cardboard.Length];
            int index = 0;
            // Completing array.
            for (int row = 0; row != arr_rows; row += 1)
            {
                for (int column = 0; column != arr_columns; column += 1)
                {
                    while (true)
                    {
                        cardboard_value = new Random().Next(0, 100);
                        if (!all_values.Contains(cardboard_value)) break;
                    }
                    cardboard[row, column] = cardboard_value;
                    all_values[index] = cardboard_value;
                    index += 1;
                }
            }
            return sort_cardboard(cardboard, arr_rows, arr_columns);
        }

        private static int[,] sort_cardboard(int[,] cardboard, int arr_rows, int arr_columns)
        {
            int index = 0;
            int[] plain_array = new int[cardboard.Length];
            for (int row = 0; row != arr_rows; row += 1)
            {
                for (int column = 0; column != arr_columns; column += 1)
                {
                    plain_array[index] = cardboard[row, column];
                    index += 1;
                }
            }
            Array.Sort(plain_array);
            index = 0;
            for (int row = 0; row != arr_rows; row += 1)
            {
                for (int column = 0; column != arr_columns; column += 1)
                {
                    cardboard[row, column] = plain_array[index];
                    index += 1;
                }
            }
            return cardboard;
        }
    }
}