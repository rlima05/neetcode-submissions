public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length == 0)
            return false;

        HashSet<int> map = new HashSet<int>();

        for (var i = 0; i < nums.Length; i++) {
            if (map.Contains(nums[i]))
                return true;

            map.Add(nums[i]);
        }

        return false;
    }
}