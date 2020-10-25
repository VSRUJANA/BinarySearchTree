using System;

namespace DS_BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree program!");
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Display(bst.root);
        }
    }
}
