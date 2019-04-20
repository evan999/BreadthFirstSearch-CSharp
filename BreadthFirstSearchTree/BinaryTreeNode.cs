using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearchTree
{
    public class BinaryTreeNode
    {
        public int data;
        public BinaryTreeNode leftChild;
        public BinaryTreeNode rightChild;

        public BinaryTreeNode(int item)
        {
            data = item;
            leftChild = null;
            rightChild = null;
        }


    }
}
