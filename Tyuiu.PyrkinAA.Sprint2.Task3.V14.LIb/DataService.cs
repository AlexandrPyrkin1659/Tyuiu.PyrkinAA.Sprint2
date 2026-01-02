using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PyrkinAA.Sprint2.Task3.V14.LIb
{
    public class DataService : ISprint2Task3V14
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                y = x - Math.Pow((x + 1) / (x - 1), 3);
            }
            else if (x == 0)
            {
                y = 3 * Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 3)) + 10;
            }
            else if (-18 < x && x < 2)
            {
                
                y = Math.Pow(1 + 1 / (x * x), x);
            }
            else if (x < -18)
            {
                y = 11 * x - 1 / x; 
            }
            else
            {
               
               y = 0; 
            }

            return Math.Round(y, 3);
        }
    }
}
