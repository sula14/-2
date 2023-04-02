int number = new Random().Next(10, 100);
int MaxNumber(int number)
{
    int dec = number / 10;
    int det = number % 10;
    int result = dec;

    if (det > result)
    {
        result = det;
    }
    return result;
}
System.Console.WriteLine($"Max number of {number} is {MaxNumber(number)}");