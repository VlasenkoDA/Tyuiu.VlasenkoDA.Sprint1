using Tyuiu.VlasenkoDA.Sprint1.Task1.V24.Lib;

namespace Tyuiu.VlasenkoDA.Sprint1.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0, res);

        }
    }
}