using Tyuiu.PyrkinAA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер масти (1-4):");
            Console.WriteLine("1 - пики");
            Console.WriteLine("2 - трефы");
            Console.WriteLine("3 - бубны");
            Console.WriteLine("4 - червы");

            int m = Convert.ToInt32(Console.ReadLine());
            string suitName;
            switch (m)
            {
                case 1:
                    suitName = "пики";
                    break;
                case 2:
                    suitName = "трефы";
                    break;
                case 3:
                    suitName = "бубны";
                    break;
                case 4:
                    suitName = "червы";
                    break;
                default:
                    suitName = "неизвестная масть (введите число от 1 до 4)";
                    break;
            }

            Console.WriteLine($"Масть: {suitName}");
        }
    }
}