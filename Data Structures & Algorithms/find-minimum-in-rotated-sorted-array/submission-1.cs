public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int n = nums.Length - 1;
        int r = n;
        int min = int.MaxValue;

        while(l <= r)
        {
            var mid = (l + r)/2;
            min = Math.Min(min, nums[mid]);

            if(nums[mid] > nums[n])
                l = mid+1;
            else
                r = mid-1;
        }

        return min;
    }
}

/*
3,4,5,6,1,2
Binary Search
mid = (r+l)/2;

mid = 2 (5)
max = math.min(max, array[mid])
mid > end of array
if yes, it is rotated so l = mid+1
else 
    r = mid-1;

*/