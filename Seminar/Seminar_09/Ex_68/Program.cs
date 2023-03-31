// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n


int akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return akkerman(m - 1, 1);
    else return akkerman(m - 1, akkerman(m, n - 1));
}


int m = 2;
int n = 3;
Console.Write($"Функция Аккерамана = {akkerman(m, n)}");