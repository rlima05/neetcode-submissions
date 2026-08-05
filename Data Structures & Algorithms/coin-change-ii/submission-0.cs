public class Solution {
    public int Change(int amount, int[] coins) {
        Array.Sort(coins);
        int n = coins.Length;

        int[,] dp = new int[n+1, amount+1];

        for(var i = 0; i <= n; i++)
        {
            dp[i,0] = 1;
        }

        for(var i = n - 1; i >= 0; i--)
        {
            for(var a = 0; a <= amount; a++)
            {
                if(a >= coins[i])
                {
                    dp[i,a] = dp[i+1,a];
                    dp[i,a] += dp[i, a-coins[i]];
                }
            }
        }

        return dp[0, amount];
    }
}
