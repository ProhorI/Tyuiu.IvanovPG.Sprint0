using Tyuiu.IvanovPG.Sprint0.Task2.V0.Lib;

namespace Tyuiu.IvanovPG.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServicesTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "������";
            var res = DataServices.GetMessage(name);

            Assert.AreEqual("������..., ������", res);

        }
    }
}