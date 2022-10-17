// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
//     Console.Write($"{array[array.Length - 1]}]");
// }


int GetNumberMinSumRow(int[,] matrix)
{
    int[] sumInRow = new int[matrix.GetLength(0)]; 
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {             
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)        
            sum += matrix[i, j];
        
        sumInRow[i] = sum;        
    }

    int min = sumInRow[0];
    int minID = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)        
        if (min > sumInRow[i]) 
        {
            minID = i;
            min = sumInRow[i];
        }
    // PrintArray(sumInRow);
    return minID;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);

PrintMatrix(array2D);

int minNumber = GetNumberMinSumRow(array2D);


Console.WriteLine($"Минимальная сумма элементов строки массива в {minNumber}-й строке.");