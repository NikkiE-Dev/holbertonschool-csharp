using System;

///<summary>Creates a class.</summary>
class Obj
{
    ///<summary>Creates a prototype.</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

