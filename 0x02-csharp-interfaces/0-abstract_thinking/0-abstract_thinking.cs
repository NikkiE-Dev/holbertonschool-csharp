using System;

///<summary>Creating an abstarct class.</summary>
public abstract class Base
{
    ///<summary>Creates property obj named "name".</summary>
    public string name;

    ///<summary>Method that prints obj and obj type.</summary>
    public override string ToString()
    {
        return (name + " is a " + this.GetType().ToString());
    }
}
