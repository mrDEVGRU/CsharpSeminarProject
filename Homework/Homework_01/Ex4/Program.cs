
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.Write("Введите число N ");
int m = int.Parse(Console.ReadLine());
for (int i = 1; i <= m; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}