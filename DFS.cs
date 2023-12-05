// C# program to print BFS traversal from a given source
// vertex. BFS(int s) traverses vertices reachable from s.
// Your task is to implement a DFS(int s) to do a DFS
// traverse,
// from the starting node s.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// This class represents a directed graph
// using adjacency list representation
class Graph
{
	// No. of vertices
	private int V;

	// Adjacency Lists
	LinkedList<int>[] adj;

	public Graph(int v)
	{
		adj = new LinkedList<int>[v];
		for (int i = 0; i < adj.Length; i++)
		{
			adj[i] = new LinkedList<int>();
		}
		V = v;
	}

	// Function to add an edge into the graph
	public void AddEdge(int v, int w)
	{
		adj[v].AddLast(w);
	}

	// Prints BFS traversal from a given source s
	/*public void BFS(int s)
	{
		// Mark all the vertices as not
		// visited (By default set as false)
		bool[] visited = new bool[V];
		for (int i = 0; i < V; i++)
		{
			visited[i] = false;
		}

		// Create a queue for BFS
		LinkedList<int> queue = new LinkedList<int>();

		// Mark the current node as
		// visited and enqueue it
		visited[s] = true;
		queue.AddLast(s);

		while (queue.Any())
		{

			// Dequeue a vertex from queue
			// and print it
			s = queue.First();
			Console.Write(s + " ");
			queue.RemoveFirst();

			// Get all adjacent vertices of the 
			// dequeued vertex s.
			// If an adjacent has not been visited,
			// then mark it visited and enqueue it
			LinkedList<int> list = adj[s];

			foreach (var val in list)
			{
				if (!visited[val])
				{
					visited[val] = true;
					queue.AddLast(val);
				}
			}
		}
	}*/
	public void DFS(int s)
	{
		bool[] visited = new bool[V];
		for (int i = 0; i < V; i ++)
			visited[i] = false;

		Stack<int> stack = new Stack<int>();

		visited[s] = true;
		stack.Push(s);

		while (stack.Any())
		{
			s = stack.Peek();
			Console.WriteLine(s + " ");
			stack.Pop();

			LinkedList<int> list = adj[s];

			foreach (var val in list)
			{
				if (!visited[val])
				{
					visited[val] = true;
					stack.Push(val);
				}
			}
		}
	}

	// Driver code
	static void Main(string[] args)
	{
		Graph g = new Graph(7);
		g.AddEdge(0, 1);
		g.AddEdge(0, 2);
		g.AddEdge(1, 2);
		g.AddEdge(2, 0);
		g.AddEdge(2, 3);
		//g.AddEdge(1, 3);
		//g.AddEdge(1, 4);
		//g.AddEdge(2, 5);
		//g.AddEdge(2, 6);
		g.AddEdge(3, 3);

		Console.Write("Following is a Depth First Search" + "\n");
		g.DFS(0);
	}
}
