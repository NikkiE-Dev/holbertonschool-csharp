using System;
using System.Collections.Generic;

class List
    {
        public static int MaxInteger(List<int> myList)
        {
            if (myList == null)
            {
                Console.WriteLine("List is empty");
                Environment.Exit(-1);
            }
            myList.Sort();
            myList.Reverse();
            return (myList[0]);
        }
    }
