// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Write("Введите количество строк: ");
int rowsG  = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите строк: ");
int columnsG = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение в массиве: ");
int matMin  = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение в массиве: ");
int matMax  = Convert.ToInt32(Console.ReadLine());



int[,] CreateMatrixRndIntM(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows,columns];
    var rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
         array[i,j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

// void PrintMatrix(int[,] array)
// {
//     Console.Write("[");
//     for (int i = 0; i <= array.Length(0) - 2; i++) 
//         for (int i4j = 0; j < array.Length(1) ; j++)
//         {
//           Console.Write($"{array[i,j]},");  
//         } 
//     Console.Write($"{array[array.Length - 1]}]");
// }


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


int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);

PrintMatrix(array2D);
