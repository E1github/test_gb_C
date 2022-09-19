
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

int cc = 2; 

if (numA>1) //осуществлять вывод только по ТЗ, когда N больше 1 
{
Console.Write($"{numA}-> ");    
while (cc<=numA)
    {
    Console.Write($"{cc},"); 
    cc=cc+2;
    };

};

//решил в данном случае не усложнять-))
// if (cc==numA) {Console.WriteLine($"{cc}");};
// if ((cc % 2) == 0) {Console.WriteLine($"{cc},");}