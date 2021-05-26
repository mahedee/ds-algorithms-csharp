//Implementaiton of Breadth first search algorithm
// C# program to print BFS traversal from a given source vertex. 
// BFS(int s) traverses vertices reachable from s. 

using System;
using System.Collections.Generic;

namespace BFS
{
    // This class represents a directed graph using adjacency list representation 
    public class Graph
    {
        private int V; // No of vertices or nodes
        private LinkedList<int>[] adj; // A linkedlist array for adjacent nodes

        // Constructor
        // Create a graph with v vertices
        public Graph(int v)
        {
            this.V = v;

            // Since no of nodes are v. So a node can be connected at most no of v vertices
            adj = new LinkedList<int>[v];

            // Initialize each adjacent nodes
            for(int i = 0; i < v; i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }

        // Method to add an edge in a graph from v to w
        public void AddEdge(int v, int w)
        {
            // Add a new node containing the specific value 'w' at the end of the linked list
            adj[v].AddLast(w);
        }

        // prints BFS traversal from a given source s 
        public void BFS(int s)
        {
            // Mark all the vertices as not visited(By default set as false) 
            bool[] visited = new bool[V];

            // Create a queue for BFS
            Queue<int> queue = new Queue<int>();

            // Mark the current node as visited and enqueue it
            // Add it to the queue = enqueue
            visited[s] = true;
            queue.Enqueue(s);

            // Traverse all the vertices
            while(queue.Count != 0)
            {
                // Dequeue a vertex from the queue and print it
                s = queue.Dequeue();
                Console.Write(s + "  ");

                // Get all adjacent vertices of the dequeued vertex s
                // If the adjacent vertex is not visited, mark it visited and enque it.
                foreach (int adjVertex in adj[s])
                {
                    //If the vertext is not visited
                    if(!visited[adjVertex])
                    {
                        visited[adjVertex] = true;
                        queue.Enqueue(adjVertex);
                    }
                }
            }

        }
    }


    public class Program
    {
        // Driver method to test
        static void Main(string[] args)
        {
            // Create a graph with 4 node or vertices
            Graph g = new Graph(4);

            // Connect a vertex with other vertex with an edge
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            // Traverse the graph
            Console.WriteLine("Following is Breadth First Traversal (starting from vertex 2)");
            g.BFS(2);

            // Output
            // Following is Breadth First Traversal (starting from vertex 2)
            // 2 0 3 1

            // Create a graph with 4 node or vertices
            Graph h = new Graph(6);


            // Connect a vertex with other vertex with an edge
            h.AddEdge(0, 1);
            h.AddEdge(0, 2);
            h.AddEdge(1, 0); 
            h.AddEdge(1, 3);
            h.AddEdge(1, 4);
            h.AddEdge(2, 4);
            h.AddEdge(3, 4);
            h.AddEdge(3, 4);
            h.AddEdge(4, 5);

            // Traverse the graph
            Console.WriteLine("\nFollowing is Breadth First Traversal (starting from vertex 1)");
            h.BFS(0);

            // Output
            // Following is Breadth First Traversal (starting from vertex 0)
            // 0 1 2 3 4 5

            Console.ReadKey();
            
        }
    }
}
