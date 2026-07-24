public class Solution {
    public int CountComponents(int n, int[][] edges) {
        List<List<int>> graph = new();
        bool[] visited = new bool[n];
        int res = 0;

        for(var i = 0; i < n; i++)
        {
            graph.Add(new List<int>());
        }

        foreach(var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        for(int i = 0; i < n; i++)
        {
            if(!visited[i])
            {
                DFS(visited, graph, i);
                res++;
            }
        }

        return res;
    }

    private void DFS(bool[] visited, List<List<int>> graph, int i)
    {
         visited[i] = true;
        foreach(var node in graph[i])
        {
            if(!visited[node])
                DFS(visited, graph, node);
        }
        

       
    }
}
