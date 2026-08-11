public class Solution {
    public int MaxProfit(int[] prices) {
        int res = 0;

        int l = 0;
        int r = 1;

        while(l < r && r < prices.Length)
        {
            if(prices[l] < prices[r])
                res = Math.Max(res, prices[r] - prices[l]);
            else
            {
                l = r;
            }            
            r++;
        }

        return res;
    }
}
/*
[10,1,5,6,7,1]

l = 0;
r = 1

if(prices[l] > prices[r])
    r++
else 
{
    max = max(max, l - r)
    l++;
}


*/