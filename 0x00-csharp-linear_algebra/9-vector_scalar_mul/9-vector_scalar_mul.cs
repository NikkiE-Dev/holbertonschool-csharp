using System;

    ///<summary>Creates a class to calculate vector.</summary>
    class VectorMath
    {
        ///<summary>Creates a protype with parameters.</summary>
        public static double[] Multiply(double[] vector, double scalar)
        {
            double[] result = new double[1] {-1};
            
            if (vector.Length == 2)
                result = new double[2] {vector[0] * scalar, vector1[1] +  * scalar};

            if (vector.Length == 3)
                result = new double[3] {vector[0] * scalar, vector1[1] +  * scalar, vector1[2] * scalar};
        
            return (result);
        }   
        
    }
