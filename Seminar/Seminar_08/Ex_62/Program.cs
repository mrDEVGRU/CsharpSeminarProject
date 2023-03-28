// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateArray(int n, int m)
{
    int[,] A = new int[n, m];
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

    for (int i = 0; i < A.Length; i++)
    {
        A[col, row] = i + 1;
        if (--gran == 0)
        {
            gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx; dx = -dy; dy = temp; dirChanges++;
        }
        col += dy; row += dx;
    }
    return A;
}

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] / 10 <= 0)
                Console.Write($" 0{a[i, j]} ");

            else Console.Write($" {a[i, j]} ");

        }
        Console.WriteLine();
    }
}

int N = 4, M = 4;
var a = CreateArray(N, M);
PrintArray(a);