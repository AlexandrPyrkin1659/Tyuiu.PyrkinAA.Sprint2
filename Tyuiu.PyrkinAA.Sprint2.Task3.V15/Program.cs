using Tyuiu.PyrkinAA.Sprint2.Task3.V15.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task3.V15
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double y = ds.Calculate(x);

            Console.WriteLine($"Y = {y}");
            Console.ReadKey();
        }
    }
}