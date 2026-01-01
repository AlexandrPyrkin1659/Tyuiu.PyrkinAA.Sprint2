using Tyuiu.PyrkinAA.Sprint2.Task2.V8.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService dataService = new DataService();

            int x = 9;
            int y = 12;

            bool res = dataService.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
