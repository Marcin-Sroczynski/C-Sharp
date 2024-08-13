for (int num = 1; num <= 100; num++)
{
    if ((num % 3 == 0) && (num % 5 == 0))
    {
        Console.WriteLine(num + " - FizzBuzz");
    }
    else if (num % 3 == 0)
    {
        Console.WriteLine(num + " - Fizz");
    }
    else if (num % 5 == 0)
    {
        Console.WriteLine(num + " - Buzz");
    }
    else
    {
        Console.WriteLine(num);
    }

}
