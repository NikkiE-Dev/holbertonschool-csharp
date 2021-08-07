using System;
using System.Collections.Generic;

///<summary>Creates a class to add 2 matrices.</summary>
class MatrixMath
{
    ///<summary>Creates a protype with parameters.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] result = new double[,] {{-1}};
            
        if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1) && matrix1.GetLength(0) == 2)
            result = new double[,] {{matrix1[0, 0] + matrix2[0, 0], matrix1[0, 1] + matrix2[0, 1]}, {matrix1[1, 0] + matrix2[1, 0], matrix1[1, 1] + matrix2[1, 1]}};

        if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1) && matrix1.GetLength(0) == 3)
            result = new double[,] {{matrix1[0, 0] + matrix2[0, 0], matrix1[0, 1] + matrix2[0, 1], matrix1[0, 2] + matrix2[0, 2]}, {matrix1[1, 0] + matrix2[1, 0], matrix1[1, 1] + matrix2[1, 1], matrix1[1, 2] + matrix2[1, 2]}, {matrix1[2, 0] + matrix2[2, 0], matrix1[2, 1] + matrix2[2, 1], matrix1[2, 2] + matrix2[2, 2]}};
        
        return (result);
    }   
        
}
