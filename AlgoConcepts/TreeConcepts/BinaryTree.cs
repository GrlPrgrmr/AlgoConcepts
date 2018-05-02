using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts.TreeConcepts
{
   
    class BinaryTree
    {
        public TreeNode root;

        public BinaryTree()
        {
            root = null;
        }

        public void printInOrder(TreeNode node)
        {
            if (node == null)
                return;

            printInOrder(node.left);

            Console.WriteLine(node.data + " ");

            printInOrder(node.right);
        }

        public void printPreOrder(TreeNode node)
        {
            if (node == null)
                return;

            Console.WriteLine(node.data+ " ");

            printPreOrder(node.left);
            printPreOrder(node.right);
        }

        public void printPostOrder(TreeNode node)
        {
            if (node == null)
                return;

            printPostOrder(node.left);
            printPostOrder(node.right);

            Console.WriteLine(node.data + " ");
        }

        private int GetIndexForTreeItem(int[] arr,int start,int end,int value)
        {
            for(int i=start;i<end;i++)
            {
                if(arr[i] == value)
                {
                    return i;
                }
            }

            return 0;
        }
        static int rootIndexPre = 0;

        public TreeNode createTreeFromPreInOrderTraversal(int[]inOrder, int[]preOrder,int beg, int last)
        {
           
            if(beg>last)
            {
                return null;
            }

            //extracted the root node from preorder
            TreeNode tnode = new TreeNode(preOrder[rootIndexPre++]);

            //only one node is present in the traversal
            if(beg==last)
            {
                return tnode;
            }

            //get index of rootNode from Inorder traversal
            int rootIndexIn = GetIndexForTreeItem(inOrder, beg,last,tnode.data);

            //using index from inorder traversal create left and right tree
            tnode.left = createTreeFromPreInOrderTraversal(inOrder, preOrder, beg, rootIndexIn - 1);
            tnode.right = createTreeFromPreInOrderTraversal(inOrder, preOrder, rootIndexIn + 1, last);

            return tnode;
            //return null;
        }
    }
}
