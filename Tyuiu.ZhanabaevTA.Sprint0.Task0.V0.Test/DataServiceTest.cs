using Tyuiu.ZhanabaevTA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint0.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Òàëãàò";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Ïðèâåò, Òàëãàò", res);
        }
    }
}