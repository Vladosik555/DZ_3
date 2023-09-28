using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
enum Dayweek
{
    Понедельник = 1,
    Вторник = 2,
    Среда = 3,
    Четверг = 4,
    Пятница = 5,
    Суббота = 6,
    Воскресенье = 7
}
namespace Проект___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание номер 1");
            Console.WriteLine("Последовательность 10 чисел");
            Console.WriteLine("Введите 10 чисел через запятую");
            string numb = Console.ReadLine();
            string[] number = numb.Split(',');
            double[] order = new double[number.Length];
            bool qwerty = true;
            if (number.Length == 10)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    bool num = Double.TryParse(number[i], out order[i]);
                    if (num == false)
                    {
                        Console.WriteLine("Нельзя вводить буквы");
                        qwerty = false;
                        break;
                    }
                }
                if (qwerty)
                {
                    for (int i = 0; i < order.Length - 1; i++)
                    {
                        if (order[i] > order[i + 1])
                        {
                            Console.WriteLine($"число по индексом {i + 1},сбивает последовательность");
                            qwerty = false;
                            break;
                        }

                    }
                }
                if (qwerty)
                {
                    Console.WriteLine("Последовательность является упорядоченной по возрастанию");
                }
            }
            else 
            {
                Console.WriteLine("Вы ввели больше или меньше 10 чисел через запятую");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            Console.WriteLine("\nЗадание номер 2");
            Console.WriteLine("Задание с картами");
            Console.WriteLine("Введите ту карту которую хотите вывести на экран. Например 6 - шестерка, 9 - девятка" +
                "\n11 - валет, 12 - дама, 13 - король, 14 - туз");
            string [] card = {"шестёрка", "семёрка", "восьмёрка", "девятка", "десятка", "валет", "дама", "король", "Туз"};
            try
            {
                int otvet = Convert.ToInt32(Console.ReadLine()) - 6;
                Console.WriteLine($"Ваша карта: {card[otvet]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Нельзя вводить буквы");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Вы не вошли в промежуток от 6 до 14");
            }
            finally
            {

            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            Console.WriteLine("\nЗадание номер 3");
            Console.WriteLine("принимает на входе строку и производит выходные данные в соответствии таблицей:");
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            text = text.ToLower();
            switch (text)
            {
                case "jabroni":
                    Console.WriteLine("Ответ: Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Ответ: Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Ответ: Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Ответ: Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Ответ: Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Ответ: Cristal");
                    break;
                default:
                    Console.WriteLine("Ответ: Beer");
                    break;
            }
            Console.WriteLine("\nДля того чтобы продолжить, нажмите любую клавишу");
            Console.ReadKey();
            Console.WriteLine("Задание номер 4");
            Console.WriteLine("Данная программа выдает дни недели");
            Console.WriteLine("Выберите день недели: Понедельник - 1, Вторник - 2, Среда - 3, Четверг - 4" +
                "\nПятница - 5, Суббота - 6, Воскресенье - 7");
            Dayweek day = (Dayweek)int.Parse(Console.ReadLine());
            switch (day)
            {
                case Dayweek.Понедельник:
            Console.WriteLine("Понедельник");
                    break;
                case Dayweek.Вторник:
                    Console.WriteLine("Вторник");
                    break;
                case Dayweek.Среда:
                    Console.WriteLine("Среда");
                    break;
                case Dayweek.Четверг:
                    Console.WriteLine("Четверг");
                    break;
                case Dayweek.Пятница:
                    Console.WriteLine("Пятница");
                    break;
                case Dayweek.Суббота:
                    Console.WriteLine("Суббота");
                    break;
                case Dayweek.Воскресенье:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Вы ввели символ, или букву. Либо вы ввели число, которое не входит в промежуток");
                    break;
            }
            
            Console.WriteLine("\nДля того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            Console.WriteLine("Задание номер 5");
            Console.WriteLine("Данная программа кладет нужные куклы в карзину");
            string[] dolls = new string[7] { "Hello Kitty" , "Toy car", "Lego", "Airplane", "Bucket", "Table hockey", "Barbie doll"};
            int result = 0;
            foreach (string doll in dolls)
            {
                if (doll == "Hello Kitty" || doll == "Barbie doll")
                {
                    result++;
                }
            }
            Console.WriteLine($"В вашей корзине {result} куклы");
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
            
            
        }
    }
}
