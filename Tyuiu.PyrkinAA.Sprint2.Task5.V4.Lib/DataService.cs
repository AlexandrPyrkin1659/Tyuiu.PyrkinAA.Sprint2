using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PyrkinAA.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int value)
        {
            switch (value)
            {
                case 1:
                    return "пики";
                case 2:
                    return "трефы";
                case 3:
                    return "бубны";
                case 4:
                    return "червы";
                default:
                    return "неизвестная масть";
            }
        }
    }
}