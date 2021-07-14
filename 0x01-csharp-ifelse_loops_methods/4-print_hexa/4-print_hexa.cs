using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a <= 98; a++)
            {
                Console.Write("{0} = 0x{0:x}\n", a);
            }
        }
    }
}
