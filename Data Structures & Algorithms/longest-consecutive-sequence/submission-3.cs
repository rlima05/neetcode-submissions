public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        HashSet<int> map = new HashSet<int>(nums);
        int res = 1;

        foreach(var num in map)
        {
            if(!map.Contains(num-1))
            {
                var curr = num;
                var seq = 1;

                while(map.Contains(curr+1))
                {
                    curr++;
                    seq++;
                }

                res = Math.Max(res, seq);
            }
        }

        return res;
    }
}

/*
add hashset for the nums

foreach num in nums:
    check if num+1 is in there
    true:  
        seq++
        curr = curr+1;
    res = max(seq, res)

*/