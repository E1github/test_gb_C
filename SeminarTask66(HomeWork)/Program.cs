// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое натуральное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {numA}; N = {numB} -> ");

if (numA > 0 && numB > 0)
    if (numB > numA) PrintSumOfMaturalNumbers(numB, numA, 0);
      else PrintSumOfMaturalNumbers(numA, numB, 0);
  else Console.Write("введено не натуральное число");

//Вопрос: можно было бы как-то обойтись безе передачи суммы 
// параметром чтобы избавиться от первоначальной передачи ноля?
void PrintSumOfMaturalNumbers(int num, int end, int sum)
{
    if (num < end)
    {
        Console.Write($"{sum}");
        return;
    }
    sum += num--;
    PrintSumOfMaturalNumbers(num, end, sum);
}
