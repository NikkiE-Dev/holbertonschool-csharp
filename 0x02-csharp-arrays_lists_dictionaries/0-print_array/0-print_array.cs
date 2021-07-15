using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size == 0)
            {
                Console.WriteLine("");
            }
            else if (size < 0)
            {
               Console.WriteLine("Size cannot be negative");
               return null;
            }
            else
            {
                int[] array = new int[size]
                for (int a = 0; a < size; a++)
                {
                    array[a] = a;
                    if (a < size)
                        Console.Write(" ");
                    Console.Write(a);
                }
                Console.WriteLine("");
                return array;
                    }
                }
            }
            
        }
    }
}
