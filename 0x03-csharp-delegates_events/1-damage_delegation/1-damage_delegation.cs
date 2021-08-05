using System;

///<summary>Creating a delegate .</summary>
delegate void CalculateHealth(float f);

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
    ///<summary>Creating a prototype.</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine("{0} takes 0 damage!", name);
        }
        else
        {
            Console.WriteLine("{0} takes {1} damage!", name, damage);
        }
    
    }
    ///<summary>Creating a prototype.</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine("{0} heals 0 HP!", name);
        }
        else
        {
            Console.WriteLine("{0} heals {1} HP!", name, heal);
        }
    
    }
}







