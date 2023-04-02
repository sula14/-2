int ReadInt(string message)
{
    Console.Write($"{message} >");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите число");
int lastDigit = number % 10;
System.Console.WriteLine($"Последняя цифра числа {number} равна {lastDigit}");