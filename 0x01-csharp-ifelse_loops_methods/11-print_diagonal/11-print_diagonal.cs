using System;

    class Line
    {
        public static void PrintDiagonal(int length)
        {
            if (length <= 0)
            {
	            Console.WriteLine("");
            }
            else
            {
                for (int j = 0; j < length; j++)
                {
                    for (int i = 0; i < j; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("\\");  
                }
                Console.WriteLine("");
            }
        }
    }
