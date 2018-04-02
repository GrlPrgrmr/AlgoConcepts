using System;

namespace AlgoConcepts
{
    public class SingleLinkedList
    {
        public Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        /// <summary>
        /// Creates a single LL using addAtLast Method
        /// </summary>
        /// <param name="arr"></param>
        public void CreateList(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                addNodeAtLast(arr[i]);
            }
        }

        public void addNodeAtFront(int data)
        {
            Node current = new Node(data);
            current.Next = this.start;

            start = current;
        }
        public void addNodeAtLast(int data)
        {
            Node Current = new Node();

            if(start==null)
            {
                start = new Node(data);
                return;
            }

            Current = start;

            while(Current.Next!=null)
            {
                Current = Current.Next;
            }

            Current.Next = new Node(data);

        }
        public int CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.Next;
            }
            Console.WriteLine("Number of nodes in list is = " + n+"\n");
            return n;
        }

       
        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null)
            {
                if (p.Data == x)
                    break;
                position++;
                p = p.Next;
            }
            if (p == null)
            {
                Console.WriteLine(x + "not found in list because use an idiot");
            }
            else
            {
                Console.WriteLine(x + "is at position " + position);
                return true;
            }
            return false;
        }
    }
}
