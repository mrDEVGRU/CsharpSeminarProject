// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Ввод числа с экрана
int Prompt(string message)
{
    Console.Write(message);  // Выводим приглашение ко вводу
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput); // Приводим к числу
    return result; // Возвращаем результат
}

// Метод для получения случайных значений массива
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; // Объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // Заполняем массив случайными цифрами из диапазона
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int length = 8;
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max); // Заполнение массива случайными числами
PrintArray(array);