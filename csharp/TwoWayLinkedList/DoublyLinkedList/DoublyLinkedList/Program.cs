using System;

namespace DoublyLinkedList
{
    public class Node
    {
        public int data;
        public Node prev;
        public Node next;

        public Node(int d) { this.data = d; this.prev = null; this.next = null; }
    }

    public class LinkedList
    {
        public Node head;

        // Adding a node at the front of the list 
        public void Push(int newData)
        {
            /* 1. allocate node  
            * 2. put in the data */
            Node newNode = new Node(newData);

            /* 3. Make next of new node as head and previous as NULL */
            newNode.next = head;
            newNode.prev = null;

            /* 4. change prev of head node to new node */
            if (head != null)
                head.prev = newNode;

            /* 5. move the head to point to the new node */
            head = newNode;
        }

        /* Given a node as prev_node, insert a new node after the given node */
        public void InsertAfter(Node prevNode, int newData)
        {

            /*1. check if the given prev_node is NULL */
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node cannot be NULL ");
                return;
            }

            /* 2. allocate node  
            * 3. put in the data */
            Node newNode = new Node(newData);

            /* 4. Make next of new node as next of prev_node */
            //new node's next will be the that node which was the next node of previous node.
            newNode.next = prevNode.next; 

            /* 5. Make the next of prev_node as new_node */
            prevNode.next = newNode;

            /* 6. Make prev_node as previous of new_node */
            newNode.prev = prevNode;

            /* 7. Change previous of new_node's next node */
            if (newNode.next != null)
                newNode.next.prev = newNode;
        }


        // Add a node at the end of the list  
        public void Append(int newData)
        {
            /* 1. allocate node  
            * 2. put in the data */
            Node newNode = new Node(newData);

            Node last = head; /* used in step 5*/

            /* 3. This new node is going  
                to be the last node, so  
            * make next of it as NULL*/
            newNode.next = null;

            /* 4. If the Linked List is empty,  
            then make the new * node as head */
            if (head == null)
            {
                newNode.prev = null;
                head = newNode;
                return;
            }

            /* 5. Else traverse till the last node */
            while (last.next != null)
                last = last.next;

            /* 6. Change the next of last node */
            last.next = newNode;

            /* 7. Make last node as previous of new node */
            newNode.prev = last;
        }



        // Function to delete a node in a Doubly Linked List. 
        // head_ref --> pointer to head node pointer. 
        // del --> data of node to be deleted. 
        public void DeleteNode(Node del)
        {

            // Base case 
            if (head == null || del == null)
            {
                return;
            }

            // If node to be deleted is head node 
            if (head == del)
            {
                head = del.next;
            }

            // Change next only if node to be deleted 
            // is NOT the last node 
            if (del.next != null)
            {
                del.next.prev = del.prev;
            }

            // Change prev only if node to be deleted 
            // is NOT the first node 
            if (del.prev != null)
            {
                del.prev.next = del.next;
            }

            // Finally, free the memory occupied by del 
            return;
        }

        // This function prints contents of  
        // linked list starting from the given node  
        public void PrintList(Node node)
        {
            Node last = null;
            Console.WriteLine("Traversal in forward Direction");
            while (node != null)
            {
                Console.Write(node.data + " ");
                last = node;
                node = node.next;
            }
            Console.WriteLine();
            Console.WriteLine("Traversal in reverse direction");
            while (last != null)
            {
                Console.Write(last.data + " ");
                last = last.prev;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Push(10);
            list.Push(20);
            list.Push(30);
            list.Push(40);

            // Insert 25, after 30. So linked list  
            // becomes 40->30->25->20->10->NULL  
            list.InsertAfter(list.head.next, 25);

            //Add new node after the link list
            list.Append(5);


            list.PrintList(list.head);

            list.DeleteNode(list.head.next);
            //Print list after deletion
            list.PrintList(list.head);
            Console.ReadKey();
        }
    }
}
