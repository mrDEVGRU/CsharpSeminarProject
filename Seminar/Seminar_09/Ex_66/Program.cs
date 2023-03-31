// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int sumNumber(int M, int N)
{
    if (M == N) return N;
    else return M + sumNumber(M + 1, N);
}

int M = 1;
int N = 6;
Console.Write($"Сумма натуральных элементов в промежутке от {M} до {N} = {sumNumber(M, N)}");