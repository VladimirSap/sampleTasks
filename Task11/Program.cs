using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task11
{
    class Program
    {
        static ArrayList tours = new ArrayList();
        static void Main(string[] args)
        {
            Tour t1 = new Tour("Egypt", 10, 4000);
            tours.Add(t1);
            Tour t2 = new Tour("USA", 12, 8000);
            tours.Add(t2);
            Tour t3 = new Tour("Crimea", 10, 4000);
            tours.Add(t3);

            // сколько денег у клиента
            int money = 120000;
            int [] difference = new int[tours.Count];
            int counter = 0;
            // подсчитать разницу по каждому из туров
            foreach (Tour t in tours)
            {
                difference[counter] = money - t.Days * t.DayCost;
                counter++;
            }

            int max = difference.Max();
            if (max < 0)
            {
                Console.WriteLine("You haven't enough money to go to tour");
            }
            else // если денег достаточно
            {

                Console.WriteLine("Max difference: " + max);

                // Может быть несколько туров с одинаковой стоимостью.
                // Поэтому ищем эти туры по максимальному значению
                for (int i = 0; i < difference.Count(); i++)
                {
                    if (difference[i] == max)
                    {
                        Console.WriteLine("Tour name: " + ((Tour)(tours[i])).Place);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
