// Напишите программу, которая принимает на вход число и проверяет,  кратно ли оно  одновременно 7 и 23.

int Prompt(string message)                          // функция
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите число > ");

if (number % 7 == 0 && number % 23 == 0)
    Console.WriteLine($"Число {number} кратно 7 и 23");
else Console.WriteLine($"Число {number} не кратно одновременно 7 и 23");
