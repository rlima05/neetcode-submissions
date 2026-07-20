public class Solution {
    public int FindDuplicate(int[] nums) {
        Array.Sort(nums);

        for(var i = 1; i < nums.Length; i++)
        {
            if(nums[i] == nums[i-1]) return nums[i];
        }

        return -1;
    }
}
/*
1- Store numbers in a map, once a hit a duplicate one return it.
O(n) of time and O(n) of space -> 55.14 time and 19 in memory

2- Sort Array
   Loop from i = 1 till last number, if num of current array is = to previous one, that is the duplicate
o(nlogn) time and O(1) space 

*/