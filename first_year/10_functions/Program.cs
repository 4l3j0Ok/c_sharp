using System;

namespace functions {
    class Program {
        static void Main(){
            calculator();
        }
        static void calculator(){
            string input = "";
            while (true){
                input = print_options_and_get_input();
                if (input.ToUpper() == "S") return;
                print_result(input);
                Console.WriteLine("Presione una tecla para continuar....");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static string print_options_and_get_input(){
            string[] valid_options = {"A","B","C","D","S"};
            string input = "";
            Console.WriteLine("Calculadora básica....");
            while (!valid_options.Contains(input.ToUpper())){
                Console.WriteLine();
                Console.WriteLine("Operaciones posibles:");
                Console.WriteLine();
                Console.WriteLine("\tA - Sumar");
                Console.WriteLine("\tB - Restar");
                Console.WriteLine("\tC - Multiplicar");
                Console.WriteLine("\tD - Dividir");
                Console.WriteLine("\tS - Salir");
                Console.WriteLine();
                Console.Write("Opción: ");
                input = Console.ReadLine();
            }
            return input;
        }
        static void print_result(string input){
            int value_1, value_2;
            decimal result = 0;
            string str_operator = "";
            string[] operators = {"sumar", "restar", "multiplicar", "dividir"};
            value_1 = get_value("primer");
            value_2 = get_value("segundo");
            if (input.ToUpper() == "A") 
            {
                result = addition(value_1, value_2);
                str_operator = operators[0];
            }
            if (input.ToUpper() == "B")
            {
                result = substraction(value_1, value_2);
                str_operator = operators[1];
            }
            if (input.ToUpper() == "C")
            {
                result = multiplication(value_1, value_2);
                str_operator = operators[2];
            }
            if (input.ToUpper() == "D") 
            {
                result = division(value_1, value_2);
                str_operator = operators[3];
            }
            Console.Write("El resultado de {0} los valores es: {1}", str_operator, result);
            Console.WriteLine();
        }
        static int get_value(string formatter){
            int value;
            Console.Write("Ingrese {0} valor: ", formatter);
            value = Convert.ToInt32(Console.ReadLine());
            return value;
        }

        static decimal addition(int value_1, int value_2){
            return value_1 + value_2;
        }
        static decimal substraction(int value_1, int value_2){
            return value_1 - value_2;
        }
        static decimal multiplication(int value_1, int value_2){
            return value_1 * value_2;
        }
        static decimal division(int value_1, int value_2){
            return value_1 / value_2;
        }
    }
}