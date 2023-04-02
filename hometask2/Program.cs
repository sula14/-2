// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета (решать только при помощи операций % и /).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int ReadInt(string message)
{
    Console.Write($"{message} >");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int number = ReadInt("Введите число");
int result = number % 10;
if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    System.Console.WriteLine($"Третье число {result}");
}