using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts
{
    public class DoublyLinkedListNode
    {
        private DoublyLinkedListNode node;

        public DoublyLinkedListNode Next
        {
            get { return node; }
            set { node = value; }
        }

        private DoublyLinkedListNode prev;

        public DoublyLinkedListNode Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public object Data { get; set; }

        public DoublyLinkedListNode(object element)
        {
            this.Data = element;
            this.Next = null;
            this.Prev = null;
        }

        public DoublyLinkedListNode(object element, DoublyLinkedListNode prevNode)
        {
            this.Data = element;
            this.Prev = prevNode;
            prevNode.Next = this;
        }

    }

    class DoublyLinkedList
    {
        private DoublyLinkedListNode head;
        private DoublyLinkedListNode tail;
        private int count;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }


        public int Count
        {
            get { return count; }
        }

        public DoublyLinkedListNode Head
        {
            get { return head; }
        }

        public DoublyLinkedListNode Tail
        {
            get { return tail; }
        }
        public object this[int index]
        {
            get
            {
                if(index>=count || index<0)
                {
                    throw new ArgumentOutOfRangeException("out of range");
                }

                DoublyLinkedListNode currNode = this.head;

                for(int i=0;i<index;i++)
                {
                    currNode = currNode.Next;
                }

                //currNode.Data = value;

                return null;
            }
        }

        public void Add(object item)
        {
            if (this.head == null)
            {
                this.head = new DoublyLinkedListNode(item);
                this.tail = this.head;
            }
            else
            {
                DoublyLinkedListNode newItem = new DoublyLinkedListNode(item, tail);
                this.tail = newItem;
            }
            count++;
        }

        public void createListFromArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Add(arr[i]);
            }
        }

        public DoublyLinkedListNode getLastNode(DoublyLinkedListNode head)
        {
            DoublyLinkedListNode dummy = head;

            while(dummy.Next!=null)
            {
                dummy = dummy.Next;
            }

            return dummy;
        }
    }
}
