public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
       Dictionary<int, int> freq = new(); //number, freq

       foreach(var n in nums)
       {
            if(!freq.ContainsKey(n))
                freq[n] = 0;
            
            freq[n]++;
       }

       PriorityQueue<int, int> heap = new(); //number, freq

       foreach(var kv in freq)
       {
            heap.Enqueue(kv.Key, kv.Value);

            if(heap.Count > k) heap.Dequeue();
       }

       int[] res = new int[k];

       for(var i = 0; i < k; i++)
       {
            res[i] = heap.Dequeue();
       }

       return res;
    }
}

/*
map out the frequency of each char in a dictionary
after that create a min heap and add the numbers there
when minheap.count > k remove 
return he heap in a array version

*/