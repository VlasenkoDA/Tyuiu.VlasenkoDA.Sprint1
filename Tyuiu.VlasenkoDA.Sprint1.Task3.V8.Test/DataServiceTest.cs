using Tyuiu.VlasenkoDA.Sprint1.Task3.V8.Lib;
namespace Tyuiu.VlasenkoDA.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            // Arrange
            DataService ds = new DataService();
            double startAmount = 1000;
            double percent = 15;
            double timeDays = 30;

            // Act
            var res = ds.IncomeAmount(startAmount, percent, timeDays);

            // Assert
            Assert.AreEqual(12.329, res, 0.001); // Проверка с точностью до 0.001
        }
    }
}