using System;

namespace task5
{
    public class  MyNSC
    {
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) Сделать задание, только вывод организуйте в центре экрана.
        //в) Сделать задание б) с использованием собственных методов (например, print (string ms, int x, int y).
       public static void NameSC()
    {
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            string ms = "Ann Samoshina Moscow";
            Console.WriteLine(ms);


            //б) Сделать задание, только вывод организуйте в центре экрана.
            var wid = Console.WindowWidth;


            var center = wid / 2 + ms.Length  / 2; // выражаем центр экрана
            Console.WriteLine("{0," + center + "}", ms);

            //в) Сделать задание б) с использованием собственных методов (например, print (string ms, int x, int y).
            print(ms, wid);

            Console.ReadKey();

        }
        static void print (string mess, int x)
        {
            x = Console.WindowWidth;

            var center = x / 2 + mess.Length / 2; // выражаем центр экрана
            Console.WriteLine("{0," + center + "}", mess);
        }
    }
}
