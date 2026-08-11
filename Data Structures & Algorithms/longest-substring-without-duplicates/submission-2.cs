public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int res = 0;

        if(s.Length == 0) return res;

        int l = 0;
        
        HashSet<char> c = new();

        for(var r = 0; r < s.Length; r++)
        {
            while(c.Contains(s[r]))
            {
                c.Remove(s[l]);
                l++;
            }

            c.Add(s[r]);
            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
/*
zxyzxyz
hash
l and r = 0
r++

*/