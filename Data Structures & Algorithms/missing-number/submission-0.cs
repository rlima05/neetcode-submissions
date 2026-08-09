public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int xorr = n;
        for(var i = 0; i < n; i++)
        {
            xorr ^= i ^nums[i];
        }
        return xorr;
    }
}

/*
0000
0001
0011
0100
0101



*/