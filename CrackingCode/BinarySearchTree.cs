using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCode
{
    class BinarySearchTree
    {
        public class Node
        {
            int data;
            Node left;
            Node right;

            public Node(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }

        Node root;

        public BinarySearchTree()
        {
            root = null;
        }
        public BinarySearchTree(int data)
        {
            root = new Node(data);
        }

        public void AddNode(int data)
        {
            if(root == null)
            {
                root = new Node(data);
            }
            else
            {
                
            }
        }
    }
}
