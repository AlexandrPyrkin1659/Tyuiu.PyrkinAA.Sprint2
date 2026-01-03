using Tyuiu.PyrkinAA.Sprint2.Task4.V24.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task4.V24
{
    class Program
    {
        static void Main (string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("*Введите значение переменой X: *");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*Введите значение Y: *");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Значение функции = " + res);

            Console.ReadKey();
        }
    }
}