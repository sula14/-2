int ReadInt(string message)
{
    Console.Write($"{message} >");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int num1 = ReadInt("Первое число");
int num2 = ReadInt("Второе число");
int result = num1 % num2;
int result2 = num2 % num1;

if (result == 0)
{
    if (result2 == 0)
    {
        System.Console.WriteLine("Кратно");
    }
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine($"остаток > {result} , {result2}");
}