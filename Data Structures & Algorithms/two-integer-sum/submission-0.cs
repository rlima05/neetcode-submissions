public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] response = new int[2];

        Dictionary<int, int> numIndexMap = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++)
        {
            var current = target - nums[i];

            if(numIndexMap.ContainsKey(current))
            {
                response[0] = numIndexMap[current];
                response[1] = i;
                break;
            }
            else
            {
                numIndexMap.Add(nums[i], i);
            }
        }

        return response;
    }
}
