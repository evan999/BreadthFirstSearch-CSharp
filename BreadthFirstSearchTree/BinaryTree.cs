using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearchTree
{
    public class BinaryTree 
    {
        BinaryTreeNode root;

        public void traverseBinaryTree()
        {
            BinaryTreeNode travelerNode = root;

            while (travelerNode.leftChild != null || travelerNode.rightChild != null)
            {
                if (travelerNode.leftChild != null)
                {
                    travelerNode = travelerNode.leftChild;
                    
                }
                else if (travelerNode.rightChild != null)
                {
                    travelerNode = travelerNode.rightChild;
                }
                

            }
            
            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
        }
        

    }
}
