public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        int[] chars = new int[26];

        for (var i = 0; i < s.Length; i++) {
            chars[s[i] - 'a']++;
            chars[t[i] - 'a']--;
        }

        for (var i = 0; i < chars.Length; i++) {
            if (chars[i] != 0)
                return false;
        }

        return true;
    }
}
