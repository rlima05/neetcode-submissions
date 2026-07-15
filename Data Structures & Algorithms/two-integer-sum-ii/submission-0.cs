public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] res = new int[2];
        int left = 0;
        int right = numbers.Length-1;

        while(left < right)
        {
            var sum = numbers[left] + numbers[right];

            if(sum == target)
            {
                res[0] = left+1;
                res[1] = right+1;

                return res;
            }
            else if(sum > target)
                right--;
            else
                left++;

        }

        return res;
        
    }
}


/*
if(sum > target)
    right--
else if(sum < target)
    left++;

if == return i+1
*/