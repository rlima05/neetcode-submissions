public class Solution {
    public bool IsHappy(int n) {
       HashSet<int> seen = new();

       while(!seen.Contains(n))
       {
            seen.Add(n);
            n = SumOfSquares(n);
            if(n == 1) return true;
       }

       return false; 
    }

    private int SumOfSquares(int n)
    {
        int output = 0;
        
        while(n > 0)
        {
            int digit = n % 10;
            digit = digit * digit;
            output += digit;
            n/=10;
        }

        return output;
    }
}


/*
calc first the n
then while n not 1 keep calculating it
store last number into a hashset of integer
if number is already there return false
*/