int SumOfDigit(int number)
{
    int sum = 0;
    for(int i = 10; number / i > 0; number = number / i)
    {
        sum += number % i;
    }
    sum += number % 10;
    return sum;
}

Console.WriteLine("input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigit(num);

Console.WriteLine("Sum of digit is: " + result);
