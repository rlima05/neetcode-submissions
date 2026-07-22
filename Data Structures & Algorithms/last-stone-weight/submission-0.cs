public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> heap = new PriorityQueue<int,int>
        (Comparer<int>.Create((a,b) => b.CompareTo(a)));

        foreach(var stone in stones)
            heap.Enqueue(stone, stone);
        
        while(heap.Count > 1)
        {
            var s1 = heap.Dequeue();
            var s2 = heap.Dequeue();

            var weight = Math.Abs(s1-s2);

            if(weight > 0) heap.Enqueue(weight, weight);
        }

        return heap.Count == 1? heap.Peek() : 0;
    }
}


/*
Max heap

while heap.Count > 1
    pick 2
    smash 
    if weight > 0 
        add to heap

    return heap.count is 1? peek, otherwise 0
1



*/