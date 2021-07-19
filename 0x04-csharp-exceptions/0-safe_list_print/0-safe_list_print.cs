using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int a = 0;
        try
        {
            for (; a < n; a++)
                Console.WriteLine("{0}", myList[a]);
        }
        catch (Exception)
        {
            return (a);
        }
        return (a);
    }
}
