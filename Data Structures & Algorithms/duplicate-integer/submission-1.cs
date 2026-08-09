public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> ns = new();

        for(var i = 0; i < nums.Length; i++)
        {
            if(ns.Contains(nums[i])) return true;

            ns.Add(nums[i]);
        }

        return false;
    }
}

/*



*/