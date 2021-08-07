using System;
using System.Collections.Generic;

///<summary>Creates a class to add 2 matrices.</summary>
class MatrixMath
{
    ///<summary>Creates a protype with parameters.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] result = new double[,] {{-1}};
            
        if (matrix.GetLength(0) == matrix.GetLength(1) && matrix.GetLength(0) == 2)
            result = new double[,] {{matrix[0, 0] * scalar, matrix[0, 1] * scalar}, {matrix[1, 0] * scalar, matrix[1, 1] * scalar}};

        if (matrix.GetLength(0) == matrix.GetLength(1) && matrix.GetLength(0) == 3)
            result = new double[,] {{matrix[0, 0] * scalar, matrix[0, 1] * scalar, matrix[0, 2] * scalar}, {matrix[1, 0] * scalar, matrix[1, 1] * scalar, matrix[1, 2] * scalar}, {matrix[2, 0] * scalar, matrix[2, 1] * scalar, matrix[2, 2] * scalar}};
        
        return (result);
    }     
}
