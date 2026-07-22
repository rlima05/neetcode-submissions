public class KthLargest {
    PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
    
    int _k;

    public KthLargest(int k, int[] nums) {
        _k = k;

        foreach(var num in nums)
        {
            heap.Enqueue(num, num);
            
            if(heap.Count > _k)
                heap.Dequeue();
        }    
    }
    
    public int Add(int val) {
        heap.Enqueue(val, val);

        if(heap.Count > _k)
            heap.Dequeue();

        return heap.Peek();
    }
}
/*
min heap

Init: add items to heap
    if heap size == k
        remove

Add:
    add to array
        if size == k
        remove and return

*/