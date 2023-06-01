using System;

namespace while_loops {
    class Program {
        static void Main(){
            //ejercicio_uno();
            //Console.ReadKey();
            //ejercicio_dos();
            //Console.ReadKey();
            //ejercicio_tres();
            //Console.ReadKey();
            ejercicio_cuatro();
            Console.ReadKey();
        }

        static void ejercicio_uno() {
            const int array_length = 10;
            int index = 0;
            string result = "";
            int[] values = new int [array_length];

            while(index != array_length) {
                Console.Write("Favor de ingresar el valor {0}:", index + 1);
                values[index] = Convert.ToInt32(Console.ReadLine());
                index += 1;
            }
            for(int i = 0; i != array_length; i +=1) {
                if(i == (array_length - 1)) result += String.Format("{0}", values[i]); 
                else result += String.Format("{0}; ", values[i]);
            }
            Console.WriteLine("El contenido del arreglo resultante es el siguiente:");
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static void ejercicio_dos()
        {
            int total_columns = 2;
            int total_rows = 5;
            int counter = 0;
            string[,] values = new string[total_rows, total_columns];
            
            while(counter != total_rows) {
                Console.Write("Ingrese el nombre: ");
                values[counter, 1] = Console.ReadLine();
                Console.Write("Ingrese el apellido: ");
                values[counter, 0] = Console.ReadLine();
                counter += 1;
            }
            Console.Clear();
            Console.WriteLine("Nombres ingresados:\n");
            for (int row = 0; row != total_rows; row += 1)
            {
                Console.Write("{0}. {1} {2}.\n",(row + 1), values[row, 1], values[row, 0]);
            }
            Console.ReadKey();
        }

        static void ejercicio_tres()
        {
            Console.Write("Ingrese la cantidad de números a ingresar: ");
            int array_length = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[array_length];
            int sum_greater = 0, total_greater = 0, sum_less = 0, total_less = 0, counter = 0;

            while (counter != array_length)
            {
                if (counter == 0) Console.Write("Ingrese un valor: ");
                else Console.Write("Ingrese otro valor: ");
                numbers[counter] = Convert.ToInt32(Console.ReadLine());
                counter += 1;
            }

            Console.Clear();
            Console.Write("Los números ingresados fueron: ");
            for (int index = 0; index != array_length; index += 1)
            {
                if (numbers[index] >= 10)
                {
                    total_greater += 1;
                    sum_greater += numbers[index];
                }
                else
                {
                    total_less += 1;
                    sum_less += numbers[index];
                }
                if (index != array_length) Console.Write("{0}, ", numbers[index]);
                else Console.Write("{0}.", numbers[index]);
            }
            Console.WriteLine();
            Console.WriteLine("La cantidad de números ingresados mayores a 10 es: " + total_greater);
            Console.WriteLine("La cantidad de números ingresados menores a 10 es: " + total_less);
            Console.WriteLine("La suma entre los números ingresados mayores a 10 es: " + sum_greater);
            Console.WriteLine("La suma entre los números ingresados menores a 10 es: " + sum_less);
        }
        static void ejercicio_cuatro()
        {
            int array_length = 6, counter = 0;
            string[] phrases = new string[array_length];
            string final_phrase = "";
            while (counter != (array_length - 1))
            {
                if (counter == 0) Console.Write("Ingrese una frase: ");
                else Console.Write("Ingrese otra frase: ");
                phrases[counter] = Console.ReadLine();
                counter += 1;
            }
            Console.Clear();
            Console.Write("Las 5 frases ingresadas fueron: ");
            for (int index = 0; index != (array_length - 1); index += 1) {
                Console.WriteLine(phrases[index]);
                if (index != (array_length - 2)) final_phrase += phrases[index] + " ";
                else final_phrase += phrases[index] + ".";
            }
            final_phrase = final_phrase.Substring(0, 1).ToUpper() + final_phrase.Substring(1);
            Console.WriteLine("La frase final es: " + final_phrase);
        }
    }
}