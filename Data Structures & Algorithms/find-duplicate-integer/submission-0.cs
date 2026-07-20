public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> map = new HashSet<int>();

        for(var i = 0; i < nums.Length; i++)
        {
            if(map.Contains(nums[i])) return nums[i];

            map.Add(nums[i]);
        }

        return -1;
    }
}
/*
1- Store numbers in a map, once a hit a duplicate one return it.
O(n) of time and O(n) of space

2- Sort Array
   Loop from i = 1 till last number, if num of current array is = to previous one, that is the duplicate
o(nlogn) time and O(1) space 

*/