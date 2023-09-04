using System;

public class PrimeFactorization
{
    public static string Factorize(int n)
    {
        int originalNumber = n;
        string result = "";
        int factor = 2;
        bool isPrime = true;

        if (n > 1)
        {
            while (factor <= (int)Math.Sqrt(n))
            {
                if (n % factor == 0)
                {
                    result += $"{factor} * ";
                    n = n / factor;
                    isPrime = false;
                }
                else
                {
                    factor++;
                }
            }

            if (n > 1)
            {
                result += n;
            }

            if (isPrime)
            {
                return $"{originalNumber} is a prime number.\n{originalNumber} = {result}";
            }
            else
            {
                return $"{originalNumber} = {result}\n{originalNumber} is not a prime number.";
            }
        }

        return "Enter a positive integer greater than 1.";
    }
}

public class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Prime Factorization and Primality Testing Program");
            Console.WriteLine("Enter a positive integer greater than 1 (or 'exit' to quit):");

            string input = Console.ReadLine()!;

            if (input.ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(input, out int n) && n > 1)
            {
                string result = PrimeFactorization.Factorize(n);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input. You should enter a positive integer greater than 1.");
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
