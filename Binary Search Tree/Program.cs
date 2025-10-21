using BinarySearchTreeDemo;

namespace BinarySearchTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            // Insert nodes
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(70);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(60);
            tree.Insert(80);

            Console.WriteLine("🌳 Binary Tree (Visual View):");
            tree.PrintTree(tree.Root);

            Console.WriteLine("\nIn-order Traversal:");
            tree.InOrderTraversal(tree.Root);

            Console.WriteLine("\n\nPre-order Traversal:");
            tree.PreOrder(tree.Root);

            Console.WriteLine("\n\nPost-order Traversal:");
            tree.PostOrder(tree.Root);

            Console.WriteLine("\n\nSearch for 60: " + (tree.Search(60) ? "Found ✅" : "Not Found ❌"));
            Console.WriteLine("Search for 25: " + (tree.Search(25) ? "Found ✅" : "Not Found ❌"));

            Console.WriteLine("\nDeleting 70...");
            tree.Delete(70);

            Console.WriteLine("\nTree After Deletion:");
            tree.PrintTree(tree.Root);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}