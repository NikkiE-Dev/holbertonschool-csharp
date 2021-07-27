using System;
using System.Collections.Generic;

///<summary>Creates a class.</summary>
class Obj
{
    ///<summary>Creates a prototype.</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;

        else
        {
            return false;
        }
    }
}
