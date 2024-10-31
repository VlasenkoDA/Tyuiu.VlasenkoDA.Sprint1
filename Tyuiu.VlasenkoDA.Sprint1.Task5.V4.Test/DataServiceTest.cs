using Tyuiu.VlasenkoDA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.VlasenkoDA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            // Arrange
            DataService ds = new DataService();
            int timeInSeconds = 3600;

            // Act
            int result = ds.SecondsToHours(timeInSeconds);

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}
        