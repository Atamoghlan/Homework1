using System;

namespace Homework_Massivi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое имя");
            string name1 = Console.ReadLine();
            Console.WriteLine("Введите второе имя");
            string name2 = Console.ReadLine();
            Console.WriteLine($"Введите возраст {name1}");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите возраст {name2}");
            int age2 = Convert.ToInt32(Console.ReadLine());

            string older = (age1 > age2) ? name1 : name2;
            string answer1 = "";
            while (answer1 != older)
            {
                Console.WriteLine("Кто из них старше?");
                answer1 = Console.ReadLine();
                if (answer1 == older)
                {
                    Console.WriteLine("Верно!");
                }
                else if (answer1 != older)
                {
                    Console.WriteLine("Не верно!Ты разбираешься в математике так же, как и Генри Форд в астрономии!Введите имя старшего еще раз.");
                }
            }
            int answer2 = 0;
            int a = age2 - age1;
            int b = age1 - age2;
            int younger = (age1 < age2) ? a : b;
            while (answer2 != younger)
            {
                Console.WriteLine("На сколько лет старше?");
                answer2 = int.Parse(Console.ReadLine());
                if (answer2 == younger)
                {
                    Console.WriteLine("Верно!");
                }
                else if (answer2 != younger)
                {
                    Console.WriteLine("Не верно!Ты разбираешься в математике так же, как и Генри Форд в астрономии!Введите на сколько лет старше.");
                }
            }
        }
    }
}


