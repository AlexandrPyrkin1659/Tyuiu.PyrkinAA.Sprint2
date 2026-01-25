using Tyuiu.PyrkinAA.Sprint2.Task6.V6.Lib;

DataService ds = new DataService();
Console.Title = "Спринт 2 | Выполнил: Пыркин А. А. | АСОиУб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Сокращенная форма записи оператора switch                         *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Пыркин Александр Артемьевич | АСОиУб-25-1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3,                 *");
Console.WriteLine("* масти «червы» — 4, а достоинству карт: «валету» — 11, «даме» — 12,      *");
Console.WriteLine("* «королю» — 13, «тузу» — 14 (порядковые номера карт остальных достоинств *");
Console.WriteLine("* соответствуют их названиям: «шестерка», «девятка» и т. п.).             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* По заданным номеру масти m (1 <= m <= 4) и номеру достоинства карты k   *");
Console.WriteLine("* (6 <= k <= 14) определить полное название (масть и достоинство)        *");
Console.WriteLine("* соответствующей карты в виде «Дама пик», «Шестерка бубен» и т. п.       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите номер масти (1-4):");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер достоинства карты (6-14):");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

var result = ds.FindCardNameAndValue(m, k);
Console.WriteLine(result);

Console.ReadKey();