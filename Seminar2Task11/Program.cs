// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
int num = new Random().Next(100, 1000);

int numA = num / 100;
int numC = num % 10;
int numD = numA * 10 + numC;

Console.WriteLine($"{num} -> {numD}");
