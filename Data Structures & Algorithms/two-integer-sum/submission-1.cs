public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
        Dictionary<int, int> map = new();

        for(var i =0; i < nums.Length; i++)
        {
            var curr = target - nums[i];

            if(map.ContainsKey(curr))
            {
                res[0] = map[curr];
                res[1] = i;

                break;
            }

            map.Add(nums[i], i);
        }

        return res;
    }
}


/*
Map to store number as the key and its index as the value
then check if target - current num is in the map, if it is return
otherwise add num to the map and ocntinue



*/