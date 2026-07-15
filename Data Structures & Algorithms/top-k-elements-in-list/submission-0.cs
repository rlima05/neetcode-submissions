public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++) {
            if (!frequencyMap.ContainsKey(nums[i])) {
                frequencyMap[nums[i]] = 1;
            } else
                frequencyMap[nums[i]]++;
        }

        PriorityQueue<int, int> heap = new PriorityQueue<int,int>();
        foreach(var kv in frequencyMap)
        {
            heap.Enqueue(kv.Key, kv.Value);

            if(heap.Count > k) heap.Dequeue();
        }

        int[] resp = new int[k];

        for(var i = 0; i < k; i++)
        {
            resp[i] = heap.Dequeue();
        }

        return resp;
    }
}
