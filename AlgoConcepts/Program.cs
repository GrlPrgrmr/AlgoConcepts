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
            int[] intarr = new int[] { 4,2,1,6,8,12};
            string[] strarr = new string[] {"paper", "flower","floppy","true","soap"};

            ss.sortIntArray(intarr);
            ss.sortStrArray(strarr);

            ds.printIntegerArray(intarr);
            ds.printStringArray(strarr);

        }
    }
}
