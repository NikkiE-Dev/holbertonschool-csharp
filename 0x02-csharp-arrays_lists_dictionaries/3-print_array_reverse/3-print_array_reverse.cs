using System;

    class Array
    {
        public static void Reverse(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("");
            }
            else
            {
                for ( int a = array.Length -1; a >= 0; a--)
                {
                    if (a != array.Length -1)
                        Console.Write(" ");
                    Console.Write(array[a]);
                }
                Console.WriteLine("");
            }
        }
    }

