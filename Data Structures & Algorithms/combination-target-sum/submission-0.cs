public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = new();

        Backtracking(res, new List<int>(), target, nums, 0, 0);

        return res;
    }

    private void Backtracking(List<List<int>> res, List<int> curr, int target, int[] nums, int currentSum, int index)
    {
        if(currentSum == target)
        {
            res.Add(new List<int>(curr));
            return;
        }

        if(currentSum > target) return;

        for(var i = index; i < nums.Length; i++)
        {
            currentSum += nums[i];
            curr.Add(nums[i]);
            Backtracking(res, curr, target, nums, currentSum, i);
            currentSum -= nums[i];
            curr.RemoveAt(curr.Count-1);
        }
    }
}


/*
Backtracking
    if the sum is > target
        return

    List of lists, current list, current sum, current index, target and nums
        I will pass in the recursion the same index
        and will do sum += current number in the list
        remove the number from sum and current list
    
    


*/