using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts
{
    public static class IsSubsetSum
    {
       public static bool isSubsetSum(int[] arr, int n, int sum)
        {
            bool res;
            // Base Cases
            if (sum == 0)
                return true;
            if (n == 0 && sum != 0)
                return false;

            // If last element is greater than sum, then ignore it
            if (arr[n - 1] > sum)
                return isSubsetSum(arr, n - 1, sum);

            /* else, check if sum can be obtained by any of
            the following
            (a) including the last element
            (b) excluding the last element
            */
            res = isSubsetSum(arr, n - 1, sum) ||
                   isSubsetSum(arr, n - 1, sum - arr[n - 1]);

            return res;
        }

        // Returns true if arr[] can be partitioned in two
        // subsets of equal sum, otherwise false
       public static bool findPartition(int[] arr, int n)
        {
            // Calculate sum of the elements in array
            int sum = 0;
            bool result;
            for (int i = 0; i < n; i++)
                sum += arr[i];

            // If sum is odd, there cannot be two subsets
            // with equal sum
            if (sum % 2 != 0)
                return false;

            // Find if there is subset with sum equal to half
            // of total sum

            result= isSubsetSum(arr, n, sum / 2);

            return result;
        }

    }
}
