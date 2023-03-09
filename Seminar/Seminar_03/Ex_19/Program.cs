// Напишите метод(-ы), который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите целое число: ");
string number = Console.ReadLine();
int length = number.Length;

bool Palindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}


if (Palindrome()) Console.WriteLine($"Число {number} является палиндромом");
else Console.WriteLine($"Число {number} не является палиндромом");