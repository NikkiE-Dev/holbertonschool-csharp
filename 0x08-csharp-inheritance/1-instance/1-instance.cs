using System;
using System.Collections.Generic;


///<summary>Creates a class.</summary>
class Obj
{
    ///<summary>Creates a prototype.</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj))
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
