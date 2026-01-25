using Tyuiu.PyrkinAA.Sprint2.Task4.V24.Lib;

namespace Tyuiu.PyrkinAA.Sprint2.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1, y = 1;
            double res = ds.Calculate(x, y);
           
            Assert.AreEqual(0.942, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 25, y = 2;
            double res = ds.Calculate(x, y);
          
            Assert.AreEqual(0.0, res); 
        }
    }
}