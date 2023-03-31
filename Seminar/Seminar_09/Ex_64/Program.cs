// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int enumNumber(int N)
{
    if (N < 1)
    {
        return 1;
    }
    Console.Write(" {0},", N);
    N--;
    return enumNumber(N);
}

int N = 20;
enumNumber(N);
