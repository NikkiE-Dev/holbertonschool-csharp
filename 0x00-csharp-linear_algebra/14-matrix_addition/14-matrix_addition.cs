using System;

///<summary>Creates a class to add 2 matrices.</summary>
class MatrixMath
{
    ///<summary>Creates a protype with parameters.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] result = new double[,] {{-1}};
            
        if (matrix1.Length == 2 && matrix2.Length == 2)
                result = new double[2] {matrix1[0] + matrix2[0], matrix1[1] + matrix2[1]};

            if (matrix1.Length == 3 && matrix2.Length == 3)
                result = new double[3] {matrix1[0] + matrix2[0], matrix1[1] + matrix2[1], matrix1[2] + matrix2[2]};
        
            return (result);
    }   
        
}
