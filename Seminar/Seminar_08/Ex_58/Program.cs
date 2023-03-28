// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetMatrix()
{
    int[,] array = new int[2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newArray = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            newArray[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return newArray;
}

int[,] matrix1 = GetMatrix();
int[,] matrix2 = GetMatrix();
int[,] newArray = MultiplyMatrix(matrix1, matrix2);
PrintMatrix(matrix1);
Console.WriteLine("------");
PrintMatrix(matrix2);
Console.WriteLine("------");
PrintMatrix(newArray);