using Tyuiu.MyshakinD.Sprint2.Task6.V6.Lib;

namespace Tyuiu.MyshakinD.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int val1 = 2;
            int val2 = 12;
            var res = ds.FindCardNameAndValue(val1, val2);
            string wait = "дама треф";
            Assert.AreEqual(wait, res);
        }
    }
}