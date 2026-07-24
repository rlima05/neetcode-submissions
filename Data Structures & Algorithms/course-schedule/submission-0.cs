public class Solution {

    private Dictionary<int, List<int>> preMap = new();
    private HashSet<int> visited = new ();

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        for(var i = 0; i < numCourses; i++)
            preMap[i] = new List<int>();

        foreach(var preReq in prerequisites)
            preMap[preReq[0]].Add(preReq[1]);

        for(var i = 0; i < numCourses; i++)
        {
            if(!DFS(i))
                return false;
        }

        return true;
    }

    private bool DFS(int course)
    {
        if(visited.Contains(course))
            return false;

        if(preMap[course].Count == 0)
            return true;
        
        visited.Add(course);

        foreach(var pre in preMap[course])
        {
            if(!DFS(pre))
                return false;
        }

        visited.Remove(course);
        preMap[course].Clear();
        return true;
    }

    
}

/*
Graph

0, 1

Build a map key = course and value is a map of dependencies

DFS
   if visited return false (cycle)

    if preMap


*/