using Tyuiu.MyshakinD.Sprint2.Task5.V6.Lib;

namespace Tyuiu.MyshakinD.Sprint2.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #2 | Выполнил: Мышакин Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Мышакин Данил              | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По заданным номеру масти m (1 <= m <= 4) и номеру достоинства карты     *");
            Console.WriteLine("* k (6 <= k <= 14) определить полное название (масть и достоинство)       *");
            Console.WriteLine("* соответствующей карты в виде «Дама пик», Шестерка бубен» и т. п.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер масти:");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер карты");
            int value2 = Convert.ToInt32(Console.ReadLine());
            var res = ds.FindCardNameAndValue(value1, value2);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
