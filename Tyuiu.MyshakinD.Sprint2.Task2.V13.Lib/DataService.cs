using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MyshakinD.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x == 4 & y == 3) || ((x == 4 || (x > 8 & x < 13)) & (y > 2 & y < 5))) || ((x == 4 || (x > 7 & x < 13) & y == 5) || ((x > 2 & x < 14) & y == 6) || ((x == 4 || (x > 7 & x < 14)) & (y > 6 & y < 9)) || ((x > 7 & x < 13) & y == 9) || ((x > 5 & x < 13) & y == 10) || ((x > 2 & x < 10) & y == 11) || ((x > 6 & x < 10) & y == 12)))
            {
                res = true;
            }
            else res = false;
            return res;
        }
    }
}
