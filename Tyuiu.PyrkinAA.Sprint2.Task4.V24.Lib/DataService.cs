using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PyrkinAA.Sprint2.Task4.V24.Lib
{
    public class DataService : ISprint2Task4V24
    {
        public double Calculate(double x, double y)
        {
            double result;

            if (x + 2 > y + 24)
            {
                result = x * Math.Pow((y + 1) / (x + 2), x);
            }
            else
            {
                
                double numerator = Math.Pow(y, 2) + Math.Cos(Math.Pow(x, 2)) + 9; 
                double denominator = Math.Pow(x, 2) - Math.Sin(Math.Pow(y, 2)) + 12; 
                result = numerator / denominator;
            }

           
            return Math.Truncate(result * 1000) / 1000;
        }
    }
}