// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите цифру обозначающую четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string QuarterDescription (int q)
{
    if (q == 1) return "В данной четверти X и Y должны быть больше нуля";
    if (q == 4) return "В данной четверти X должен быть больше нуля, а Y меньше нуля";
    if (q == 3) return "В данной четверти X и Y должны быть меньше нуля";
    if (q == 2) return "В данной четверти X должен быть меньше нуля, а Y больше нуля";
    return "введенное число не может быть четвертью";
}

string result = QuarterDescription(quarter);

Console.WriteLine(result);

