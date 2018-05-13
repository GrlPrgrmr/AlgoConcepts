using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts
{
    public static class MatrixChainMultiplication
    {

        // Matrix Ai has dimension p[i-1] x p[i]
        // for i = 1..n
        public static int MatrixChainOrder(int[] p, int i, int j)
        {

            if (i == j)
                return 0;

            int min = int.MaxValue;

            // place parenthesis at different places 
            // between first and last matrix, recursively 
            // calculate count of multiplications for each
            // parenthesis placement and return the 
            // minimum count
            for (int k = i; k < j; k++)
            {
                int count = MatrixChainOrder(p, i, k) +
                MatrixChainOrder(p, k + 1, j) + p[i - 1]
                                           * p[k] * p[j];

                if (count < min)
                    min = count;
            }

            // Return minimum count
            return min;
        }
    }
}
