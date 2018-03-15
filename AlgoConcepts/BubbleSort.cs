using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts
{
    public class BubbleSort
    {
        public void sortIntArray(int[] arr)
        {
            int i, j = 0;
            for(i=0;i<arr.Length-1;i++)
            {
                for(j =0;j<arr.Length-i-1;j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            
        }
    }
}
