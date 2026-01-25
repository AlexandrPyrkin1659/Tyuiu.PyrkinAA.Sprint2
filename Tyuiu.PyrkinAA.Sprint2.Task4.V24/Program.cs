using Tyuiu.PyrkinAA.Sprint2.Task4.V24.Lib;

DataService ds = new DataService();
Console.Title = "Спринт 2 | Выполнил: Пыркин А. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #24                                                             *");
Console.WriteLine("* Выполнил: Пыркин Александр Артемьевич | АСОиУб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
Console.WriteLine("* переменных x,y с клавиатуры. Если x + 2 > y + 24, то                    *");
Console.WriteLine("* z = x * ((y + 1)/(x + 2))^x, иначе (y^2 + cos(x)^2 + 9)/(x^2 - sin(y)^2 + 12)");
Console.WriteLine("* Округлить полученное значение до трех знаков после запятой             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение x:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y:");
double y = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение функции = " + res);

Console.ReadKey();