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

        public void printSingleLinkedList(SingleLinkedList LList)
        {
            
                Node p;
                if (LList.start == null)
                {
                    Console.WriteLine("Your list is empty, idiot");
                    return;
                }
                Console.WriteLine("List is :  ");
                p = LList.start;
                while (p != null)
                {
                    Console.WriteLine(p.Data + " ");
                    p = p.Next;
                }
                Console.WriteLine();
            
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
