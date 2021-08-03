﻿using System;

    ///<summary>Creates a class to calculate vector.</summary>
    class VectorMath
    {
        ///<summary>Creates a protype with parameters.</summary>
        public static double[] Add(double[] vector1, double[] vector2)
        {
            double[] result = new double[1] {-1};
            
            if (vector1.Length == 2 && vector2.Length == 2)
                result = new double[2] {vector1[0] + vector2[0], vector1[1] + vector2[1]};

            if (vector1.Length == 3 && vector2.Length == 3)
                result = new double[3] {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]};
        
            return (result);
        }   
        
    }
