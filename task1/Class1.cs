using System;

namespace task1
{
    //Написать программу Анкета. Последовательно задаются вопросы
    //(имя, фамилия, возраст, рост, вес). В результате вся информация
    //в одну строчку.
    //а) используя склеивание;
    //б) используя форматированный вывод;
    //в) используя вывод со знаком $.
    public class Anketa
    {
        public static void Run()
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            String surname = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            //а) используя склеивание;
            Console.WriteLine(name + " " + surname + " " + age + " " + height + " " + weight);
            //б) используя форматированный вывод;
            Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, height, weight);
            //в) используя вывод со знаком $.
            Console.WriteLine($"{name} {surname} {age} {height} {weight}");



        }
    }
}
