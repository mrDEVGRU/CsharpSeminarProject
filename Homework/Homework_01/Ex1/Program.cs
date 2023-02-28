
Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

Console.Write("Введите number1 = ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите number2 = ");
int number2 = int.Parse(Console.ReadLine());
int max = number1;
int min = number2;
if (number1 > number2)
{
}
else
{
    min = number1;
    max = number2;
}
Console.WriteLine(min);
Console.WriteLine(max);