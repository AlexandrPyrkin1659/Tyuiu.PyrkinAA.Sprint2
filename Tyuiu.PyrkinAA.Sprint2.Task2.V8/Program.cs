using Tyuiu.PyrkinAA.Sprint2.Task2.V8.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task2.V8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.WriteLine("Vvedi x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedi y:");
            int y = Convert.ToInt32(Console.ReadLine());

            bool res = dataService.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("Pobeda");
            }
            else
            {
                Console.WriteLine("Mimo");
            }
        }
    }
}