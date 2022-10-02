﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size]; 
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.WriteLine($"{array[array.Length - 1]}]");
}

void InvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i]; 
}

int[] arrayGlobal = CreateArrayRndInt(4,-8,8);
PrintArray(arrayGlobal);
InvertArray(arrayGlobal);
PrintArray(arrayGlobal);
