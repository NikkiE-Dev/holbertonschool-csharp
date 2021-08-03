using System;

///<summary>Creates a new class.</summary>
public class Queue<T>
{
    ///<summary>Creates a method that returns the Queue’s type.</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
}
