using System;

namespace Enemies
{
    ///<summary>Creates a Zombie.</summary>
    public class Zombie
    {
        ///<summary>Creates a public field.</summary>
        public int health;
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
    }
       
}
