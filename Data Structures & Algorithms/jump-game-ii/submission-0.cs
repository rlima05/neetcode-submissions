public class Solution {
    public int Jump(int[] nums) {
        int l = 0;
        int r = 0;
        int res = 0;

        while(r < nums.Length-1)
        {
            int farthest = 0;
            for(var i = l; i <= r; i++)
            {
                farthest = Math.Max(farthest, i + nums[i]);
            }

            l = r+1;
            r = farthest;
            res++;

        }

        return res;
    }
}

/*


*/