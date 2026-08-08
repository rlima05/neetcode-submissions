public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;

        for(var i = n-1; i >= 0; i--)
        {
            if(digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        int[] res = new int[n+1];

        res[0] = 1;

        return res;
    }
}

/*
Convert array in an integer
1,2,3,4 becomes 1234

add 1

convert number into array



*/