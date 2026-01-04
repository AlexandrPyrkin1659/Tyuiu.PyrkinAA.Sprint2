using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PyrkinAA.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            double parabolaY = x * x - 2;
            double lineY1 = x;
            double lineY2 = -x;

            bool aboveParabola = y >= parabolaY;
            bool belowLine1 = y <= lineY1;
            bool aboveLine2 = y >= lineY2;
            bool rightOfYAxis = x >= 0;

            return aboveParabola && belowLine1 && aboveLine2 && rightOfYAxis;
        }
    }
}