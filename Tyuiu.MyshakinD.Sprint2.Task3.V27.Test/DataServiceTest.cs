using Tyuiu.MyshakinD.Sprint2.Task3.V27.Lib;

namespace Tyuiu.MyshakinD.Sprint2.Task3.V27.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            var res = ds.Calculate(x);
            double wait = 1.082;
            Assert.AreEqual(wait, res);
        }
    }
}