using System;

///<summary>Creating an public class.</summary>
public class Player
{
    ///<summary>Creating properties for class.</summary>
    private string name { get; set; }

    ///<summary>Creating properties for class.</summary>
    private float maxHp { get; set; }
   
    ///<summary>Creating properties for class.</summary>
    private float hp { get; set; }
    
    ///<summary>Creating prototype.</summary>
    public Player(string name= "Player", float maxHp= 100f)
    {
        if (maxHp <= 0)
        {
            maxHp= 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;

    }

    ///<summary>Creating prototype.</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }
}

