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
            public int data;
            public Node left;
            public Node right;

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
        public BinarySearchTree(int value)
        {
            root = new Node(value);
        }

        public void AddNode(int data)
        {
            if(root == null)
            {
                root = new Node(data);
                Console.WriteLine($"Root was null, adding {data} as root. Root: {root.data}, Root Left:{root.left == null}, Root right:{root.right==null}");
                return;
            }
            else
            {
                Console.WriteLine("root was not null. Calling new method.");
                AddNode(root,data);
            }
            return;
        }
        public void AddNode(Node currentNode, int data)
        {
            if(data < currentNode.data && currentNode.left == null)
            {
                currentNode.left = new Node(data);
                Console.WriteLine($"Added {currentNode.left.data} to the left of root value{currentNode.data} with the value of {data}");
                return;
            }
            if(data > currentNode.data && currentNode.right == null)
            {
                currentNode.right = new Node(data);
                Console.WriteLine($"Added {currentNode.right.data} to the right of root value{currentNode.data} with the value of {data}");
                return;
            }
            if(data < currentNode.data && currentNode.left != null)
            {
                Console.WriteLine($"CurrentNode with value of {currentNode.data} has a left child with value of null: {currentNode.left == null}. Recursion");
                currentNode = currentNode.left;
                Console.WriteLine($"CurrentNode is now {currentNode.data}");
                AddNode(currentNode, data);
            }
            if (data > currentNode.data && currentNode.right != null)
            {
                Console.WriteLine($"CurrentNode with value of {currentNode.data} has a right child with value of null: {currentNode.right == null}. Recursion");
                currentNode = currentNode.right;
                Console.WriteLine($"CurrentNode is now {currentNode.data}");
                AddNode(currentNode, data);
            }
        }
    }
}
