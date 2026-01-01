using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PyrkinAA.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (x < 3 || x > 13 || y < 2 || y > 14)
            {
                res = false;
            }
            else if (y >= 8 && y <= 10 && x >= 7 && x <= 9)
            {
                res = false;
            }
            else
            {
                res = true;
            }

            return res;
        }
    }
}
