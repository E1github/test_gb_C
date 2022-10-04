// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите целое положительное число:");
int numA = Convert.ToInt32(Console.ReadLine());

void ConvertToBin(int num)
{
    string bin = default;

    if (num > 0)
    {
        if (num % 2 == 1) bin += "1";
            else bin+= "0";
        ConvertToBin(num / 2);    
    }
     Console.Write(bin);
}

void ConvertToBin2(int num)
{
    string bin = default;

     if (num > 0)
     {
        bin += num % 2;         
        ConvertToBin2(num / 2);    
     }   

    Console.Write(bin);
}

int[] array = new int[200];

void ConvertToBin3(int num)
{
    
    array[0] = num;
    int pos = 1;
    if (array[0]>0)
        {
            array[pos] = array[0] % 2;
            Console.Write(array[pos]);
            pos++;
            ConvertToBin3(array[0] / 2);
        }
}

// ConvertToBin(numA);
ConvertToBin2(numA);
// ConvertToBin3(numA);
