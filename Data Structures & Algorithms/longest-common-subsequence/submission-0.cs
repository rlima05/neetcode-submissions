public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int m = text1.Length;
        int n = text2.Length;

        int[,] dp = new int[m+1, n+1];

        for(var i = m-1; i >= 0; i--)
        {
            for(var j = n-1; j >= 0; j--)
            {
                if(text1[i] == text2[j])
                    dp[i,j] = 1 + dp[i+1, j+1];
                else
                    dp[i,j] = Math.Max(dp[i, j+1], dp[i+1, j]);
            }
            
        }

        return dp[0,0];
    }
}

/*
text1 = "cat", text2 = "crabt" 

3, 5

  0 1 2 3
0 6 3 1 0
1 3 3 1 0
2 1 0 0 0
3 0 1 0 0
4 0 0 1 0 
5 0 0 0 0


*/