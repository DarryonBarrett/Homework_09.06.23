/*
Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
string numberA = Console.ReadLine()!;
int numA = int.Parse(numberA);
Console.Write("Введите второе число: ");
string numberB = Console.ReadLine()!;
int numB = int.Parse(numberB);
Console.Write("Введите третье число: ");
string numberC = Console.ReadLine()!;
int numC = int.Parse(numberC);
int max = numA;
if (numB > max)
{
    max = numB;
}
if (numC > max)
{
    max = numC;
}
Console.Write($"Максимальное число из трех введенных - {max}.");