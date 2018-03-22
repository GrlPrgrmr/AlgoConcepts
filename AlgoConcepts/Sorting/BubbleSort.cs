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

        //we can use recursion as every next pass array size is reduced by 1 and end of array is already sorted
        public void recursiveBubbleSort(int[] arr,int n)
        {
            int i = 0;

            if(n==1)
            {
                return;
            }

            //single pass to fix largest element in the end
            for(i=0;i<n-1;i++)
            {
                if(arr[i]>arr[i+1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }

            recursiveBubbleSort(arr,n-1);

        }

        public void bubbleSortSingleLList(SingleLinkedList list)
        {
            int sizeList = list.CountNodes();
            if(sizeList>1)
            {
                for(int i=0;i<sizeList;i++)
                {
                    Node current = list.start;
                    Node next = current.Next;

                    for(int j=0;j<sizeList-i-1;j++)
                    {
                        if(current.Data>next.Data)
                        {
                            int temp = current.Data;
                            current.Data = next.Data;
                            next.Data = temp;
                        }

                        current = next;
                        next = next.Next;
                    }

                }
            }

        }
    }
}
