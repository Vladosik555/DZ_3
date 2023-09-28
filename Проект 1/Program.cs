using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Упражнение 4.1");
            Console.WriteLine("Данная программа показывает считывает число от 1 до 365 и переводит его в месяц с датой");
            Console.WriteLine("\nВведите число от 1 до 365, после чего программа переведет его в календарь");
            bool numb = int.TryParse(Console.ReadLine(),out int number);
            if (numb == true)
            {
                switch (number)
                {
                    case int n when (n >= 0 && n <= 31):
                        Console.WriteLine($"{number} января ");
                        break;
                    case int n when (n >= 32 && n <= 59):
                        Console.WriteLine((number - 31) + " февраля");
                        break;
                    case int n when (n >= 60 && n <= 90):
                        Console.WriteLine((number - 59) + "марта");
                        break;
                    case int n when (n >= 91 && n <= 120):
                        Console.WriteLine((number - 90) + " апреля");
                        break;
                    case int n when (n >= 121 && n <= 151):
                        Console.WriteLine((number - 120) + " мая");
                        break;
                    case int n when (n >= 152 && n <= 181):
                        Console.WriteLine((number - 151) + " июня");
                        break;
                    case int n when (n >= 182 && n <= 212):
                        Console.WriteLine((number - 181) + " июля");
                        break;
                    case int n when (n >= 213 && n <= 243):
                        Console.WriteLine((number - 212) + " августа");
                        break;
                    case int n when (n >= 244 && n <= 273):
                        Console.WriteLine((number - 243) + "сентября");
                        break;
                    case int n when (n >= 274 && n <= 304):
                        Console.WriteLine((number - 273) + " октября");
                        break;
                    case int n when (n >= 305 && n <= 334):
                        Console.WriteLine((number - 304) + " ноября");
                        break;
                    case int n when (n >= 335 && n <= 365):
                        Console.WriteLine((number - 334) + " декабря");
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Нельзя вводить буквы или другие символы");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 4.2");
            Console.WriteLine("Данная программа показывает считывает число от 1 до 365 и переводит его в месяц с датой," +
                "но также может выдавать исключение, если число не входит в промежут от 1 до 365");
            Console.WriteLine("\nВведите число от 1 до 365, после чего программа переведет его в календарь");
            bool numb1 = int.TryParse(Console.ReadLine(), out int number1);
            if (numb1 == true)
            {
                switch (number1)
                {
                    case int n when (n >= 0 && n <= 31):
                        Console.WriteLine($"{number1} января ");
                        break;
                    case int n when (n >= 32 && n <= 59):
                        Console.WriteLine((number1 - 31) + " февраля");
                        break;
                    case int n when (n >= 60 && n <= 90):
                        Console.WriteLine((number1 - 59) + "марта");
                        break;
                    case int n when (n >= 91 && n <= 120):
                        Console.WriteLine((number1 - 90) + " апреля");
                        break;
                    case int n when (n >= 121 && n <= 151):
                        Console.WriteLine((number1 - 120) + " мая");
                        break;
                    case int n when (n >= 152 && n <= 181):
                        Console.WriteLine((number1 - 151) + " июня");
                        break;
                    case int n when (n >= 182 && n <= 212):
                        Console.WriteLine((number1 - 181) + " июля");
                        break;
                    case int n when (n >= 213 && n <= 243):
                        Console.WriteLine((number1 - 212) + " августа");
                        break;
                    case int n when (n >= 244 && n <= 273):
                        Console.WriteLine((number1 - 243) + "сентября");
                        break;
                    case int n when (n >= 274 && n <= 304):
                        Console.WriteLine((number1 - 273) + " октября");
                        break;
                    case int n when (n >= 305 && n <= 334):
                        Console.WriteLine((number1 - 304) + " ноября");
                        break;
                    case int n when (n >= 335 && n <= 365):
                        Console.WriteLine((number1 - 334) + " декабря");
                        break;
                    default:
                        Console.WriteLine("Вы ввели число, которое не входит в промежуток от 1 до 365");
                        break;
                } 
            }
            else
            {
                Console.WriteLine("Нельзя вводить буквы или другие символы");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Домашнее задание 4.1");
            Console.WriteLine("Задание 4.1 и 4.2 с добавлением високосного года");
            Console.WriteLine("Укажите год");
            bool year1 = int.TryParse(Console.ReadLine(), out int year);
            if (year1 == true)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine($"{year} является високосным");
                    Console.WriteLine("\nВведите число от 1 до 366, после чего программма переведет его в календарь");
                    int number2 = int.Parse(Console.ReadLine());
                    switch (number2)
                    {
                        case int n when (n >= 0 && n <= 31):
                            Console.WriteLine($"{number2} января ");
                            break;
                        case int n when (n >= 32 && n <= 60):
                            Console.WriteLine((number2 - 31) + " февраля");
                            break;
                        case int n when (n >= 61 && n <= 91):
                            Console.WriteLine((number2 - 60) + "марта");
                            break;
                        case int n when (n >= 92 && n <= 121):
                            Console.WriteLine((number2 - 91) + " апреля");
                            break;
                        case int n when (n >= 122 && n <= 152):
                            Console.WriteLine((number2 - 121) + " мая");
                            break;
                        case int n when (n >= 153 && n <= 182):
                            Console.WriteLine((number2 - 152) + " июня");
                            break;
                        case int n when (n >= 183 && n <= 213):
                            Console.WriteLine((number2 - 182) + " июля");
                            break;
                        case int n when (n >= 214 && n <= 244):
                            Console.WriteLine((number2 - 213) + " августа");
                            break;
                        case int n when (n >= 245 && n <= 274):
                            Console.WriteLine((number2 - 244) + "сентября");
                            break;
                        case int n when (n >= 275 && n <= 305):
                            Console.WriteLine((number2 - 274) + " октября");
                            break;
                        case int n when (n >= 306 && n <= 335):
                            Console.WriteLine((number2 - 305) + " ноября");
                            break;
                        case int n when (n >= 336 && n <= 366):
                            Console.WriteLine((number2 - 335) + " декабря");
                            break;
                        default:
                            Console.WriteLine("Вы ввели число, которое не входит в промежуток от 1 до 366");
                            break;
                    }
            
                
                }
                else
                {
                    Console.WriteLine($"{year} является невисокосным");
                    Console.WriteLine("\nВведите число от 1 до 365, после чего программа переведет его в календарь");
                    int number3 = int.Parse(Console.ReadLine());
                    switch (number3)
                    {
                        case int n when (n >= 0 && n <= 31):
                            Console.WriteLine($"{number3} января ");
                            break;
                        case int n when (n >= 32 && n <= 59):
                            Console.WriteLine((number3 - 31) + " февраля");
                            break;
                        case int n when (n >= 60 && n <= 90):
                            Console.WriteLine((number3 - 59) + "марта");
                            break;
                        case int n when (n >= 91 && n <= 120):
                            Console.WriteLine((number3 - 90) + " апреля");
                            break;
                        case int n when (n >= 121 && n <= 151):
                            Console.WriteLine((number3 - 120) + " мая");
                            break;
                        case int n when (n >= 152 && n <= 181):
                            Console.WriteLine((number3 - 151) + " июня");
                            break;
                        case int n when (n >= 182 && n <= 212):
                            Console.WriteLine((number3 - 181) + " июля");
                            break;
                        case int n when (n >= 213 && n <= 243):
                            Console.WriteLine((number3 - 212) + " августа");
                            break;
                        case int n when (n >= 244 && n <= 273):
                            Console.WriteLine((number3 - 243) + "сентября");
                            break;
                        case int n when (n >= 274 && n <= 304):
                            Console.WriteLine((number3 - 273) + " октября");
                            break;
                        case int n when (n >= 305 && n <= 334):
                            Console.WriteLine((number3 - 304) + " ноября");
                            break;
                        case int n when (n >= 335 && n <= 365):
                            Console.WriteLine((number3 - 334) + " декабря");
                            break;
                        default:
                            Console.WriteLine("Вы ввели число, которое не входит в промежуток от 1 до 365");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Нельзя вводить буквы или символы");
            }
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
        }
    }
}