Console.Write("Введите целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

int numAntiA = (-1)*numA;
 while (numAntiA<=numA)
{
Console.Write($"{numAntiA}");
if (numAntiA==numA) 
{Console.Write("");}
    else {Console.Write(",");};
numAntiA++;
};
