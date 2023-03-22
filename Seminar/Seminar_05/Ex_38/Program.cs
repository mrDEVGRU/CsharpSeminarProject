// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int size = 4;

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintResult(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    double result = array.Max() - array.Min();
    Console.WriteLine();
    Console.WriteLine($"Минимальное значение массива {array.Min()}, максимальное значение массива {array.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {result}");
}

PrintResult(FillArray(size));