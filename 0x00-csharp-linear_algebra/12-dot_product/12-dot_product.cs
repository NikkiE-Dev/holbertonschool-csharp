using System;

    ///<summary>Creates a class to calculate vector.</summary>
    class VectorMath
    {
        ///<summary>Creates a protype with parameters.</summary>
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            double result = -1;
            
            if ((vector1.Length == 2  || vector1.Length == 3) && vector1.Length == vector2.Length)
            {
                result = 0;
                for (int a = 0; a < vector2.Length; a++)
                {
                    result += (vector1[a] * vector2[a]);
                }
            }
            return (result);
        }   
        
    }

