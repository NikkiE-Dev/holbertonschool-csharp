using System;
using System.Collections.Generic;
using System.Reflection;

///<summary>Creates a class.</summary>
class Obj
{
    ///<summary>Creates a prototype.</summary>
    public static void Print(object myObj)
    {
        TypeInfo l = myObj.GetType().GetTypeInfo();
        Console.WriteLine("{0} Properties:", l.Name);
        foreach (PropertyInfo item in l.GetProperties())
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine("{0} Methods:", l.Name);
        foreach (MethodInfo thing in l.GetMethods())
        {
            Console.WriteLine(thing.Name);
        }
    }
}