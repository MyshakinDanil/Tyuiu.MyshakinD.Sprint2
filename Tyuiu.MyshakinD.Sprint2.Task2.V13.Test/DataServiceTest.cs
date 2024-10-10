using Tyuiu.MyshakinD.Sprint2.Task2.V13.Lib;

namespace Tyuiu.MyshakinD.Sprint2.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            int x = 9;
            int y = 3;
            var res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}