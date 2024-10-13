using System.ComponentModel;
using System.Resources;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MyshakinD.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string mast = "";
            string kart = "";
            switch (value2)
            {
                case 6:
                    mast = "Шестерка";
                    break;
                case 7:
                    mast = "Семерка";
                    break;
                case 8:
                    mast = "Восьмерка";
                    break;
                case 9:
                    mast = "Девятка";
                    break;
                case 10:
                    mast = "Десятка";
                    break;
                case 11:
                    mast = "Валет";
                    break;
                case 12:
                    mast = "Дама";
                    break;
                case 13:
                    mast = "Король";
                    break;
                case 14:
                    mast = "Туз";
                    break;
                default:
                    throw new ArgumentException($"Карта должна быть от 6 до 14. Значение {value1}");
            }
            switch (value1)
            {
                case 1:
                    kart = "пик";
                    break;
                case 2:
                    kart = "треф";
                    break;
                case 3:
                    kart = "бубен";
                    break;
                case 4:
                    kart = "черв";
                    break;
                default:
                    throw new ArgumentException($"Масть должна быть от 1 до 4. Значение {value2}");
            }
            return ($"{mast} {kart}");
        }
    }
}
