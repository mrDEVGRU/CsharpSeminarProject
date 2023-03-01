// 1. По двум введённым числам проверять является ли первое квадратом второго 

Console.Write("Введите первое число: ");
//string writeNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
//string writeNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(Console.ReadLine());

string txtResult = $"Число {number1} не является квадратом числа {number2}";    //вывод результата проверки на экран

if (number1 == number2 * number2)
{
    txtResult = txtResult.Replace(" не", "");  // если условие выполняется, "не" заменяется пробелом
}
Console.WriteLine(txtResult);