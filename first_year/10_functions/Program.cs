using System;

namespace functions {
    class Program {
        static void Main(){
            Calculator();
        }
        static void Calculator(){
            string input;
            while (true){
                input = PrintOptionsAndGetInput();
                if (input.ToUpper() == "S") return;
                PrintResult(input);
                Console.WriteLine("Presione una tecla para continuar....");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static string PrintOptionsAndGetInput(){
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
        static void PrintResult(string input){
            int value_1, value_2;
            decimal result = 0;
            string str_operator = "";
            string[] operators = {"sumar", "restar", "multiplicar", "dividir"};
            value_1 = GetValue("primer");
            value_2 = GetValue("segundo");
            if (input.ToUpper() == "A") 
            {
                result = Addition(value_1, value_2);
                str_operator = operators[0];
            }
            if (input.ToUpper() == "B")
            {
                result = Substraction(value_1, value_2);
                str_operator = operators[1];
            }
            if (input.ToUpper() == "C")
            {
                result = Multiplication(value_1, value_2);
                str_operator = operators[2];
            }
            if (input.ToUpper() == "D") 
            {
                result = Division(value_1, value_2);
                str_operator = operators[3];
            }
            Console.Write("El resultado de {0} los valores es: {1}", str_operator, result);
            Console.WriteLine();
        }
        static int GetValue(string formatter){
            int value;
            Console.Write("Ingrese {0} valor: ", formatter);
            value = Convert.ToInt32(Console.ReadLine());
            return value;
        }

        static decimal Addition(int value_1, int value_2){
            return value_1 + value_2;
        }
        static decimal Substraction(int value_1, int value_2){
            return value_1 - value_2;
        }
        static decimal Multiplication(int value_1, int value_2){
            return value_1 * value_2;
        }
        static decimal Division(int value_1, int value_2){
            return value_1 * value_2;
        }
    }
}