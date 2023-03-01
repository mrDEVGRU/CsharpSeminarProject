
Console.WriteLine("Удалить вторую цифру трёхзначного числа");

int Number = new Random().Next(100, 1000);
int NewNumber = 0;

NewNumber = Number / 100 * 10 + Number % 10;

Console.WriteLine($"Если из числа {Number} удалить вторую цифру, получится число {NewNumber}");