// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int[,] array = new int[3, 4];
Random rand = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = rand.Next(-10, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}