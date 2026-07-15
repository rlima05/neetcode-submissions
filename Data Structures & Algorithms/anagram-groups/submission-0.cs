public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        for (var i = 0; i < strs.Length; i++) {
            var current = strs[i];
            var sortedCurr = SortString(current);

            if (!map.ContainsKey(sortedCurr)) {
                map.Add(sortedCurr, new List<string>());
            }

            map[sortedCurr].Add(current);
        }

        var response = new List<List<string>>();

        foreach (var kv in map) {
            response.Add(kv.Value);
        }

        return response;
    }

    private string SortString(string s) {
        var arr = s.ToCharArray();
        Array.Sort(arr);
        return new string(arr);
    }
}

/*
act - cat

stop, pots, tops
opst



*/