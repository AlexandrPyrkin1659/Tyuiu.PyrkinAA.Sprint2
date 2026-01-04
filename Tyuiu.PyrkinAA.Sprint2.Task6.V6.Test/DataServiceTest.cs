using Tyuiu.PyrkinAA.Sprint2.Task6.V6.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.PyrkinAA.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue1()
        {
            DataService ds = new DataService();
            int suit = 1;
            int rank = 12;
            string wait = "Дама пик";
            string res = ds.FindCardNameAndValue(suit, rank);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue2()
        {
            DataService ds = new DataService();
            int suit = 3;
            int rank = 6;
            string wait = "Шестерка бубен";
            string res = ds.FindCardNameAndValue(suit, rank);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue3()
        {
            DataService ds = new DataService();
            int suit = 4;
            int rank = 14;
            string wait = "Туз червей";
            string res = ds.FindCardNameAndValue(suit, rank);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue4()
        {
            DataService ds = new DataService();
            int suit = 2;
            int rank = 11;
            string wait = "Валет треф";
            string res = ds.FindCardNameAndValue(suit, rank);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue5()
        {
            DataService ds = new DataService();
            int suit = 1;
            int rank = 10;
            string wait = "Десятка пик";
            string res = ds.FindCardNameAndValue(suit, rank);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue6()
        {
            DataService ds = new DataService();
            int suit = 0;
            int rank = 10;
            string wait = "Десятка неизвестной масти";
            string res = ds.FindCardNameAndValue(suit, rank);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue7()
        {

            DataService ds = new DataService();
            int suit = 2;
            int rank = 5;
            string wait = "Неизвестное достоинство треф";
            string res = ds.FindCardNameAndValue(suit, rank);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue8()
        {
            DataService ds = new DataService();
            int suit = 3;
            int rank = 13;
            string wait = "Король бубен";
            string res = ds.FindCardNameAndValue(suit, rank);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue9()
        {
            DataService ds = new DataService();
            int suit = 4;
            int rank = 7;
            string wait = "Семерка червей";
            string res = ds.FindCardNameAndValue(suit, rank);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValue10()
        {
            DataService ds = new DataService();
            int suit = 2;
            int rank = 9;
            string wait = "Девятка треф";
            string res = ds.FindCardNameAndValue(suit, rank);
            Assert.AreEqual(wait, res);
        }
    }
}