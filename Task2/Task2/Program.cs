using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static int N = 6;
        static int[,] matrix;

        static void Main(string[] args)
        {
            fillMatrix();
            showMatrix();

            calcQuad1();
            calcQuad2();
            calcQuad3();
            calcQuad4();

            Console.ReadLine();
        }

        private static void fillMatrix()
        {
            Random r = new Random();

            matrix = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = r.Next(0, 10);
                }
            }
        }


        private static void calcQuad1()
        {
            int sum = 0;

            for (int i = 0; i < N/2; i++)
            {
                for (int j = 0; j < N/2; j++)
                {
                    if (j >= (N/2-1) - i)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine("Quad 1 sum: " + sum);
        }


        private static void calcQuad2()
        {
            int sum = 0;

            for (int i = 0; i < N / 2; i++)
            {
                for (int j = N/2; j < N; j++)
                {
                    if (j >= (N - 1) - i)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine("Quad 2 sum: " + sum);
        }

        private static void calcQuad3()
        {
            int sum = 0;

            for (int i = N/2; i < N; i++)
            {
                for (int j = 0; j < N / 2; j++)
                {
                    if (j >= (N / 2 - 1) - (i-N/2))
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine("Quad 3 sum: " + sum);
        }

        private static void calcQuad4()
        {
            int sum = 0;

            for (int i = N/2; i < N; i++)
            {
                for (int j = N / 2; j < N; j++)
                {
                    if (j >= (N - 1) - (i-N/2))
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine("Quad 4 sum: " + sum);
        }

        private static void showMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.Write("\r\n");

                if (i == (N / 2 - 1)) Console.WriteLine(); // Для разделения квадратов
            }
        }
    }
}
