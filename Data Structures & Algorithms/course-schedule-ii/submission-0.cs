public class Solution {
    Dictionary<int, List<int>> preMap = new();
    HashSet<int> visited = new();
    HashSet<int> cycle = new();

    public int[] FindOrder(int numCourses, int[][] prerequisites) {

        foreach(var pre in prerequisites)
        {
            if(!preMap.ContainsKey(pre[0]))
                preMap[pre[0]] = new List<int>();

            preMap[pre[0]].Add(pre[1]);
        }

        var res = new List<int>();

        for(var c = 0; c < numCourses; c++)
        {
            if(!DFS(c, res))
                return new int[0];
        }

        return res.ToArray();
    }

    private bool DFS(int c, List<int> res)
    {
        if(cycle.Contains(c))
            return false;

        if(visited.Contains(c))
        {
            return true;
        }

        cycle.Add(c);

        if(preMap.ContainsKey(c))
        {
            foreach(var pre in preMap[c])
            {
                if(!DFS(pre, res))
                    return false;
            }
        }

        res.Add(c);
        visited.Add(c);
        cycle.Remove(c);
        return true;

        
    }
}

/*
build a map of course and its dependencies

DFS
    if already visited return as there is a cycle

    add current to visited

    if current has no dependencies add it to the list and return

    foreach pre req
        do the DFS again
        remove from depedency
    
    add to the list if successful

    
*/