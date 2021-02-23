using System;

namespace Courses1
{
    public class Pr1
    {
        public static void Main ()
        {
            Task6.PR.Print("Ann Samoshina");
            Console.Write("Enter the task number (1-6): ");
            int caseSwitch = Convert.ToInt32( Console.ReadLine());
            
            
            switch (caseSwitch)
            {
                case 1:
                    //первое задание
                    task1.Anketa.Run();
                    break;
                case 2:
                    //второе задание
                    task2.Bodymassindex.Run1();
                    break;
                case 3:
                    //третье задание
                    task3.Formula.Solve();
                    break;
                case 4:
                    //четвертое задание
                    task4.Parametr.Solve1();
                    break;
                case 5:
                    //пятое задание
                    task5.MyNSC.NameSC();
                    break;
                case 6:
                    //шестое задание
                    Task6.PR.Print("Ann");
                    break;
                          }
            Console.ReadKey();
        }
    }



}
