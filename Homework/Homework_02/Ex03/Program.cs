// 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.Write("Введите номер дня недели: ");
int dayNumber = int.Parse(Console.ReadLine());
string txtResult = "";

if (dayNumber > 5) txtResult = $", выходной день.";
else txtResult = $", рабочий день";

Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");