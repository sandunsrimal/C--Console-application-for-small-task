using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the range (e.g. 20-40, 1-25): ");
        string range = Console.ReadLine();

        string[] rangeValues = range.Split('-');
        int start = int.Parse(rangeValues[0]);
        int end = int.Parse(rangeValues[1]);

        int maxDivisorsCount = 0;
        int numberWithMaxDivisors = 0;

        Console.WriteLine("Prime numbers within the range:");
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }

            int divisorsCount = CountDivisors(i);
            if (divisorsCount > maxDivisorsCount)
            {
                maxDivisorsCount = divisorsCount;
                numberWithMaxDivisors = i;
            }
        }

        Console.WriteLine("Number with the maximum number of divisors: " + numberWithMaxDivisors);
        Console.WriteLine("Maximum number of divisors: " + maxDivisorsCount);
    }
    // Find Prime numbers
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static int CountDivisors(int number)
    {
        int count = 0;
        int sqrt = (int)Math.Sqrt(number);

        for (int i = 1; i <= sqrt; i++)
        {
            if (number % i == 0)
            {
                count += 2; 
            }
        }

        
        if (sqrt * sqrt == number)
        {
            count--;
        }

        return count;
    }
}
