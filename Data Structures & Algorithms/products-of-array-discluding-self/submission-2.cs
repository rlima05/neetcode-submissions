public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        int zeroes = 0;

        int[] res = new int[nums.Length];

        foreach(var n in nums)
        {
            if(n == 0)
            {
                zeroes++;
                continue;
            }

            product *= n;
        }

        if(zeroes > 1) return res;

        for(var i = 0; i < nums.Length; i++)
        {
            if(zeroes == 0)
            {
                res[i] = product/nums[i];
            }
            else
            {
                if(nums[i] == 0) res[i] = product;
                else res[i] = 0;
            }
        }
        return res;
    }
}

/*
calc the whole product
calc number of zeroes

if zeroes > 1 return all zeroes

if zeroes == 1 && nums[i] != 0 add 0
if zeroes == 1 && nums[i] == 0 add product
else product / nums[i]

O(n)

*/