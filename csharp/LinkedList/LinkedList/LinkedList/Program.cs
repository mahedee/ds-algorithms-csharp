using System;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d) { this.data = d;  this.next = null; }
    }

    public class LinkedList
    {
        Node head;

        public void CreateLinkedList()
        {
            //Create a nodes
            head = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);

            //Create linked list using the nodes.
            head.next = node2;
            node2.next = node3;
        }

        /* Inserts a new Node at front of the list. */
        public void Push(int newData)
        {
            /* 1 & 2: Allocate the Node & Put in the data*/
            Node newNode = new Node(newData);

            /* 3. Make next of new Node as head */
            newNode.next = head;

            head = newNode;

            //return head;
        }

        //Inserts a new node after the given prevNode.
        public void InsertAfter(Node prevNode, int newData)
        {
            /* 1. Check if the given Node is null */
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node" +
                                          " cannot be null");
                return;
            }
            else
            {

                /* 2 & 3: Allocate the Node & 
                        Put in the data*/
                Node newNode = new Node(newData);

                /* 4. Make next of new Node as 
                             next of prev_node */
                newNode.next = prevNode.next;

                /* 5. make next of prev_node 
                                 as new_node */
                prevNode.next = newNode;

            }
        }


        //Appends a new node at the end. This method is 
        //defined inside LinkedList class shown above 
        public void Append(int newData)
        {
            /* 1. Allocate the Node & 
            2. Put in the data 
            3. Set next as null */
            Node new_node = new Node(newData);

            /* 4. If the Linked List is empty,  
               then make the new node as head */
            if (head == null)
            {
                head = new Node(newData);
                return;
            }

            /* 4. This new node is going to be  
            the last node, so make next of it as null */
            new_node.next = null;

            /* 5. Else traverse till the last node */
            Node last = head;
            while (last.next != null)
                last = last.next;

            /* 6. Change the next of last node */
            last.next = new_node;
            return;
        }

        public int Search(int val)
        {
            Node node = head;
            int i = 0;
            while(node !=null )
            {
                i++;
                if (node.data == val) return i;
                else
                    node = node.next;
            }

            return 0; //Not found
        }

        /* Given a key, deletes the first occurrence of key in linked list */
        public void DeleteNode(int key)
        {
            // Store head node 
            Node temp = head, prev = null;

            // If head node itself holds the key to be deleted 
            if (temp != null && temp.data == key)
            {
                head = temp.next; // Changed head 
                return;
            }

            // Search for the key to be deleted, keep track of the 
            // previous node as we need to change temp.next 
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            // If key was not present in linked list 
            if (temp == null) return;

            // Unlink the node from linked list 
            prev.next = temp.next;
        }


        public Node GetNode(int position)
        {
            if (position <= 0) return null;

            Node node = head;
            for(int i = 1; i <= position; i++)
            {
                node = node.next;
            }
            return node;
        }

        //public Node head;
        public void PrintList()
        {
            Node n = head;
            while(n != null)
            {
                Console.Write(n.data + "  ");
                n = n.next;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
          
            LinkedList linkedList = new LinkedList();

            //Create initial linked list
            linkedList.CreateLinkedList();

            //Then print the linked list
            linkedList.PrintList();


            //Insert a new node at the front of the list
            linkedList.Push(5);         
            
            //Print new line
            Console.WriteLine();

            //Print linked list
            linkedList.PrintList();


            /* Inserts a new node after the given prev_node. */
            Node previousNode = linkedList.GetNode(2);
            int newData = 25;
            linkedList.InsertAfter(previousNode, newData);
            //Print new line
            Console.WriteLine();
            //Print linked list
            linkedList.PrintList();

            //Add a node at the end
            linkedList.Append(35);
            //Print new line
            Console.WriteLine();
            //Print linked list
            linkedList.PrintList();


            //Search location
            int position = linkedList.Search(20);
            //Print new line
            Console.WriteLine();
            Console.WriteLine(position);

            //Delete node
            linkedList.DeleteNode(25);
            //Print new line
            Console.WriteLine();
            //Print linked list
            linkedList.PrintList();



            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
