using System;

    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size < 0)
            {
               Console.WriteLine("Size cannot be negative");
               return null;
            }
            int[] nwarray = new int[size];
            for (int a = 0; a < size; a++)
            {
                nwarray[a] = a;
                if (a != 0)
                    Console.Write(" ");
                Console.Write(a);                    
            }
            Console.WriteLine("");
            return nwarray; 
        }
    }
