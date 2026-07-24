public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length < 2) return nums[0];

        int[] dp = new int[nums.Length];

        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);


        for(var i = 2; i < nums.Length; i++)
        {
            dp[i] = Math.Max(dp[i-2] + nums[i], dp[i-1]);
        }

        return dp[nums.Length - 1];
    }
}


/*
[0] - 1
[1] - 1
[2] - max between this house and i-2 or i-1 alone

*/