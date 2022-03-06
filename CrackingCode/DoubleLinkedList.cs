using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCode
{
    class DoubleLinkedList<T> where T : IComparable
    {
        class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node<T> prev;
            public Node(T data)
            {
                this.data = data;
                next = null;
                prev = null;
            }
        }

        Node<T> head = null;
        Node<T> trail = null;
        int count = 0;

        public void AddToFront(T value)
        {
            Node<T> node = new Node<T>(value);
            node.next = head;
            head = node;
            count++;
        }
        public void AddToEnd(T value)
        {
            Node<T> node = new Node<T>(value);

            var current = head;
            while (current != null)
            {
                if (current.next == null)
                {
                    current.next = node;
                    break;
                }
                current = current.next;
            }
        }
        public void Remove(T value)
        {
            var currentNode = head;
            var previousNode = currentNode;
            while (currentNode.data.CompareTo(value) != 0)
            {
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
            previousNode.next = currentNode.next;
            currentNode.next = null;
            currentNode.data = default;
            count--;

        }
        public int Count => count;

        public void Print()
        {
            var runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }
    }
}
