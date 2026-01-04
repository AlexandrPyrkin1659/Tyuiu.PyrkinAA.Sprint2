using Tyuiu.PyrkinAA.Sprint2.Task6.V6.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Примеры работы программы:");
            Console.WriteLine($"1. m=1, k=12: {ds.FindCardNameAndValue(1, 12)}");
            Console.WriteLine($"2. m=3, k=6: {ds.FindCardNameAndValue(3, 6)}");
            Console.WriteLine($"3. m=2, k=11: {ds.FindCardNameAndValue(2, 11)}");
            Console.WriteLine($"4. m=4, k=14: {ds.FindCardNameAndValue(4, 14)}");
            Console.WriteLine($"5. m=1, k=10: {ds.FindCardNameAndValue(1, 10)}");

            Console.ReadKey();
        }
    }
}