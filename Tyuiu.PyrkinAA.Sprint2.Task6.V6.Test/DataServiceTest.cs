using Tyuiu.PyrkinAA.Sprint2.Task6.V6.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.PyrkinAA.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

           
            Assert.AreEqual("дама пик", ds.FindCardNameAndValue(1, 12));

            
            Assert.AreEqual("шестерка бубен", ds.FindCardNameAndValue(3, 6));

            
            Assert.AreEqual("туз черв", ds.FindCardNameAndValue(4, 14));

            
            Assert.AreEqual("валет треф", ds.FindCardNameAndValue(2, 11));

            
            Assert.AreEqual("десятка пик", ds.FindCardNameAndValue(1, 10));
        }

        [TestMethod]
        public void InvalidFindCardNameAndValue()
        {
            DataService ds = new DataService();

           
            Assert.AreEqual("неизвестная карта неизвестная масть", ds.FindCardNameAndValue(0, 0));
            Assert.AreEqual("неизвестная карта треф", ds.FindCardNameAndValue(2, 0));
            Assert.AreEqual("шестерка неизвестная масть", ds.FindCardNameAndValue(0, 6));
        }
    }
}