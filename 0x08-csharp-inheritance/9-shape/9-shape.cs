using System;
using System.Reflection;

///<summary>Creates a class.</summary>
public class Shape
{
    ///<summary>Creates a prototype.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary>Creates a class that inherits from another class.</summary>
public class Rectangle : Shape
{
    ///<summary>Creates a private field.</summary>
    private int width;

    ///<summary>Creates a 2nd private field.</summary>
    private int height;

    ///<summary>Creates a public property.</summary>
    public int Width
    {
        get
        {
            if (width < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                return width;
            }
        }
        set
        {
            width = value;
        }
    }
    ///<summary>Creates a 2nd public property.</summary>
    public int Height
    {
        get
        {
            if (height < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                return height;
            }
        }
        set
        {
            height = value;
        }
    }
    ///<summary>Creates a public method.</summary>
    public new int Area()
    {
        int area = Width * Height;
        return area;
    }
    ///<summary>Creates a public .toString() method.</summary>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", Width, Height);
    }    
}
///<summary>Creates a class that inherits from another class.</summary>
public class Square : Rectangle
{
   
    ///<summary>Creates a private field.</summary>
    private int size;

    ///<summary>Creates a public property.</summary>
    public int Size
    {
        get
        {
            
            if (size < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                return size;
            }
        }
        set
        {
            Width = value;
            Height = value;
            size = value;
        }
    }
    ///<summary>Creates a public .toString() method.</summary>
    public override string ToString()
    {
        return string.Format("[Square] {0} / {1}", size, size);
    }
}