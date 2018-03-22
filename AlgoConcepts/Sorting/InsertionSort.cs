using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts.Sorting
{
    public class InsertionSort
    {
        public void sortIntArray(int[] arr)
        {
            int size = arr.Length;

            for(int i=1;i<size;++i)
            {
                int key = arr[i];
                int j = i - 1;
                
                //Creating a window backwards and finding place for the key in it
                while (j >= 0 && arr[j]>key)
                {
                    arr[j + 1] = arr[j]; 
                    j = j - 1;
                }

                arr[j+1] = key;
            }
        }

        public void recursiveSortIntArray(int[] arr,int n)
        {
            if (n <= 1)
                return;

            recursiveSortIntArray(arr, n - 1);

            int last = arr[n - 1];
            int j = n - 2;

            while(j>=0 && arr[j]>last)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = last;
        }
    }
}
