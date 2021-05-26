// C# program for different  
// tree traversals 

using System;

namespace TreeTraversals
{
    //Class containing left and right child of current node and key value
    public class Node
    {
        //For storing data or value
        public int key;

        public Node left, right; 
        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

   
    public class TreeTraversal
    {
        //Given a binary tree, print its nodes according to the "bottom-up" postorder traversal.
        public void PrintPostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            //First recure on left subtreee
            PrintPostOrder(node.left);

            //then recure on right subtree
            PrintPostOrder(node.right);

            //
            Console.Write(node.key + "  ");
        }

        //Given a binary tree, print its nodes in order.
        public void PrintInOrder(Node node)
        {
            if (node == null)
            {
                return;
            }


            //First recure on left subtreee
            PrintInOrder(node.left);


            /* then print the data of node */
            Console.Write(node.key + "  ");

            //then recure on right subtree
            PrintInOrder(node.right);
        }


        /* Given a binary tree, print its nodes in preorder*/
        public void PrintPreorder(Node node)
        {
            if (node == null)
                return;

            /* first print data of node */
            Console.Write(node.key + " ");

            /* then recur on left sutree */
            PrintPreorder(node.left);

            /* now recur on right subtree */
            PrintPreorder(node.right);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //This is the root Node
            //This is also a binary tree
            Node root = new Node(1); 

            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            TreeTraversal treeTraversal = new TreeTraversal();

            Console.WriteLine("Preorder traversal of binary tree is ");
            treeTraversal.PrintPostOrder(root);

            Console.WriteLine("\nInorder traversal of binary tree is ");
            treeTraversal.PrintInOrder(root);

            Console.WriteLine("\nPostorder traversal of binary tree is ");
            treeTraversal.PrintPreorder(root);


            Console.ReadKey();
        }
    }
}
