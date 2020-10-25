using System;
using System.Collections.Generic;
using System.Text;

namespace DS_BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> root;

        //Constructor
        public BinarySearchTree()
        {
            this.root = null;
        }

        //Insert element into Binary Search Tree
        public void Insert(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (root == null)
                root = newNode;
            else
            {
                Node<T> current = root;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    if (element.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }

                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        //Inorder traversal to display Binary search Tree
        public void Display(Node<T> node)
        {
            if (node != null)
            {
                Display(node.Left);
                Console.WriteLine(node.data);
                Display(node.Right);
            }
        }


        public int Size(Node<T> node)
        {
            if (node == null) return (0);
            else
            {
                return (Size(node.Left) + 1 + Size(node.Right));
            }
        }
    }
}
