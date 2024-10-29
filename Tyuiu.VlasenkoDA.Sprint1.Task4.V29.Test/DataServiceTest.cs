using Tyuiu.VlasenkoDA.Sprint1.Task4.V29.Lib;
namespace Tyuiu.VlasenkoDA.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            // Arrange
            var dataService = new DataService();
            double x = 4.0;
            double y = 2.0;
            double expected = Math.Sqrt(2.0 + Math.Abs(x - 2 * y)) / (3 * x * Math.Pow(y, 2));

            // Act
            double result = dataService.Calculate(x, y);

            // Assert
            Assert.AreEqual(expected, result, 0.294 );
        }
    }
}