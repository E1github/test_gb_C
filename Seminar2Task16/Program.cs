// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

bool IsPairSqure(int num1, int num2)
{
    return (num1 == num2 * num2) || (num2 == num1 * num1);
}

if (IsPairSqure(numA, numB)) Console.WriteLine($"{numA}, {numB} -> да");
else Console.WriteLine($"{numA}, {numB} -> нет");