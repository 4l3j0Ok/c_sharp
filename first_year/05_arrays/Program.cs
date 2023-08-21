using System;
using System.Security.Cryptography;

namespace arrays {
    class Program
    {
        static void Main(string[] args)
        {
            //print_binary_square_v2();
            //zero_in_middle();
            //interspersed_zero();
            //mirrored_count();
            a_at_limit();
        }
        static void print_binary_square_v2()
        {
            int square_size = 30;
            string[,] grid = new string[square_size, square_size];
            for (int row = 0; row != square_size; row += 1)
            {
                for (int column = 0; column != square_size; column += 1)
                {
                    if (row == column) grid[row, column] = "1";
                    else grid[row, column] = "0";
                    Console.Write(grid[row, column] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
        static void zero_in_middle()
        {
            int length = 9;
            if (length % 2 == 0) length += 1;
            int half = length / 2;
            string[] ary_values = new string[length];
            for (int index = 0; index != length; index += 1)
            {
                if (index == half) ary_values[index] = "0 ";
                else ary_values[index] = "1 ";
                Console.Write(ary_values[index]);
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
        static void interspersed_zero()
        {
            int length = 9;
            string[] ary_values = new string[length];
            for (int index = 0; index != length; index += 1)
            {
                if (index % 2 == 0) ary_values[index] = "1 ";
                else ary_values[index] = "0 ";
                Console.Write(ary_values[index]);
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void mirrored_count()
        {
            int length = 9;
            if (length % 2 == 0) length += 1;
            string[] ary_values = new string[length];
            int half = length / 2;
            for (int index = half; index != 0; index -= 1)
            {
                if (index == half) continue;
                ary_values[index] = Convert.ToString(index) + " ";
                Console.Write(ary_values[index]);
            }
            for (int index = 0; index != half; index += 1)
            {
                ary_values[index] = Convert.ToString(index) + " ";
                Console.Write(ary_values[index]);
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
        static void a_at_limit()
        {
            int length = 9;
            string[] ary_values = new string[length];

            for (int index = 0; index != length; index += 1) 
            {
                if (index == length - 1 || index == 0) ary_values[index] = "A ";
                else ary_values[index] = "o ";
                Console.Write(ary_values[index]);
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}