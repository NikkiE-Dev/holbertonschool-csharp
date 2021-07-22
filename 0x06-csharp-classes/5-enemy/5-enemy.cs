using System;

namespace Enemies
{
    ///<summary>Creates a Zombie.</summary>
    public class Zombie
    {
        ///<summary>Creates a private field.</summary>
        private int health;

        ///<summary>Creates a 2nd private field.</summary>
        private string name = "(No name)";
            ///<summary>Creates a public constructor.</summary>
            public Zombie()
            {
                health = 0;
            }
            ///<summary>Creates a 2nd public constructor.</summary>
            public Zombie(int value)
            {
                if (value < 0)
                {
                    throw new ArgumentException("Health must be greater than or equal to 0");
                }
                else
                {
                    health = value;
                }
                
            }
            
            ///<summary>Creates a public method.</summary>
            public int GetHealth()
            {
                return health;
            }
            ///<summary>Creates a public property.</summary>
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            ///<summary>Creates a public .toString() method.</summary>
            public override string ToString()
            {
                return string.Format("Zombie Name: {0} / Total Health: {1}", name, health);
            }    
    }
       
}
