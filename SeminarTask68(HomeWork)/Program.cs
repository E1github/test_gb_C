// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите первое натуральное число: ");
long numA = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
long numB = Convert.ToInt64(Console.ReadLine());

Console.Write($"M = {numA}; N = {numB} -> A(m,n) = ");

if (numA >= 0 && numB >= 0) Console.Write($"{Accerman(numA, numB)}");
  else Console.Write("введено не натуральное число");

long Accerman(long n, long m)
{
  if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return Accerman(n - 1, 1);
            else return Accerman(n - 1, Accerman(n, m - 1));
}