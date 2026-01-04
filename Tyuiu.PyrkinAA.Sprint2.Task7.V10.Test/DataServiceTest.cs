using Tyuiu.PyrkinAA.Sprint2.Task7.V10.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.7;
            double y = 0.7;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea3()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = -1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotNotInShadedArea()
        {
            DataService ds = new DataService();
            double x = -0.5;
            double y = 1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotOnBoundary()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true; 
            Assert.AreEqual(wait, res);
        }
    }
}