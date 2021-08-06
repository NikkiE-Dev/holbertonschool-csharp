using System;

///<summary>Creating a enumeration.</summary>
public enum Modifier
{
    ///<summary>First element.</summary>
    Weak,
    ///<summary>Second element.</summary>
    Base,
    ///<summary>Third element.</summary>
    Strong
}

///<summary>Creating a delegate .</summary>
delegate void CalculateHealth(float f);

///<summary>Creating a delegate .</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary>Creating an public class.</summary>
public class CurrentHPArgs : EventArgs
{
    ///<summary>Creating a property that cannot be modified.</summary>
    public readonly float currentHp;

    ///<summary>Creating a constructor.</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

///<summary>Creating an public class.</summary>
public class Player
{
    ///<summary>Creating properties for class.</summary>
    private string name { get; set; }

    ///<summary>Creating properties for class.</summary>
    private float maxHp { get; set; }
   
    ///<summary>Creating properties for class.</summary>
    private float hp { get; set; }

    EventHandler<CurrentHPArgs> HPCheck;

    private string status { get; set; }
    
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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;

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
            float newHp = this.hp - damage;
            this.ValidateHP(newHp);
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
            float newHp = this.hp + heal;
            this.ValidateHP(newHp);
        }
    }
    ///<summary>Creating a method that takes in account the damage and heal.</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
        CheckStatus(HPCheck, new CurrentHPArgs(this.hp));
    }
    ///<summary>Creating a method.</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier is Modifier.Weak)
        {
            return (baseValue * 0.5f);
        }
        if (modifier is Modifier.Strong)
        {
            return (baseValue * 1.5f);
        }
        else
        {
            return baseValue;
        }
    }
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
        {
            Console.WriteLine("{0} is in perfect health!", name);
        }
        else if (e.currentHp >= (this.maxHp * 0.5))
        {
            Console.WriteLine("{0} is doing well!", name);
        }
        else if (e.currentHp >= (this.maxHp * 0.25) && e.currentHp < (this.maxHp * 0.5))
        {
            Console.WriteLine("{0} isn't doing too great...", name);
        }
        else if (e.currentHp < (this.maxHp * 0.25) && e.currentHp > 0)
        {
            Console.WriteLine("{0} needs help!", name);
        }
        else if (e.currentHp == 0)
        {
            Console.WriteLine("{0} is knocked out!", name);
        }
    }
}
