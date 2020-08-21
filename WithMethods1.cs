using System;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = AskName();
            string name2 = AskName();
            int age1 = AskAge(name1);
            int age2 = AskAge(name2);
            {
                string older = (age1 > age2) ? name1 : name2;
                Question1(older);
                Question2(age2, age1);

            }
        }
        static string AskName()
        {
            string a;
            while (true)
            {
                Console.WriteLine("Напишите имя");
                a = Console.ReadLine();
                bool test = Int32.TryParse(a, out int chislo);
                if (test == true)
                {
                    Console.WriteLine("Напишите имя, а не цифры.");
                }
                else if (a.Length < 2 || a.Length > 30)
                {
                    Console.WriteLine("Такого имени не существует.");
                }
                else
                {
                    foreach (char v in a)
                    {
                        for (int i = 0; i <= 9; i++)
                        {
                            int[] Array = new int[9];
                            if (v != Array[i])
                            {
                                break;
                            }
                        }

                    }
                    break;
                }
            }
            return a;

        }
        static int AskAge(string name)
        {
            Console.WriteLine($"Введите возраст {name}");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
        static string Question1(string older)
        {
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
                        Console.WriteLine("Не верно!Ты разбираешься в математике так же, как и Генри Форд в астрономии!");
                        Console.WriteLine("Ошибка! Введите имя старшего еще раз.");

                    }
                
            }
                return older;
            
        }
        static int Question2(int age2, int age1)
        {
            Console.WriteLine("На сколько лет старше?");
            int answer2 = int.Parse(Console.ReadLine());
            int a = age2 - age1;
            int b = age1 - age2;
            int younger = (age1 < age2) ? a : b;
            while(answer2 != younger)
            {
                if (answer2 == younger)
                {
                    Console.WriteLine("Верно!");
                }
                else if (answer2 != younger)
                {
                    Console.WriteLine("Не верно!Ты разбираешься в математике так же, как и Генри Форд в астрономии!");
                    Console.WriteLine("Ошибка! Введите на сколько лет старше.");
                }
                
            }
            return younger;
        }
    }
}
        
    



