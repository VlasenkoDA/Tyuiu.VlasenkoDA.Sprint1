using Tyuiu.VlasenkoDA.Sprint1.Task0.V8.Lib;

namespace Tyuiu.VlasenkoDA.Sprint1.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            var ds = new DataService();
            Assert.AreEqual(1.875, ds.Calculate());
        }
    }
}