using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Program
    {
        static int N = 10;
        static int[,] matrix = new int[N, N];

        static void Main(string[] args)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = getValue(i, j);
                }
            }

            showMatrix();
            Console.ReadLine();
        }

        private static int getValue(int i, int j)
        {
            int res = 0;

            if (j >= 0 && j < N / 2) // левая часть? 
            {
                if (i >= 0 && i < N / 2) // первый квадрат?
                {
                    res = 77;
                }
                else // третий квадрат
                {
                    if (j < (N - 1) - i) // перед побочной диагональю?
                    {
                        res = 77;
                    }
                    else // за побочной диагональю
                    {
                        res = i + j;
                    }
                }
            }
            else
            {
                res = i + j; 
            }

            return res;
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
