// Напишите цикл, который принимает на вход два числа (A и B) и возводит числа A в натуральную степень B.

Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int index = int.Parse(Console.ReadLine());

Console.WriteLine();
for (int power = 0; power <= index; power++)
    Console.WriteLine($"{value}^{power} = {Math.Pow(value, power):N0}");