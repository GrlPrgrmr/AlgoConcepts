using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts
{
    public class SelectionSort
    {
       
        /// <summary>
        /// Selection sort for integer array
        /// </summary>
        /// <param name="arr"></param>
        public void sortIntArray(int[] arr)
        {
            int min_idx = 0;

            for(int i=0;i<arr.Length-1;i++)
            {
                min_idx = i;

                for(int j=i+1;j<arr.Length;j++)
                {
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                }

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;

            }
        }

        /// <summary>
        /// Selection Sort for String arrays
        /// </summary>
        /// <param name="arr"></param>
        public void sortStrArray(string[] arr)
        {
            int min_idx = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                min_idx = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[min_idx])<0)
                        min_idx = j;
                }

                string temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;

            }
        }
    }
}
