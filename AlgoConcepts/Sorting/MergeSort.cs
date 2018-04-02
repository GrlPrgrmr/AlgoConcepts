using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts.Sorting
{
    public class MergeSort
    {
        #region merge sort arrays
        public void mergesortIntArray(int[] arr,int l,int r)
        {
           if(l<r)
            {
                int mid = (l + r) / 2;

                mergesortIntArray(arr, l, mid);
                mergesortIntArray(arr, mid + 1, r);

                mergeArrays(arr, l, mid, r);
            }
        }

        private void mergeArrays(int[] arr,int l,int m, int r)
        {
            //find sizes of two array to be merged
            int nL = m - l + 1;
            int nR = r - m;

            int[] L = new int[nL];
            int[] R = new int[nR];

            for(int i1 =0;i1<nL;i1++)
            {
                L[i1] = arr[i1+l];
            }


            for (int i2 =0; i2 < nR; i2++)
            {
                R[i2] = arr[i2+m+1];
            }

             int i = 0, j = 0;
            int  k = l;

            while (i<nL && j<nR)
            {
                if(L[i]<R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else 
                {
                    arr[k] = R[j];
                    j++;
                }

                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < nL)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < nR)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
           
        }
        #endregion

        #region merge sort linked lists
        public Node MergeSortLList(Node head)
        {
            if(head==null || head.Next==null)
            {
                return head;
            }


            Node middle = head.getMiddleNode();
            Node nextOfMiddle = middle.Next;

            middle.Next = null;
            Node left = MergeSortLList(head);
            Node right = MergeSortLList(nextOfMiddle);

            Node sortedList = sortedMerge(left, right);

            return sortedList;
        }

        private Node sortedMerge(Node left, Node right)
        {
            Node result = null;
            if (left == null)
                return right;

            if (right == null)
                return left;

            if(left.Data<right.Data)
            {
                result = left;
                left.Next = sortedMerge(left.Next, right);
            }
            else
            {
                result = right;
                right.Next = sortedMerge(right.Next, left);
            }

            return result;
        }
        #endregion
    }
}
