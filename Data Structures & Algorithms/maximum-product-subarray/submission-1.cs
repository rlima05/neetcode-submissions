public class Solution {
    public int MaxProduct(int[] nums) {
        int res = nums[0];
        int curMin = 1, curMax = 1;

        foreach(var num in nums)
        {
            int tmp = curMax*num;

            curMax = Math.Max(Math.Max(curMax * num, curMin * num), num);
            curMin = Math.Min(Math.Min(tmp, curMin * num), num);
            res = Math.Max(curMax, res);
        }

        return res;
    }
}
