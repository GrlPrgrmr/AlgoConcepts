using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts.Sorting
{
    public class QuickSort
    {
        #region arrays

        public void quickSortIntArray(int[] arr,int low,int high)
        {
            if(low>=high)
            {
                return;
            }

            int pi = partitionIntArrayFromEnd(arr, low, high);

            quickSortIntArray(arr, low, pi - 1);
            quickSortIntArray(arr, pi + 1, high);


        }

        private int partitionIntArrayFromEnd(int[] arr, int low, int high)
        {
            int pi;

            pi = arr[high];

            int i = low - 1;

            for(int j=low;j<high;j++)
            {
                if(arr[j]<pi)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high]; // as we have filled places till i with values smaller than our pivot arr[arr.length-1]
            arr[high] = temp1;

            return (i+1);
        }
        #endregion

        #region Linked List

        public Node QuickSortLinkedList(Node head,Node end)
        {
            //Base case
            if(head==null || head.Next==null || head == end)
            {
                return head;
            }

            //size 5 array with pivot and two end points for left and right part
            Node[] BrokenLL = partition(head, end);

            //Recur the left side
            Node Left = null;
            if(BrokenLL[0]!=null)
            {
                Left = QuickSortLinkedList(BrokenLL[0], BrokenLL[1]);
            }

            //recur right side
            Node Right = null;
            if (BrokenLL[3] != null)
            {
                Right = QuickSortLinkedList(BrokenLL[3], BrokenLL[4]);
            }


            //join the pivot to right part
            if(Right!=null)
            {
                BrokenLL[2].Next = Right;
            }

            //return head of the new created list
            if(Left==null)
            {
                //return pivot
                return BrokenLL[2];

            }
            else
            {
                return Left;
            }
        }

        private Node[] partition(Node head,Node end)
        {
            //choose a pivot
            Node pivot = new Node();
            pivot = end;

            //points to the end of new list
            Node tail = end;

            Node newStart = null;

            Node current = head;
            Node previous = null;
            Boolean isFirstNodeDidntMove = true;
            //Iterate and move nodes
            //Iterate the original list till end
            while(current!=null && end!=current)
            {
                Node next = current.Next;

                if(current.Data>pivot.Data)
                {
                    moveCurrentToEnd(current, tail, previous);
                    tail = tail.Next;
                }
                else
                {
                    //??????
                    if(isFirstNodeDidntMove)
                    {
                        newStart = current;
                        isFirstNodeDidntMove = false;
                    }

                    //???????
                    if(previous!=null)
                    {
                        previous.Next = current;
                    }

                    previous = current;
                }

                current = next;
            }

            Node[] brokenList = new Node[5];
            brokenList[0] = newStart;
            brokenList[1] = previous;
            brokenList[2] = pivot;
            brokenList[3] = pivot.Next;
            brokenList[4] = tail;

            return brokenList;
        }

        /// <summary>
        /// Required in partitioning the linked list
        /// </summary>
        /// <param name="current"></param>
        /// <param name="end"></param>
        /// <param name="previous"></param>
        private void moveCurrentToEnd(Node current,Node end,Node previous)
        {
            if(previous!=null)
            {
                previous.Next = end;
            }

            current.Next = null;
            end.Next = current;
        }
        #endregion

        #region doubly Linked List

        private DoublyLinkedListNode partitionDLL(DoublyLinkedListNode head, DoublyLinkedListNode tail)
        {
            int pivot = Convert.ToInt32(tail.Data);

            DoublyLinkedListNode i = head.Prev;

            for(DoublyLinkedListNode j = head;j!=tail;j=j.Next)
            {
                if(Convert.ToInt32(j.Data)<=pivot)
                {
                    i = (i == null) ? head : i.Next;
                    object temp1 = i.Data;
                    i.Data = j.Data;
                    j.Data = temp1;
                }
            }

            i = (i == null) ? head : i.Next;
            object temp = i.Data;
            i.Data = tail.Data;
            tail.Data = temp;
            return i;
        }

        public void QuickSortDLL(DoublyLinkedListNode head, DoublyLinkedListNode tail)
        {
            if(head!=null && tail!=head && head!=tail.Next)
            {
                DoublyLinkedListNode pivot = partitionDLL(head, tail);
                QuickSortDLL(head, pivot.Prev);
                QuickSortDLL(pivot.Next, tail);
            }
        }
        #endregion
    }
}
