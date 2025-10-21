using System;

namespace BinarySearchTreeDemo
{
    public class TreeNode<T>
    {
        // The value stored in this node
        public T Value { get; set; }

        // Nullable child references (can be null for leaf nodes)
        public TreeNode<T>? Left { get; set; }
        public TreeNode<T>? Right { get; set; }

        // Constructor to create a node with a given value
        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
