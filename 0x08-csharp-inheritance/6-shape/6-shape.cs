using System;

///<summary>Creates a class.</summary>
class Shape
{
    ///<summary>Creates a prototype.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary>Creates a class that inherits from another class.</summary>
class Rectangle : Shape
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
            return width;
        }
        set
        {
            if (width < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }
    ///<summary>Creates a 2nd public property.</summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (height < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }

        }
    }


}