using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task9
{
    class Program
    {
        static int N = 5, M = 3;
        static int[,] matrix = new int[N, M];

        static int step = 1; // На сколько ячеек смещать массив

        static void Main(string[] args)
        {
            fillMatrix();

            Console.WriteLine("Initial matrix");
            showMatrix();

            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0) // четная строка?
                {
                    moveArrayToLeft(i);
                }
                else // нечетные
                {
                    moveArrayToRight(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Matrix after movement");
            showMatrix();

            Console.ReadLine();

        }

        private static void fillMatrix()
        {
            Random r = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = r.Next(10, 50);
                }
            }
        }

        static void moveArrayToLeft(int i)
        {
            for (int j = step; j < M; j++)
            {
                // присвоить предыдущему значению текущее
                matrix[i, j - step] = matrix[i, j];
            }

            // Заполнить нулями освободившиеся ячейки
            for (int k = 0; k < step; k++)
            {
                matrix[i, (M-1) - k] = 0;
            }   
        }

        static void moveArrayToRight(int i)
        {
            for (int j = M-1; j >= step; j--)
            {
                // присвоить предыдущему значению текущее
                matrix[i, j] = matrix[i, j-step];
            }

            // Заполнить нулями освободившиеся ячейки
            for (int k = 0; k < step; k++)
            {
                matrix[i, k] = 0;
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
