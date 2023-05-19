using System;

namespace while_loops {
    class Program {
        static void Main(){
            ejercicio_uno();
        }

        static void ejercicio_uno() {
            int array_length = 10;
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
        }
    }
}