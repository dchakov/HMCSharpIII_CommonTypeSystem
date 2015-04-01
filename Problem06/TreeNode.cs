using System;
using System.Collections.Generic;

namespace Problem06
{
    public class TreeNode<T>
    {
        // Contains the value of the node
        private T value;

        // Shows whether the current node has parent
        private bool hasParent;

        // Contains the left child of the node
        private TreeNode<T> leftChild;

        // Contains the right child of the node
        private TreeNode<T> rightChild;

        // Constructs a binary tree node
        public TreeNode(T value, TreeNode<T> leftChild, TreeNode<T> rightChild)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            this.value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        // Constructs a binary tree node with no children
        public TreeNode(T value)
            : this(value, null, null)
        {
        }

        // The value of the node
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        /// The left child of the node       
        public TreeNode<T> LeftChild
        {
            get { return this.leftChild; }
            set
            {
                if (value == null)
                {
                    return;
                }
                if (value.hasParent)
                {
                    throw new ArgumentException("The node already has a parent!");
                }
                value.hasParent = true;
                this.leftChild = value;
            }
        }

        /// The right child of the node

        public TreeNode<T> RightChild
        {
            get { return this.rightChild; }
            set
            {
                if (value == null)
                {
                    return;
                }
                if (value.hasParent)
                {
                    throw new ArgumentException("The node already has a parent!");
                }
                value.hasParent = true;
                this.rightChild = value;
            }
        }
    }
}
