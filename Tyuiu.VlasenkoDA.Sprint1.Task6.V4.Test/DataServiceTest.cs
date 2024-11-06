using Tyuiu.VlasenkoDA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.VlasenkoDA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private DataService dataService;

        // ������������� ����� �������
        [TestInitialize]
        public void Setup()
        {
            dataService = new DataService(); // �������������� ������ DataService
        }

        [TestMethod]
        public void ValidExpression()
        {
            // ������ �������� ������
            string inputText = "�� �������� � ������ ����� ���������� � ��������� ����������";

            // ��������� ��������� � ��� ����� � "��"
            string expected = "����������, ���������";

            // �������� ��������� ���������� ������
            string result = dataService.CheckDoubleN(inputText);

            // ���������� ���������� ��������� � ���������
            Assert.AreEqual(expected, result);
        }
    }
}