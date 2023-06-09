using System;

namespace random {
    class Program
    {
        static void Main(string[] args)
        {
            first_exercise();
        }
        static void first_exercise()
        {
            int arr_rows = 6, arr_columns = 4;
            string[,] cardboard = new string[arr_rows, arr_columns];
            int max_attempts = 3;
            int raffled, cardboard_value;
            string str_raffled;
            string[] all_values = new string[arr_rows * arr_columns];
            

            // Completing array.
            Console.WriteLine("Tu cartón es el siguiente: ");
            for (int row = 0; row != arr_rows; row += 1)
            {
                for (int column = 0; column != arr_columns; column += 1)
                {
                    while (true) {
                        cardboard_value = new Random().Next(0, 100);
                        if (!all_values.Contains(cardboard_value.ToString())) break;
                    }
                    if (cardboard_value >= 10) cardboard[row, column] = cardboard_value.ToString();
                    else cardboard[row, column] = "0" + cardboard_value.ToString();
                    all_values[row * column] = cardboard_value.ToString();
                    Console.Write(" " + cardboard[row, column]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Presiona una tecla para sortear un número: ");
            Console.ReadKey();
            for (int attempt = max_attempts; attempt > 0; attempt -= 1)
            {
                raffled = new Random().Next(0, 100);
                if (raffled >= 10) str_raffled = raffled.ToString();
                else str_raffled = "0" + raffled.ToString();
                Console.WriteLine("\nEl número sorteado fue: " + str_raffled + "\n");
                for (int row = 0; row != arr_rows; row += 1)
                {
                    for (int column = 0; column != arr_columns; column += 1)
                    {
                        if (str_raffled == cardboard[row, column])
                        {
                            Console.WriteLine("El número {0} está en su cartón.", str_raffled);
                            Console.WriteLine("¡¡¡¡¡¡ACABAS DE GANAR!!!!!!");
                            Environment.Exit(0);
                        }
                    }
                }
                Console.WriteLine("El número {0} no se encuentra en su cartón.", str_raffled);
                Console.WriteLine("\nTe quedan {0} intentos.\n", attempt - 1);
                if (attempt != 1)
                {
                    Console.WriteLine("Presiona una tecla para sortear otro número...");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Se te acabaron los intentos ):\nMás suerte la próxima.");
        }
    }
}