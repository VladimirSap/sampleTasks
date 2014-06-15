using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Program
    {
        static int N = 5;
        static int M = 4;

        static int[,] matrix = new int[N, M];
        
        static void Main(string[] args)
        {
            generateMatrix();
            showMatrix();

            string numbers = "";
            // взять цифры с верхней границы матрицы (справа налево)
            for (int i = 0; i < M; i++)
            {
                numbers += matrix[0, i];
            }
            
            // взять цифры c правой границы матрицы (сверху вниз)
            for (int i = 1; i < N-1; i++)
            {
                numbers += matrix[i, M-1];
            }
            // взять цифры с нижней границы матрицы (слева направо)
            for (int i = M - 1; i >= 0; i--)
            {
                numbers += matrix[N-1, i];
            }
            // взять цифры c левой границы матрицы (снизу вверх)
            for (int i = N-2; i > 0; i--)
            {
                numbers += matrix[i, 0];
            }

            Console.WriteLine(numbers);
            Console.ReadLine();
        }

        private static void generateMatrix()
        {
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = r.Next(0, 10);
                }
            }
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
