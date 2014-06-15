using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class Program
    {
        static int N = 10;
        static int[] numbers = new int[N];
        static string[] codeLetters = new string[N];

        static void Main(string[] args)
        {
            generateNumbers();

            Console.WriteLine("Initial numbers:");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            getLetters();
            Console.WriteLine("Letter code:");
            foreach (string c in codeLetters)
            {
                Console.Write(c + " ");
            }

            Console.ReadLine();
        }

        private static void generateNumbers()
        {
            Random r = new Random();

            for (int i = 0; i < N; i++)
            {
                numbers[i] = r.Next(0, 9000);
            }
        }

        private static void getLetters()
        {
            for (int i = 0; i < N; i++)
            {
                // Преобразуем число в строку
                string code = numbers[i].ToString();

                string letters = "";

                // преобразуем каждое число в соответствующую ей букву
                foreach (char c in code)
                {
                    string strNum = c.ToString();
                    int intNum = int.Parse(strNum);
                    char symbol = (char)('A' + intNum);
                    letters += symbol.ToString();
                }

                codeLetters[i] = letters;
            }
        }
    }
}
