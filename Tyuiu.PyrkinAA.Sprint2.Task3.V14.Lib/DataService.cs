using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PyrkinAA.Sprint2.Task3.V14.Lib;

public class DataService : ISprint2Task3V15
{
    public double Calculate(double x)
    {
        double result;


        if (x > 1)
        {
            result = x - Math.Pow((x + 1) / (x - 1), 3);
        }

        else if (Math.Abs(x) < 0.00001)
        {
            result = 3 * x * x - Math.Cos(x * x * x) + 10;
        }

        else if (x > -18 && x < 2)
        {

            if (Math.Abs(x) < 0.00001)
            {

                result = 3 * x * x - Math.Cos(x * x * x) + 10;
            }
            else
            {
                result = Math.Pow(1 + 1 / (x * x), x);
            }
        }

        else if (x < -18)
        {
            result = 11 * x - (1 / x);
        }

        else
        {
            if (Math.Abs(x - 2) < 0.00001)
            {
                throw new ArgumentException("x = 2 не определено");
            }
            else if (Math.Abs(x + 18) < 0.00001)
            {
                throw new ArgumentException("x = -18 не определено");
            }
            else if (Math.Abs(x - 1) < 0.00001)
            {
                throw new DivideByZeroException("x = 1 приводит к делению на ноль");
            }
            else
            {
                throw new ArgumentException($"Неподдерживаемое значение x = {x}");
            }
        }


        return Math.Round(result, 3);
    }
}
