using Tyuiu.PyrkinAA.Sprint2.Task3.V14.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task3.V14.Lib.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {

        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();


            double result1 = ds.Calculate(2.5);
            Console.WriteLine($"При x = 2.5, y = {result1}");


            double result2 = ds.Calculate(0);
            Console.WriteLine($"При x = 0, y = {result2}");


            double result3 = ds.Calculate(-5);
            Console.WriteLine($"При x = -5, y = {result3}");


            double result4 = ds.Calculate(-20);
            Console.WriteLine($"При x = -20, y = {result4}");
        }
    }
}