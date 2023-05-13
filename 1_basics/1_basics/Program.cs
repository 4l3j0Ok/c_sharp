using System;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            is_year_leap();
        }
        static void calc()
        {
            // Declaración de las variables.
            int suma = 0;
            int resta = 0;
            int multiplicacion = 0;
            int division = 0;
            int num_1 = 0;
            int num_2 = 0;

            Console.WriteLine(
                "Este programa se encarga de calcular la suma, la resta, la multiplicación y la división dos valores ingresados."
            );

            // Ingreso de datos del usuario.
            Console.Write("\n\tFavor de ingresar el valor 1: ");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tFavor de ingresar el valor 2: ");
            num_2 = Convert.ToInt32(Console.ReadLine());

            // Asignación del resultado de la suma de los valores de num_1 y num_2.
            suma = num_1 + num_2;
            Console.WriteLine("\nEl resultado de la suma es: " + suma);

            // Asignación del resultado de la resta de los valores de num_1 y num_2.
            resta = num_1 - num_2;
            Console.WriteLine("\nEl resultado de la resta es: " + resta);

            // Asignación del resultado de la multiplicación de los valores de num_1 y num_2.
            multiplicacion = num_1 * num_2;
            Console.WriteLine("\nEl resultado de la multiplicación es: " + multiplicacion);

            // Asignación del resultado de la división de los valores de num_1 y num_2.
            division = num_1 / num_2;
            Console.WriteLine("\nEl resultado de la división es: " + division);
            // Finalización del programa.
            Console.WriteLine("");
            Console.Write("Presione una tecla para terminar...");
            Console.ReadKey();
        }

        static void area_triangulo() {
            Console.WriteLine(
                "Este programa se encarga de calcular el área del triángulo teniendo en cuenta el valor de la base y de la altura."
            );
            Console.Write("\tIngrese el valor del la base del triángulo: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tIngrese el valor del la altura del triángulo: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El área del triángulo es: " + (b * h) / 2);
            // Finalización del programa.
            Console.WriteLine("");
            Console.Write("Presione una tecla para terminar...");
            Console.ReadKey();
        }
        static void calc_with_input() {
            double num_1 = 0;
            double num_2 = 0;
            double res = 0;
            // Ingreso de datos del usuario.
            Console.Write("\n\tFavor de ingresar el valor 1: ");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tFavor de ingresar el valor 2: ");
            num_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\t¿Qué desea hacer? ¿sumar, restar, multiplicar o dividir?: ");
            string operador = Console.ReadLine();
            if (operador.ToLower() == "sumar") {
                res = num_1 + num_2;
            }
            else if (operador.ToLower() == "restar") {
                res = num_1 - num_2;
            }
            else if (operador.ToLower() == "dividir") {
                res = num_1 / num_2;
            }
            else if (operador.ToLower() == "multiplicar") {
                res = num_1 * num_2;
            }
            else {
                Console.Write("No se ingresó un operado válido");
                return;
            }
            Console.Write("El resultado de la operación es: " + res);
        }
        static void check_odd_or_even() {
            string odd_even = "impar";
            Console.Write("\n Este programa se encargará de verificar si el numero ingresado es par o impar.");
            Console.Write("\n\tFavor de ingresar el valor del número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) odd_even = "par";
            Console.Write("El numero ingresado es: " + odd_even);
        }
        static void wich_is_major() {
            int num_1 = 0, num_2 = 0, num_3 = 0;
            int major = 0;
            Console.Write("\n Este programa verificará cuál número es mayor entre los 3 ingresados:");
            Console.Write("\nIngrese el valor del primer número:");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el valor del segundo número:");
            num_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el valor del tercer número:");
            num_3 = Convert.ToInt32(Console.ReadLine());

            if (num_1 > num_2 && num_1 > num_3) {
                major = num_1;
            }

            else if (num_2 > num_1 && num_2 > num_3) {
                major = num_2;
            }

            else if (num_3 > num_2 && num_3 > num_1) {
                major = num_3;
            }

            else {
                Console.Write("Se rompió todo.");
            }

            Console.Write("El número mayor es: " + major);
            Console.WriteLine("");
            Console.Write("Presione una tecla para terminar...");
            Console.ReadKey();
        }
        static void is_year_leap() {
            int year = 0;
            Console.WriteLine("Este programa se encargará de indicar si el año ingresado es bisiesto.");
            Console.Write("Favor de ingresar el año a validar: ");
            year = Convert.ToInt32(Console.ReadLine());
            bool year_leap = false;
            if (year % 4 == 0) {
                if (year % 100 == 0) {
                    if (year % 400 == 0) {
                        year_leap = true;
                    }
                }
                else {
                    year_leap = true;
                }
            }
            if (year_leap) {
                Console.WriteLine("El año ingresado es bisiesto.");
            }
            else {
                Console.WriteLine("El año ingresado no es bisiesto");
            }
            Console.WriteLine("");
            Console.Write("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}