public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0;
        int l = 0;
        int r = heights.Length - 1;

        while(l < r)
        {
            int area = (r-l) * Math.Min(heights[l], heights[r]);

            res = Math.Max(res, area);

            if(heights[l] < heights[r])
                l++;
            else
                r--;
        }

        return res;
    }
}
