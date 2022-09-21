// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

string StrangeN(int numAA, int numBB)
{
if ((numAA % numBB) == 0)
    {
        string result = "Число " + numAA + " кратно числу " + numBB;
    }
    else
    {
        string result = "Число " + numAA + " НЕ кратно числу " + numBB;
    }
}

Console.WriteLine(StrangeN(numA,numB));