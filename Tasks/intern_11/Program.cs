// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

int Number = new Random().Next(10, 100);
int Max = 0;

int MaxDigit()          // функция
{
    int DigitOne = Number / 10;         // int целое число десятки уберутся
    int DigitTwo = Number % 10;         // % останется остаток они же десятки
    if (DigitOne > DigitTwo) Max = DigitOne;
    else Max = DigitTwo;

    return Max;             // возврат для функции
}
MaxDigit();         // обрашение к функции
Console.WriteLine($"В числе {Number} наибольшая цифра {Max}");