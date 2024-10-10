using Tyuiu.MyshakinD.Sprint2.Task1.V7.Lib;

namespace Tyuiu.MyshakinD.Sprint2.Task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 195;
            int b = 16;
            int c = 14;
            int d = 45;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            
            Console.Title = "Спринт #2 | Выполнил: Мышакин Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Мышакин Данил              | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,                   *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также              *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
            Console.WriteLine("* (массив): (True, False, False, False, True, False), при a = 195,        *");
            Console.WriteLine("* b = 16, c = 14, d = 45                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
            Console.WriteLine("c = "+c);
            Console.WriteLine("d = "+d);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
