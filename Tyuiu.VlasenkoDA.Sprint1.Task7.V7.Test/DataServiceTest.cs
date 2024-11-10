using Tyuiu.VlasenkoDA.Sprint1.Task7.V7.Lib;
namespace Tyuiu.VlasenkoDA.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private DataService _dataService;

        [TestInitialize]
        public void TestInitialize()
        {
            // Инициализация перед каждым тестом
            _dataService = new DataService();
        }

        [TestMethod]
        public void ValidExpression()
        {
            // Пример значений для теста
            double x = 1.0;
            double y = 2.0;

            // Ожидаемый результат (например, вычислим вручную или зададим заранее)
            double expected = Math.Cos(x) / (Math.PI - 2 * Math.Pow(y, x)) + 16 * x * Math.Cos(x * y) - 2;

            // Округление ожидаемого результата до 3 знаков после запятой
            expected = Math.Round(expected, 3);

            // Получаем результат из метода Calculate
            double result = _dataService.Calculate(x, y);

            // Проверяем, что результат соответствует ожидаемому с точностью до 3 знаков
            Assert.AreEqual(expected, result, 0.001, "Результат вычисления неверен.");
        }
    }
}