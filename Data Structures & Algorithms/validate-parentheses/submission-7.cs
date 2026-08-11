public class Solution {
    public bool IsValid(string s) {
        if(s.Length == 1) return false;

        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> closeToOpen = new Dictionary<char, char>
        {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        foreach(var c in s)
        {
            if(c == '(' || c == '{' || c == '[')
                stack.Push(c);
            
            else if(stack.Count > 0)
            {
                var curr = stack.Pop();

                if(curr != closeToOpen[c])
                    return false;
            }
            else{
                return false;
            }
        }

        return stack.Count == 0;
    }
}

/*
if [{( add to stack
else remove and check pairs }{)(][

if pair does not match return false
otherwise end returning true

*/