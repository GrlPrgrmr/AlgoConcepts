using AlgoConcepts.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDS ds = new PrintDS();
            SelectionSort ss = new SelectionSort();
            int[] intarr = new int[] { 5,3,4,2,8,9,1};
            string[] strarr = new string[] {"paper", "flower","floppy","true","soap"};

            //ss.sortIntArray(intarr);
            //ss.sortStrArray(strarr);

            //ds.printIntegerArray(intarr);
            //ds.printStringArray(strarr);

            //BubbleSort bs = new BubbleSort();
            //bs.recursiveBubbleSort(intarr,intarr.Length);
            //ds.printIntegerArray(intarr);

            //SingleLinkedList sList = new SingleLinkedList();
            //sList.CreateList(intarr);

            //BubbleSort bs = new BubbleSort();
            //bs.bubbleSortSingleLList(sList);

            //InsertionSort isrt = new InsertionSort();
            //isrt.sortIntArray(intarr);

            //isrt.recursiveSortIntArray(intarr,intarr.Length);

            MergeSort ms = new MergeSort();
            int[] input = new int[] { 12, 11, 13, 5, 6, 7 };
            //ms.mergesortIntArray(input,0,input.Length-1);

            SingleLinkedList sLL = new SingleLinkedList();
            sLL.CreateList(input);

            ms.MergeSortLList(sLL.start);

        }
    }
}
