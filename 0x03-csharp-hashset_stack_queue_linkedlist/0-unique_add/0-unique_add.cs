using System;
using System.Collections.Generic;

    class List
    {
        public static int Sum(List<int> myList)
        {
            int sum = 0;
            List<int> sumList = myList;
            for (int a = 0; a < sumList.Count; a++)
            {
                if (sumList[a] != sumList[a - 1] || a == 0)
                    sum += sumList[a];
            }
            return (sum);
        }
    }
