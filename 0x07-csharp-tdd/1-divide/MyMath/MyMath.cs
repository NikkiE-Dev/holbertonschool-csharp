using System;

namespace MyMath
{
    ///<summary>Creates a public class.</summary>
    public class Matrix
    {
        ///<summary>Creates a protype.</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            int mrow = matrix.GetLength(0);
            int mcolumn = matrix.GetLength(1);
            int[,] newMatrix = new int[mrow, mcolumn];
            for (int a = 0; a < mrow; a++)
            {
                for (int b = 0; b < mcolumn; b++)
                {
                    newMatrix[a, b] = matrix[a,b] / num;
                }
            }
            return (newMatrix);
        }
    }
}
