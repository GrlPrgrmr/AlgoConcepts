using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts
{
    public class Node
    {
        private int data;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        private Node node;

        public Node Next
        {
            get { return node; }
            set { node = value; }
        }

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public Node getLastNode()
        {
            Node current = this;
            Node end = new Node();
            while(current.Next!=null)
            {
                current = current.Next;
            }

            end = current;
            return end;
        }
        public Node getMiddleNode()
        {
            Node mid = new Node();
            Node dummy = new Node();
            dummy = this;
            int count = 0;
            while (dummy.Next != null)
            {
                count++;
                dummy = dummy.Next;
            }
            count = count + 1;
            int midPos = count / 2;

            if(count%2!=0)
            {
                midPos = midPos + 1;
            }
            dummy = this;
            while (midPos > 1)
            {
                dummy = dummy.Next;
                midPos--;
            }

            mid = dummy;

            return mid;
        }
        public Node()
        {

        }
    }
}
