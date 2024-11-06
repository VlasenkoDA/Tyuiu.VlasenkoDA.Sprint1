using Tyuiu.VlasenkoDA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.VlasenkoDA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private DataService dataService;

        // Инициализация перед тестами
        [TestInitialize]
        public void Setup()
        {
            dataService = new DataService(); // Инициализируем объект DataService
        }

        [TestMethod]
        public void ValidExpression()
        {
            // Вводим тестовую строку
            string inputText = "На выставке я увидел много стеклянных и оловянных солдатиков";

            // Ожидаемый результат — два слова с "нн"
            string expected = "стеклянных, оловянных";

            // Получаем результат выполнения метода
            string result = dataService.CheckDoubleN(inputText);

            // Сравниваем полученный результат с ожидаемым
            Assert.AreEqual(expected, result);
        }
    }
}