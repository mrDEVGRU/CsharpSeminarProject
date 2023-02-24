
Console.WriteLine("Показать чётные числа от 1 до N");

int a = 1;
Console.Write("Введите число N ");
int m = int.Parse(Console.ReadLine());
for (int i = a; i <= m; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}