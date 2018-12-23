using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treemerge
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(1);
            t1.left = new TreeNode(3);
            t1.right = new TreeNode(2);
            t1.left.left = new TreeNode(5);

            TreeNode t2 = new TreeNode(2);
            t2.left = new TreeNode(1);
            t2.right = new TreeNode(3);
            t2.left.right = new TreeNode(4);
            t2.right.right = new TreeNode(7);

            TreeNode mergedTree = MergeTrees(t1, t2);




        }

        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if(t1 == null)
            {
                return t2;
            }
            if(t2 == null)
            {
                return t1;
            }

            TreeNode newNode = new TreeNode(t1.val + t2.val);

            newNode.left = MergeTrees(t1.left, t2.left);
            newNode.right = MergeTrees(t1.right, t2.right);

            return newNode;
        }

    }
}
