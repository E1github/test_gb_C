// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
// в задаче не требуется, но можно осуществить ввод интересующей цифры и должно работать при такой реализации
int MyDigit = 3; // номер искомой цифры

//метод возведения в степень
int InPow (int num, int step)
{
    if (step == 1) return num;
    if (step == 0) return 1;
    int intC = 2;
    int numD = num; 
    while (intC <= step)
    {     
        numD = numD * num;
        intC++;
    }
    return numD;
}

int end = -1;
int countNumber = 1;

//определение количества цифр в числе
while (end != 0) 
{
    end = numA / (InPow(10,countNumber));
    countNumber++;
}
countNumber--;

//вывод результата
if (countNumber < MyDigit) Console.Write($"{numA} -> третьей цифры нет");
// if (countNumber < MyDigit) Console.Write($"{numA} -> {MyDigit}-й цифры нет"); //вариант вывода для задаваемой цифры 
    else Console.Write($"{numA} -> {(numA / InPow(10,countNumber-MyDigit)) % 10}");
    