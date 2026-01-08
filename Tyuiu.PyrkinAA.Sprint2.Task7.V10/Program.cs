using Tyuiu.PyrkinAA.Sprint2.Task7.V14.Lib;
namespace Tyuiu.PyrkinAA.Sprint2.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ПРОВЕРКА НАХОЖДЕНИЯ ТОЧКИ В ЗАШТРИХОВАННОЙ ОБЛАСТИ                     *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("\nОбласть ограничена:");
            Console.WriteLine("1) Параболой: y = x^2 - 2");
            Console.WriteLine("2) Прямой: y = x");
            Console.WriteLine("3) Осью Y: x = 0");
            Console.WriteLine("4) Прямой: y = -x");
            Console.WriteLine("\nЗаштрихованная область находится в правом верхнем квадранте");
            Console.WriteLine("между этими кривыми.");

            DataService ds = new DataService();

            // Ввод координат
            Console.Write("\nВведите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Проверка
            bool result = ds.CheckDotInShadedArea(x, y);

            // Вывод результата
            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Координаты точки: ({x:F2}, {y:F2})");
            Console.WriteLine($"Значение параболы y = x^2 - 2: {x * x - 2:F2}");
            Console.WriteLine($"Значение прямой y = x: {x:F2}");
            Console.WriteLine($"Значение прямой y = -x: {-x:F2}");

            Console.WriteLine($"\nПроверка условий:");
            Console.WriteLine($"1. y >= x^2 - 2 : {y:F2} >= {x * x - 2:F2} = {y >= x * x - 2}");
            Console.WriteLine($"2. y <= x      : {y:F2} <= {x:F2} = {y <= x}");
            Console.WriteLine($"3. y >= -x     : {y:F2} >= {-x:F2} = {y >= -x}");
            Console.WriteLine($"4. x >= 0      : {x:F2} >= 0 = {x >= 0}");

            if (result)
            {
                Console.WriteLine("\n✅ Точка НАХОДИТСЯ в заштрихованной области");
            }
            else
            {
                Console.WriteLine("\n❌ Точка НЕ находится в заштрихованной области");
            }

            // Примеры
            Console.WriteLine("\nПримеры точек в области:");
            Console.WriteLine("(0.5, 0.5), (1, 0), (0.7, 0.7), (0, 0)");
            Console.WriteLine("\nПримеры точек вне области:");
            Console.WriteLine("(-1, 1), (2, 3), (0, -2), (-0.5, 0.5)");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}