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

           
            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(1, 12));

            
            Assert.AreEqual("Шестерка бубен", ds.FindCardNameAndValue(3, 6));

           
            Assert.AreEqual("Туз черв", ds.FindCardNameAndValue(4, 14));

           
            Assert.AreEqual("Валет треф", ds.FindCardNameAndValue(2, 11));

            
            Assert.AreEqual("Десятка пик", ds.FindCardNameAndValue(1, 10));
        }

        [TestMethod]
        public void InvalidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            
            Assert.AreEqual("Неизвестная карта неизвестная масть", ds.FindCardNameAndValue(0, 0));
            Assert.AreEqual("Неизвестная карта треф", ds.FindCardNameAndValue(2, 0));
            Assert.AreEqual("Шестерка неизвестная масть", ds.FindCardNameAndValue(0, 6));
        }
    }
}