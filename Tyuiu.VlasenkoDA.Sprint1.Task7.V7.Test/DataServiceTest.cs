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
            // ������������� ����� ������ ������
            _dataService = new DataService();
        }

        [TestMethod]
        public void ValidExpression()
        {
            // ������ �������� ��� �����
            double x = 1.0;
            double y = 2.0;

            // ��������� ��������� (��������, �������� ������� ��� ������� �������)
            double expected = Math.Cos(x) / (Math.PI - 2 * Math.Pow(y, x)) + 16 * x * Math.Cos(x * y) - 2;

            // ���������� ���������� ���������� �� 3 ������ ����� �������
            expected = Math.Round(expected, 3);

            // �������� ��������� �� ������ Calculate
            double result = _dataService.Calculate(x, y);

            // ���������, ��� ��������� ������������� ���������� � ��������� �� 3 ������
            Assert.AreEqual(expected, result, 0.001, "��������� ���������� �������.");
        }
    }
}