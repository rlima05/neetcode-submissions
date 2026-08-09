public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] chars = new int[26];

        for(var i = 0; i < s.Length; i++)
        {
            chars[s[i] - 'a']++;
            chars[t[i] - 'a']--;
        }


        for(var i = 0; i < 26; i++)
        {
            if(chars[i] != 0)
                return false;
        }

        return true;
    }
}


/*
create array with size 26
for chars in s add one
for chars in t reduce one

if any item in array is != 0 return false;


*/