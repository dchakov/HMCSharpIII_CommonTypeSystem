//Problem 6.* Binary search tree• Define the data structure binary search tree with operations for "adding new element", "searching element" and "deleting elements". It is not necessary to keep the tree balanced.
//• Implement the standard methods from  System.Object  –  ToString() ,  Equals(…) ,  GetHashCode()  and the operators for comparison  ==  and  != .
//• Add and implement the  ICloneable  interface for deep copy of the tree.
//Remark: Use two types – structure  BinarySearchTree  (for the tree) and class  TreeNode  (for the tree elements). Implement  IEnumerable<T>  to traverse the tree.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class MainMethod
    {
        public static void Main()
        {
            // From book 

            BinarySearchTree<int> binaryTree =
                new BinarySearchTree<int>(14,
                new BinarySearchTree<int>(19,
                new BinarySearchTree<int>(23),
                new BinarySearchTree<int>(6,
                new BinarySearchTree<int>(10),
                new BinarySearchTree<int>(21))),
                new BinarySearchTree<int>(15,
                new BinarySearchTree<int>(3),
                null));
            // Traverse and print the tree in in-order manner
            binaryTree.PrintInorder();
        }
    }
}
