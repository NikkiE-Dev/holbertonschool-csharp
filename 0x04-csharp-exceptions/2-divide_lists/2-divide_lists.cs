using System;
using System.Collections.Generic;
    
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        int b = 0;

            for (int a = 0; a < listLength; a++)
            {
                try
                {
                    b = list1[a] / list2[a];
                    result.Add(b);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    result.Add(0);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                }
                
            }
        return (result);
    }
}
