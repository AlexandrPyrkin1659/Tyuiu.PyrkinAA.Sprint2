using Tyuiu.PyrkinAA.Sprint2.Task3.V14.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1() 
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = -26; 
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2() 
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 9; 
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate3() 
        {
            DataService ds = new DataService();
            double x = -5;
            double wait = 0.993; 
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001); 
        }

        [TestMethod]
        public void ValidCalculate4() 
        {
            DataService ds = new DataService();
            double x = -20;
            double wait = -219.95; 
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate5() 
        {
            DataService ds = new DataService();
            double x = 1.0001;
            double wait = 1.0001 - Math.Pow((2.0001) / (0.0001), 3);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate6() 
        {
            DataService ds = new DataService();
            double x = -17.9999;
            double wait = Math.Pow(1 + 1 / (x * x), x);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
