using Tyuiu.MyshakinD.Sprint2.Task2.V13.Lib;

namespace Tyuiu.MyshakinD.Sprint2.Task2.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #2 | Выполнил: Мышакин Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Мышакин Данил              | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            var res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
