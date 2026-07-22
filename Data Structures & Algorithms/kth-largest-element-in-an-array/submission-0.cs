public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();

        foreach(var n in nums)
        {
            heap.Enqueue(n, n);

            if(heap.Count > k)
                heap.Dequeue();
        }

        return heap.Peek();
    }
}

/*
Brute Force: sort and pick element

use a heap
add to it, when heap count is more than k 
remove from the heap

*/