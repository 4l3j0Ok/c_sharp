using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum_five_numbers();
            //create_phrase();
            //print_binary_square();
            //print_binary_square_v2();
            zero_in_middle();

        }
        static void sum_five_numbers()
        {
            // Sumar 5 números ingresados por consola.
            int var_result = 0;
            for (int counter = 1; counter <= 5; counter += 1)
            {
                Console.Write("Favor de ingresar un número: ");
                var_result = var_result + Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("El resultado de la suma entre todos los valores es: " + var_result);
            Console.WriteLine("Ingrese una tecla para finalizar.");
            Console.ReadKey();
        }

        static void create_phrase()
        {
            string var_phrase = "";
            for (int counter = 1; counter <= 5; counter += 1)
            {
                Console.Write("Favor de ingresar una palabra: ");
                var_phrase += Console.ReadLine() + " ";
            }
            Console.WriteLine(
                "La frase final es: " +
                char.ToUpper(var_phrase[0]) +
                var_phrase.Substring(1)
            );
            Console.ReadKey();
        }

        static void print_binary_square() {
            int square_size = 30;
            for (int row = 1; row != square_size; row += 1) {
                for (int column = 1; column != square_size; column += 1)
                {
                    if (row == column)
                    {
                        Console.Write("1 ");
                        continue;
                    }
                    Console.Write("0 ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}

