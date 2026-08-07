public class Solution {
    public int[][] Merge(int[][] intervals) {        
        List<int[]> res = new();

        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        var currInterval = intervals[0];

        for(var i = 1; i < intervals.Length; i++)
        {
            if(intervals[i][0] <= currInterval[1])
            {
                currInterval[0] = Math.Min(currInterval[0], intervals[i][0]);
                currInterval[1] = Math.Max(currInterval[1], intervals[i][1]);
            }
            else
            {
                res.Add(currInterval);
                currInterval = intervals[i];
            }
        }      

        res.Add(currInterval);

        return res.ToArray();
    }
}

/*
[[1,3],[1,5],[6,7]]

interval[i][1] < interval[i-1][1]
curreinterval start min of both
curr interval end max of both
continue
else add

*/