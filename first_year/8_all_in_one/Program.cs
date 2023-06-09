using System;

namespace aio
{
    class Program
    {
        static void Main(string[] args)
        {
            first_exercise();
        }
        static void first_exercise()
        {
            int array_length = 6, counter = 0, string_length = 0;
            string[] phrases = new string[array_length];
            string final_phrase = "";
            while (counter != (array_length - 1))
            {
                if (counter == 0) Console.Write("Ingrese una frase: ");
                else Console.Write("Ingrese otra frase: ");
                phrases[counter] = Console.ReadLine();
                string_length += phrases[counter].Length;
                counter += 1;
            }
            phrases[array_length - 1] = Convert.ToString(string_length);
            Console.Clear();
            Console.WriteLine("Las 5 frases ingresadas fueron:");
            for (int index = 0; index != (array_length - 1); index += 1)
            {
                Console.WriteLine(phrases[index]);
                if (index != (array_length - 2)) final_phrase += phrases[index] + " ";
                else final_phrase += phrases[index] + ".";
            }
            final_phrase = final_phrase.Substring(0, 1).ToUpper() + final_phrase.Substring(1);
            Console.WriteLine("La frase final es: " + final_phrase);
            Console.WriteLine("El largo de todas las frases sumadas individualmente es: " + phrases[array_length - 1]);
            Console.ReadKey();
        }
    }
}