using System;

namespace more_basics {
    class Program {
        static void Main(string[] args)
        {
            WhileFalopa();
        }
        static void WhileFalopa()
        {
            int max = 10;
            int counter = 0;
            int total = 0;
            start:
            if (counter != max) {
                Console.Write("Ingrese un numero a sumar: ");
                counter = counter + 1;
                total = Convert.ToInt32(Console.ReadLine()) + total;
                goto start;
            }
            Console.WriteLine("El total de todos los números ingresados es: " + total);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}