public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> res = new();
        Dictionary<string, List<string>> map = new();
        foreach(var s in strs)
        {
            var array = s.ToCharArray();
            Array.Sort(array);
            string ordered = new string(array);

            if(!map.ContainsKey(ordered))
                map[ordered] = new List<string>();

            map[ordered].Add(s);
        }

        foreach(var kv in map)
            res.Add(kv.Value);

        return res;
    }
}


/*
Have a dictionary that maps string, to a list of strings
for each string sort it, 
if key matches add

then loop through dict and add the list to the list

*/