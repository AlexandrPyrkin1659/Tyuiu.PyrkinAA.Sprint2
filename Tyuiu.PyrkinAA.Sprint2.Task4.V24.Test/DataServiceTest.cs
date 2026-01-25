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
           
        }
    }
}