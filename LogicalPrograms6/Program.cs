using System;
class Program
{
    public static void Main(string[] args)
    {
       
            int n;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            int i;
            bool isPrime = true;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine("{0} is a prime number.", n);
            else
                Console.WriteLine("{0} is not a prime number.", n);
        }
    }

