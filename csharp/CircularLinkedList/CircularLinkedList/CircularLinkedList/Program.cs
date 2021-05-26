using System;

namespace CircularLinkedList
{
    // node 
    public class Node
    {
        public int data;
        public Node next;
    };

    public class LinkedList
    {
        /* Method to insert a node at the beginning of a Circular linked list */
        static Node Push(Node head, int data)
        {
            Node newNode = new Node();
            Node temp = head;
            newNode.data = data;
            newNode.next = head;

            /* If linked list is not null then set the next of last node */
            if (head != null)
            {
                while (temp.next != head)
                    temp = temp.next;

                //Now new node is the head node. So last node's next node will be new node.
                temp.next = newNode; 
            }
            else
                newNode.next = newNode;

            head = newNode;

            return head;
        }

        /* Method to print nodes in a given Circular linked list */
        static void PrintNode(Node head)
        {
            Node temp = head;
            if (head != null)
            {
                do
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                while (temp != head);
            }
        }

        // Driver Code 
        static public void Main(String[] args)
        {
            // Initialize lists as empty 
            Node head = null;

            /* Created linked list will be 40.30.20.10 */
            head = Push(head, 10);
            head = Push(head, 20);
            head = Push(head, 30);
            head = Push(head, 40);

            Console.WriteLine("Contents of Circular " +
                                        "Linked List:");
            PrintNode(head);

            Console.ReadKey();
        }
    }

}
