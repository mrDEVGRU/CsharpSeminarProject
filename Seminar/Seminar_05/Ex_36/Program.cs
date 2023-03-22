// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int size = 10;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (i % 2 == 1) sum += array[i];
    }
    Console.WriteLine($"Сумма элементов нечётной позиции = {sum}");
}

PrintResult(FillArray(size));