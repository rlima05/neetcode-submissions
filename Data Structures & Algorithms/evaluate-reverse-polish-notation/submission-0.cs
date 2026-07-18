public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        foreach(string c in tokens)
        {
            if(c == "+")
            {
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if(c == "-")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b - a);
            }
            else if(c == "*")
            {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if(c == "/")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push((int) ((double) b / a));
            }
            else
                stack.Push(int.Parse(c));
        }

        return stack.Pop();
        
    }
}

/*
stack<string>
while(token[i] is a number)
    stack.Push(token[i])

while(stack.Count > 0)
    curr +-/*= stack.Pop()

stack.Push(curr)


return stack.Peek();


*/