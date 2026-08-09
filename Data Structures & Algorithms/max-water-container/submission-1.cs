public class Solution {
    public int MaxArea(int[] heights) {
       int l = 0;
       int r = heights.Length - 1;

       int res = int.MinValue;

       while(l < r)
       {
            int area = Math.Min(heights[r], heights[l]) * (r - l);
            res = Math.Max(res, area);

            if(heights[l] <= heights[r]) l++;
            else r--;
       }

       return res;
    }
}

/*
area = Math.Min heights * (r - l)
6 * 6

two points
    l = 0; r length - 1

    loop through it and calc the area
    keep the max area stored
    move the smaller pointer
    reapet until pointers meet
    if height is same can move either, so left

*/