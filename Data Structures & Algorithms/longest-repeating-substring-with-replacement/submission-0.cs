public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> count = new Dictionary<char, int>();
        int res = 0;
        int l = 0;
        int maxF = 0;

        for(var r = 0; r < s.Length; r++)
        {
            if(count.ContainsKey(s[r]))
                count[s[r]]++;
            else
                count[s[r]] = 1;
            
            maxF = Math.Max(maxF, count[s[r]]);

            while((r-l+1) - maxF > k)
            {
                count[s[l]]--;
                l++;
            }

            res = Math.Max(maxF, r-l+1);
        }

        return res;
    }
}
