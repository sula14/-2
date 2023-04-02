int ReadInt(string message)
{
    Console.Write($"{message} >");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int num = ReadInt("Введите число");
if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("да");
}
else 
{
    System.Console.WriteLine("нет");
}