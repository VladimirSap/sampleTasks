using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static string set = "RED   YELLOW GREEN/ YELLOW GREEN   RED/ RED RED GREEN/" +
            "GREEN YELLOW   RED";

        static void Main(string[] args)
        {
            string[] trafficLight = set.Split('/');

            for (int i = 0; i < trafficLight.Count(); i++)
            {
                // Если внутри набора цвета разделены кучей пробелов,
                // то заменить их на единственный пробел
                // добавь using System.Text.RegularExpressions (регулярные выражения)
                trafficLight[i] = Regex.Replace(trafficLight[i], " {2,}", " ");
                // Убрать пробелы слева и справа
                trafficLight[i] = trafficLight[i].Trim();
            }
            // После этого цикла получаем подготовленные для сравнения с эталоном
            // тройки цветов

            bool isWrongExists = false;
            foreach(string str in trafficLight) {

                if (!str.Equals("RED YELLOW GREEN") && !str.Equals("GREEN YELLOW RED"))
                {
                    Console.WriteLine(str);
                    isWrongExists = true;
                }
            }

            if (!isWrongExists)
            {
                Console.WriteLine("Неисправных светофоров нет");
            }

            Console.ReadLine();
        }
    }
}
