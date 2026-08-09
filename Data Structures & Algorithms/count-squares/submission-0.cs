public class CountSquares {

    private Dictionary<(int, int), int> count;
    private List<int[]> points;

    public CountSquares() {
        count = new();
        points = new();    
    }
    
    public void Add(int[] point) {
        int x = point[0];
        int y = point[1];
        var tuple = (x,y);
        if(!count.ContainsKey(tuple))
            count[tuple] = 0;
        
        count[tuple]++;
        points.Add(point);
        
    }
    
    public int Count(int[] point) {
        int px = point[0];
        int py = point[1];
        int res = 0;

        foreach(var p in points)
        {
            int x = p[0];
            int y = p[1];
            if(Math.Abs(py - y) != Math.Abs(px-x) || py == y || px==x)
                continue;

            res += (count.GetValueOrDefault((x, py)) *
                   count.GetValueOrDefault((px, y)));
        }

        return res;
    }
}


/*
dirs = - +1- 0 -1, 0- 0 - +1 - 0, -1- +1,+1 - -1, -1
g1: -1-1, 0+1, 0 -1
g2: +1+1,+10, 0+1
g3 


*/