// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numX = Convert.ToInt32(Console.ReadLine());
if (numX < 0) numX = -numX;
Console.WriteLine($"{numX} -> {SummDigits(numX)}");

int SummDigits(int num)
{
    int sum = 0;
    int countDigits = CountDigits(num);
    for (int i = 0; i <= countDigits; i++) 
        sum = sum + (num / InPow(10, countDigits - i)) % 10;
    return sum;
}

int CountDigits(int num)
{
    int counter = 0;
    while (num != 0)
    {
        num = num / 10;
        counter++;
    }
    return counter;
}

//метод возведения в степень
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