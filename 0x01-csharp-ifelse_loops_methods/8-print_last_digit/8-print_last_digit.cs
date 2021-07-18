using System;

    class Number
    {
        public static int PrintLastDigit(int number)
        {
            int absvalue = Math.Abs(number);
            int lstdg = absvalue % 10;
            
            Console.Write(lstdg);
            return (lstdg);
        }
    }
