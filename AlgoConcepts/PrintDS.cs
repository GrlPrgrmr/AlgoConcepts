using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts
{
    public class PrintDS : IPrint
    {
        public void printIntegerArray(int[] arr)
        {
           for(int i =0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void printStringArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
