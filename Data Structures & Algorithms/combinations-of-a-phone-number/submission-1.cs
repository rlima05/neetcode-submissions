public class Solution {
    private readonly Dictionary<char, char[]> Map = new()
    {
        {'2', ['a', 'b', 'c']},
        {'3', ['d', 'e', 'f']},
        {'4', ['g', 'h', 'i']},
        {'5', ['j', 'k', 'l']},
        {'6', ['m', 'n', 'o']},
        {'7', ['p', 'q', 'r', 's']},
        {'8', ['t', 'u', 'v']},
        {'9', ['w', 'x', 'y', 'z']}
    };

    public List<string> LetterCombinations(string digits) {
        List<string> res = new();
        
        if(string.IsNullOrWhiteSpace(digits))
            return res;

        Backtracking(digits, res, new StringBuilder(), 0);
            
        return res;
    }

    private void Backtracking(string digits, List<string> res, StringBuilder sb, int index)
    {
        if(sb.Length == digits.Length)
        {
            res.Add(sb.ToString());
            return;
        }

            var curr = Map[digits[index]];
            for(var j = 0; j < curr.Length; j++)
            {
                sb.Append(curr[j]);
                Backtracking(digits, res, sb, index+1);
                sb.Length--;
            }
    }
}


/*
2 = [a,b,c]
3 = [d,e,f]...

Backtracking
    if sb length == digits length
        then I add to the list
        return;
    

    from = i till last digit
        from(j = 0; j < map[digit].Length)
            append to string builder
            call backtracking with i+1
            remove from sb


*/