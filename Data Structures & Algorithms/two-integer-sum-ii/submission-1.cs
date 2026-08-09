public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length-1;
        int[] res = new int[2];

        while(l < r)
        {
            if(target < numbers[l] + numbers[r])
                r--;
            else if(target > numbers[l] + numbers[r])
                l++;
            else
            {
                res[0] = l+1;
                res[1] = r+1;
                break;
            }
        }


        return res;
        
    }
}


/*
 
*/