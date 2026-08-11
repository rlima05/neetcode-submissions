public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res = 0;
        int l =0;
        int maxF = 0;

        Dictionary<char, int> map = new();

        for(var r = 0; r < s.Length; r++)
        {
            if(!map.ContainsKey(s[r]))
            {
                map[s[r]] = 0;
            }

            map[s[r]]++;

            maxF = Math.Max(maxF, map[s[r]]);

            while((r - l + 1) - maxF > k)
            {
                map[s[l]]--;
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
/*


*/