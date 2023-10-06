using System;
using validations;

namespace classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool valid = Functions.isAgeValid("12");
            Console.WriteLine(valid);
        }
        
    }
}