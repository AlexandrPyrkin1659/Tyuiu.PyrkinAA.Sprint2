using Tyuiu.PyrkinAA.Sprint2.Task6.V6.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Программа определения названия карты                    *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("\nВведите номер масти (1-4):");
            Console.WriteLine("1 - пики");
            Console.WriteLine("2 - трефы");
            Console.WriteLine("3 - бубны");
            Console.WriteLine("4 - червы");

            int m = Convert.ToInt32(Console.ReadLine());
            string suitName;

            switch (m)
            {
                case 1:
                    suitName = "пики";
                    break;
                case 2:
                    suitName = "трефы";
                    break;
                case 3:
                    suitName = "бубны";
                    break;
                case 4:
                    suitName = "червы";
                    break;
                default:
                    suitName = "неизвестная масть";
                    break;
            }

            Console.WriteLine("\nВведите номер достоинства карты (6-14):");
            Console.WriteLine("6 - шестерка");
            Console.WriteLine("7 - семерка");
            Console.WriteLine("8 - восьмерка");
            Console.WriteLine("9 - девятка");
            Console.WriteLine("10 - десятка");
            Console.WriteLine("11 - валет");
            Console.WriteLine("12 - дама");
            Console.WriteLine("13 - король");
            Console.WriteLine("14 - туз");

            int k = Convert.ToInt32(Console.ReadLine());
            string rankName;

            switch (k)
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

            Console.WriteLine("\n***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            if (m >= 1 && m <= 4 && k >= 6 && k <= 14)
            {
                string suitForResult = "";
                switch (m)
                {
                    case 1:
                        suitForResult = "пик";
                        break;
                    case 2:
                        suitForResult = "треф";
                        break;
                    case 3:
                        suitForResult = "бубен";
                        break;
                    case 4:
                        suitForResult = "червей";
                        break;
                }
                if (k >= 6 && k <= 10)
                {
                    Console.WriteLine($"{rankName.ToLower()} {suitForResult}");
                }
                else
                {
                    Console.WriteLine($"{rankName} {suitForResult}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода! Проверьте введенные данные.");
                Console.WriteLine($"Масть: {suitName}");
                Console.WriteLine($"Достоинство: {rankName}");
            }

            Console.WriteLine("\nДля завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}