// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());


if (numA>numB)
{
    if (numA>numC) {Console.WriteLine($"{numA}, {numB}, {numC} -> {numA}");}
        else {Console.WriteLine($"{numA}, {numB}, {numC} -> {numC}");}
}
    else 
 {   
    if (numB>numC) {Console.WriteLine($"{numA}, {numB}, {numC} -> {numB}");}
            else {Console.WriteLine($"{numA}, {numB}, {numC} -> {numC}");};
 }           
