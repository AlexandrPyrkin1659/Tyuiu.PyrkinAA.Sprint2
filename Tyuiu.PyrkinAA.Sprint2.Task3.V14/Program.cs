using Tyuiu.PyrkinAA.Sprint2.Task3.V14.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите значение переменной X: *");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* ЗНАЧЕНИЕ ФУНКЦИИ = *" + res);

            Console.ReadKey();
        }
    }
}