using System;
using System.Collections.Generic;


namespace Problem06
{
    public class BinarySearchTree<T>
    {
        // The root of the tree
        private TreeNode<T> root;
                
        // Constructs the tree
        public BinarySearchTree(T value, BinarySearchTree<T> leftChild, BinarySearchTree<T> rightChild)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            TreeNode<T> leftChildNode = leftChild != null ? leftChild.root : null;
            TreeNode<T> rightChildNode = rightChild != null ? rightChild.root : null;
            this.root = new TreeNode<T>( value, leftChildNode, rightChildNode);
        }
        // Constructs the tree
        public BinarySearchTree(T value)
            : this(value, null, null)
        {
        }
       
        // The root of the tree.
        public TreeNode<T> Root
        {
            get { return this.root;}
        }

        // Traverses binary tree in pre-order manner
        private void PrintInorder(TreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }
            // 1. Visit the left child
            PrintInorder(root.LeftChild);
            // 2. Visit the root of this subtree
            Console.Write(root.Value + " ");
            // 3. Visit the right child
            PrintInorder(root.RightChild);
        }

        // Traverses and prints the binary tree in pre-order manner
        public void PrintInorder()
        {
            PrintInorder(this.root);
            Console.WriteLine();

        }
    }
}
