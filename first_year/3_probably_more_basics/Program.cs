using System;
using System.Threading;

namespace probably_more_basics {
    class Program {
        static void Main(string[] args)
        {
            register_box();
        }
        static void clock() {
            int hour = 0;
            int minute = 0;
            int second = 0;
            init:
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("La hora actual es: {0}:{1}:{2}", hour, minute, second);
            if (second == 59)
            {
                second = 0;
                if (minute == 59)
                {
                    minute = 0;
                    if (hour == 23)
                    {
                        hour = 0;
                    }
                    else
                    {
                        hour = hour + 1;
                    }
                }
                else
                {
                    minute = minute + 1;
                }
            }
            else
            {
                second = second + 1;
            }
            goto init;
        }
        static void register_box() {
            // Declaro variables.
            double subtotal = 0;
            double total = 0;
            double price = 0;
            double iva = 0;
            string product_id = "";
            // Declaro el punto de vuelta.
            init:
            // Pido al usuario que ingrese los valores.
            Console.Write("Ingrese código de producto: ");
            product_id = Console.ReadLine();
            Console.Write("Ingrese precio: ");
            price = Convert.ToDouble(Console.ReadLine());
            // Si el código de proucto está vacío, entonces pido que lo ingrese otra vez.
            if (product_id == "") {
                goto init;
            }
            // Sumo el precio del producto al subtotal.
            subtotal = subtotal + price;
            // Calculo el IVA en base al subtotal.
            iva = subtotal * 0.15;
            // Calculo el total en base al IVA y al subtotal.
            total = subtotal + iva;
            // Imprimo el carrito hasta ahora.
            Console.WriteLine("Producto: " + product_id.ToUpper());
            Console.WriteLine("SubTotal: " + subtotal);
            Console.WriteLine("IVA: " + iva);
            Console.WriteLine("Total: " + total);
            // Creo un punto de vuelta para preguntar al usuario.
            question:
            string answer = "";
            Console.Write("¿Desea ingresar más productos? (s/n): ");
            answer = Console.ReadLine();
            // Valido sobre lo que escribió el usuario.
            // Si no puso S o N, entonces lo devuelvo al punto de vuelta "question".
            if (answer.ToLower() != "si" && answer.ToLower() != "n") {
                Console.WriteLine("Ingrese S o N.");
                goto question;
            }
            // Si desea agregar mas productos lo devuelvo al punto de inicio para que ingrese otro producto.
            if (answer.ToLower() == "s")
                goto init;
            // Imprimo la factura final.
            Console.WriteLine("\t====== FACTURA ======");
            Console.WriteLine("\tSubTotal: " + subtotal);
            Console.WriteLine("\tIVA: " + iva);
            Console.WriteLine("\tTotal: " + total);
            Console.WriteLine("\t==================");
            Console.WriteLine("Ingrese una tecla para continuar...");
            Console.ReadKey();
        }
    }
}