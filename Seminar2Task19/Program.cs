// Задача 19
// 1/ Напишите программу, которая принимает на вход пятизначное число
// 2/ и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да 
// 23432 -> да

Console.Write("Введите число: ");
int numX = Convert.ToInt32(Console.ReadLine());

bool EqualDigitsIn5 (int num)
{
    return (num % 10 == num / 10000) && (num /1000 % 10 == num % 100 / 10);
}

if (numX > 9999 && numX < 100000)
{
    if (EqualDigitsIn5(numX)) Console.WriteLine($"{numX} -> да");
    else Console.WriteLine($"{numX} -> нет");
} 
else Console.WriteLine($"{numX} -> не пятизначное число");