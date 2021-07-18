using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            for (a = 1; a <= 100; a++)
            {
                if (a % 5 == 0 && a % 3 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (a % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (a % 5 == 0)
                {
                    if (a == 100)
                    {
                        Console.WriteLine("Buzz");
                    }
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write("{0} ", a);
                }
            } 
        }
    }
}
