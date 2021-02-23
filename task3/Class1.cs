using System;

namespace task3
{
    //а) Написать программу, которая подсчитывает расстояние между точками с координатами
    //x1, y1 и x2, y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)).
    //Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    //б) Выполните предыдущее задание, оформив вычисления расстояние между точками в виде метода.
    public class Formula
    {
       static void MO(double x1, double y1, double x2, double y2)
        {
           double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
           Console.WriteLine(r.ToString("F2"));
        }
        public static void Solve()
        {
            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            //а)
            //double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Console.WriteLine(r.ToString("F2")); 
            //б)
            MO(x1, y1,x2, y2);
        }
    }

}
