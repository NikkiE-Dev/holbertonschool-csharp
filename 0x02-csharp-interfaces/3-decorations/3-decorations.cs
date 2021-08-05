using System;

///<summary>Creating an abstarct class.</summary>
public abstract class Base
{
    ///<summary>Creates property obj named "name".</summary>
    public string name { get; set; }

    ///<summary>Method that prints obj and obj type.</summary>
    public override string ToString()
    {
        return (name + " is a " + this.GetType().ToString());
    } 
}
    ///<summary>Creating interface named Interactive.</summary>
    interface IInteractive
    {
        ///<summary>Creates method for interface.</summary>
        void Interact();
    }
    ///<summary>Creating interface named Breakable.</summary>
    interface IBreakable
    {
        ///<summary>Creates method for interface.</summary>
        void Break();

        ///<summary>Creates an int property for interface.</summary>
        int durability { get; set; }
    }
    ///<summary>Creating interface named Collectable.</summary>
    interface ICollectable
    {
        ///<summary>Creates method for interface.</summary>
        void Collect();

        ///<summary>Creates an int property for interface.</summary>
        bool isCollected { get; set; }
    }
    ///<summary>Creating an class that inherits from Base class and the interfaces.</summary>
    public class Door : Base, IInteractive
    {
        ///<summary>Creating constructor.</summary>
        public Door(string name="Door")
        {
            this.name = name;
        }
        ///<summary>Inheriting properties for interface.</summary>
        public void Interact()
        {
            Console.WriteLine("You try to open the {0}. It's locked.", name);
        }
    }
    ///<summary>Creating an class that inherits from Base class and the interfaces.</summary>
    public class Decoration : Base, IInteractive, IBreakable
    {
        ///<summary>Creating bool property.</summary>
        public bool isQuestItem = false;

        ///<summary>Creating int property.</summary>
        public int durability { get; set; }
        ///<summary>Creating constuctor.</summary>
        public Decoration(string name= "Decoration", int durability= 1, bool isQuestItem= false)
        {
            if (durability < 1)
            {
                 throw new Exception("Durability must be greater than 0");
            }
            this.name = name;
            this.durability = durability;
            this.isQuestItem = isQuestItem;
        }
        ///<summary>Implementing method.</summary>
        public void Interact()
        {
            if (durability < 1)
            {
                Console.WriteLine("The {0} has been broken.", name);
            }
            else if (isQuestItem == true)
            {
                Console.WriteLine("You look at the {0}. There's a key inside.", name);
            }
            else if (isQuestItem == false)
            {
                Console.WriteLine("You look at the {0}. Not much to see here.", name);
            }
        }
        ///<summary>Implementing method.</summary>
        public void Break()
        {
            durability -= 1;
            if (durability < 0)
            {
                Console.WriteLine("The {0} is already broken.", name);
            }
            else if (durability == 0)
            {
                Console.WriteLine("You smash the {0}. What a mess.", name);
            }
            else
            {
                Console.WriteLine("You hit the {0}. It cracks.", name);
            }

        }


    }
