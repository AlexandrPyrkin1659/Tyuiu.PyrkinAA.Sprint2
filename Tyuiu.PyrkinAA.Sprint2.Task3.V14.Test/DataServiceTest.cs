using Tyuiu.PyrkinAA.Sprint2.Task3.V14.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tyuiu.PyrkinAA.Sprint2.Task3.V14.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateXGreaterThan1() 
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = -25;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateXEquals0() 
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.75;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateXInInterval() 
        {
            DataService ds = new DataService();
            double x = -5;
            double wait = 0.822; 
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateXLessThanMinus18() 
        {
            DataService ds = new DataService();
            double x = -20;
            double wait = -219.95;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateXNearOne() 
        {
            DataService ds = new DataService();
            double x = 1.0001;
            double part = (x + 1) / (x - 1); 
            double cube = Math.Pow(part, 3); 
            double wait = x - cube; 
            wait = Math.Round(wait, 3);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 1e9);
        }

        [TestMethod]
        public void ValidCalculateXNearMinus18() 
        {
            DataService ds = new DataService();
            double x = -17.999;
            double wait = Math.Pow(1 + 1 / (x * x), x);
            wait = Math.Round(wait, 3);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}