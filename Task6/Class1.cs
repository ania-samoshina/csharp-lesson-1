using System;

namespace Task6
{
    //Написать класс с методами, которые могут пригодиться в вашей учебе(print, pause).
    public class PR
    {
        public static void Print(string mess)
        {
           int x = Console.WindowWidth;
            var center = x / 2 + mess.Length / 2; // выражаем центр экрана
            Console.WriteLine("{0," + center + "}", mess);
        }
    }
}
