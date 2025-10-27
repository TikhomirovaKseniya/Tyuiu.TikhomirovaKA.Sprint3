using Tyuiu.TikhomirovaKA.Sprint3.Task0.Lib;

namespace Tyuiu.TikhomirovaKA.Sprint3.Task0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 4;
            int sv = 1;
            int ev = 5;
            double res = ds.GetMultiplySeries(a, sv, ev);
            Assert.AreEqual(-346976844.821, res);
        }
    }
}
