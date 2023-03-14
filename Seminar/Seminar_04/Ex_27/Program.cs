// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int newnumber = 0;

while (number > 0)
{
    newnumber = number % 10 + newnumber;
    number = number / 10;
}

Console.WriteLine($"Сумма цифр = {newnumber}");