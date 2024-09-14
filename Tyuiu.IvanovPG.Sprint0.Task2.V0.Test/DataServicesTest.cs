using Tyuiu.IvanovPG.Sprint0.Task2.V0.Lib;

namespace Tyuiu.IvanovPG.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServicesTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Прохор";
            var res = DataServices.GetMessage(name);

            Assert.AreEqual("Привет..., Прохор", res);

        }
    }
}