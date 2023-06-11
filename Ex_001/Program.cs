/*
 Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
 какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/

Console.Write("Введите первое число: ");
string numberA = Console.ReadLine()!;
int numA = int.Parse(numberA);
Console.Write("Введите второе число: ");
string numberB = Console.ReadLine()!;
int numB = int.Parse(numberB);
if (numA > numB)
{
    Console.Write($"Число {numA} больше числа {numB}");
}
else
{
    Console.Write($"Число {numB} больше числа {numA}");
}