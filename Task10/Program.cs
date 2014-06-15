using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task10
{
    class Program
    {
        static string input = "BDD EE CAFB";

        static string output = "";
        
        static void Main(string[] args)
        {
            Console.WriteLine("Initial sentence: ");
            Console.WriteLine(input);
            Console.WriteLine();

            string[] codes = input.Split(' ');

            // Пробежимся по каждой тройке символов
            foreach (string str in codes)
            {
                // пробежимся по каждому символу тройки
                foreach(char c in str) {
                    int num = (int)c - 65;
                    output += num.ToString();
                }
                output += " ";
            }
            Console.WriteLine("Result: ");
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
