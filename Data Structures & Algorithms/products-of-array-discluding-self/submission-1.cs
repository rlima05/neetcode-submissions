public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        int zeroCount = 0;
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                zeroCount++;
                continue;
            }
            product *= nums[i];
        }
        int[] resp = new int[nums.Length];

        if (zeroCount > 1)
            return resp;

        for (var i = 0; i < nums.Length; i++) {
            if (zeroCount > 0) {
                resp[i] = nums[i] == 0 ? product : 0;
            } else {
                resp[i] = product / nums[i];
            }
        }

        return resp;
    }
}
