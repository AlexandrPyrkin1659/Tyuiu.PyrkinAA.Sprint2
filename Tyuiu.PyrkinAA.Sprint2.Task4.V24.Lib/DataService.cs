using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PyrkinAA.Sprint2.Task4.V24.Lib
{
    public class DataService : ISprint2Task4V24
    {
        public double Calculate(double x, double y)
        {
            double result = (x + 2 > y + 24)
                ? x * Math.Pow((y + 1) / (x + 2), x)
                : (Math.Pow(y, 2) + Math.Pow(Math.Cos(x), 2) + 9)
                  / (Math.Pow(x, 2) - Math.Pow(Math.Sin(y), 2) + 12);

            return Math.Round(result, 3);
        }
    }
}