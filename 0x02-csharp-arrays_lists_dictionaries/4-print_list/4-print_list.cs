using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            List<int> printlst = new List<int> ();
            for (int a = 0; a < size; a++)
            {
                printlst.Add(a);
                if (a == 0)
                {
                    Console.Write("{0}", a); 
                }
                else 
                {
                    Console.Write(" {0}", a);
                }
            }
            Console.WriteLine("");
            return printlst;
        }
    }
}
