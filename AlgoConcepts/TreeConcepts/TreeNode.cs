using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts.TreeConcepts
{
    public class TreeNode
    {
       public int data { get; set; }
        public  TreeNode left, right;

        public TreeNode(int _data)
        {
            data = _data;
            left = right = null;
        }
    }
}
