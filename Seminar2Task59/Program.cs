// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.



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


int[] GetIndexMinElement(int[,] matrix)
{
    int min = matrix[0, 0];
    int minI = 0;
    int minJ = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minI = i;
                minJ = j;
            }
        }

    }
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"minIndex = {minI}, {minJ}");
    return new int[]{ minI, minJ };

}

int[,] CreateMatrixWithoutMinimalRowColElement(int[,] matrix, int[] indexIJ)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int resultI = 0;
    int resultJ = 0;

     for (int i = 0; i < matrix.GetLength(0); i++)
    {
       if (i != indexIJ[0]) 
       {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j != indexIJ[1])
            {
                result[resultI,resultJ] = matrix[i,j];
                resultJ++;
            } 
        }
       resultI++;
       resultJ = 0; 
       }    
    }
    return result;
}




int[,] array2D = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(array2D);
int[,] array2Dshort = CreateMatrixWithoutMinimalRowColElement(array2D, GetIndexMinElement(array2D));
PrintMatrix(array2Dshort);