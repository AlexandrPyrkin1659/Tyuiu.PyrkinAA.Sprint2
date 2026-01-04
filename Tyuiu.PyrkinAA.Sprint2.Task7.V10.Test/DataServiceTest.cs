using Tyuiu.PyrkinAA.Sprint2.Task7.V10.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValodCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.7;
            double y = 0.7;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;
            
            Assert.AreEqual(wait, res);

        }
    }
}
