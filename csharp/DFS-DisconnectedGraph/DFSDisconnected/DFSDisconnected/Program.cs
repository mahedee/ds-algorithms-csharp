// Implementaiton of Depth first search algorithm
// C# program to print DFS traversal for disconnected graph 
// DFS() traverses all vertices one by one.
// Applicable for directed and undirected graph

using System;
using System.Collections.Generic;

namespace DFSDisconnected
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

        // A function used by DFS 
        void DFSUtil(int v, bool []visited)
        {
            // Mark the current node as visited and print it 
            visited[v] = true;
            Console.Write(v + "  ");

            // Recur for all the vertices adjacent to this vertex 
            foreach (int adjVertex in adj[v])
            {
                
                if (!visited[adjVertex])
                    DFSUtil(adjVertex, visited);
            }
        }

        // The function to do DFS traversal. It uses recursive DFSUtil() 
        public void DFS()
        {
            // Mark all the vertices as not visited(set as false by default in C#) 
            bool[] visited = new bool[V];
            for (int i = 0; i < V; i++)
                visited[i] = false;

            // Call the recursive helper function to print DFS traversal 
            // Starting from all vertices one by one.
            for (int i = 0; i < V; i++)
            {
                if (visited[i] == false)
                    DFSUtil(i, visited);
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
            Console.WriteLine("Following is Depth First Traversal (for disconnected graph)");
            g.DFS();

            // Output
            // Following is Depth First Traversal (for disconnected graph)
            // 0 1 2 3

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
            Console.WriteLine("\nFollowing is Depth First Traversal (for disconnected graph)");
            h.DFS();

            // Output
            // Following is Depth First Traversal (for disconnected graph)
            // 0 1 3 4 5 2

            Console.ReadKey();
            
        }
    }
}
