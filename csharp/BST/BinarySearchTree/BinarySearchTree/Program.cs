using System;

namespace BinarySearchTree
{
    class Program
    {
        // Node for binary tree
        // Consist of key, left subtree and right sub tree
        public class Node
        {
            public int key;
            public Node left;
            public Node right;

            public Node(int item)
            {
                key = item;
                left = right = null;

            }
        }

        // Binary search tree also called BST
        // The left subtree of a node contains only nodes with keys lesser than the node’s key.
        // The right subtree of a node contains only nodes with keys greater than the node’s key.
        // The left and right subtree each must also be a binary search tree.
        // There must be no duplicate nodes.
        public class BinarySearchTree
        {
            //root of BST
            Node root;


            // This method mainly calls insertRec() 
            // A wrapper method
            public void Insert(int key)
            {
                root = InsertRec(root, key);
            }

            // A recursive function to insert a new key in BST
            // Create a binary search tree
            public Node InsertRec(Node root, int key)
            {
                if (root == null)
                {
                    root = new Node(key);
                    return root;
                }

                /* Otherwise, recur down the tree */
                if (key < root.key)
                {
                    root.left = InsertRec(root.left, key);
                }
                else if(key > root.key)
                {
                    root.right = InsertRec(root.right, key);
                }

                /* return the (unchanged) node pointer */
                return root;
            }

            // This method mainly calls DeleteRec() 
            // A wrapper method
            public void Delete(int key)
            {
                DeleteRec(root, key);
            }


            /* A recursive function to delete a key from BST */
            private Node DeleteRec(Node root, int key)
            {
                // Base case: if the tree is empty
                if (root == null) return root;

                // Otherwise, recur down the tree
                if (key < root.key)
                {
                    root.left = DeleteRec(root.left, key);
                }
                else if(key > root.key)
                {
                    root.right = DeleteRec(root.right, key);
                }
                // if key is same as root's key, then This is the node  
                // to be deleted  
                else
                {
                    // node with only one child or no child  
                    if (root.left == null)
                        return root.right;
                    else if (root.right == null)
                        return root.left;


                    // node with two children: Get the 
                    // inorder successor (smallest in the right subtree)  
                    root.key = MinValue(root.right);

                    // Delete the inorder successor  
                    root.right = DeleteRec(root.right, root.key);

                }
                return root;
            }


            private int MinValue(Node root)
            {
                int minv = root.key;
                while (root.left != null)
                {
                    minv = root.left.key;
                    root = root.left;
                }
                return minv;
            }

            //Print BST
            public void PrintBST()
            {
                PrintInOrder(root);
            }

            // A utility function to do inorder traversal of BST
            // Recursive function
            // Inorder print data in sorted way
            private void PrintInOrder(Node root)
            {
                if(root != null)
                {
                    PrintInOrder(root.left);
                    Console.Write(root.key + "  ");
                    PrintInOrder(root.right);
                }
            }

            // Todo: Implement PrintPreOrder(Node root)

            // Todo: Implement PrintPostOrder(Node root)

            // Wrapper mehtod for search
            public Node Search(int item)
            {
                return SearchItem(root, item);
            }
            public Node SearchItem(Node root, int item)
            {
                Node node = root;
                while(node != null)
                {
                    if(node.key == item)
                    {
                        return node;
                    }

                    if(item < node.key)
                    {
                        node = node.left;
                    }
                    else
                    {
                        node = node.right;
                    }
                }
                return node;
            }

        }

        //Driver method to test
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            /* Let us create following BST 
                  50 
               /     \ 
              30      70 
             /  \    /  \ 
           20   40  60   80 */

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            tree.PrintBST();

            // Search item in the tree
            Node node = tree.Search(30);
            if(node != null)
            {
                Console.WriteLine("\n {0} is found in the tree", node.key);
            }
            else
            {
                Console.WriteLine("\n Item not found");
            }


            /* Delete in BST
             
                      50                            50
                   /     \         delete(20)      /   \
                  30      70       --------->    30     70 
                 /  \    /  \                     \    /  \ 
               20   40  60   80                   40  60   80



                      50                            50
                   /     \         delete(30)      /   \
                  30      70       --------->    40     70 
                    \    /  \                          /  \ 
                    40  60   80                       60   80



                      50                            60
                   /     \         delete(50)      /   \
                  40      70       --------->    40    70 
                         /  \                            \ 
                        60   80                           80
             
             */

            Console.WriteLine("\nDelete 20");
            tree.Delete(20);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.PrintBST();

            Console.WriteLine("\nDelete 30");
            tree.Delete(30);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.PrintBST();

            Console.WriteLine("\nDelete 50");
            tree.Delete(50);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.PrintBST();


            Console.ReadKey();
        }
    }
}
