using System;

namespace task2
{
    //Вывести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМП)
    //по формуле I=m/(h*h); где m - масса тела в кг; h - рост в м.
    public class Bodymassindex
    {
        public static void Run1()
        {
            Console.Write("Enter height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double I = weight / (height * height);
            Console.Write("Body mass index: ");
            Console.WriteLine($"{I,3:F5}");

          
        }
    }
}
