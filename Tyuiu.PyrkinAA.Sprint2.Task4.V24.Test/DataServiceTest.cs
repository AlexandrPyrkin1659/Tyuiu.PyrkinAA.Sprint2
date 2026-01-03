using Tyuiu.PyrkinAA.Sprint2.Task4.V24.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.PyrkinAA.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateConditionTrue() 
        {
            DataService ds = new DataService();
            double x = 30;
            double y = 5;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0, res, 0.001); 
        }

        [TestMethod]
        public void ValidCalculateConditionFalse() 
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 30;

            // Правильный расчёт:
            // 5 + 2 = 7, 30 + 24 = 54 → 7 > 54? НЕТ → вторая ветка

            double numerator = Math.Pow(y, 2) + Math.Pow(Math.Cos(x), 2) + 9;
            double denominator = Math.Pow(x, 2) - Math.Pow(Math.Sin(y), 2) + 12;
            double wait = Math.Round(numerator / denominator, 3);

            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateEdgeCase() 
        {
            DataService ds = new DataService();
            double x = 15;
            double y = -7;
            double numerator = Math.Pow(y, 2) + Math.Pow(Math.Cos(x), 2) + 9;
            double denominator = Math.Pow(x, 2) - Math.Pow(Math.Sin(y), 2) + 12;
            double wait = Math.Round(numerator / denominator, 3);

            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateSimpleTrue()
        {
            DataService ds = new DataService();
            double x = 100;
            double y = 50;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateSimpleFalse()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = Math.Round(
                (Math.Pow(3, 2) + Math.Pow(Math.Cos(2), 2) + 9)
                / (Math.Pow(2, 2) - Math.Pow(Math.Sin(3), 2) + 12),
                3
            );

            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
