using System;

namespace while_loops {
    class Program {
        static void Main(){
            //ejercicio_uno();
            ejercicio_dos();
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
    }
}