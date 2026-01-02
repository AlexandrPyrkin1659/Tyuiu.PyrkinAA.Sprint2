using Tyuiu.PyrkinAA.Sprint2.Task3.V14.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tyuiu.PyrkinAA.Sprint2.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1() // Для x > 1, например x = 2
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = -26; // Здесь нужно посчитать ожидаемое значение
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2() // Для x = 0
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 9; // 3*0 - cos(0) + 10 = 0 - 1 + 10 = 9
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate3() // Для -18 < x < 2, например x = -5
        {
            DataService ds = new DataService();
            double x = -5;
            double wait = 0.993; // (1 + 1/25)^(-5) = (1.04)^(-5) ≈ 0.993
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001); // Проверка с точностью 0.001
        }

        [TestMethod]
        public void ValidCalculate4() // Для x < -18, например x = -20
        {
            DataService ds = new DataService();
            double x = -20;
            double wait = -219.95; // 11*(-20) - 1/(-20) = -220 + 0.05 = -219.95
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate5() // Граничный случай: x = 1.0001 (чуть больше 1)
        {
            DataService ds = new DataService();
            double x = 1.0001;
            double wait = 1.0001 - Math.Pow((2.0001) / (0.0001), 3);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculate6() // Граничный случай: x = -17.9999 (чуть больше -18)
        {
            DataService ds = new DataService();
            double x = -17.9999;
            double wait = Math.Pow(1 + 1 / (x * x), x);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
