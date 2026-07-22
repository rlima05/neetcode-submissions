public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], int> heap = new PriorityQueue<int[], int>
        (Comparer<int>.Create((a,b) => b.CompareTo(a)));

        for(var i = 0; i < points.Length; i++)
        {
            var distance = CalculateDistance(points[i][0], points[i][1]);

            heap.Enqueue(points[i], distance);

            if(heap.Count > k)
                heap.Dequeue();
        }

        var resp = new List<int[]>();

        while(heap.Count > 0)
            resp.Add(heap.Dequeue());

        return resp.ToArray();
    }

    private int CalculateDistance(int x, int y)
    {
        return (x*x) + (y*y);
    }
}


/*
Max heap
Calculate the distance
Add to the heap <(int,int) -> being the point, int -> distance
Once the heap is larger than k, remove one item
return peek


*/