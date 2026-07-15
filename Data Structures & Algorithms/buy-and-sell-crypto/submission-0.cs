public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int r = 1;
        int maxP = 0;

        while(r < prices.Length)
        {
            if(prices[r] > prices[l])
            {
                int profit = prices[r] - prices[l];
                maxP = int.Max(maxP, profit);
            }
            else l = r;
            r++;
        }

        return maxP;
    }
}
