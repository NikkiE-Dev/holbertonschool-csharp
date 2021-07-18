using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        List<int> sumList = myList.Distinct().ToList();
        int sum = 0;
        for (int a = 0; a < sumList.Count; a++)
        {
            sum += sumList[a];
        }
        return sum;
    }
}
