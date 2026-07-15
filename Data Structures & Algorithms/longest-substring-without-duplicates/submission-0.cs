public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0;
        int maxLen = 0;
        HashSet<char> chars = new HashSet<char>();

        for(int r = 0; r < s.Length; r++)
        {
            while(chars.Contains(s[r]))
            {
                chars.Remove(s[l]);
                l++;
            }
            chars.Add(s[r]);
            maxLen = Math.Max(maxLen, r-l+1);
        }

        return maxLen;
    }
}

/*
zxyzxyz

pointers
l = 0; r = 0;

while(s[r] not part of a hash)
    AddToHash
    r++;

maxLen = max(r-l, maxLen)
l++;

*/