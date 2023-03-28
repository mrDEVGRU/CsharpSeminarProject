// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-10, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}