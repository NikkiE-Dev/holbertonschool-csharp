using System;

    ///<summary>Creates a class to calculate vector.</summary>
    class VectorMath
    {
        ///<summary>Creates a protype with parameters.</summary>
        public static double[] Add(double[] vector1, double[] vector2)
        {
            int a = (vector1[0] + vector2[0]), b = (vector1[1] + vector2[1]), c = (vector1[2] + vector2[2]);
            
            if (vector1.Length == 2 && vector2.Length == 2)
                
                return String.Format("({0}, {1}, {2})", a, b);

            if (vector1.Length == 3 && vector2.Length == 3)
                return String.Format("({0}, {1}, {2})", a, b, c);
        
            else
                return (-1);
        }   
        
    }
