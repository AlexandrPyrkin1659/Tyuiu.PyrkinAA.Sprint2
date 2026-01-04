using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PyrkinAA.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double parabolaY = x * x - 2;
            double lineY = x;



            bool isUnderParabola = y <= parabolaY;
            bool isAboveLine = y >= lineY;
            bool isInXRange = x <= 0;

            return isUnderParabola && isAboveLine && isInXRange;
        }

    }
 
}