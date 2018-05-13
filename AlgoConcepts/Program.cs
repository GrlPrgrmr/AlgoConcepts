using AlgoConcepts.Sorting;
using AlgoConcepts.TreeConcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts
{
    class Program
    {
        static void DriverCodeGraph()
        {
            // Create a list of vertices using the Vertex<T> class
            List<Vertex<string>> vertices = new List<Vertex<string>>
            (
                new Vertex<string>[]
                    {
                new Vertex<string>("Los Angeles"),
                new Vertex<string>("San Francisco"),
                new Vertex<string>("Las Vegas"),
                new Vertex<string>("Seattle"),
                new Vertex<string>("Austin"),
                new Vertex<string>("Portland")
                    }
            );

            // Establish edges; Ex. Los Angeles -> San Francisco, Las Vegas, Portland
            vertices[0].AddEdges(new List<Vertex<string>>(new Vertex<string>[]
            {
            vertices[1], vertices[2], vertices[5]
            }));

            vertices[1].AddEdges(new List<Vertex<string>>(new Vertex<string>[]
            {
            vertices[0], vertices[3], vertices[5]
            }));

            vertices[2].AddEdges(new List<Vertex<string>>(new Vertex<string>[]
            {
            vertices[0], vertices[1], vertices[4]
            }));

            vertices[3].AddEdges(new List<Vertex<string>>(new Vertex<string>[]
            {
            vertices[1], vertices[5]
            }));

            vertices[4].AddEdges(new List<Vertex<string>>(new Vertex<string>[]
            {
            vertices[2]
            }));

            vertices[5].AddEdges(new List<Vertex<string>>(new Vertex<string>[]
            {
            vertices[1], vertices[3]
            }));

            // Create graph using the UndirectedGenericGraph<T> class
            UndirectedGenericGraph<string> testGraph = new UndirectedGenericGraph<string>(vertices);

            // Check to see that all neighbors are properly set up
            foreach (Vertex<string> vertex in vertices)
            {
                Console.WriteLine(vertex.ToString());
            }

            // Test searching algorithms
            testGraph.DepthFirstSearch(vertices[0]);
            //testGraph.BreadthFirstSearch(vertices[0]);
        }

        static void driverCodeMatrixChainMulti()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 3 };
            int n = arr.Length;

            Console.Write("Minimum number of multiplications is "
                              + MatrixChainMultiplication.MatrixChainOrder(arr, 1, n - 1));
        }

        static void driverCodeMinEditDistance()
        {
            int res = MinimumEditDistance.findMinDistance("Sun", "Sat",3,3);
        }

        static void driverCodeIsSubsetSum()
        {
            int[] arr = { 3, 1, 5, 9, 12 };
            int n = arr.Length;
            if (IsSubsetSum.findPartition(arr, n) == true)
                Console.Write("Can be divided into two " +
                              "subsets of equal sum");
            else
                Console.Write("Can not be divided into " +
                              "two subsets of equal sum");
        }
        static void Main(string[] args)
        {

            driverCodeIsSubsetSum();
            ////driverCodeMinEditDistance();
            //driverCodeMatrixChainMulti();
            //DriverCodeGraph();

            //PrintDS ds = new PrintDS();
            //SelectionSort ss = new SelectionSort();
            //int[] intarr = new int[] { 5,3,4,2,8,9,1};
            //string[] strarr = new string[] {"paper", "flower","floppy","true","soap"};

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

            
            int[] input = new int[] { 12, 11, 13, 5, 6, 7 };
            //ms.mergesortIntArray(input,0,input.Length-1);
            //MergeSort ms = new MergeSort();
            //SingleLinkedList sLL = new SingleLinkedList();
            //sLL.CreateList(input);

            //ms.MergeSortLList(sLL.start)

            QuickSort qs = new QuickSort();
            //qs.quickSortIntArray(input,0,input.Length-1);
            //qs.QuickSortLinkedList(sLL.start, sLL.start.getLastNode());

            //DoublyLinkedList dll = new DoublyLinkedList();
            //dll.createListFromArray(input);
            //qs.QuickSortDLL(dll.Head,dll.Tail);

            //BinaryTree bt = new BinaryTree();
            //bt.root = new TreeNode(1);
            //bt.root.left = new TreeNode(2);
            //bt.root.right = new TreeNode(3);
            //bt.root.left.left = new TreeNode(4);
            //bt.root.left.right = new TreeNode(5);

            //bt.printInOrder(bt.root);

            //bt.printPreOrder(bt.root);

            //bt.printPostOrder(bt.root);

            int[] inorder = new int[] {4,2,5,1,3,6 };
            int[] preorder = new int[] { 1,2,4,5,3,6};

            BinaryTree output = new BinaryTree();
            output.root = output.createTreeFromPreInOrderTraversal(inorder, preorder, 0, inorder.Length-1);


        }
    }
}
