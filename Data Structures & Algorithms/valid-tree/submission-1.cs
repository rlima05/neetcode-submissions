public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if(edges.Length > n -1)
            return false;
        
        List<List<int>> adj = new();

        for(var i = 0; i < n; i++)
        {
            adj.Add(new List<int>());
        }

        foreach(var edge in edges)
        {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        HashSet<int> visited = new();

        if(!DFS(0, -1, visited, adj))
            return false;

        return visited.Count == n;
    }

    private bool DFS(int node, int parent, HashSet<int> visited, List<List<int>> graph)
    {
        if(visited.Contains(node))
            return false;

        visited.Add(node);

        foreach(var nei in graph[node])
        {
            if(nei == parent)
                continue;
            if(!DFS(nei, node, visited, graph))
                return false;
        }

        return true;
    }
}
