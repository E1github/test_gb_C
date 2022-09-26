// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB > 0) Console.Write($" {numA}, {numB} -> {InPow(numA,numB)} ");
    else Console.Write("Число B не натуральное");

int InPow(int num, int step)
{
    if (step == 1) return num;
    if (step == 0) return 1;
    int intC = 2;
    int numD = num;
    while (intC <= step)
    {
        numD = numD * num;
        intC++;
    }
    return numD;
}