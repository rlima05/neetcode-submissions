public class Solution {
    private Dictionary<(int, bool), int> dp = new();

    public int MaxProfit(int[] prices) {
        return DFS(0, true, prices);
    }

    private int DFS(int i, bool buying, int[]  prices)
    {
        if(i >= prices.Length)
            return 0;

        var key = (i, buying);

        if(dp.ContainsKey(key))
            return dp[key];

        int cooldown = DFS(i+1, buying, prices);

        if(buying)
        {
            int buy = DFS(i+1, false, prices) - prices[i];
            dp[key] = Math.Max(buy, cooldown);
        }
        else
        {
            int sell = DFS(i+2, true, prices) + prices[i];
            dp[key] = Math.Max(sell, cooldown);
        }

        return dp[key];
    }
}
