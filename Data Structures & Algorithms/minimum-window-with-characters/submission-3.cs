public class Solution {
    public string MinWindow(string s, string t) {
        if(t == "") return "";

        Dictionary<char,int> countT = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();

        foreach(char c in t)
        {
            if(!countT.ContainsKey(c))
                countT[c] = 0;
            
            countT[c]++;
        }

        int have = 0;
        int need = countT.Count;

        int[] res = new int[2];
        int resLen = int.MaxValue;
        int l =0;

        for(var r = 0; r < s.Length; r++)
        {
            char c = s[r];

            if(!window.ContainsKey(c))
                window[c] = 0;
            
            window[c]++;

            if(countT.ContainsKey(c) && countT[c] == window[c])
                have++;
            
            while(have == need)
            {
                if((r - l +1) < resLen)
                {
                    resLen = r - l + 1;
                    res[0] = l;
                    res[1] = r;
                }
            
                char leftChar = s[l];
                window[leftChar]--;

                if(countT.ContainsKey(leftChar) && window[leftChar] < countT[leftChar])
                    have--;
                
                l++;
            }
        }

        return resLen == int.MaxValue? "" : s.Substring(res[0], resLen);
    }
}

/*
if len(t) > len(s) return ""
lower x upper cases, need to compare both in a single case

s = OUZODYXAZV
t = XYZ

sPointer
dictionary<char, int> -> char from t, frequency

loop throuhj s until find a char present in t
then create a right pointer = current index + 1 and see if we can find other chars of t


*/