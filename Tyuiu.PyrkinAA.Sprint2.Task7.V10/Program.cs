using Tyuiu.PyrkinAA.Sprint2.Task7.V10.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();


            double[,] testPoints = {
                {-1, -2},   
                {-0.5, -1}, 
                {0, -1.5},  
                {1, 0},     
                {-1, 0},    
                {-2, -5}    
            };

            Console.WriteLine("Тестирование метода CheckDotInShadedArea:");
            Console.WriteLine("X\t\tY\t\tРезультат");
            Console.WriteLine("----------------------------------------------------");

            for (int i = 0; i < testPoints.GetLength(0); i++)
            {
                double x = testPoints[i, 0];
                double y = testPoints[i, 1];
                bool result = ds.CheckDotInShadedArea(x, y);

                Console.WriteLine($"{x:F2}\t\t{y:F2}\t\t{result}");
            }

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* ВВОД ПОЛЬЗОВАТЕЛЯ:                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите координату X: ");
            double userX = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double userY = Convert.ToDouble(Console.ReadLine());

            bool userResult = ds.CheckDotInShadedArea(userX, userY);

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (userResult)
            {
                Console.WriteLine($"Точка ({userX:F2}, {userY:F2}) находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка ({userX:F2}, {userY:F2}) НЕ находится в заштрихованной области");
            }

            Console.WriteLine("\nГраницы области:");
            Console.WriteLine($"1. Парабола: y = x^2 - 2");
            Console.WriteLine($"2. Прямая: y = x");
            Console.WriteLine($"3. Ось Y: x = 0");
            Console.WriteLine($"\nДля точки ({userX:F2}, {userY:F2}):");
            Console.WriteLine($"Значение параболы: {userX * userX - 2:F2}");
            Console.WriteLine($"Значение прямой: {userX:F2}");

            Console.WriteLine("\nДля выхода нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}