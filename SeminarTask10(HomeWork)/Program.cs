// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

int SecondDigitOf3(int num)
{
    int[] arrayF = new int[3];
    arrayF[0] = num / 100;
    arrayF[2] = num % 10;
    arrayF[1] = num / 10 - arrayF[0] * 10;
    return arrayF[1];
}

// num / 10 % 10.

Console.Write($"Вторая цифра: {SecondDigitOf3(numA)}");