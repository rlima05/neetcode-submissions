public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> response = new List<List<int>>();
        Array.Sort(nums);

        for(var i = 0; i < nums.Length; i++)
        {
            if(i > 0 && nums[i] == nums[i-1]) continue;

            var l = i + 1;
            var r = nums.Length-1;

            while(l < r)
            {
                var sum = nums[i] + nums[l] + nums[r];

                if(sum > 0)
                    r--;
                else if(sum < 0)
                    l++;
                else
                {
                    response.Add(new List<int> {nums[i], nums[l], nums[r]});
                    l++;
                    r--;
                    while(nums[l] == nums[l-1] && l < r)
                        l++;
                }

            }
        }


        return response;
    }

  
}

/*
Backtracking all of them

for each number I need to check
    recursion(next number, current sum, starting index)
        remove it
if(list.Count == 3 && sum != 0) return
else add



*/
