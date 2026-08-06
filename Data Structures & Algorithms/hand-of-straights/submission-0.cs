public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
       if(hand.Length % groupSize != 0)
            return false;

        Dictionary<int, int> count = new();
        
        foreach(var num in hand)
        {
            if(count.ContainsKey(num))
                count[num]++;
            else
                count[num] = 1;
        }

        PriorityQueue<int, int> heap = new();

        foreach(var num in count.Keys)
            heap.Enqueue(num, num);

        while(heap.Count > 0)
        {
            int first = heap.Peek();

            for(var i = first; i < first + groupSize; i++)
            {
                if(!count.ContainsKey(i) || count[i] == 0)
                    return false;
                
                count[i]--;

                if(count[i] == 0)
                {
                    if(i != heap.Peek())
                        return false;
                    heap.Dequeue();
                }
            }
        }

        return true;
    }
}

/*
[1,2,4,2,3,5,3,4]

[1,2,2,3,3,4,4,5]

*/