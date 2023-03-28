// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] array = new int[3, 4];
Random rand = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = rand.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Элемент на позиции 3, 4 > {array[2, 3]}");