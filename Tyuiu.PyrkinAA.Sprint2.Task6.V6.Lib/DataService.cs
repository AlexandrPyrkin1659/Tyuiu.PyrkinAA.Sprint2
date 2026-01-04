using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PyrkinAA.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string suitName;
            string rankName;
            switch (value1)
            {
                case 1:
                    suitName = "пик";
                    break;
                case 2:
                    suitName = "треф";
                    break;
                case 3:
                    suitName = "бубен";
                    break;
                case 4:
                    suitName = "червей";
                    break;
                default:
                    suitName = "неизвестной масти";
                    break;
            }
            switch (value2)
            {
                case 6:
                    rankName = "Шестерка";
                    break;
                case 7:
                    rankName = "Семерка";
                    break;
                case 8:
                    rankName = "Восьмерка";
                    break;
                case 9:
                    rankName = "Девятка";
                    break;
                case 10:
                    rankName = "Десятка";
                    break;
                case 11:
                    rankName = "Валет";
                    break;
                case 12:
                    rankName = "Дама";
                    break;
                case 13:
                    rankName = "Король";
                    break;
                case 14:
                    rankName = "Туз";
                    break;
                default:
                    rankName = "Неизвестное достоинство";
                    break;
            }

            return $"{rankName} {suitName}";
        }
    }
}
