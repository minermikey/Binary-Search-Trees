namespace BinarySearchTreeDemo
{
    // Binary Tree vs Binary search Tree 

    // Binary Tree : the larger value can be any where ( Left or Right of parent node)

    // Binary search Tree : the larger value can only be on the right n the left node withh be less than the parent node 
    // Binary search Tree : logical structure that can be implemented in many different ways 

    //Calculating Height
    // 2^h-1 = n -> h = log (n+1) -> 0 logn)

    //time complexity for delete and insert are also log n because essentially they are finding a node //and then adding constant time to do the operation so we can forget about the added constant time


    using System.Runtime.CompilerServices;
    using System.Threading.Tasks.Dataflow;
    using System.Xml;


    /// Summary we will be looking at the diffrences in diffrent trees 
    /// /// 
    /// /// Reffrences https://www.youtube.com/watch?v=Etpc_-br5rI
    /// /// https://chatgpt.com/share/68f620da-24d0-8004-a192-55be877a7bd5
    /// public class BinaryTree<T> where T : IComparable<T> 
    /// what is happening here ?? 
    /// Where are creating a class with a generic type that will allow any information 
    /// to be stored such as a string or a int 
    /// IComparable simply means that IComparable we can use .CompareTo() when coding out information. This is very important 
    /// so that we can know where on the tree it can go either left or right 
    public class BinaryTree<T> where T : IComparable<T>
    {

        // Creating the Top Node
        // Making a Private Set so that only the tree itself can set the node
        public TreeNode<T> Root { get; private set; }

        /// <summary>
        /// This method ass values to the tree 
        /// /// It is called a recursive helper function : which is a secondary function, that is used in conjuntion with a main function to faciliate a recursive ( repetative ) process 
        /// /// So the use of recursive allows us to find where in the tree is goes
        /// </summary>

        public void Insert(T value)
        {

            Root = InsertRecursive(Root, value);

        }

        private TreeNode<T> InsertRecursive(TreeNode<T> node, T value)
        {

            // if the node is empty then we create a new node 
            if (node == null) { return new TreeNode<T>(value); }
            // if the value < node.value, go left
            if (value.CompareTo(node.Value) < 0)
            { node.Left = InsertRecursive(node.Left, value); }
            else // if the value >  node.value, go right 
            { node.Right = InsertRecursive(node.Right, value); }

            return node;

        }
        // InOrderTraversal : This method is used to traverse the tree in order ( Left -> Root -> Right )
        public void InOrderTraversal(TreeNode<T> node)
        {
            if (node == null) { return; } // if the node is null then we return 

            InOrderTraversal(node.Left);    // we go left 
            Console.Write(node.Value + " "); // we print the value 
            InOrderTraversal(node.Right); // we go right 
        }

        // Preorder 
        public void PreOrder(TreeNode<T> node)
        {

            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }

        }

        // Postorder 
        public void PostOrder(TreeNode<T> node)
        {

            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write(node.Value + " ");
            }

        }


        // Search 
        // This is a recursive helper function 
        // It is used to find a value in the tree 
        public bool Search(T value)
        {
            // Root is the current node we are checking 
            // value is the value we are looking for 
            return SearchRecursive(Root, value);
        }

        // SearchRecursive : This is a recursive helper function 
        // It is used to find a value in the tree 

        private bool SearchRecursive(TreeNode<T> node, T value)
        {
            // if the node is null then we return false 
            if (node == null) return false;
            // comparison is used to compare the value we are looking for with the current node 

            // Below are the 3 possible outcomes 
            int comparison = value.CompareTo(node.Value);
            // if the comparision is = 0 then we return true    
            if (comparison == 0) return true;
            // if the comparison is < 0 then we go left 
            else if (comparison < 0) return SearchRecursive(node.Left, value);
            // if the comparison is > 0 then we go right 
            else return SearchRecursive(node.Right, value);

        }


        // Delete
        // This is a recursive helper function 
        // It is used to delete a value from the tree 
        public void Delete(T value)
        {
            // Root is the current node we are checking 
            // value is the value we are looking for 
            Root = DeleteRecursive(Root, value);
        }

        private TreeNode<T> DeleteRecursive(TreeNode<T> node, T value)
        {

            // if the node is null then we return null 
            if (node == null)
                return null;
            // comparison is used to compare the value we are looking for with the current node 
            int comparison = value.CompareTo(node.Value);
            // if the comparison is < 0 then we go left 
            if (comparison < 0)
                node.Left = DeleteRecursive(node.Left, value);
            // if the comparison is > 0 then we go right 
            else if (comparison > 0)
                node.Right = DeleteRecursive(node.Right, value);
            // if the comparison is = 0 then we delete the node 
            else
            {
                // Case 1: No child
                if (node.Left == null && node.Right == null)
                    return null;

                // Case 2: One child
                if (node.Left == null)
                    return node.Right;
                if (node.Right == null)
                    return node.Left;

                // Case 3: Two children
                // Find the minimum node in the right subtree
                TreeNode<T> minNode = FindMin(node.Right);
                // Set the node's value to the minimum value
                node.Value = minNode.Value;
                // Delete the minimum node from the right subtree
                node.Right = DeleteRecursive(node.Right, minNode.Value);
            }
            return node;
        }

        private TreeNode<T> FindMin(TreeNode<T> node)
        {
            while (node.Left != null)
                node = node.Left;
            return node;
        }

        // Visual Print (simple indented structure)
        public void PrintTree(TreeNode<T> node, string indent = "", bool isLeft = true)
        {

            // if the node is not null then we print the node 
            if (node != null)
            {
                // if the node is the left child then we print the node 
                Console.WriteLine(indent + (isLeft ? "├── " : "└── ") + node.Value);
                // if the node is the left child then we print the node     
                PrintTree(node.Left, indent + (isLeft ? "│   " : "    "), true);
                // if the node is the right child then we print the node 
                PrintTree(node.Right, indent + (isLeft ? "│   " : "    "), false);
            }
        }


    }
}