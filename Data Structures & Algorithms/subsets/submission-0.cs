public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new List<List<int>>();

        Backtracking(res, new List<int>(), 0, nums);

        return res;
    }

    private void Backtracking(List<List<int>> res, List<int> current, int index, int[] nums)
    {
        res.Add(new List<int>(current));

        for(var i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            Backtracking(res, current, i+1, nums);
            current.RemoveAt(current.Count-1);
        }
    }
}

/*
Backtracking
For each num
    add itself to list
    move on to the next index with recursion
    remove current item

    repeat it until all indexes are gone

    now I need per recursion:
    List of List, current List, current index




Edge case: empty list is also part

*/