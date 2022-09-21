// 9. Напишите программу, которая выводит
// 1/случайное число из отрезка [10, 99] 
// 2/ найти наибольшую цифру числа.
// 3/ вывести результат
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100);
// int firstD = number / 10;
// int secondD = number % 10;

// if (firstD == secondD) Console.WriteLine($"В числе {number} -> числа одинаковые"); 
// else if (firstD > secondD) Console.WriteLine($"Наибольшее цифра числа {number} -> {firstD}");
//     else Console.WriteLine($"Наибольшее цифра числа {number} -> {secondD}");


// //тернальный оператор
// number = new Random().Next(10, 100);
// int max = firstD > secondD ? firstD : secondD;
//     Console.Write($"Наибольшее цифра числа {number} -> {max}");

int MaxDigit (int num)
{
    int firstD = num / 10;
    int secondD = num % 10;    
    // if (firstD > secondD) return firstD;
    // return secondD;
    if (IsEqualDigits(firstD, secondD)) return = -1;
    return firstD > secondD ? firstD : secondD;
}

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2;
}

int number = new Random().Next(10, 100);
int maxDg = MaxDigit(number);
// Console.WriteLine($"Наибольшее цифра числа {number} -> {maxDg}");
string result = maxDg != -1 ? maxDigit.ToString(): "Цифры одинаковые";
