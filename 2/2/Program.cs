using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1\n");
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Ответ: " + (number + 5));
            }
            else if (number < 0)
            {
                Console.WriteLine("Ответ" + (number - 5));
            }
            else
            {
                Console.WriteLine("Ошибка");
            }



    
            Console.WriteLine("\nЗадание №2\n");
            Console.WriteLine("Введите первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            if ((number1 > number2) && (number1 > number3))
            {
                Console.WriteLine("Ответ: " + number1);
            }
            else if ((number2 > number1) && (number2 > number3))
            {
                Console.WriteLine("Ответ: " + number2);
            }
            else { Console.WriteLine("Ответ: " + number3); }


           
            Console.WriteLine("\nЗадание №3\n");
            int res = 0;
            Console.WriteLine("Введите первое число: ");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int number_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int number_3 = Convert.ToInt32(Console.ReadLine());
            if (number_1 > 0)
            {
                res += number_1;
            }
            if (number_2 > 0)
            {
                res += number_2;
            }
            if (number_3 > 0)
            {
                res += number_3;
            }
            Console.WriteLine("Ответ: " + res);



           
            Console.WriteLine("\nЗадание №4\n");
            Console.WriteLine("Введите х: ");
            double number__ = Convert.ToDouble(Console.ReadLine());
            if (number__ > 10)
            {
                Console.WriteLine("Ответ: " + number__ * 2);
            }
            else { Console.WriteLine("Ответ: " + number__); }



           
            Console.WriteLine("\nЗадание №5\n");
            Console.WriteLine("Введите число: ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }


          
            Console.WriteLine("\nЗадание №6\n");
            for (int number_min = 200; number_min < 500; number_min++)
            {
                if (number_min % 17 == 0)
                {
                    Console.WriteLine("Ответ: " + number_min);
                    break;
                }
            }



        
            Console.WriteLine("\nЗадание №7\n");
            double km = 10;
            double summakm = km;
            int day_ = 1;
            while (km < 20)
            {
                km += km * 0.05;
                day++;
            }
            Console.WriteLine($"В {day_} день человек пройдет {km} км");

            km = 10;
            day_ = 1;
            while (summakm < 100)
            {
                km += km * 0.05;
                summakm += km;
                day_++;
            }
            Console.WriteLine($"За {day_} дней человек пройдет 100км ");




          
            Console.WriteLine("\nЗадание №8\n");
            Console.WriteLine("Введите число факториала: ");
            int chislo_factoriala = Convert.ToInt32(Console.ReadLine());
            int g = 1;
            for (int o = 1; chislo_factoriala >= o; o++)
            {
                g *= o;
            }
            Console.WriteLine("Ответ: " + g);


            Console.WriteLine("\nЗадание №9\n");
            Console.WriteLine("Введите натуральное число: ");
            int number_natur = Convert.ToInt32(Console.ReadLine());
            for (int j = 2; number_natur >= j; j++)
            {
                if (number_natur % j == 0)
                {
                    Console.WriteLine("Ответ: " + j);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
