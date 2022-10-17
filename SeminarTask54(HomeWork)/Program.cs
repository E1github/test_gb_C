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

void SortColumnElementsInMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int min = matrix[i,0];

       for (int n = 0; n < matrix.GetLength(1)-1; n++)
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            if (matrix[i, j] < matrix[i, j+1]) 
                {
                    min = matrix[i, j];
                    matrix[i, j] = matrix[i, j+1];
                    matrix[i, j+1] = min;
                }
        }
        
    }
    
}

int[,] array2D = CreateMatrixRndInt(7, 7, 0, 10);

PrintMatrix(array2D);

Console.WriteLine("-------------------------------------");

SortColumnElementsInMatrix(array2D);

PrintMatrix(array2D);