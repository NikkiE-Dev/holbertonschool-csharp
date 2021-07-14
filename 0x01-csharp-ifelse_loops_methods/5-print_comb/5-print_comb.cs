using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a <= 99; a++)
            {
                if (a <= 98)
                {
                    Console.Write("{0:D2}, ", a);
                }
                else
                {
                    Console.Write("{0:D2}\n", a);
                }
                
            } 
        }
    }
}
