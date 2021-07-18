using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            for (a = 0; a < 10; a++)
            {
                for (int b = a + 1; b < 10; b++)
                {
                    if (a == 8 && b == 9)
                    {
                        Console.WriteLine("{0}{1}", a, b);
                    }
                    else
                    {
                        Console.Write("{0}{1}, ", a, b);
                    }
                } 
            } 
        }
    }
}
