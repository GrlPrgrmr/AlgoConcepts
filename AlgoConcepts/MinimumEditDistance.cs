using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts
{
    public static class MinimumEditDistance
    {
        static int min(int x, int y, int z)
        {
            if (x <= y && x <= z) return x;
            if (y <= x && y <= z) return y;
            else return z;
        }


        //find minimum distance between two strings where cost of 3 operations replace,add and delete is 1
        public static int findMinDistance(string str1, string str2,int m,int n)
        {
            int minDistance;
            if (m == 0)
            {
                minDistance = n;
                return minDistance;
            }

            if (n == 0)
            {
                minDistance = m;
                return minDistance;
            }


            if (str1[m - 1] == str2[n - 1])
            {
                minDistance = findMinDistance(str1, str2, m - 1, n - 1);
                return minDistance;
            }

           

            minDistance = 1 + min(findMinDistance(str1, str2, m, n - 1),
                            findMinDistance(str1,str2,m-1,n),
                            findMinDistance(str1,str2,m-1,n-1));
            return minDistance;
        }
    }
}
