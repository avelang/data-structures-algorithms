using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms
{
    // to do : how to build a graph using adjacency list or matrix
    public class GraphAlgorithms
    {
        public void DepthFirstTraversal(Node start)
        {
            Stack<Node> nodesToVisit = new Stack<Node>();
            start.isVisited = true;  
            if(start.AdjacentNodes.Count>0)
            {
                foreach(var node in start.AdjacentNodes)
                {
                    nodesToVisit.Push(node);
                }
                while(nodesToVisit.Count>0)
                {
                    DepthFirstTraversal(nodesToVisit.Pop());
                }
            }
        }

        public void BreadthFirstTraversal(Node start)
        {
            Queue<Node> nodesToVisit = new Queue<Node>();
            start.isVisited = true;
            if (start.AdjacentNodes.Count > 0)
            {
                foreach (var node in start.AdjacentNodes)
                {
                    nodesToVisit.Enqueue(node);
                }
                while (nodesToVisit.Count > 0)
                {
                    DepthFirstTraversal(nodesToVisit.Dequeue());
                }
            }
        }
    }

    public class Node
    {
        int value;
        public bool isVisited;
        public Node(int val)
        {
            value = val;
        }
        public List<Node> AdjacentNodes;
    }
}
