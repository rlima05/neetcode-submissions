public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> closeToOpen = new Dictionary<char, char>
        {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        foreach(char c in s)
        {
            if(closeToOpen.ContainsKey(c))
            {
                if(stack.Count > 0 && stack.Peek() == closeToOpen[c])
                {
                    stack.Pop();
                }
                else
                    return false;
            }
            else
                stack.Push(c);
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