using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task8
{
    class Program
    {

        static void Main(string[] args)
        {
            string colors = "WHITE RED BLUE";
            string[] set = colors.Split(' ');

            // Вычислить количество возможных вариантов
            int variants = set.Count() * 2;

            // Массив, в который будем записывать результаты
            string [,] results = new string[variants, set.Count()];

            // в ячейке c1 хранится цвет №1, 
            // в ячейке c2 - цвет №2,
            // в ячейке с3 - цвет №3
            int c1 = 0, c2 = 1, c3 = 2; 

            // Знаем, что каждый цвет обязан побывать первым по 2 раза
            // За выполнения этого условия отвечает counter. Он считает
            // сколько раз цвет побывал на первом месте.
            int counter = 1; 
            for (int i = 0; i < variants; i++)
            {
                // этап 1: записать цвета в ячейки
                results[i, 0] = set[c1]; 
                results[i, 1] = set[c2]; 
                results[i, 2] = set[c3];

                // если цвет уже побывал на первом месте 2 раза
                if (counter == 2)
                {
                    c1++; // Уступить первое место следующему цвету
                    counter = 1; // Сбросить счетчик
                    c2 = 0; // воткнуть цвет 2 на второе место
                    // Кто на третьем месте? 
                    // Это зависит от того, кто занимает 1-е место.
                    c3 = 3 - c1;
                }
                // если цвет сидит на 1-м месте лишь 2-й раз,
                // то поменять местами 2 других элемента
                else  
                {
                    int temp = c3;
                    c3 = c2; c2 = temp;
                    counter++;
                }
            }

            Console.WriteLine("Possible variants: ");

            for (int i = 0; i < variants; i++)
            {
                for (int j = 0; j < set.Count(); j++)
                {
                    Console.Write(results[i, j] + "\t");
                }
                Console.Write("\r\n");
            }


            Console.ReadLine();

        }
    }
}
