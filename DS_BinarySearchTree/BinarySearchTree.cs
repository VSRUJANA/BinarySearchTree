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
                Console.Write(node.data+"\t");
                Display(node.Right);
            }
        }


        //Size of Binary Search Tree
        public int Size(Node<T> node)
        {
            if (node == null) return (0);
            else
            {
                return (Size(node.Left) + 1 + Size(node.Right));
            }
        }

        //Search given node in Binary search tree
        public void BinarySearch(T element)
        {
            Node<T> current = root;
            bool elementFound = false;
            while (current != null)
            {
                if (current.data.Equals(element))
                {
                    elementFound = true;
                    break;
                }
                else
                {
                    if (element.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
            if (elementFound)
                Console.WriteLine("Element {0} found",element);
            else
                Console.WriteLine("Element doesn't exist in the tree");
        }
    }
}
