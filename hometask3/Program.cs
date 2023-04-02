// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string message)
{
    Console.Write($"{message} >");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int day = ReadInt("Введите день недели");
if (day == 6 || day == 7)
{
    System.Console.WriteLine("Выходной день");
}
else
{
    System.Console.WriteLine("Рабочий день");
}
