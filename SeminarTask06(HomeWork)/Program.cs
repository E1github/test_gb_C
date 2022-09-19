// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
double numA = Convert.ToInt32(Console.ReadLine());

if ((numA % 2) == 0) {Console.WriteLine($"{numA} -> да");}
    else {Console.WriteLine($"{numA} -> нет");};

