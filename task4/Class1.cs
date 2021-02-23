using System;

namespace task4
{
    public class Parametr
    {
        //Написать программу обмена значениями двух переменных.
        //а) с использованием третьей переменной;
        //б) без использования третьей переменной.
        public static void Solve1()
        {
            Console.Write("Enter parametr a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter parametr b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            //а) с использованием третьей переменной;
            // int c = a;
            //   a = b;
            // b = c;
            //б) без использования третьей переменной.
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write(a + " " + b);
        }
    }
}
