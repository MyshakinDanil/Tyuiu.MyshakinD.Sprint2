using Tyuiu.MyshakinD.Sprint2.Task0.V28.Lib;

namespace Tyuiu.MyshakinD.Sprint2.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int x = 111;
            int y = 735;
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, false, false, false, false };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}