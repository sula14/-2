int ReadInt(string message)
{
    Console.Write($"{message} >");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int num1 = ReadInt("Первое число");
int num2 = ReadInt("Второе число");

if (num1 % num2 == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    int result = num1 % num2;
    System.Console.WriteLine($"не кратно остаток {result}");
}