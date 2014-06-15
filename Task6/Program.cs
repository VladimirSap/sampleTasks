using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6
{
    class Program
    {
        static int N = 4;
        static int M = N * 2 - 1;

        static string[,] matrix = new string[N, M];
        static Random r = new Random();

        static void Main(string[] args)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = getValue(i, j);
                }
            }

            showMatrix();
            Console.ReadLine();
        }

        static string getValue(int i, int j) {
            string value = "";
            // Сколько нужно вычесть с каждой стороны матрицы,
            // чтобы попасть в треугольник?
            int minus = (N - 1) - i;

            
            if (j >= minus && j <= (M - 1) - minus) // попадаем в треугольник?
            {
                value = r.Next(0, 9).ToString();
            }
            else
            {
                char c = (char)('a' + r.Next(0, 26));
                value = c.ToString();
            }

            return value;
        }

        private static void showMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.Write("\r\n");
            }
        }
    }
}
