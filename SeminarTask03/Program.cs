
Console.Write("Введите целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

//if ((numA<1) || (numA>7)) Console.Write($"Число {numA} некорректно.");

if (numA==1) {Console.Write("Понедельник");}
else if (numA==2) {Console.Write("Вторник");}
else if (numA==3) {Console.Write("Среда");}
else if (numA==4) {Console.Write("Четверг");}
else if (numA==5) {Console.Write("Пятница");}
else if (numA==6) {Console.Write("Суббота");}
else if (numA==7) {Console.Write("Воскресенье");}
else Console.Write($"Число {numA} некорректно.");

// Console.Write($"Число {numA} некорректно.");