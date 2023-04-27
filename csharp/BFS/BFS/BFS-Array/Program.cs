//Implementaiton of Breadth first search algorithm
// C# program to print BFS traversal from a given source vertex. 
// BFS(int s) traverses vertices reachable from s. 

namespace BFS_Array
{
    // This class represents a undirected graph using adjacency list representation 
    // You can keep this class name as BFS also
    public class BFSGraph
    {
        private int V; // No of vertices or nodes
        private int[,] adj; // adjacency matrix

        // Constructor
        // Create a graph with v vertices
        public BFSGraph(int v)
        {
            V = v;

            // Since no of nodes are v. So a node can be connected at most no of v vertices
            // It can be represented by VxV adjacency matrix
            // initialized the adjacency matrix with zeros
            adj = new int[V, V];
        }

        // Method to add an edge in a graph from src to dest
        // takes two vertex indices as arguments and updates the adjacency matrix accordingly.
        // Since the graph is undirected, we update both the(src, dest) and(dest, src) entries in the matrix.
        public void AddEdge(int src, int dest)
        {
            // Since it is undirected and transpose matrix
            adj[src, dest] = 1;
            adj[dest, src] = 1;
        }

        // prints BFS traversal from a given source start 
        public void TraverseBFS(int start)
        {
            // Declare a boolean array visited to keep track of which vertices have been visited,
            // and a queue to store the vertices that need to be visited.
            // We mark the starting vertex as visited and add it to the queue.
            bool[] visited = new bool[V];
            Queue<int> queue = new Queue<int>();

            // Mark the current node as visited and enqueue it
            // Add it to the queue = enqueue
            visited[start] = true;
            queue.Enqueue(start);
            
            // loop that continues until the queue is empty.
            // In each iteration, we dequeue a vertex from the queue and print it to the console.
            // We then iterate over all the vertices adjacent to the dequeued vertex(i.e., all vertices i such that adj[start, i] is 1),
            // and if a vertex i has not been visited before, we mark it as visited and add it to the queue.
            while (queue.Count != 0)
            {
                // Dequeue a vertex from the queue and print it
                start = queue.Dequeue();
                Console.Write(start + "  ");

                // Get all adjacent vertices of the dequeued vertex s
                // If the adjacent vertex is not visited, mark it visited and enque it.
                for(int i = 0; i < V; i++) 
                {
                    //If the vertext is not visited
                    if (adj[start,i] == 1 && ! visited[i])
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
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
            BFSGraph g = new BFSGraph(4);

            // Connect a vertex with other vertex with an edge
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            // Traverse the graph
            Console.WriteLine("Following is Breadth First Traversal (starting from vertex 2)");
            g.TraverseBFS(2);

            // Output
            // Following is Breadth First Traversal (starting from vertex 2)
            // 2 0 3 1

            // Create a graph with 6 node or vertices
            BFSGraph h = new BFSGraph(6);


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
            h.TraverseBFS(0);

            // Output
            // Following is Breadth First Traversal (starting from vertex 0)
            // 0 1 2 3 4 5

            Console.ReadKey();

        }
    }
}