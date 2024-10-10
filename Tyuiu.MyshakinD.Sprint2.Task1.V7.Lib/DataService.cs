using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MyshakinD.Sprint2.Task1.V7.Lib
{
    public class DataService : ISprint2Task1V7
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == d) | (b == c + 2);
            res[1] = (a != d) & (c +2 != b);
            res[2] = (a < d) || (b < c);
            res[3] = (d > a) && (b > c);
            res[4] = !(b <= c);
            res[5] = (a >= b) ^ (d >= b);
            return res;
        }
    }
}
