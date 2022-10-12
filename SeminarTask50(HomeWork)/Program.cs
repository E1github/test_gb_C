// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

using System.Linq;

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[] ReadCheckingRowCol()
{
    
    Console.Write("Введите значение строки и колонки искомого элемента матрицы: ");
    var arrS = Console.ReadLine()
                        .Split(",");
    // .Select(int.Parse);
    

    int[] arr = new int[arrS.Length];

    if (arrS.Length == 2)
       for (int i = 0; i < arrS.Length; i++)
           arr[i] = Convert.ToInt32(arrS[i]);
    
    return arr;
}

void PrintMatrixElement(int[] RowCol, int[,] matrix)
{
    if (RowCol[0] <= matrix.GetLength(0) - 1 && RowCol[1] <= matrix.GetLength(1) - 1)
            Console.WriteLine($"{RowCol[0]},{RowCol[1]} -> {matrix[RowCol[0],RowCol[1]]}");
       else
            Console.WriteLine($"{RowCol[0]},{RowCol[1]} -> такого элемента в массиве нет");             
}

int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);

PrintMatrix(array2D);

PrintMatrixElement(ReadCheckingRowCol(), array2D);
