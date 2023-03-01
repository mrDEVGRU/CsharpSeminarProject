
Console.WriteLine("Остаток от двух чисел");

Console.Write("Введите number1 = ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите number2 = ");
int number2 = int.Parse(Console.ReadLine());
int result = 0;

int MultipleNumber()
{
    result = number1 % number2;
    return result;
}

MultipleNumber();

Console.WriteLine();
if (result == 0) Console.WriteLine($"Число {number1} кратно числу {number2}");
else
{
    Console.WriteLine($"Число {number1} не кратно числу {number2}, остаток от деления равен {number1 % number2}");
}
Console.WriteLine();