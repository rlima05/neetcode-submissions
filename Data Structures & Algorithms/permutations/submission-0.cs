public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> res = new();

        Backtrack(res, new List<int>(), nums, new bool[nums.Length]);

        return res;
    }

    private void Backtrack(List<List<int>> res, List<int> curr, int[] nums, bool[] visited)
    {
        if(curr.Count == nums.Length)
        {
            res.Add(new List<int>(curr));
            return;
        }

        for(var i = 0; i < nums.Length; i++)
        {
            if(!visited[i])
            {
                visited[i] = true;
                curr.Add(nums[i]);
                Backtrack(res, curr, nums, visited);
                visited[i] = false;
                curr.RemoveAt(curr.Count-1);
            }
        }
    }
}
