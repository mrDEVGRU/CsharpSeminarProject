
Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.");

Console.Write("Введите число = ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0) Console.Write("Yes");
else Console.Write("No");