using Tyuiu.VlasenkoDA.Sprint1.Task2.V13.Lib;
namespace Tyuiu.VlasenkoDA.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertMilesToKm(x);
            Assert.AreEqual(1.609, res, 0.001); // Добавляем допуск 0.001 для сравнения
        }
    }
}