// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int numA = Convert.ToInt32(Console.ReadLine());

string DayOfWeek(int num)
{
    string wday = " ";
    if ((num > 0) && (num < 6)) wday = "нет";
    else if ((num==6) || (num==7)) wday = "да";
    else wday = "число некорректно.";
    return wday;
}

Console.Write($"{numA} -> {DayOfWeek(numA)}");


