// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число = ");
int number = int.Parse(Console.ReadLine());
if (number < 99)
    Console.WriteLine($"В числе {number} третьей цифры нет");
else
    if (number < 999)
    Console.WriteLine($"Третья цифра числа {number} -> {number % 10}");
if (number > 999 && number < 9999)
    Console.WriteLine($"Третья цифра числа {number} -> {number / 10 % 10}");
else
    if (number > 9999)
    Console.WriteLine($"Третья цифра числа {number} -> {number / 100 % 10}"); // Больше пятизначного числа код не работает