
Console.Write("Введите первое целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int numB = Convert.ToInt32(Console.ReadLine());


if ((numA*numA)==numB)
{
    Console.WriteLine($"Число {numB} равно квадрату {numA}");
}
else 
{
    Console.WriteLine($"Число {numB} НЕ равно квадрату {numA}");
}