int num = new Random().Next(10, 10000);
int MaxNumber(int num)
{
    int number = num;
    int max = 0;
    while(number > 0)
    {
    int ost = number % 10;
    number/= 10;
    
    if (max < ost)
    {
        max = ost;
    }
    }
    return max;
}
System.Console.WriteLine($"из чисел {num} макс число {MaxNumber(num)} ");