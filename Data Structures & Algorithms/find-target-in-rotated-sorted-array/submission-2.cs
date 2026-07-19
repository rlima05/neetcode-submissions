public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int n = nums.Length-1;
        int r = n;

        while(l <= r)
        {
            var mid = (l+r)/2;
            if(nums[mid] == target)
                return mid;
            
            if(nums[mid] >= nums[l]) //left half is sorted
            {
                if(target > nums[mid] || target < nums[l])
                    l = mid+1;
                else
                    r = mid-1;
            }
            else
            {
                if(target < nums[mid] || target > nums[r])
                    r = mid-1;
                else
                    l = mid+1;
            }
        }

        return -1;
    }
}

/*
1,3

3,4,5,6,1,2
modified binary search

mid = (r+l)/2;
if(nums[mid] == target)
    return mid;

 if(nums[l] <= nums[mid])
    if(nums[mid] > nums[r])
        l = mid+1;
    else 
        r = mid-1;
else
    if(nums[mid] < nums[l])
       r = mid - 1;
    else
        l = mid+1;

return -1;


*/